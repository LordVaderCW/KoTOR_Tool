/*-----------------------------------------------------------------------------\

    Scale Wizard

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

if g_linkCopy == undefined then (
	global g_linkCopy = #()
)

--------------------------------------------------------------------------------
-- Model scale wizard
rollout nx_ScaleWizard "Scale Wizard"
(
    spinner spn_scale "Scale %" range:[0.0,1000.0,100.0] type:#float
    label lbl_status ""
    button btn_scale "Scale" width:44 across:2
    button btn_close "Close" width:44

    on btn_scale pressed do
    (
	    local skinslist = #()
	    local selectedSkins = #()
        local lParents = #()
        local objSelect = #()
        local n
        local s
        local obj
        
	    -- select everything
	    max select all
	    lbl_status.text="Store selection ..."
    	-- build up parent list and a list of the selection
    	for s in selection do
    	(
        	append lParents s
        	append lParents s.parent
        	append objSelect s
    	)
    	
    	-- we have to delink all skins at this stage
    	-- Also record all the skins for furture processing
	    lbl_status.text="Delink skins ..."
    	for s in objSelect do
    	(
	    	if s.modifiers["Skin"] != undefined then
	    	(
		    	s.parent = undefined
		    	append selectedSkins s
	    	)
    	)
    	
    	-- also store the bone/weight information for each skin
    	-- We will "re-import" this later when we recreate the skin
	    lbl_status.text="Store bone weights ..."
    	local swl = #()
    	local weightBuffer
    	local strStream
    	for s in selectedSkins do
    	(
        	weightBuffer = #()
        	
    	    -- Code from Bioware. To export bone weights, modified for this
    	    -- particular purpose.
        	local save_selection = selection
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
        	if(save_selection != undefined) do
        	(
        		select save_selection
        	)

        	append swl (nx_SkinWeights s weightBuffer)
    	)
    	
        -- perform the scale
	    lbl_status.text="Scale geom ..."
        local calc_scale = spn_scale.value/100
        local tm_scale = [calc_scale,calc_scale,calc_scale]
        for obj in objSelect do
        (
	        -- scale anything but skins
	        if (obj.modifiers["Skin"] == undefined) then
			(
	            obj.scale = tm_scale
            )
        )
        
    	-- unlink the entire selection
	    lbl_status.text="Unlink geom ..."
    	for s in objSelect do
    	(
        	s.parent = undefined
    	)
    	
    	-- collapse all skin modifiers
	    lbl_status.text="Collapse Skins ..."
    	for s in selectedSkins do
    	(
	    	try (
		    	collapseStack s
	    	) catch ()
    	)
    	
    	-- do the reset
	    lbl_status.text="Reset XForms ..."
    	local rotvalue
    	local piv
    	local orig
    	for s in objSelect do
    	(
	    	if (iskindof s Editable_Mesh) then
	    	(
		    	rotvalue = s.rotation
				s.rotation = (quat 0 0 0 1)
				orig = copy s
	        	nx_reset_transforms s
	        	s.rotation = rotvalue
	        	format "XForm added: %\r\n" s.name
	        	
	        	-- collapse stack
	        	try ( collapsestack s ) catch()
	        	format "XForm collapsed\r\n"
	        	
	        	-- restore original modifiers less the Xform
	        	nx_copy_modifiers s orig ignore:#("XForm")
	        	delete orig
	    	) else
	    	(
		    	-- not editable mesh therefore is a dummy
		    	--piv = s.pivot
		    	--s.transform = matrix3 [1,0,0] [0,1,0] [0,0,1] piv
		    	s.scale = [1,1,1]
	    	)
    	)
    	
    	-- restore skin modifiers
	    lbl_status.text="Restore Skins ..."
    	for s in selectedSkins do
    	(
	    	-- make a new skin modifier and apply it
	    	addmodifier s (skin())
    	)
    	for i = 1 to swl.count do
    	(
            -- Apply weight info to the skin modifer
            addMDLSkin (swl[i]).Object (swl[i]).WeightsData
    	)
    	
    	-- relink selection
	    lbl_status.text="Relink Geom ..."
    	for n = 1 to lParents.count by 2 do
    	(
        	lParents[n].parent = lParents[n+1]
    	)
    	
    	lbl_status.text="Update model bases ..."
    	-- update the aurora bases in the selection
    	for s in objSelect do
    	(
	    	if (nx_strclassof s) == "aurorabase" then
	    	(
		    	if s.setanimationscale == 0 then (
			    	s.setanimationscale = 1
		    	)
		    	s.setanimationscale = s.setanimationscale * calc_scale
		    	if s.setsupermodel == "NULL" then (
		    		lbl_status.text="No supermodel set."
	    		)
	    	)
    	)
    	if lbl_status.text!="No supermodel set." then
    		lbl_status.text="Done."
    )
        
    on btn_close pressed do ( destroyDialog nx_ScaleWizard )
)

createDialog nx_ScaleWizard modal:true 