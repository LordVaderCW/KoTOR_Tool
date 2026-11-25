/*-----------------------------------------------------------------------------\

    Anim Key Copy

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

-- Animation key copy rollout. Used for Dialog creation
rollout AnimKeyCopy "Animation Key Copier" width:162
(
    spinner spn_startframe "Start Frame:" range:[0,100000,0] type:#integer
    spinner spn_endframe  "End Frame:" range:[0,100000,0] type:#integer
    spinner spn_targetframe "Target Frame:" range:[0,100000,0] type:#integer
    group "" (
	    pickbutton pck_source "Source" align:#left width:50 across:2 toolTip:"Select the source node to copy anim keys from"
	    label lbl_src "#undefined" align:#right
	    pickbutton pck_target "Target" align:#left width:50 across:2 toolTip:"Select the target node. If blank the source node will be used."
	    label lbl_trg "#undefined" align:#right
	    checkbox chk_pos "Pos" checked:true across:3
	    checkbox chk_rot "Rot" checked:true
	    checkbox chk_scl "Scale" checked:true
	    checkbox chk_children "Copy child nodes" checked:true
	    radiobuttons rdo_abs labels:#("absolute","relative") default:1
	)
    group "" (
	-- not yet implemented. Trying to figure out the math needed here
	    --label lbl_notyet "Not implimented:Researching."			enabled:false
        checkbox chk_mirror "Mirror on axises - Rot only" checked:false  enabled:true
        checkbox chk_x "X" across:3                       enabled:true
        checkbox chk_y "Y"                                enabled:true
        checkbox chk_z "Z"                                enabled:true
    )
	button btn_ok "COPY" width:64 across:2
	button btn_cancel "Done" width:64
	
	on spn_startframe changed val do
	(
    	if val > spn_endframe.value then (
    	    spn_endframe.value = val
	    )
	)
	
	on spn_endframe changed val do
	(
    	if val < spn_startframe.value then (
        	spn_startframe.value = val
    	)
	)
	
	on pck_source picked obj do
	(
    	lbl_src.text = obj.name
	)

	on pck_target picked obj do
	(
    	lbl_trg.text = obj.name
    	-- if copying to a target != to source we assume not copying a hierarchy
    	-- unless the user EXPLICTLY sets it
    	if pck_target.object != pck_source.object then (
    	    chk_children.checked = false
	    )
	)
	
	on btn_cancel pressed do ( DestroyDialog AnimKeyCopy )

	-- Animation copy code
	--
	local trgHierCounts = undefined
	local srcHierCounts = undefined
	local trgHierObjs = undefined
	local trgHierIndex
	-- Build a node tree hierachy into an array
    fn buildHierarchyShape node cntlist objlist =
    (
        if cntlist != undefined then (
            append cntlist node.children.count
        )
        if objlist != undefined then (
            append objlist node
        )
        for child in node.children do (
            buildHierarchyShape child cntlist objlist
        )
    )
	-- Recursive anim key copy
	fn animkeycopy node nodetrg dopos dorot doscale dochildren =
	(
    	local fr, idx, p, r, s, nf, tchild
    	local existingPosKey
        local existingPos
        local newPosKey
    	local sf = spn_startframe.value     -- start frame
    	local ef = spn_endframe.value       -- end frame
    	local tf = spn_targetframe.value    -- target frame
    	local span = ef - sf                -- source frames span (interval)
    	format "+++++++++++++ Anim Key Copy ++++++++++++++\r\n"
    	-- we have valid data so lets get into it.
    	-- 1. Work through the selected nodes
		format "Node: %: Target:% Copy Type: %\r\n" node.name nodetrg.name rdo_abs.state
		-- work through the frames in the source interval and look for keys
		-- which are then copied to the target range
		
		-- Process the pos data
		local masterpos_src = undefined
		local masterpos_src_delta = undefined
		local masterpos_trg = undefined
		if dopos then
		(
			format "copy pos data\r\n"
    		for fr = sf to ef do
    		(
        		idx = getKeyIndex node.pos.controller fr
        		if idx > 0 then    -- we have an index!
        		(
            		in coordsys parent
            		(
	            		-- check to see if is first pass on this obj.
	            		-- If so setup delta vars, else calc them as normal
	            		if masterpos_src == undefined then (
		            		at time sf
		            		(
			            		masterpos_src = node.pos
			            		masterpos_trg = nodetrg.pos
			            		masterpos_src_delta = masterpos_src - masterpos_src
		            		)
	            		) else
	            		(
		            		masterpos_src_delta = (at time fr node.pos) - masterpos_src
	            		)
	            		case rdo_abs.state of
	            		(
		            		1: at time fr p = node.pos
							2: p = nodetrg.pos + masterpos_src_delta
	            		)
                		--p = node.pos.keys[idx].value
                		
	            		-- deal with the mirroring calcs
	            		/*
	            		if chk_mirror.checked then
	            		(
		            		format "Processing mirror code: pos=%\r\n" r_euler
    	            		if chk_x.checked then (
        	            		-- mirror along the x axis
        	            		r_euler.x *= -1
    	            		)
    	            		if chk_y.checked then (
        	            		-- mirror along the y axis
        	            		r_euler.y *= -1
    	            		)
    	            		if chk_z.checked then (
        	            		-- mirror along the z axis
        	            		r_euler.z *= -1
    	            		)
    	            		
		            		format "Finished mirror code: euler=%\r\n" r_euler
    	            		-- turn the euler back to a quat
    	            		r = eulerToQuat r_euler order:1
	            		)
	            		*/
	            		-- end mirroring code
                		nf = tf+(fr-sf)
                		format "Source fr:%  Target fr:%  Pos:%\r\n" fr nf p
                		with animate on at time nf nodetrg.pos = p
            		)
        		)
    		)   -- end for fr
		)
    	
		-- process rotation data
		local masterrot_src = undefined
		local masterrot_src_delta = undefined
		local masterrot_trg = undefined
		if dorot then
		(
			format "copy rot data\r\n"
    		for fr = sf to ef do
    		(
        		idx = getKeyIndex node.rotation.controller fr
        		if idx > 0 then    -- we have an index!
        		(
            		in coordsys parent
            		(
	            		-- check to see if is first pass on this obj.
	            		-- If so setup delta vars, else calc them as normal
	            		if masterrot_src == undefined then (
		            		at time sf
		            		(
			            		masterrot_src = node.rotation
			            		masterrot_trg = nodetrg.rotation
			            		masterrot_src_delta = masterrot_src - masterrot_src
		            		)
	            		) else
	            		(
		            		masterrot_src_delta = (at time fr node.rotation) - masterrot_src
	            		)
	            		case rdo_abs.state of
	            		(
		            		1: at time fr r = node.rotation
							2: r = nodetrg.rotation + masterrot_src_delta
	            		)
	            		-- deal with the mirroring calcs
	            		if chk_mirror.checked then
	            		(
    	            		-- we need to convert to euler rots for easy mirroring.
    	            		-- Might be a better way with quats??
		            		local r_euler = quatToEuler r order:1
		            		format "Processing mirror code: euler=%\r\n" r_euler
    	            		if chk_x.checked then (
        	            		-- mirror along the x axis
        	            		r_euler.x *= -1
    	            		)
    	            		if chk_y.checked then (
        	            		-- mirror along the y axis
        	            		r_euler.y *= -1
    	            		)
    	            		if chk_z.checked then (
        	            		-- mirror along the z axis
        	            		r_euler.z *= -1
    	            		)
    	            		
		            		format "Finished mirror code: euler=%\r\n" r_euler
    	            		-- turn the euler back to a quat
    	            		r = eulerToQuat r_euler order:1
	            		)

	            		-- end mirroring code
                		nf = tf+(fr-sf)
                        existingPosKey = getKeyIndex nodetrg.pos.controller nf
                        existingPos = [0,0,0]
                        if (existingPosKey > 0) then
                        (
                            existingPos = nodetrg.pos.keys[existingPosKey].value
                        )
                		format "Source fr:%  Target fr:%  Pos:%\r\n" fr nf r
                		with animate on at time nf nodetrg.rotation = r
                		
                        if (existingPosKey == 0) then
                        (
                            format "existingPosKey==0\n"
                            newPosKey = getKeyIndex nodetrg.pos.controller nf
                            if (newPosKey != 0) then deleteKey nodetrg.pos.controller newPosKey
                        )
                        else
                        (
                            format "existingPosKey!=0\n"
                            format "existingPos=%; existingPosKey=%\n" existingPos existingPosKey
                            nodetrg.pos.keys[existingPosKey].value = existingPos
                        )
            		)
        		)
    		)   -- end for fr
		)
    		
		-- process scale data
		if doscale then
		(
    		for fr = sf to ef do
    		(
        		idx = getKeyIndex node.scale.controller fr
        		if idx != 0 then    -- we have an index!
        		(
            		in coordsys parent
            		(
                		at time fr s = node.scale
                		nf = tf+(fr-sf)
                		with animate on at time nf node.scale = s
            		)
        		)
    		)   -- end for fr
		)
		format "\r\n"
		
		-- Q: how deal with target children for different hierarchy?
		
		-- process the nodes children
		if dochildren then (
			for child in node.children do (
    			trgHierIndex += 1
    			format "trgHierIndex=%\r\n" trgHierIndex
    			if trgHierObjs != undefined then
    			    tchild = trgHierObjs[trgHierIndex]
                else
                    tchild = child
                
			    animkeycopy child \
			    			tchild \
			    			dopos \
			    			dorot \
			    			doscale \
			    			dochildren
    			
			)
	    )
	)		
	on btn_ok pressed do
	(
    	local fr, idx, p, r, s, nf, index
    	local sf = spn_startframe.value     -- start frame
    	local ef = spn_endframe.value       -- end frame
    	local tf = spn_targetframe.value    -- target frame
    	local span = ef - sf                -- source frames span (interval)
    	local target_obj
    	trgHierIndex = 1    -- set index to start of target hierarchy array
    	-- Perform sanity check on parameters
    	format "Sanity 1\r\n"
    	if (tf < ef) and (tf > (sf-span)) and \
    	    ((pck_source.object==pck_target.object)or(pck_target.object==undefined)) then
    	(
        	-- error message
        	local errortxt = "Target frame and resulting copy overlaps source range."
        	messagebox errortxt title:"Source/Target Range Error"
        	return 0
    	)
    	format "Sanity 2\r\n"
    	if pck_source.object == undefined then
    	(
        	-- error message
        	local errortxt = "There must at least be a source object identified."
        	messagebox errortxt title:"Source Undefined"
        	return 0
    	)
    	format "Sanity 3\r\n"
    	if chk_mirror.checked and not (chk_x.checked or chk_y.checked or chk_z.checked) then
    	(
        	-- error message
        	local errortxt = "You must select a mirror axis."
        	messagebox errortxt title:"Undefined Mirror Axis"
        	return 0
    	)
    	format "Sanity 4\r\n"
    	if (pck_source.object != pck_target.object) and \
    	    (pck_target.object != undefined) and \
    	    chk_children.checked then
    	(
        	-- make sure the source/target hierarchies are the same
        	trgHierCounts = #()
        	trgHierObjs = #()
        	srcHierCounts = #()
        	buildHierarchyShape pck_target.object trgHierCounts trgHierObjs
        	buildHierarchyShape pck_source.object srcHierCounts undefined
        	-- error message
        	local errortxt = "Target/Source hierarchies not the same."
        	-- start the sanity compares
        	if trgHierCounts.count != srcHierCounts.count then
        	(
            	format "array counts do not match\r\n"
            	trgHierCounts = #()
            	trgHierObjs = #()
            	srcHierCounts = #()
            	messagebox errortxt title:"Hierarchies not the same"
            	return 0
        	)
        	for index = 1 to srcHierCounts.count do
        	(
            	if srcHierCounts[index] != trgHierCounts[index] then
            	(
                	format "child counts do not match\r\n"
                	trgHierCounts = #()
                	trgHierObjs = #()
                	srcHierCounts = #()
                	messagebox errortxt title:"Hierarchies not the same"
                	return 0
            	)
        	)
    	)
    	-- Sanity checks finished
    	
    	-- Set the new animationRange if it's not big enough at the moment
    	if (animationRange.end < (tf+span)) then (
        	animationRange = (interval 0 (tf+span+100))
    	)
    	clearListener()
    	-- dump out the content of the arrays for debug purposes
    	format "trgHierCounts=%\r\n" trgHierCounts
    	format "srcHierCounts=%\r\n" srcHierCounts
    	format "trgHierObjs=%\r\n" trgHierObjs
    	
    	format "s=%; t=%\r\n" pck_source.object pck_target.object
    	if pck_target.object == undefined then
    		target_obj = pck_source.object
		else
			target_obj = pck_target.object
		
    	animkeycopy pck_source.object \
    				target_obj \
    				chk_pos.checked \
    				chk_rot.checked \
    				chk_scl.checked \
    				chk_children.checked
	)
)

createDialog AnimKeyCopy