-- Run only in an isolated 3dsmaxbatch process with a copied war-droid.mdl.
(
global ImportNWNmdl, NWlistenResetControllers, NWlistenJoinClipGaps, NWlistenValidateClipGaps, NWlistenTimer
local here=getFilenamePath(getSourceFileName())
local report=createFile(here+"reset-import.txt")
try
(
 fileIn @"C:\Program Files\Autodesk\3ds Max 2021\scripts\NWmax\nwmax.ms"
 fileIn (here+"../../NWlisten.ms")
 NWlistenTimer.Stop()
 resetMaxFile #noPrompt
 ImportNWNmdl (here+"war-droid.mdl") true false showprogress:false
 NWlistenResetControllers (objects as array)
 fileIn (here+"../ValidateClipGaps.ms")
 local checked = NWlistenValidateClipGaps (objects as array)
 format "PASS clip-gap cleanup preserves % transform samples\n" checked to:report
 local base=getNodeByName "C_DrdWar"
 format "Animations: %\n" base.animations to:report
 for n in objects do
  if classOf n.position.controller != Linear_Position or classOf n.rotation.controller != Linear_Rotation or classOf n.scale.controller != Linear_Scale then throw "Unexpected controller type"
 for t in #(91,110,145,180,200,600,815) do at time t
  format "frame=% upperdummy local-position=%\n" t (getNodeByName "upperdummy").position.controller.value to:report
 if not (saveMaxFile (here+"reset-import.max")) then throw "Could not save diagnostic scene"
 format "PASS import/reset: % nodes\n" objects.count to:report
)
catch (format "FAIL %\n" (getCurrentException()) to:report)
close report
)
