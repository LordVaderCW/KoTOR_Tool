/*-----------------------------------------------------------------------------\

	Weight Master

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

rollout nx_weightmaster "Weight Master" width:400
(
	label lbl1 "Bones and Weights:"
	dropdownlist drp_bone1 width:90 align:#left across:4
	dropdownlist drp_bone2 width:90 align:#left
	dropdownlist drp_bone3 width:90 align:#left
	dropdownlist drp_bone4 width:90 align:#left
	spinner spn_weight1 width:50 align:#left scale:0.01 range:[0,1,0] enabled:false across:4
	spinner spn_weight2 width:50 align:#left scale:0.01 range:[0,1,0] enabled:false
	spinner spn_weight3 width:50 align:#left scale:0.01 range:[0,1,0] enabled:false
	spinner spn_weight4 width:50 align:#left scale:0.01 range:[0,1,0] enabled:false
	
	button btn_apply "Apply" width:144 across:2 enabled:false
	button btn_refreshbones "Refresh Bone Data" width:144
	button btn_refreshverts "Refresh Vertex Data" width:144 across:2
	button btn_resetbones "Skin Bone Envelopes to Zero"
	checkbox chk_listselverts "Select vertexes based on list selections" checked:false
	
	multilistbox lst_selverts "Selected Verts Data" height:15
	
	fn refreshbones skinmod =
	(
		local tmplist = #()
		local bonecnt
		-- make sure we are in the right max view to operate
		max modify mode
		bonecount = skinOps.GetNumberBones skinmod
		-- append the no none option
		append tmplist "-nobone-"
		for i = 1 to bonecount do
		(
			append tmplist (skinOps.GetBoneName skinmod i 1 )
		)
		-- assign the list to each drop down list
		drp_bone1.items = tmplist
		drp_bone2.items = tmplist
		drp_bone3.items = tmplist
		drp_bone4.items = tmplist
	)
	
	on nx_weightmaster open do
	(
		-- get the currently selected mesh and see if is a skin,
		-- if so process it
		local skinmod
		local sel = selection[1]
		
		if sel != undefined then (
			skinmod = sel.modifiers["skin"]
		)
		if  skinmod != undefined then
		(
			-- have a skin
			refreshbones skinmod
		)
	)
	
	on nx_weightmaster close do
	(
	)
	
	on nx_weightmaster resized val do
	(
	)
	
	on btn_apply pressed do
	(
		-- build the bone array and weight array
		local bonelist = #()
		local weightlist = #()
		local vertcnt
		local sel = selection[1]
		
		if sel != undefined then (
			skinmod = sel.modifiers["skin"]
		)
		if  skinmod != undefined then
		(
			max modify mode
			
			-- build up data to apply
			if drp_bone1.selected != "-nobone-" then
			(
				append bonelist (drp_bone1.selection - 1)
				append weightlist (spn_weight1.value)
			)
			if drp_bone2.selected != "-nobone-" then
			(
				append bonelist (drp_bone2.selection - 1)
				append weightlist (spn_weight2.value)
			)
			if drp_bone3.selected != "-nobone-" then
			(
				append bonelist (drp_bone3.selection - 1)
				append weightlist (spn_weight3.value)
			)
			if drp_bone4.selected != "-nobone-" then
			(
				append bonelist (drp_bone4.selection - 1)
				append weightlist (spn_weight4.value)
			)
			
			-- get number of verts in the skin
			vertcnt = skinOps.GetNumberVertices skinmod
			-- work through the verts and find ones that are selected and apply data
			for i = 1 to vertcnt do
			(
				if (skinOps.IsVertexSelected skinmod i) == 1 then
				(
					-- apply bone weight data
					skinOps.ReplaceVertexWeights skinmod i bonelist weightlist
				)
			)
		)
	)
	
	on btn_refreshbones pressed do
	(
		-- get the currently selected mesh and see if is a skin,
		-- if so process it
		local skinmod
		local sel = selection[1]
		
		if sel != undefined then (
			skinmod = sel.modifiers["skin"]
		)
		if  skinmod != undefined then
		(
			-- have a skin
			refreshbones skinmod
		)
	)
	
	on btn_resetbones pressed do
	(
		local skinmod
		local sel = selection[1]
		if sel != undefined then (
			skinmod = sel.modifiers["skin"]
		)
		if  skinmod != undefined then
		(
			local bonecnt
			-- make sure we are in the right max view to operate
			max modify mode
			bonecount = skinOps.GetNumberBones skinmod
			-- set all bones to zero radius
			for b = 1 to bonecount do
			(
				skinOps.SetInnerRadius skinmod b 1 0.0
				skinOps.SetOuterRadius skinmod b 1 0.0
				skinOps.SetInnerRadius skinmod b 2 0.0
				skinOps.SetOuterRadius skinmod b 2 0.0
			)
		)
	)
	
	on btn_refreshverts pressed do
	(
		-- we need to get the selected verts on the skin
		local skinmod
		local vertcnt
		local vertbonecnt
		local boneindex
		local tmplist = #()
		local datastr
		local sel = selection[1]
		local vertsloaded = 0
		
		if sel != undefined then (
			skinmod = sel.modifiers["skin"]
		)
		if  skinmod != undefined then
		(
			max modify mode
			-- get number of verts in the skin
			vertcnt = skinOps.GetNumberVertices skinmod
			-- work through the verts and find ones that are selected and add
			-- to the info list with required bone data
			for i = 1 to vertcnt do
			(
				if (skinOps.IsVertexSelected skinmod i) == 1 then
				(
					vertsloaded += 1
					datastr = (i as string) + ": "
					-- get # of bones on vert
					vertbonecnt = skinOps.GetVertexWeightCount skinmod i
					for j = 1 to vertbonecnt do
					(
						boneindex = skinOps.GetVertexWeightBoneID skinmod i j 
						datastr += skinOps.GetBoneName skinmod boneindex 1
						datastr += ("::" + ((skinOps.GetVertexWeight skinmod i j) as string) + " ")
					)
					append tmplist datastr
				)
				if vertsloaded > 300 then
				(
					messagebox "--Max vertlist of 300 exceeded--"
					exit
				)
			)
			-- set the listbox
			lst_selverts.items = tmplist
		)
	)
	
	-- update the apply button availability
	fn updateapply =
	(
		local total = spn_weight1.value + \
						spn_weight2.value + \
						spn_weight3.value + \
						spn_weight4.value
						
		if (total as string) == "1.0" then (
			btn_apply.enabled = true
		) else (
			btn_apply.enabled = false
		)
	)
	
	on spn_weight1 changed val do
	(
		updateapply()
	)
	on spn_weight2 changed val do
	(
		updateapply()
	)
	on spn_weight3 changed val do
	(
		updateapply()
	)
	on spn_weight4 changed val do
	(
		updateapply()
	)
	
	-- update the weight spinners
	fn updateweightspns =
	(
		if drp_bone1.selected != "-nobone-" then (
			spn_weight1.enabled = true
		) else (
			spn_weight1.enabled = false
			spn_weight1.value = 0.0
		)
		
		if drp_bone2.selected != "-nobone-" then (
			spn_weight2.enabled = true
		) else (
			spn_weight2.enabled = false
			spn_weight2.value = 0.0
		)
		
		if drp_bone3.selected != "-nobone-" then (
			spn_weight3.enabled = true
		) else (
			spn_weight3.enabled = false
			spn_weight3.value = 0.0
		)
		
		if drp_bone4.selected != "-nobone-" then (
			spn_weight4.enabled = true
		) else (
			spn_weight4.enabled = false
			spn_weight4.value = 0.0
		)
		updateapply()
	)
	
	on drp_bone1 selected val do
	(
		updateweightspns()
	)
	on drp_bone2 selected val do
	(
		updateweightspns()
	)
	on drp_bone3 selected val do
	(
		updateweightspns()
	)
	on drp_bone4 selected val do
	(
		updateweightspns()
	)
	
	on lst_selverts selectionEnd do
	(
		-- after a selecton go through the list of selected lines in the
		-- list and select the verts on the skin
		local vertlist = #()
		local tmpdata
		local sel = selection[1]
		
		if chk_listselverts.checked then
		(
			if sel != undefined then (
				skinmod = sel.modifiers["skin"]
			)
				if  skinmod != undefined then
				(
				max modify mode
				for i in lst_selverts.selection do
				(
					tmpdata = filterstring  lst_selverts.items[i] ":"
					append vertlist (tmpdata[1] as integer)
				)
				skinOps.SelectVertices skinmod vertlist
			)
		)
	)
	
)

createDialog nx_weightmaster style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox, #style_resizing)