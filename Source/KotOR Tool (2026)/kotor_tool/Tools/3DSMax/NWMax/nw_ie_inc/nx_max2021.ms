-- Max 2021 runtime services. Loaded before NWmax preferences and rollouts.
global gNX_userPath = (getDir #plugcfg) + "\\NWmax\\"
global gNX_prefsFile = gNX_userPath + "nxlocalprefs.ini"
global gNX_scratchPath = (getDir #temp) + "\\NWmax\\" + (((dotNetClass "System.Diagnostics.Process").GetCurrentProcess()).Id as string) + "\\"
makeDir gNX_userPath all:true
makeDir gNX_scratchPath all:true
global gNX_sanityPath = gNX_userPath + "sanity\\"
global gNX_tlibsPath = gNX_userPath + "tlibs\\"
makeDir gNX_sanityPath all:true
makeDir gNX_tlibsPath all:true
for libraryFile in getFiles (g_startpath + "tlibs/*.tlib") do
(
    local destination = gNX_tlibsPath + filenameFromPath libraryFile
    if not doesFileExist destination do
        if not copyFile libraryFile destination do throw ("Cannot migrate texture library to " + destination)
)

-- Migrate once; never overwrite preferences already saved in the user profile.
if not doesFileExist gNX_prefsFile do
(
    local legacyPrefs = scriptsPath + "nxlocalprefs.ini"
    if doesFileExist legacyPrefs do
        if not copyFile legacyPrefs gNX_prefsFile do throw ("Cannot migrate NWmax preferences to " + gNX_prefsFile)
)

fn nx_reportError context detail notify:true =
(
    local message = context + "\n" + (detail as string)
    format "NWmax: %\n" message
    local logFile = undefined
    try
    (
        logFile = openFile (gNX_userPath + "nwmax-errors.log") mode:"a"
        if logFile != undefined do
        (
            format "[%] %\n" localTime message to:logFile
            close logFile
        )
    ) catch (if logFile != undefined do try (close logFile) catch ())
    if notify do messageBox message title:"NWmax"
    false
)

fn nx_loadTool filename =
(
    try
    (
        if not doesFileExist filename do throw ("Script not found: " + filename)
        fileIn filename
        true
    ) catch (nx_reportError ("Could not load " + filename) (getCurrentException()))
)

fn nx_requireScript filename =
(
    try
    (
        if not doesFileExist filename do throw ("Script not found: " + filename)
        fileIn filename
    ) catch
    (
        local detail = getCurrentException()
        progressEnd()
        nx_reportError ("Startup failed in " + filename) detail notify:false
        throw
    )
)

fn nx_prefString section key fallback =
(
    local value = getINISetting gNX_prefsFile section key
    if value == "" do value = getINISetting (g_startpath + "nwmax.ini") section key
    if value == "" then fallback else value
)

fn nx_savePreference section key value =
(
    if setINISetting gNX_prefsFile section key (value as string) then true
    else nx_reportError "Could not save preferences" gNX_prefsFile
)

fn nx_parseInt value fallback minimum maximum =
(
    local result = try (value as integer) catch (undefined)
    if result == undefined then fallback
    else if result < minimum or result > maximum then fallback
    else result
)

fn nx_prefInt key fallback minimum maximum =
    nx_parseInt (nx_prefString "init" key (fallback as string)) fallback minimum maximum

fn nx_parsePosition value =
(
    -- Parse data only; never execute text from a preferences file.
    local parts = filterString value "[], \t\r\n"
    if parts.count != 2 then return [0,100]
    local x = try (parts[1] as integer) catch (undefined)
    local y = try (parts[2] as integer) catch (undefined)
    if x == undefined or y == undefined then [0,100] else [x,y]
)

fn nx_sanityFlags value =
(
    local defaults = "11000111110111111111"
    if value.count != 20 then return defaults
    for i = 1 to value.count where value[i] != "0" and value[i] != "1" do return defaults
    value
)

fn nx_refreshMapPaths =
(
    global g_maps_path = #()
    for i = 1 to mapPaths.count() do appendIfUnique g_maps_path (mapPaths.get i)
    g_maps_path
)

-- Resolve textures beside the model, in its textures folder, or in Max paths.
fn nx_findImportTexture textureName modelFolder =
(
    if textureName == undefined or textureName == "" or toLower textureName == "null" do return undefined
    local folders = #(modelFolder, modelFolder + "textures/")
    for folder in g_maps_path where findItem folders folder == 0 do append folders folder
    local extensions = if getFilenameType textureName != "" then #("") else #(".tga", ".png", ".dds", ".bmp", ".jpg", ".tif")
    for folder in folders do
        for extension in extensions do
        (
            local candidate = pathConfig.appendPath folder (textureName + extension)
            if doesFileExist candidate do return candidate
        )
    undefined
)

-- Static first-frame preview for Odyssey cycle texture atlases; mesh UVs stay intact.
fn nx_applyTextureTXI texMap textureFile debug:false =
(
    local txiPath = (getFilenamePath textureFile) + (getFilenameFile textureFile) + ".txi"
    if not doesFileExist txiPath do return false
    local stream = openFile txiPath
    if stream == undefined do return false
    local procedure = "", columns = 1, rows = 1
    try
    (
        while not eof stream do
        (
            local tokens = filterString (readLine stream) " \t"
            if tokens.count >= 2 do case (toLower tokens[1]) of
            (
                "proceduretype": procedure = toLower tokens[2]
                "numx": columns = tokens[2] as integer
                "numy": rows = tokens[2] as integer
            )
        )
        close stream
    ) catch (close stream; format "NWmax: Invalid TXI: %\n" txiPath; return false)
    if procedure != "cycle" do return false
    if columns == undefined or rows == undefined do return false
    if columns < 1 or rows < 1 or columns > 256 or rows > 256 do return false
    texMap.cropPlace = 0
    texMap.clipu = 0.0
    texMap.clipv = 0.0
    texMap.clipw = 1.0 / columns
    texMap.cliph = 1.0 / rows
    texMap.apply = true
    if debug do format "NWmax: Cycle texture %: first-frame preview (% x % frames).\n" (filenameFromPath textureFile) columns rows
    true
)
