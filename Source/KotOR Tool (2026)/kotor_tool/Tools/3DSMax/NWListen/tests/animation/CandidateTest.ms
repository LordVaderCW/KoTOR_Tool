(
global ImportNWNmdl
local here = getFilenamePath (getSourceFileName())
local report = createFile (here + "candidate.txt")
fileIn @"C:\Program Files\Autodesk\3ds Max 2021\scripts\NWmax\nwmax.ms"
fileIn (here + "candidate.ms")
for mode in #(1) do
(
 resetMaxFile #noPrompt
 sliderTime = if mode == 2 then 815 else 0
 ImportNWNmdl (here+"war-droid.mdl") (mode != 0) false
 for t in #(0,815) do at time t
 (
  format "MODE % TIME %\n" mode t to:report
  for n in objects where n.parent != undefined do
  (
   local tm = n.transform * inverse n.parent.transform
   format "%|%|%\n" n.name tm.translation n.position.controller.value to:report
  )
 )
)
close report
)
