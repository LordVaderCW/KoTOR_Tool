

-- tvert displacer.  For Lisa

rollout nx_tvert_displacer "TVert Displacer" width:200
(
	group "TVert Scale Data"
	(
		spinner spn_scalevalx "x-axis" range:[0,2,1] type:#float scale:0.0001 align:#center
		spinner spn_scalevaly "y-axis" range:[0,2,1] type:#float scale:0.0001 align:#center
	)
	--"Position for original texture"
	group "TVert Origin Adjustment"
	(
		checkbox chk_change "Change position" checked:false
		spinner spn_otherx "Custom x origin" type:#float scale:0.0001 range:[-1,1,0] enabled:false
		spinner spn_othery "Custom y origin" type:#float scale:0.0001 range:[-1,1,0] enabled:false
	)
	
	button btn_scalemove "Process TVerts"
	
	on chk_change changed val do
	(
		if val then
		(
			spn_otherx.enabled = true
			spn_othery.enabled = true
		) else
		(
			spn_otherx.enabled = false
			spn_othery.enabled = false
		)
	)
	
	on btn_scalemove pressed do
	(
		local sel = selection as array
		local tvc	-- the tvert count
		local tvp	-- the tvert pos data
		local xscale
		local yscale
		local orig	-- original object
		local isSkin = false
    	local swl
    	local weightBuffer
    	local strStream
		
		-- sanity checks
		if sel.count < 1 then
		(
			messagebox "No selection found"
			return false
		)
		
		-- sort out and store the scale values
		xscale = spn_scalevalx.value
		yscale = spn_scalevaly.value
		if xscale == 0 then xscale = 1.0
		if yscale == 0 then yscale = 1.0
		
		
		disableSceneRedraw()
		for s in sel do
		(
			isSkin = false
			if (iskindof s Editable_mesh) then
			(
				if s.modifiers["Skin"] != undefined then
				(
					isSkin = true
		        	weightBuffer = #()
		        	
		    	    -- Code from Bioware. To export bone weights, modified for this
		    	    -- particular purpose.
		        	max modify mode
		        	select s
		        
		        	local i,j,zeroWeights
		        	local m = s.modifiers["Skin"]
		        	local n = skinops.getnumbervertices m
		        	--format "   weights %%" n g_delim to:g_strBuffer
		        	for i = 1 to n do
		        	(
		        		local w_num = skinops.getvertexweightcount m i
		        		local counter = 0
			        	strStream = stringStream ""
		        		--format "    " to:g_strBuffer
		        		for j = 1 to w_num do
		        		(
		        			local bone_id   = (skinops.getvertexweightboneid m i j )
		        			local bone_name = "root"
		        			local weight_i_j = 1
		        			if(bone_id > 0) do
		        			(
		        				bone_name = (skinops.getbonename m bone_id 0) -- could be 1 or could be 0 UNSURE!!
		        			)
		        			weight_i_j = (skinops.getvertexweight m i j )
		        			if (weight_i_j != 0.0) then (
		        				format "  % % "  bone_name weight_i_j to:strStream
		        				counter += 1
		        			)
		        		)
		        		if(( w_num ==0 ) or (counter == 0) ) do
		        		(
		        			format "  root 1.00 " to:strStream
		        		)
		        		--format "\r\n" to:strStream
		        		append weightBuffer (strStream as string)
		        	)
				) -- end if : skin processing
				-- sort out the stack as can't do anything if has modifiers
				orig = copy s
	        	try ( collapsestack s ) catch() -- collapse stack
				
				tvc = getNumTVerts s
				
				-- start processing this in earnest
				for i = 1 to tvc do
				(
					tvp = getTVert s i
					-- now scale the tvp data
					tvp.x = tvp.x * xscale
					tvp.y = tvp.y * yscale
					if chk_change.checked then
					(
						-- adjust the origin
						tvp.x += spn_otherx.value
						tvp.y += spn_othery.value
					) -- end if
					-- set the tvert data back
					setTVert s i tvp
				)
	        	-- restore original modifiers
	        	nx_copy_modifiers s orig ignore:#("Unwrap UVW", "Skin")
	        	delete orig
	        	-- add back in a Unwrap UVW
	        	-- leave out as more hassle than worth: addModifier s (Unwrap_UVW())
	        	-- if this is a skin the do skin postprocessing
	        	if isSkin then
	        	(
		        	addModifier s (Skin())
    	            -- Apply weight info to the skin modifer
		            addMDLSkin s weightBuffer
	        	)
			)
		)
		enableSceneRedraw()
	)
)

createdialog nx_tvert_displacer