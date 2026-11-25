/*-----------------------------------------------------------------------------\

    WOk Tool
    
	This tool executes the WOK sanity check function on a selected walkmesh.
	It then returns a list of suspect edges in a list box. You can then select
	the listbox entries and have the edge or verts selected in the mesh.
	You can then perform whatever corrective action you feel is needed.
	Rinse and repeat until all WOK errors are either removed or deemed
	as immaterial by yourself.

    NWmax for NWN
    by Joco (jameswalker@clear.net.nz)

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
/*
*/

rollout nx_woktool "WOK Testing Tool"
(
	local woknode
	local bad_vert_boxes = #()
	local subobj = 2
	
	fn wok_filter obj =
	(
		obj.modifiers["AuroraWalkmesh"] != undefined
	)
	
	-- gui
	label lbl_wok "NULL"
	pickbutton pck_wok "Select WOK" filter:wok_filter
	radiobuttons rdo_sel_type "Selection Type" labels:#("Edge", "Vert") default:1 colummns:2
	button btn_checkwok "Check WOK Mesh"
	checkbutton btn_show_bad_vert_boxes "Bad Vert Boxes" tooltip:"Show/Hide Possible Bad Vert Boxes"
	label lbl_errors "No Errors"
	listbox lst_edge_probs "Problem Edges" height:10
	--listbox lst_aabb "AABB Tree" height:10
	--button btn_aabb "AABB Build"
	
	on nx_woktool close do
	(
		for i = 1 to bad_vert_boxes.count do
		(
			dummy_obj = bad_vert_boxes[i]
			delete dummy_obj
		)
		bad_vert_boxes = #()
	)
	
	-- actions
	on pck_wok picked obj do
	(
		woknode = obj
		lbl_wok.text = obj.name
	)
	
	on btn_checkwok pressed do
	(
		if woknode != undefined then
		(
			-- get any bad edges as an array of string numbers.
			lst_edge_probs.items = wok_edgetest woknode array:true
			if lst_edge_probs.items.count == 0 then
				lbl_errors.text = "No Errors"
			else
				lbl_errors.text = "Errors"
		)
	)
	
	on rdo_sel_type changed state do
	(
		case state of
		(
			1: subobj = 2
			2: subobj = 1
			default: subobj = 2
		)
	)
	
	on lst_edge_probs doubleClicked val do
	(
		local viPair, v1, v2
		local edge = (lst_edge_probs.items[val] as integer)
		viPair = nx_edgeVerts woknode edge

		-- we need to know the model base node for this WOK
		local modelbase = woknode.parent
		while (modelbase != undefined) do
		(
			if nx_strclassof(modelbase) == "aurorabase" then
				exit
			else
				modelbase = modelbase.parent
		)
		if modelbase == undefined then
		(
			-- fundamental problem, modelbase not found
			format "Error: no modelbase found on node %" woknode.name
			return false
		)
		
		in coordsys modelbase
		(
			v1 = getVert woknode viPair.x
			v2 = getVert woknode viPair.y
		)
		
		-- now make sure in right mesh mode and select as appropriate
		if getCommandPanelTaskMode() != #modify then
		(
			setCommandPanelTaskMode mode:#modify
		)
		
		if selection[1] != woknode then
		(
			select woknode
		)
		
		if modPanel.getCurrentObject() != woknode then
		(	
			modPanel.setCurrentObject woknode
		)
		
		if subObjectLevel != subobj then
		(
			subObjectLevel = subobj
		)
		case subobj of
		(
			1:
			(
				setVertSelection woknode #{viPair.x,viPair.y}
			)
			
			2:
			(
				setEdgeSelection woknode #{edge}
			)
		)
	)
	
	on btn_show_bad_vert_boxes changed state do
	(
		local viPair, v1, v2, edge, i, dummy_obj
		
		if woknode == undefined then return 0
		
		if state == on then
		(
			-- make sure old boxes are cleaned up
			
			bad_vert_boxes = #()
			
			-- identify the problem verts
			for i = 1 to lst_edge_probs.items.count do
			(
				edge = (lst_edge_probs.items[i] as integer)
				viPair = nx_edgeVerts woknode edge
				v1 = getVert woknode viPair.x
				v2 = getVert woknode viPair.y
				-- place the dummys on the problem verts
				dummy_obj = Dummy name:("Bad_edge_vert_" + (viPair as string)) pos:v1
				append bad_vert_boxes dummy_obj
				dummy_obj = Dummy name:("Bad_edge_vert_" + (viPair as string)) pos:v2
				append bad_vert_boxes dummy_obj
			)
		) else
		(
			-- remove the dummys in array bad_vert_boxes
			for i = 1 to bad_vert_boxes.count do
			(
				dummy_obj = bad_vert_boxes[i]
				delete dummy_obj
			)
			bad_vert_boxes = #()
		)
	)
	
	--on lst_aabb selected sel do
	--(
    --	local s = lst_aabb.selected
    --	if s[1] == "#" then
    --	(
    --    	local tok = filterString s " "
    --    	if tok[2] 
    --	)
	--)
)

createDialog nx_woktool