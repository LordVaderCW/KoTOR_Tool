/*-----------------------------------------------------------------------------\

    Bake animation keys - based on code from Danmar and a number of other
    authors who have written similar utilities.

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

rollout NXanimbaker "Animation Baker"
(
	-- define UI
	spinner spn_startframe "Start Frame:" type:#integer range:[0,100000,0]
	spinner spn_endframe "End Frame:" type:#integer range:[0,100000,0]
	spinner spn_interval "Sample Interval:" type:#integer range:[1,1000,1]
	checkbox chk_bakehierarchy "Bake full hierarchy" checked:true
	checkbox chk_hidesel "Hide Selection" checked:true
	checkbox chk_reduce "Auto Reduce Keys" checked:true
	label lbl_baketype "Key types to bake"
	checkbox chk_bakerot "Rotation" checked:true across:2
	checkbox chk_bakepos "Position" checked:true
	button btn_bake "Bake"
	
	-- duplicate the selected objects and maintain the same hierarchy
	fn dupObjs SObjs =
	(
		local newobjs = #()
		for i in 1 to SObjs.count do 
		(
			--  Duplicate the objects  
			newobjs[i] = copy SObjs[i]
			newobjs[i].name = SObjs[i].name+"_TOBAKE"
			newobjs[i].controller = prs() -- set a prs controller
			newobjs[i].rotation.controller = Linear_rotation()	-- set linear rot
			newobjs[i].position.controller = Linear_position()	-- set linear pos
			deletekeys newobjs[i].rotation.controller #allkeys	-- del all keys
			deletekeys newobjs[i].position.controller #allkeys
		)
		for i in 1 to SObjs.count do 
		(						
		    /* Set the new Parent up  */
			pObj = SObjs[i].parent
			pIndex = findItem SObjs pObj
			if pIndex != 0 then pObj = newObjs[pIndex]
			newobjs[i].parent = pObj;
		)
		newobjs
	)
	
	fn BakeKeysByInterval bakeInterval dochildren =
	(
		local SObjs = getCurrentSelection()
		local count = SObjs.count
	    local newobjs = dupObjs SObjs
	    local animKeyIndex
	    local modelbase
	    local basecount = 0
	    local animbands = #()
	    
		if count > 0 then
		(
			for i = 1 to SObjs.count do
			(
				-- Now let's swap names now that everyone's	found their proper parent.
				newobjs[i].name = SObjs[i].name
	            SObjs[i].name = "ignore_" + SObjs[i].name+"_ORIG"
			)
		            
			-- We walk through the animation set by x keys
			animate on		
			for t in spn_startframe.value to spn_endframe.value by bakeInterval do
			(
				at time t
				(
					for i = 1 to SObjs.count do 
					(
						-- copy transform matrix at this time from source to target
						newobjs[i].transform = in coordsys parent SObjs[i].transform 
						
						-- remove keys not to baked
						if chk_bakepos.checked != true then
						(
							-- we only delete the position key that was created
							animKeyIndex = getKeyIndex newobjs[i].position.controller t
							format "PosKey Index: % \r\n" posKeyIndex
							if animKeyIndex > 0 then
							(
								deleteKey newobjs[i].position.controller animKeyIndex
							)
						) -- end if
						if chk_bakerot.checked != true then
						(
							-- we only delete the rot key that was created
							animKeyIndex = getKeyIndex newobjs[i].rotation.controller t
							if animKeyIndex > 0 then
							(
								deleteKey newobjs[i].rotation.controller animKeyIndex
							)
						) -- end if
					) -- end for i
				) -- end at time
			) -- end for t
			
			if chk_hidesel.checked == true then
			(
			    max hide selection
			)

			-- We only delete if delete is set and hide isn't
			if (delorig == true) and (hideorig != true) then
			(
				delete SObjs
			)
			
			-- reduce keys if needed
			if (chk_reduce.checked) then
			(
				-- find model base
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
				for s in newobjs do
				(
					nx_reduct s (spn_startframe.value) \
				            (spn_endframe.value) \
				            pos:true \
				            rot:true \
				            sca:true \
				            thresholdRot:0 \
				            thresholdPos:0 \
				            safeframes:animbands
				)
			)
		)
		else
		(
		    /* Generic warning message when no objects are selected */
			messagebox "No Objects selected."
		)
	)
	
	on NXanimbaker open do
	(
		spn_startframe.value = animationrange.start
		spn_endframe.value = animationrange.end
	)
	
	on btn_bake pressed do ( BakeKeysByInterval (spn_interval.value) (chk_bakehierarchy.checked) )
)

createDialog NXanimbaker