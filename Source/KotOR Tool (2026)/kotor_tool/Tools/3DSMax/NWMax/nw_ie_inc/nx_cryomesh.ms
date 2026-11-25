/*
Store the links, relative parent pos and object offset data in a flat cryo file
*/

global gNX_exestr
global gNX_fileh

rollout nx_cryomesh "Cryo Mesh"
(
	edittext edt_file "File:"
	button btn_browse "Browse File to Load"
	button btn_save "Save" across:2
	button btn_load "Restore"
	checkbox chk_excludeposdata "Load ONLY hierarchy" checked:false
	listbox lst_names height:10
	button btn_assign "Assign Name"
	
	fn NXcryodiver node =
	(
	   local objoffsetpos, objoffsetrot, objoffsetscale, position
	   local name, parent
	   local child
	   
	   name = node.name
	   if node.parent == undefined then (
	      parent = "NULL"
	   ) else (
	      parent = node.parent.name
	   )
	   objoffsetpos = node.objectoffsetpos
	   objoffsetrot = node.objectoffsetrot
	   objoffsetscale = node.objectoffsetscale
	   in coordsys parent (
	      position = node.pos
	   )
	   
	   if name == undefined then name = "NULL"
	   
	   -- save data
	   if g_ismax then
	   (
		   format "%|%|%|%|%|%\n" name parent objoffsetpos objoffsetrot objoffsetscale position to:gNX_fileh
	   ) else
	   (
		   format "%|%|%|%|%|%~\n" name parent objoffsetpos objoffsetrot objoffsetscale position
	   )
	   for child in node.children do
	   (
	      NXcryodiver child
	   )
	)
	
	
	fn NXcryomeshload file =
	(
		local fileh = openFile file mode:"r"
		local fileline = ""
		local linetoks
		local data = #()
		local node, parent
		
		if fileh == undefined then
		(
			format "ERROR: Can't open file:%\r\n" file
			return false
		)
		-- load in the data from file
		while not eof(fileh) do
		(
			fileline = readLine fileh
			linetoks = filterString fileline "|"
			-- remember data order is:
			-- name parent objoffsetpos objoffsetrot objoffsetscale position
			append data linetoks
		)
		
		-- close the file
		if fileh != undefined then (
			close fileh
		)
		
		-- relink, position, and pivot correct
		for d in data do
		(
			node = getNodeByName d[1]
			parent = getNodeByName d[2]
			if node != undefined then
			(
				node.parent = parent
				-- position the mesh pieces correctly in relation to their parents
				gNX_exestr = "in coordsys parent $" + node.name + ".pos=" + d[6]
				execute(gNX_exestr)
				-- pivot adjust
				gNX_exestr = "$" + node.name + ".objectoffsetpos=" + d[3]
				execute(gNX_exestr)			
				-- rotation adjust
				gNX_exestr = "$" + node.name + ".objectoffsetrot=" + d[4]
				execute(gNX_exestr)			
				-- scale adjust
				gNX_exestr = "$" + node.name + ".objectoffsetscale=" + d[5]
				execute(gNX_exestr)			
			)
		)
	)
	
	
	fn NXcryomeshsave modelbase =
	(
	   if (not (iskindof modelbase aurorabase)) and (not (iskindof modelbase aurabase)) then
	   (
		   format "ERROR: No model base selected.\r\n"
		   return false
	   )
	   local extn = ""
	   
	   if not (matchPattern edt_file.text pattern:"*.cyo") then (
		   extn = ".cyo"
	   )
	   
	   if g_ismax then
	   (
		   gNX_fileh = createFile (edt_file.text + extn)
		   if gNX_fileh != undefined then
		   (
			   NXcryodiver modelbase
			   flush gNX_fileh
			   close gNX_fileh
		   ) else
		   (
			   format "Error: File not created\r\n"
		   )
	   ) else	   
	   (
		   clearListener()
		   format "<snoopstart file=%>~\n" (edt_file.text + extn)
		   NXcryodiver modelbase
		   format "</snoopstart>~\n"
		   format "</snoopend>~\r\n"
	   )
	)
	
	on btn_browse pressed do
	(
		local filename = getOpenFileName caption:"Open Crymesh file" types:"Cryomesh(*.cyo)|*.cyo|All|*.*|"
		if filename != undefined then
		(
			local fileh = openFile filename mode:"r"
			local filedata
			local listdata = #()
			while not eof(fileh) do
			(
				filedata = filterString (readline fileh) "|"
				append listdata filedata[1]
			)
			lst_names.items = listdata
			edt_file.text = filename
		)
	)
	
	on btn_assign pressed do
	(
		if lst_names.selection != 0 then
		(
			selection[1].name = lst_names.selected
		)
	)
	
	on btn_save pressed do
	(
		NXcryomeshsave selection[1]
	)
	
	on btn_load pressed do
	(
		NXcryomeshload edt_file.text
	)
)

createDialog nx_cryomesh