/*-----------------------------------------------------------------------------\

    Animation Parts Mapper

    NWmax (gmax)
    by Joco (jameswalker@clear.net.nz)
    
    Anim Mapper supports the copying of animations from model parts
    to other model parts that are in different files. For example you
    could copy just the right arm swing anims from the a_ba model chain
    to a custom model.

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


global nx_animpartsmapper_flag
-- parts anim mapper gui
rollout nx_animpartsmapper "Animation Parts Importing Mapper" width:598 height:524
(
	GroupBox grp1 "1. Sources to Targets" pos:[4,7] width:154 height:507
	edittext edt_mdl "" pos:[14,26] width:126 height:24
	button btn_browse "Browse MDL" pos:[19,53] width:80 height:19
	button btn_loadmdl "Load" pos:[103,53] width:36 height:19
	listbox lst_mdlobjs "Source MDL Nodes" pos:[13,78] width:136 height:13
	listbox lst_trgnobhs "Target Scene Nodes" pos:[13,285] width:136 height:13
	button btn_refresh "Refresh Scene Nodes" pos:[20,485] width:121 height:21
	
	button btn_addmap ">>" pos:[165,335] width:40 height:28
	button btn_delmap "<<" pos:[165,375] width:40 height:28
	button btn_automap "Auto" pos:[165,414] width:40 height:28
	
	GroupBox grp3 "Mappings: Source --> Target" pos:[213,280] width:374 height:195
	listbox lst_mappings "" pos:[225,296] width:354 height:13
	GroupBox grp4 "2. Anim Data" pos:[213,8] width:373 height:264
	spinner spn_inserrtpoint "Insert Point:" pos:[422,240] width:125 height:16 enabled:false range:[0,100000,0] type:#integer scale:1
	button btn_selectall "Sel All" pos:[225,202] width:50 height:16
	button btn_deselectall "Desel All" pos:[280,202] width:50 height:16
	button btn_addanim "Add" pos:[335,203] width:50 height:16
	multiListBox lst_availanims "Anim names available:" pos:[224,30] width:161 height:11
	dropdownList drp_options "Options" pos:[226,221] width:146 height:40 items:#("Anim Names Defined", "Append To End", "Use Insert Point")
	multiListBox lst_animstoproc "Anims to process:" pos:[415,30] width:161 height:11
	button btn_selectall2 "Sel All" pos:[416,203] width:50 height:16
	button btn_deselectall2 "Desel All" pos:[471,203] width:50 height:16
	button btn_delanim "Remove" pos:[526,202] width:50 height:16
	button btn_import "Import" pos:[213,486] width:136 height:26
	
	on nx_animpartsmapper open do
	(
		local temp = #()
		
		-- load scene objects
		for o in $objects do
		(
			append temp o.name
		)
		lst_trgnobhs.items = temp
		
		nx_animpartsmapper_flag = true
	)
	
	on nx_animpartsmapper close do
	(
    	nx_animpartsmapper_flag = false
	)

	on btn_browse pressed do
	(
		local f = getOpenFileName \
					caption:"MDL File with source animations" \
					types:"MDL(*.mdl)|*.mdl|MDL Ascii(*.ascii)|*.ascii|"
					
		if f != undefined then
		(
			edt_mdl.text = f
		)
	)
		
	on btn_selectall pressed do
	(
		lst_availanims.selection = #{1..(lst_availanims.items.count)}
	)
	
	on btn_deselectall pressed do
	(
		lst_availanims.selection = 0
	)
	
	on btn_addanim pressed do
	(
		local tmp = lst_animstoproc.items as array
		for s in lst_availanims.selection do
		(
			-- only add animation if not already in list
			if (findItem tmp lst_availanims.items[s]) == 0 then
			(
				append tmp lst_availanims.items[s]
			)
		)
		lst_animstoproc.items = tmp
	)
	
	on btn_selectall2 pressed do
	(
		lst_animstoproc.selection = #{1..(lst_animstoproc.items.count)}
	)
	
	on btn_deselectall2 pressed do
	(
		lst_animstoproc.selection = 0
	)
	
	on btn_delanim pressed do
	(
		local tmp = lst_animstoproc.items as array
		local sel = lst_animstoproc.selection as array
		sort sel
		for s = sel.count to 1 by -1 do
		(
			deleteitem tmp sel[s]
		)
		lst_animstoproc.items = tmp
	)
	
	on btn_refresh pressed do
	(
		local temp = #()
		
		-- load scene objects
		for o in $objects do
		(
			append temp o.name
		)
		lst_trgnobhs.items = temp
	)

	on drp_options selected val do
	(
		case val of
		(
			1: spn_inserrtpoint.enabled = false
			2: spn_inserrtpoint.enabled = false
			3: spn_inserrtpoint.enabled = true
		)
	)
		
	on btn_loadmdl pressed do
	(
		-- load all the geom nodes in the mdl file
	    -- Model heirarchy defs
	    local MDL_DEF = 1
	    local MDL_GEOM = 2
	    local MDL_ANIM = 3
	    local MDL_NOT_IN_MDL = 4
	    
	    local pFile = edt_mdl.text
	    
	    if (pFile == unefined) or (pFile == "") then return false
	    	
	    local currentPath = getFilenamePath pFile
	
	    -- Open up the file and check to see if its a binary file
	    local binMdlStream = fopen pFile "rb"
	    local isNotBinary = ReadByte binMdlStream
	    fclose binMdlStream
	
	    if (isNotBinary == 0) then
	    (
	        -- we need to decompile this model. We assume it is a real model and not junk
	        local tstamp = (timestamp() as string)
	        fControl = gNX_scratchPath+""+tstamp+".txt"
	        local pFilePath = getFilenamePath pFile
	        local chkLoop
	        local bDecompiled = false
	        
	        if g_ismax then
	        (
		        local cmdFile
		        local strCmd
		        cmdFile = createFile (gNX_scratchPath+"import.bat")
		        format "\"%\" -d \"%\" \"%\\\"\r\n" g_compiler pFile pFilePath to:cmdFile
		        flush cmdFile
		        close cmdFile
		        strCmd = "\"" + gNX_scratchPath+"import.bat\""
		        DOSCommand (strCmd)
	        ) else
	        (
		        clearListener()
		        nx_FlushBuffer reset:true
		        -- Have to hard code the delim here into verbose mode
		        format "<snoopstart file=%>%" (gNX_scratchPath+"scratch.txt") "~\n" to:g_strBuffer
		        format "Processing ...%" g_delim to:g_strBuffer
		        format "\"%\" -d \"%\" \"%\\\" > \"%\"%" g_compiler pFile pFilePath (gNX_scratchPath+"decomp.txt") "~\n" to:g_strBuffer
		        format "echo \"done\" > \"%\"%" fControl "~\n" to:g_strBuffer
		
		        format "<snoopstart file=%>%" (gNX_scratchPath+"import.bat") "~\n" to:g_strBuffer
		        format "\"%\" -d \"%\" \"%\\\" > \"%\"%" g_compiler pFile pFilePath (gNX_scratchPath+"decomp.txt") "~\n" to:g_strBuffer
		        format "echo \"done\" > \"%\"%" fControl "~\n" to:g_strBuffer
		        format "</snoopstart>%" "~\n" to:g_strBuffer
		        
		        format "<commandstart>%" "~\n" to:g_strBuffer
		        format "\"%import.bat\"%" (gNX_scratchPath+"") "~\n" to:g_strBuffer
		        format "</commandstart>%" "~\n" to:g_strBuffer
		        
		        format "</snoopstart>%" "~\n" to:g_strBuffer
		        format "</snoopend>%" "~" to:g_strBuffer
		        if g_delim == "~\n" then format "\r\n" to:g_strBuffer
		        nx_FlushBuffer force:true
		        
		        -- Start up model dialog to wait for this processing to complete
		        createdialog rl_binmdl modal:true
		     )
	        -- check for ascii model exists
	        pFile = pFile + ".ascii"
	        if (nx_existFile pFile) == false then
	        (
	            MessageBox("Binary MDL File not decompiled. Check file is valid or NWNmdlcomp is present.")
	            return false
	        )
	    )
	
	    -- Open up the file
	    local mdlStream = openFile pFile mode:"r"
	
	    local lineNum = 0
	    local mdl_pos = MDL_DEF
	    local quitEarly = false
	
	    
	    -- Setup basis for model header    
	    local newModelClassification = 1
	    local newModelSupermodel = "NULL"
	    
	    local nodenames = #()
	    local animnames = #()
	
	    try (
	        -- Go through the whole mdl file
	        while not (eof mdlStream) and not quitEarly do
	        (
	            local tok = nx_Tokenizer()
	            local line = getNextNonBlankLine mdlStream
	            tok.SetString (line)
	            lineNum += 1
	
	
	            -- Read the data ID tag
	            local idToken = tok.ReadToken()
	            
	            -- if idToken is a string token the convert to lowercase
	            if (isKindOf idToken string) then idToken = nx_lowercase idToken
	            
	            if (idToken[1] == "#") then idToken = "#"
	            if (idToken == "donemodel") then
	            (
	                mdl_pos = MDL_NOT_IN_MDL
	                quitEarly = true
	            )
	            case mdl_pos of (
	                ----------------------------------------------------------------
	                -- Model definition
	                ----------------------------------------------------------------
	                MDL_DEF:
	                (
	                    if DEBUG then format "MDL_DEF:  Line:% :: %\r\n" lineNum idToken
	                    case idToken of
	                    (
	                        "#": () -- ignore comments
	                        "newmodel": newModelName = tok.ReadString()
	                        "beginmodelgeom": mdl_pos = MDL_GEOM
	                    )
	                ) -- End MDL_DEF case
	
	                -- Model Geometry
	                MDL_GEOM:
	                (
	                    if DEBUG then format "MDL_GEOM:  Line:% :: %\r\n" lineNum idToken
	                    case idToken of
	                    (
	                        "#": () -- ignore comments
	                        "node": -- Node Struct
	                        (
	                            -- Define initial node data
	                            objType = tok.ReadToken()
	                            objName = tok.ReadToken()
	                            append nodenames objName
	                        )
	    
	
	                        "endmodelgeom": -- End of model geometry
	                        (
	                            mdl_pos = MDL_ANIM;
	                        )
	                    ) -- end iktoken case statement
	                ) -- End MDL_GEOM case
	
	
	                ----------------------------------------------------------------
	                -- Load model animations
	                ----------------------------------------------------------------
	                MDL_ANIM:
	                (
	                    if DEBUG then format "MDL_ANIM:  Line:% :: %\r\n" lineNum idToken
	                    case idToken of
	                    (
	                        "#": () -- ignore comments
	
	                        "newanim": -- New animation
	                        (
	                            animName = tok.ReadToken()
	                            append animnames animName
	                        )
	                        "doneanim": ()
	                    )
	                ) -- End MDL_ANIM case
	            ) -- end mdl_pos case statement
	        ) -- end while not eof
	    )
	    catch
	    (
	        --messageBox ("NWN importer Script Error reading mdl file at line:" + lineNum as string)
	        close mdlStream
	        throw
	    )
	    close mdlStream
	    nx_FlushBuffer()
	    
	    -- now add the mdl name list back in
	    lst_mdlobjs.items = nodenames
        lst_availanims.items = animnames
	)
	
	on btn_addmap pressed do
	(
		-- add only of selection in both list boxes
		local mdlsel = lst_mdlobjs.selected
		local trgsel = lst_trgnobhs.selected
		local tmp
		
		if (mdlsel != undefined) and (trgsel != undefined) then
		(
			tmp = lst_mappings.items as array
			append tmp (mdlsel + " --> " + trgsel)
			lst_mappings.items = tmp
		)
	)
	
	on btn_delmap pressed do
	(
		local mapsel = lst_mappings.selection
		local tmp = lst_mappings.items as array
		-- sanity check
		if mapsel == 0 then return false
		deleteItem tmp mapsel
		lst_mappings.items = tmp
	)
	
	on btn_automap pressed do
	(
		-- work through the mdl list and try to map to same name in scene node list
		local tmp = #()
		for mdl in lst_mdlobjs.items do
		(
			for src in lst_trgnobhs.items do
			(
				if nx_lowercase(mdl) == nx_lowercase(src) then
				(
					append tmp (mdl + " --> " + src)
				)
			)
		)
		if tmp.count > 0 then
		(
			lst_mappings.items = tmp
		)
	)
	
	on btn_import pressed do
	(
	    /*
	    The call structure for the import function
			fn ImportNWNmdl pFile importAnims showWarnings \
				loadGeom:true \
				animLoadBase:undefined \
				loadsingleanim:undefined \
				insertpoint:0 \
				mappingtbl:undefined \
	    */
	    
	    -- make sure the model base is selected
	    local base = selection[1]
	    if not (iskindof base aurorabase) then
	    (
    	    -- no model base was selected so see if only 1 in the scene.
    	    -- If there is only 1 then select it, else show message.
    	    local basecount = 0
    	    for o in $objects do
    	    (
        	    if (iskindof o aurorabase) then
        	    (
            	    basecount += 1
            	    base = o
        	    )
    	    )
    	    
    	    if basecount != 1 then
    	    (
    		    messagebox "Model base not selected"
    		    return false
		    )
		    
		    -- set the selection
		    selection = base
	    )
	    
	    -- make sure there a anims marked for processing
	    if lst_animstoproc.items.count < 1 then
	    (
		    messagebox "No animations marked for processing"
		    return false
	    )
	    
	    -- make sure there are mappings
	    if lst_mappings.items.count < 1 then
	    (
		    messagebox "No mappings present"
		    return false
	    )
	    
        clearListener()
	        
        -- setup for processing
        local animlist = lst_animstoproc.items as array
        local animcount = 0
        local maptbl = #() -- setup map table
        bStopWork = false
        for m in (lst_mappings.items) do
        (
	        mtoks = filterString m " ->"
	        append maptbl mtoks[1]
	        append maptbl mtoks[2]
        )
        
        -- work out the insert point
        insertframe = -1
        case drp_options.selection of
        (
	        -- insert based on named anims
	        1:
	        (
		        insertframe = 0
	        )
	        
	        -- insert at end of last named anim
	        2:
	        (
		        -- find the largets frame ref on model base
		        local largestframe = 0
		        for an in base.animations do
		        (
			        tempstr = filterString an " "
			        if (tempstr.count > 3) and ((tempstr[3] as integer) > largestframe) then
			        (
				        largestframe = tempstr[3] as integer
			        )
		        )
		        insertframe = largestframe + 10
	        )
	        
	        -- insert at specified point
	        3: insertframe = spn_inserrtpoint.value
        )
        
        bStopWork = not (ProgressUpdate ((animcount * 100)/animlist.count))
        if bStopWork then exit
        
        if insertframe > -1 then (
	        disableSceneRedraw()
	        ImportNWNmdl \
	            (edt_mdl.text) \
	            true \
	            false \
	            loadGeom:false \
	            animLoadBase:base \
	            loadanimlist:animlist \
	            insertpoint:insertframe \
	            mappingtbl:maptbl \
	            animloadtype:(drp_options.selection) \
	            showprogress:true
	        enableSceneRedraw()
        ) else
        (
            format "Anim: Insert frame is -1\r\n"
        )
        
        -- reset controllers after all anim import processing has completed.
		local objSum = $objects.count * 2.0
		local cnt = 0.0
		progressStart "Reset Controllers"
		format "Setting to tcb rotation\r\n"
		for o in $objects do
		(
    		o.rotation.controller = tcb_rotation()
    		o.pos.controller = tcb_position()
    		o.scale.controller = tcb_scale()
    		cnt += 1
    		if (progressUpdate (((cnt*100)/objSum) as integer)) == false then return 0
		)
		format "Setting back to linear rotation\r\n"
		for o in $objects do
		(
    		o.rotation.controller = linear_rotation()
    		o.pos.controller = linear_position()
    		o.scale.controller = linear_scale()
    		cnt += 1
    		if (progressUpdate (((cnt*100)/objSum) as integer)) == false then return 0
		)
		progressEnd()
	)
)

if nx_animpartsmapper_flag != true then
(
    createdialog nx_animpartsmapper style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox, #style_resizing)
)