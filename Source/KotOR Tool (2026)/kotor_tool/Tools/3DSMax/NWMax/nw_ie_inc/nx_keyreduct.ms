/*-----------------------------------------------------------------------------\

    Reduce animation keys

    NWmax (gmax)
    by Joco (jameswalker@clear.net.nz)

    Credits:
    Wayland Reid :-
        Extends Wayland's Import/Export script with rewrites as needed
    Zaddix :-
        Based on code from Zaddix's original WOK file importer
    BioWare :-
        This code is based on the information gleaned from BioWares
        3DS Max scripts. In many cases the Bioware code is used instead of
        "re-inventing the wheel". I have attempted to note all those places
        where I have used the Bioware code.


    Legal Stuff
    1. This is free software and is provided with no explicit or implied
       warranty. If you use this software then you do so at your own risk.
    2. If there is any law in your country that requires the author to provide
       any form of support or indemnity on the use of the this software you are
       not therefore authorised to use said software as no such indemnity or
       support will be provided (per 1) other than at the authors discretion.
    3. Credit has been given where code or methods have been integrated from
       other sources.
    4. No code has been knowingly included from other sources where that code
       is sold for commercial purposes.
     
\-----------------------------------------------------------------------------*/


rollout nx_keyreduction "Anim Key Reducer"
(
   spinner spn_start "Start Frame:" align:#right type:#integer range:[0,100000,0]
   spinner spn_end "End Frame:" align:#right type:#integer range:[0,100000,100000]
   checkbox chk_pos "Position" checked:true align:#left across:3
   checkbox chk_rot "Rotation" checked:true align:#center
   checkbox chk_sca "Scale" checked:true align:#right
   spinner spn_threshrot "Rot % Threshold:" align:#right range:[0,1,0] scale:0.01
   spinner spn_threshpos "Pos Amnt Threshold:" align:#right range:[0,10000,0]
   button btn_reduce "Reduce Keys"
   
   on nx_keyreduction open do
   (
      spn_start.value = animationRange.start
      spn_end.value = animationRange.end
   )
   
   on btn_reduce pressed do
   (
      clearListener()
      local sel = selection as array
      local animbands = #()
      local modelbase
      local animline
      local basecount = 0
      
      -- get all the start/end frames from the modelbase. These are frames
      -- which we don't want to mung the frames on.
      modelbase = undefined
      for h in $helpers do
      (
         if (iskindof h aurorabase) then
         (
            modelbase = h
            basecount += 1
         )
      )
      
      -- error case
      if (modelbase == undefined) then
      (
         if not (queryBox "Warning: No modelbase found. Continue?") then return false
      )
      if (basecount > 1) then
      (
         messagebox "Only 1 model base allowed in the scene."
         return false
      )
      
      -- build up the anim bands from the modelbase data
      if modelbase != undefined then
      (
	      for a in modelbase.animations do
	      (
	         animline = filterString a " "
	         append animbands (animline[2] as integer)
	         append animbands (animline[3] as integer)
	         if ((animline[2] as integer)-1) >= 0 then (
		         append animbands ((animline[2] as integer)-1)
	         )
	         append animbands ((animline[3] as integer)+1)
	      )
	  )
      
      -- start processing selection for key reduction
      for s in sel do
      (
         nx_reduct s (spn_start.value) \
                    (spn_end.value) \
                    pos:(chk_pos.state) \
                    rot:(chk_rot.state) \
                    sca:(chk_sca.state) \
                    thresholdRot:(spn_threshrot.value) \
                    thresholdPos:(spn_threshpos.value) \
                    safeframes:animbands
      )
   )
)

createDialog nx_keyreduction width:210