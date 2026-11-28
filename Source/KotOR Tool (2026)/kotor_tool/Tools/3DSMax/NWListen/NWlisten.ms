-- NWlisten v1: data-only queue beside KoTOR Tool. Never evaluates request text.
global ImportNWNmdl, nx_refreshMapPaths
global NWlistenTimer, NWlistenBusy = false, NWlistenWindow
global NWlistenRoot
global NWlistenHome = getFilenamePath (getSourceFileName())
global NWlistenStatus = "Ready for KoTOR Tool"

fn NWlistenProgress job message =
(
    NWlistenStatus = message
    try ((dotNetClass "System.IO.File").WriteAllText (job + "progress.txt") message) catch ()
)

fn NWlistenReadApplicationDirectory =
(
    (dotNetClass "Microsoft.Win32.Registry").GetValue @"HKEY_CURRENT_USER\Software\KotOR Tool\NWlisten" "ApplicationDirectory" ""
)

fn NWlistenRootForApplication applicationDirectory =
(
    if applicationDirectory == undefined or applicationDirectory == "" then return undefined
    local paths = dotNetClass "System.IO.Path"
    if not (paths.IsPathRooted applicationDirectory) then throw "KoTOR Tool application directory must be absolute."
    (paths.GetFullPath (paths.Combine applicationDirectory @"working\NWlisten")) + "\\"
)

fn NWlistenRemoveHeartbeat root =
(
    if root == undefined then return false
    local io = dotNetClass "System.IO.File"
    local file = root + "listener.alive"
    local pid = (((dotNetClass "System.Diagnostics.Process").GetCurrentProcess()).Id as string)
    try (if io.Exists file and (io.ReadAllText file) == pid do io.Delete file) catch ()
)

fn NWlistenResult job state detail =
(
    local io = dotNetClass "System.IO.File"
    io.WriteAllText (job + "result.tmp") (state + "\n" + detail)
    io.Move (job + "result.tmp") (job + "result.txt")
)

fn NWlistenResetControllers importedNodes =
(
    -- Match NWmax's Reset Controllers operation, scoped to this import.
    -- Assigning replacement controllers lets Max transfer their animation keys.
    for n in importedNodes do
    (
        n.rotation.controller = tcb_rotation()
        n.pos.controller = tcb_position()
        n.scale.controller = tcb_scale()
    )
    for n in importedNodes do
    (
        n.rotation.controller = linear_rotation()
        n.pos.controller = linear_position()
        n.scale.controller = linear_scale()
    )
)

fn NWlistenJoinClipGaps importedNodes =
(
    -- NWmax places rest-pose guards just outside each clip. When scrubbing the
    -- whole timeline these can snap the rig to rest and back between clips.
    -- Pin the evaluated clip endpoints before removing only those gap guards.
    fn compareClips a b = if a[1] < b[1] then -1 else if a[1] > b[1] then 1 else 0
    for base in importedNodes where isProperty base #animations do
    (
        local clips = #()
        for entry in base.animations do
        (
            local parts = filterString entry " "
            if parts.count >= 3 do append clips #(parts[2] as integer, parts[3] as integer)
        )
        qsort clips compareClips
        local gaps = #()
        if clips.count > 1 do
        (
            local lastEnd = clips[1][2]
            for i=2 to clips.count do
            (
                if clips[i][1] > lastEnd + 1 do append gaps #(lastEnd, clips[i][1])
                lastEnd = amax lastEnd clips[i][2]
            )
        )
        for n in importedNodes do
        (
            local ancestor = n
            while ancestor != undefined and ancestor != base do ancestor = ancestor.parent
            if ancestor == base do for c in #(n.position.controller, n.rotation.controller) do
            (
                -- Let Max insert keys from the evaluated controller. Rotation
                -- key values use a different convention from controller.value.
                -- Pin all affected endpoints before removing any guards.
                local affected = for gap in gaps where (getKeyIndex c (gap[1]+1) > 0 or getKeyIndex c (gap[2]-1) > 0) collect gap
                for gap in affected do
                (
                    addNewKey c gap[1]
                    addNewKey c gap[2]
                )
                for gap in affected do
                (
                    for t in #(gap[1]+1, gap[2]-1) do
                    (
                        local keyIndex = getKeyIndex c t
                        if keyIndex > 0 do deleteKey c keyIndex
                    )
                )
            )
        )
    )
)

fn NWlistenHideSkeleton importedNodes =
(
    -- Skeleton/proxy meshes are explicitly non-rendering in the MDL. Some
    -- visible body parts are also bones, so bone status alone is not enough.
    for n in importedNodes do
    (
        local meshSettings = n.modifiers["AuroraTrimesh"]
        if meshSettings != undefined and meshSettings.render == 0 do hide n
    )
)

fn NWlistenPrepareHairMaterials importedNodes =
(
    -- Alpha is not universally opacity in KotOR. Limit this viewport aid to
    -- explicitly named hair meshes; never modify a material shared with skin.
    local sources = #(), prepared = #()
    for n in importedNodes where matchPattern n.name pattern:"*hair*" do
    (
        local source = n.material
        if classOf source == Standardmaterial and classOf source.diffuseMap == Bitmaptexture and source.opacityMap == undefined do
        (
            local index = findItem sources source
            if index == 0 do
            (
                local hasTransparency = false
                -- Missing/unreadable textures do not prevent model import.
                try
                (
                    local pixels = source.diffuseMap.bitmap
                    local y = 0
                    while y < pixels.height and not hasTransparency do
                    (
                        for p in (getPixels pixels [0,y] pixels.width) while not hasTransparency do
                            if p.a < 255 do hasTransparency = true
                        y += 1
                    )
                ) catch ()
                local hair = undefined
                if hasTransparency do
                (
                    hair = copy source
                    hair.name = source.name + "_NWlistenHair"
                    hair.diffuseMap = copy source.diffuseMap
                    hair.diffuseMap.alphaSource = 2 -- Color only; separate opacity below.
                    hair.diffuseMap.rgbOutput = 0
                    hair.diffuseMap.preMultAlpha = false
                    local alpha = copy source.diffuseMap
                    alpha.name = source.diffuseMap.name + "_HairAlpha"
                    alpha.alphaSource = 0 -- Image alpha, never RGB brightness.
                    alpha.monoOutput = 1
                    alpha.rgbOutput = 1
                    alpha.preMultAlpha = false
                    hair.opacityMap = alpha
                    hair.opacityMapEnable = true
                    hair.opacityMapAmount = 100
                    hair.twoSided = true
                    enableHardwareMaterial hair true
                    showHWTextureMap hair true
                )
                append sources source
                append prepared hair
                index = sources.count
            )
            if prepared[index] != undefined do n.material = prepared[index]
        )
    )
)

fn NWlistenTick =
(
    if NWlistenBusy then return false
    NWlistenBusy = true
    local io = dotNetClass "System.IO.File"
    local dirs = dotNetClass "System.IO.Directory"
    try
    (
        local nextRoot = NWlistenRootForApplication (NWlistenReadApplicationDirectory())
        if nextRoot != NWlistenRoot do
        (
            NWlistenRemoveHeartbeat NWlistenRoot
            NWlistenRoot = nextRoot
        )
        if NWlistenRoot == undefined then
        (
            NWlistenStatus = "Waiting for KoTOR Tool to register its application folder"
            NWlistenBusy = false
            return false
        )
        dirs.CreateDirectory (NWlistenRoot + "jobs")
        io.WriteAllText (NWlistenRoot + "listener.alive") (((dotNetClass "System.Diagnostics.Process").GetCurrentProcess()).Id as string)
        for jobDir in dirs.GetDirectories (NWlistenRoot + "jobs") do
        (
            local job = jobDir + "\\"
            local ready = job + "request.ready"
            if io.Exists ready do
            (
                -- Atomic claim: only one Max instance can consume this request.
                local claimed = false
                try (io.Move ready (job + "request.working"); claimed = true) catch ()
                if claimed do
                (
                    try
                    (
                        local now = (dotNetClass "System.DateTime").UtcNow
                        local written = io.GetLastWriteTimeUtc (job + "request.working")
                        local elapsed = now.Subtract written
                        local age = elapsed.TotalSeconds
                        if age > 120 then throw "Request expired. Send the model again."
                        local request = io.ReadAllText (job + "request.working")
                        local includeAnimations = true
                        case request of
                        (
                            "NWlisten/1": ()
                            "NWlisten/1\nanimations=1": ()
                            "NWlisten/1\nanimations=0": (includeAnimations = false)
                            default: throw "Unsupported request version or animation option."
                        )
                        local mdl = job + "model-ascii.mdl"
                        if not (io.Exists mdl) then throw "ASCII model is missing."
                        if ImportNWNmdl == undefined do fileIn ((getDir #scripts) + "\\NWmax\\nwmax.ms")
                        if ImportNWNmdl == undefined then throw "NWmax ImportNWNmdl is unavailable."
                        NWlistenProgress job "Importing geometry in NWmax (Max may be busy until this completes)..."
                        mapPaths.add job
                        if nx_refreshMapPaths != undefined do nx_refreshMapPaths()
                        local existingNodes = objects as array
                        local imported
                        -- Avoid repainting partially constructed room geometry on every importer update.
                        with redraw off (imported = ImportNWNmdl mdl includeAnimations false showprogress:false)
                        local addedNodes = for n in objects where (findItem existingNodes n) == 0 collect n
                        if imported == false or addedNodes.count == 0 then throw "NWmax reported an import failure."
                        if includeAnimations do
                        (
                            NWlistenProgress job "Resetting imported controllers..."
                            NWlistenResetControllers addedNodes
                            NWlistenJoinClipGaps addedNodes
                        )
                        NWlistenProgress job "Hiding non-rendering imported meshes..."
                        NWlistenHideSkeleton addedNodes
                        NWlistenProgress job "Preparing imported materials..."
                        NWlistenPrepareHairMaterials addedNodes
                        NWlistenProgress job "Refreshing Max viewports..."
                        redrawViews()
                        NWlistenResult job "OK" (if includeAnimations then "Imported with animations; controllers reset." else "Imported without animations.")
                        NWlistenStatus = "Model imported"
                    )
                    catch
                    (
                        NWlistenStatus = "Import failed: " + (getCurrentException())
                        try (NWlistenResult job "ERROR" NWlistenStatus) catch ()
                    )
                )
            )
        )
    )
    catch (NWlistenStatus = getCurrentException())
    NWlistenBusy = false
    true
)

fn NWlistenStart =
(
    if NWlistenTimer != undefined do
    (
        NWlistenTimer.Stop()
        dotNet.removeAllEventHandlers NWlistenTimer
        NWlistenTimer.Dispose()
    )
    NWlistenTimer = dotNetObject "System.Windows.Forms.Timer"
    NWlistenTimer.Interval = 500
    dotNet.addEventHandler NWlistenTimer "Tick" NWlistenTick
    NWlistenTimer.Start()
    NWlistenStatus = "Ready for KoTOR Tool"
)

-- Dispose either the original dialog or an earlier floater before redefining rollouts.
global NWlistenFloater, NWlistenConnectionRollout, NWlistenImportRollout, NWlistenAboutRollout
try (destroyDialog NWlistenWindow) catch ()
try (closeRolloutFloater NWlistenFloater) catch ()
NWlistenFloater = undefined

rollout NWlistenConnectionRollout "Listener" width:240
(
    label status "Ready for KoTOR Tool" width:220 height:44 align:#left
    button start "Start" width:104 across:2
    button stop "Stop" width:104
    timer refresh interval:500
    on start pressed do NWlistenStart()
    on stop pressed do
    (
        if NWlistenTimer != undefined do NWlistenTimer.Stop()
        NWlistenStatus = "Stopped"
        NWlistenRemoveHeartbeat NWlistenRoot
    )
    on refresh tick do
    (
        status.text = NWlistenStatus
        local listening = NWlistenTimer != undefined and NWlistenTimer.Enabled
        start.enabled = not listening
        stop.enabled = listening
    )
)

rollout NWlistenImportRollout "Model Import" width:240
(
    label instructions "In KoTOR Tool, right-click an MDL and choose Send to 3DS Max (2021)." width:220 height:44 align:#left
    label mode "Imports geometry with optional animations. Animated imports reset controllers." width:220 height:44 align:#left
    label assets "Exported textures stay in the job folder for your scene to reference." width:220 height:44 align:#left
)

rollout NWlistenAboutRollout "About NWlisten" width:240
(
    label title "NWlisten 1.0" align:#left
    label description "KoTOR Tool model bridge for 3DS Max 2021." width:220 height:32 align:#left
    label lifecycle "Closing this panel keeps the listener running. Use Stop to pause imports." width:220 height:44 align:#left
)

fn NWlistenShow =
(
    try (closeRolloutFloater NWlistenFloater) catch ()
    NWlistenFloater = newRolloutFloater "NWlisten" 260 380
    addRollout NWlistenConnectionRollout NWlistenFloater rolledUp:false
    addRollout NWlistenImportRollout NWlistenFloater rolledUp:false
    addRollout NWlistenAboutRollout NWlistenFloater rolledUp:true
)

macroScript NWlisten category:"NWlisten" tooltip:"Open NWlisten - KoTOR Tool model bridge" buttonText:"NWlisten" iconName:"NWlisten/NWlisten"
(
    on execute do NWlistenShow()
)
NWlistenStart()
