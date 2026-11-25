(
global ImportNWNmdl
local here=getFilenamePath(getSourceFileName())
local report=createFile(here+"clip-results.txt")
fileIn @"C:\Program Files\Autodesk\3ds Max 2021\scripts\NWmax\nwmax.ms"
if doesFileExist (here+"candidate.ms") do fileIn(here+"candidate.ms")
resetMaxFile #noPrompt
ImportNWNmdl (here+"war-droid.mdl") true false
local base=getNodeByName "C_DrdWar"
local expected=#(__POSITIONS__)
local checks=0, failed=0
for row in expected do
(
 local n=getNodeByName row[2]
 for clip in base.animations do
 (
  local parts=filterString clip " "
  if parts[1] == row[1] do
  (
   local first=parts[2] as integer
   local last=parts[3] as integer
   for t in #(first, (first+last)/2, last) do at time t
   (
    checks+=1
    local delta=distance n.position.controller.value row[3]
    if delta>0.01 do (failed+=1;format "FAIL % % frame=% delta=%\n" row[1] row[2] t delta to:report)
   )
  )
 )
)

local rotations=#(__ROTATIONS__)
for row in rotations do at time row[2]
(
 local n=getNodeByName row[1]
 local expectedRotation=quat (radToDeg row[4]) row[3]
 local actual=n.rotation.controller.value
 local dotValue=abs (actual.x*expectedRotation.x+actual.y*expectedRotation.y+actual.z*expectedRotation.z+actual.w*expectedRotation.w)
 checks+=1
 if dotValue < 0.9999 do (failed+=1;format "FAIL rotation % frame=% dot=%\n" row[1] row[2] dotValue to:report)
)
format "checks=% failures=%\n" checks failed to:report
close report
)
