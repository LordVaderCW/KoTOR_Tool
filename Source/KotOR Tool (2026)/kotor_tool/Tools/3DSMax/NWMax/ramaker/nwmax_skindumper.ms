/*-----------------------------------------------------------------------------\

    Skin Dumper

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

rollout nx_skindumper "Skin Dumper" width:250
(
	label lbl_path "" align:#left
	button btn_browse "Set Path"
	group "Save Details"
	(
    	edittext edt_filename "File name:" align:#left
    	label lbl1 "Comment:" align:#left
    	edittext edt_comment align:#left
    	button btn_save "Save"
    )
    group "Available Skin Files"
    (
        listbox lst_files height:10
        label lbl_comment "" height:60
    	button btn_load "Load"
    )
	label lbl_status ""
	
	fn NX_getskindata s =
	(
		-- build up skin weight data	
		local swl
		local weightBuffer
		local strStream
    	weightBuffer = #()
    	
	    -- Code from Bioware. To export bone weights, modified for this
	    -- particular purpose.
    	local save_selection = selection
    	max modify mode
    	select s
    
    	local i,j,zeroWeights
    	local m = s.modifiers["Skin"]
    	
    	if m == undefined then return #()
    	
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
    				bone_name = (skinops.getbonename m bone_id 1)
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

    	swl = (nx_SkinWeights (s.name) weightBuffer)
    	
    	swl
	)
	
	fn NX_savedata sdata filename =
	(
		ClearListener()
		-- start the file
		if g_ismax then
		(
			g_strBuffer = createfile filename
			if g_strBuffer == undefined then
			(
				-- error state
				return false
			)
		) else
		(
			format "<snoopstart file=%>%" filename g_delim to:g_strBuffer
			format "\n%" g_delim to:g_strBuffer
			format "\n%" g_delim to:g_strBuffer
			format "\n%" g_delim to:g_strBuffer
		)
		
		-- put in comment
		format "%%" ("#"+edt_comment.text) g_delim to:g_strBuffer
		
		-- write out the skin obj name as the first line
		format "%%" (sdata.Object) g_delim to:g_strBuffer
		
		-- cycle through all the data lines and export them all out a row at a time
		for wstr in (sdata.WeightsData) do
		(
			format "%%" wstr g_delim to:g_strBuffer
			nx_FlushBuffer()
		)
		
		-- close the file
		if g_ismax then
		(
			flush g_strBuffer
			close g_strBuffer
		) else
		(
			format "\n%" g_delim to:g_strBuffer
			format "</snoopstart>%" g_delim to:g_strBuffer  -- closes exportcontrol.txt
			format "</snoopend>%" g_delim to:g_strBuffer
			nx_FlushBuffer force:true
		)
	)
	
	fn NX_loaddata filename =
	(
		local sdata = #()
		local skinobj
		local fileh = openFile filename mode:"r"
		local fileline = ""
		local comment = ""
		
		if fileh == undefined then
		(
			format "ERROR: Can't open file:%\r\n" filename
			return false
		)
		
		-- get firstline. It might be either comment or skin obj, depending on version
		fileline = readLine fileh
		
		if fileline[1] == "#" then
		(
    		comment = fileline
    		fileline = readLine fileh
		)
		skinobj = getNodeByName fileline
		if skinobj == undefined then return false
		
		-- delete any skin modifier if exists
		md = skinobj.modifiers["skin"]
		if md != undefined then (
			deleteModifier skinobj md
		)
		addModifier skinobj (skin())
		
		-- load in the data from file
		while not eof(fileh) do
		(
			fileline = readLine fileh
			append sdata fileline
		)
		
		close fileh
		
		-- data is loaded
        addMDLSkin skinobj sdata
	)
	
	fn nx_refresh_files path =
	(
    	local files = getFiles path
    	local temp = #()
    	for f in files do
    	(
        	append temp (getFilenameFile f)
    	)
    	lst_files.items = temp
	)
	
	on nx_skindumper open do
	(
		nx_skindumper_flag = true
		lbl_path.text = getINISetting (gNX_prefsFile) "skindumper" "filepath"
		if lbl_path.text ==  undefined or lbl_path.text == "" then
		(
			lbl_path.text = gNX_scratchPath+""
		)
		-- refresh the available .skn list
		nx_refresh_files (lbl_path.text + "*.skn")
	)
	
	on nx_skindumper close do
	(
		nx_skindumper_flag = false
		if g_ismax then
		(
			setINISetting (gNX_prefsFile) "skindumper" "filepath" lbl_path.text
		) else
		(
			-- gmax processing. Verbose data dumping
			clearListener()
			format "<snoopstart file=%>~\n\n" (gNX_scratchPath+"setini.txt")
			format "<snoopset %,%,\"%\",%,\>~\n" "skindumper" "filepath" lbl_path.text (gNX_prefsFile)
			format "</snoopstart>~\n"
			format "</snoopend>~\n"
		)
	)
	
	on lst_files selected val do
	(
    	-- set the new comment field
    	local comment = ""
    	if lst_files.selected != undefined then
    	(
        	local filename = lbl_path.text + lst_files.selected + ".skn"
			local fileh = openFile filename mode:"r"
			local fileline = ""
    		if fileh == undefined then
    		(
    			format "ERROR: Can't open file:%\r\n" filename
    			return false
    		)
    		fileline = readLine fileh
			if fileline[1] == "#" then
			(
            	comment = fileline
            	comment[1] = " "
        	)
        	close fileh
    	)
    	lbl_comment.text = comment
	)
	
	on btn_browse pressed do
	(
		local pth = getSavePath()
		
		if pth != undefined then
		(
			lbl_path.text = pth + "\\"
		)
		nx_refresh_files (lbl_path.text + "*.skn")
	)
	
	on btn_save pressed do
	(
		local sel = selection[1]
		if selection.count > 1 then
		(
			messagebox "More than one object selected"
			return false
		)
		if sel == undefined then
		(
			messagebox "No object selected."
			return false
		)
		if sel.modifiers["skin"] == undefined then
		(
			messagebox "No skin selected."
			return false
		)
		local sdata = NX_getskindata sel
		select sel
		NX_savedata sdata (lbl_path.text + edt_filename.text + ".skn")
		lbl_status.text = "Save Done."
	)
	
	on btn_load pressed do
	(
    	if lst_files.selected == undefined then
    	(
			lbl_status.text = "No file chosen."
			return false
    	)
		-- makesure file exists
		if not (nx_existFile (lbl_path.text + lst_files.selected + ".skn")) then
		(
			lbl_status.text = "File not found."
			return false
		)
		NX_loaddata (lbl_path.text + lst_files.selected + ".skn")
		lbl_status.text = "Load Done."
	)
)


if not nx_skindumper_flag then
(
	createDialog nx_skindumper style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox)
)