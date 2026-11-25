(
-- Run in isolated 3dsmaxbatch only; never the user's open scene.
global NWlistenRoot, NWlistenTimer, NWlistenTick, NWlistenResetControllers, NWlistenJoinClipGaps, NWlistenValidateClipGaps
global aurorabase
global auroratrimesh, NWlistenHideSkeleton
global NWlistenPrepareHairMaterials
global NWlistenReadApplicationDirectory, NWlistenRootForApplication, NWlistenTestApplicationDirectory
local here = getFilenamePath (getSourceFileName())
local report = createFile (here + "results.txt")
try
(
 fileIn (here + "../NWlisten.ms")
 NWlistenTimer.Stop()
 local io = dotNetClass "System.IO.File"
 local dirs = dotNetClass "System.IO.Directory"
 local expectedApplication = (dotNetClass "System.Environment").GetEnvironmentVariable "NWLISTEN_TEST_APPLICATION"
 if expectedApplication != undefined and expectedApplication != "" do
 (
  if NWlistenReadApplicationDirectory() != expectedApplication then throw "64-bit Max could not read x86 sender registration"
  NWlistenTick()
  if NWlistenRoot != expectedApplication + "\\working\\NWlisten\\" then throw "Listener did not use sender application directory"
  if not (io.Exists (NWlistenRoot + "listener.alive")) then throw "Registered listener heartbeat missing"
  format "PASS x86 sender registration read by 64-bit Max; application-local heartbeat\n" to:report
 )
 -- Override discovery only in this isolated process; never poll a real sender queue.
 fn NWlistenReadApplicationDirectory = NWlistenTestApplicationDirectory
 NWlistenTestApplicationDirectory = ""
 NWlistenTick()
 if NWlistenRoot != undefined then throw "Unregistered listener fell back to another directory"
 local testApplication = here + "run-" + (((dotNetClass "System.Guid").NewGuid()).ToString "N") + "\\KoTOR Tool (copied fixtures)"
 NWlistenTestApplicationDirectory = testApplication
 NWlistenTick()
 if NWlistenRoot != testApplication + "\\working\\NWlisten\\" then throw "Queue is not beside application"
 if not (io.Exists (NWlistenRoot + "listener.alive")) then throw "Application-local heartbeat missing"
 format "PASS no registration has no fallback; application path with spaces\n" to:report
 local sentinel = box name:"PreserveExistingScene"
 local sentinelPosition = sentinel.position.controller
 local sentinelRotation = sentinel.rotation.controller
 local sentinelScale = sentinel.scale.controller
 for fixture in #("foundation_triangle.mdl.ascii", "tsl_fields.mdl.ascii") do
 (
  local job = NWlistenRoot + "jobs\\" + fixture + "\\"
  dirs.CreateDirectory job
  io.Copy (here + fixture) (job + "model-ascii.mdl")
  io.WriteAllText (job + "request.ready") "NWlisten/1"
  NWlistenTick()
  local result = io.ReadAllText (job + "result.txt")
  if not (matchPattern result pattern:"OK*") then throw result
  local before = objects.count
  NWlistenTick()
  if objects.count != before then throw "Job imported twice"
  if not isValidNode sentinel then throw "Existing scene was reset"
  if sentinel.position.controller != sentinelPosition or sentinel.rotation.controller != sentinelRotation or sentinel.scale.controller != sentinelScale then throw "Existing scene controllers changed"
  for n in objects where n != sentinel do
   if classOf n.position.controller != Linear_Position or classOf n.rotation.controller != Linear_Rotation or classOf n.scale.controller != Linear_Scale then throw "Imported controllers were not reset"
  format "PASS % nodes=%\n" fixture objects.count to:report
 )
 -- Explicit animation modes use the same copied fixture; inspect only added nodes.
 for mode in #(0,1) do
 (
  delete (for n in objects where n != sentinel collect n)
  local job = NWlistenRoot + "jobs\\mode" + (mode as string) + "\\"
  dirs.CreateDirectory job
  local fixture = io.ReadAllText (here + "tsl_fields.mdl.ascii")
  local clip = "newanim test nx_tsl_test\nlength 1\ntranstime 0.25\nanimroot nx_tsl_test\nnode trimesh nx_tsl_test_mesh\nparent nx_tsl_test\npositionkey 2\n0 0 0 0\n1 1 0 0\nendnode\ndoneanim test nx_tsl_test\n"
  io.WriteAllText (job + "model-ascii.mdl") (substituteString fixture "donemodel nx_tsl_test" (clip + "donemodel nx_tsl_test"))
  local existing = objects as array
  io.WriteAllText (job + "request.ready") ("NWlisten/1\nanimations=" + (mode as string))
  NWlistenTick()
  local result = io.ReadAllText (job + "result.txt")
  if not (matchPattern result pattern:"OK*") then throw result
  local keyed = false
  for n in objects where (findItem existing n) == 0 do
  (
   if (numKeys n.position.controller) > 0 or (numKeys n.rotation.controller) > 0 then keyed = true
  )
  if mode == 0 and keyed then throw "Geometry-only import contains animation keys"
  if mode == 1 and not keyed then throw "Animated import lost its keys"
  format "PASS animation option %\n" mode to:report
 )
 local bad = NWlistenRoot + "jobs\\bad\\"
 dirs.CreateDirectory bad
 io.WriteAllText (bad + "request.ready") "NWlisten/1"
 NWlistenTick()
 if not (matchPattern (io.ReadAllText (bad + "result.txt")) pattern:"ERROR*") then throw "Missing-model error not reported"
 format "PASS missing model; repeated polling; existing scene preserved\n" to:report
 -- Keyed transforms must survive the same conversion used by real imports.
 local animated = box name:"AnimatedResetFixture"
 animated.position.controller = tcb_position()
 animated.rotation.controller = tcb_rotation()
 animated.scale.controller = tcb_scale()
 with animate on
 (
  at time 0 (animated.pos=[0,0,0];animated.rotation=quat 0 [0,0,1];animated.scale=[1,1,1])
  at time 10 (animated.pos=[3,4,5];animated.rotation=quat 75 [0,0,1];animated.scale=[2,3,4])
  at time 20 (animated.pos=[-1,2,3];animated.rotation=quat 150 [0,0,1];animated.scale=[1,2,1])
 )
 local samples = for t in #(0,10,20) collect (at time t #(animated.pos,animated.rotation,animated.scale))
 NWlistenResetControllers #(animated)
 for i=1 to 3 do at time ((i-1)*10)
 (
  if distance animated.pos samples[i][1] > 0.0001 or distance animated.scale samples[i][3] > 0.0001 then throw "Reset lost keyed position/scale"
  local a=animated.rotation, b=samples[i][2]
  if abs(a.x*b.x+a.y*b.y+a.z*b.z+a.w*b.w) < 0.99999 then throw "Reset lost keyed rotation"
 )
 format "PASS reset preserves keyed position, rotation and scale\n" to:report
 -- Reproduce a rest-pose snap in the gap between two clips.
 local base = aurorabase name:"GapTestRoot"
 base.animations = #("first 0 10 0.25 1 GapTestRoot", "second 20 30 0.25 1 GapTestRoot")
 local child = box name:"GapTestChild" parent:base
 NWlistenResetControllers #(base,child)
 with animate on
 (
  at time 0 (child.rotation=quat 30 [0,0,1];child.pos=[5,0,0])
  at time 10 (child.rotation=quat 60 [0,0,1];child.pos=[10,0,0])
  at time 11 (child.rotation=quat 0 [0,0,1];child.pos=[0,0,0])
  at time 19 (child.rotation=quat 0 [0,0,1];child.pos=[0,0,0])
  at time 20 (child.rotation=quat 90 [0,0,1];child.pos=[20,0,0])
  at time 30 (child.rotation=quat 120 [0,0,1];child.pos=[25,0,0])
 )
 fileIn (here+"ValidateClipGaps.ms")
 local checked = NWlistenValidateClipGaps #(base,child)
 at time 15 if distance child.pos [15,0,0] > 0.001 then throw "Gap still snaps to rest"
 for t in #(11,19) do
  if getKeyIndex child.position.controller t > 0 or getKeyIndex child.rotation.controller t > 0 then throw "Gap guard remained"
 if sentinel.position.controller != sentinelPosition or sentinel.rotation.controller != sentinelRotation or sentinel.scale.controller != sentinelScale then throw "Gap cleanup changed existing scene"
 format "PASS clip-gap cleanup: % unchanged clip transforms; smooth gap; existing scene untouched\n" checked to:report
 -- Hide non-rendering skeleton proxies, never visible bone geometry or
 -- unrelated existing objects. Hiding must retain parenting/controllers.
 local proxy = convertToMesh (box name:"SkeletonProxy")
 local visibleBone = convertToMesh (box name:"VisibleBone" parent:proxy)
 local existingProxy = convertToMesh (box name:"ExistingProxy")
 for n in #(proxy,visibleBone,existingProxy) do addModifier n (auroratrimesh())
 proxy.modifiers["AuroraTrimesh"].render = 0
 visibleBone.modifiers["AuroraTrimesh"].render = 1
 existingProxy.modifiers["AuroraTrimesh"].render = 0
 proxy.setBoneEnable true 0
 visibleBone.setBoneEnable true 0
 local proxyController = proxy.rotation.controller
 local oldTransform = visibleBone.transform
 NWlistenHideSkeleton #(proxy,visibleBone)
 if not proxy.isHidden then throw "Skeleton proxy still visible"
 if visibleBone.isHidden or existingProxy.isHidden then throw "Visible or existing geometry was hidden"
 if visibleBone.parent != proxy or proxy.rotation.controller != proxyController then throw "Hiding changed rig structure"
 for i=1 to 4 do if distance oldTransform[i] visibleBone.transform[i] > 0.0001 then throw "Hiding moved visible geometry"
 format "PASS skeleton hidden; visible bones and existing objects preserved; rig retained\n" to:report
 -- Hair and skin can share one source material: opacity must be isolated.
 local pixels = bitmap 2 2 color:(color 80 40 20 255)
 setPixels pixels [0,0] #((color 80 40 20 0),(color 80 40 20 255))
 pixels.filename = NWlistenRoot + "hair.tga"
 save pixels
 local source = standardMaterial name:"SharedHairAndFace"
 source.diffuseMap = bitmapTexture bitmap:pixels
 source.diffuseMap.coords.U_Tiling = 2
 local body = box name:"BanthaFace" material:source
 local hair = box name:"bthair" material:source
 local existingHair = box name:"ExistingHair" material:source
 local originalAlpha = source.diffuseMap.alphaSource
 NWlistenPrepareHairMaterials #(body,hair)
 if body.material != source or existingHair.material != source or source.opacityMap != undefined then throw "Hair opacity leaked into face or existing scene"
 if source.diffuseMap.alphaSource != originalAlpha then throw "Source diffuse map changed"
 if hair.material == source or hair.material.opacityMap == undefined then throw "Hair alpha was not configured independently"
 if hair.material.opacityMap.alphaSource != 0 or hair.material.opacityMap.monoOutput != 1 or hair.material.opacityMap.rgbOutput != 1 then throw "Opacity is not using image alpha"
 if hair.material.opacityMap.coords.U_Tiling != 2 then throw "Alpha UV mapping changed"
 if not hair.material.twoSided then throw "Hair cards are not double sided"
 local converted = hair.material
 NWlistenPrepareHairMaterials #(hair)
 if hair.material != converted then throw "Repeat processing replaced an existing opacity material"
 local opaquePixels = bitmap 2 2 color:(color 80 40 20 255)
 opaquePixels.filename = NWlistenRoot + "opaque.tga"
 save opaquePixels
 local opaqueMaterial = standardMaterial diffuseMap:(bitmapTexture bitmap:opaquePixels)
 local opaqueHair = box name:"OpaqueHair" material:opaqueMaterial
 local missingMaterial = standardMaterial diffuseMap:(bitmapTexture filename:(NWlistenRoot+"missing.tga"))
 local missingHair = box name:"MissingHair" material:missingMaterial
 NWlistenPrepareHairMaterials #(opaqueHair,missingHair)
 if opaqueHair.material != opaqueMaterial or missingHair.material != missingMaterial then throw "Opaque or missing texture was replaced"
 format "PASS hair alpha isolated from shared face material; UVs preserved; opaque/missing maps and existing opacity retained\n" to:report
 local previousRoot = NWlistenRoot
 NWlistenTestApplicationDirectory = testApplication + " relocated"
 NWlistenTick()
 if NWlistenRoot != NWlistenTestApplicationDirectory + "\\working\\NWlisten\\" then throw "Listener did not follow application relocation"
 if not (io.Exists (NWlistenRoot + "listener.alive")) then throw "Relocated heartbeat missing"
 if io.Exists (previousRoot + "listener.alive") then throw "Old heartbeat was retained"
 if not (io.Exists (previousRoot + "hair.tga")) or not (io.Exists (bad + "result.txt")) then throw "Relocation removed old assets"
 NWlistenTestApplicationDirectory = ""
 NWlistenTick()
 if NWlistenRoot != undefined or io.Exists (testApplication + " relocated\\working\\NWlisten\\listener.alive") then throw "Unregister did not clear heartbeat"
 format "PASS application relocation and unregister; old texture assets retained\n" to:report
)
catch (format "FAIL %\n" ((getCurrentException()) + "\n" + (getCurrentExceptionStackTrace())) to:report)
close report

)
