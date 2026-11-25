/*-----------------------------------------------------------------------------\

    Robe and Armour Maker

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
-- Armour/Robe Part Builder
rollout nx_ramaker "Armour and Robe Maker" width:425 height:564
(
	local basemodels = #()
	-- list box for ref models
	GroupBox grp_base "1. Base Models" pos:[4,5] width:192 height:256
	listbox lst_basemodels "" pos:[13,24] width:174 height:10
	-- browse btn/edit with add btn to id models to add
	button btn_browsemodel "Browse" pos:[13,167] width:70 height:18 across:2
	button btn_delete "Delete" pos:[117,167] width:70 height:18
	editText edt_loadpattern "" pos:[12,205] width:171 height:24
	button btn_loadpattern "Load Pattern" pos:[45,236] width:102 height:19
	
	-- browse btn/edit for export path
	GroupBox grp_path "2. Export path" pos:[4,266] width:192 height:65
	edittext edt_path text:((getdir #export)+"\\") pos:[13,287] width:174 height:17
	--button btn_browseexp "Browse" pos:[13,307] width:70 height:18
    
	-- scale ini file
	GroupBox grp_ini "3. Scaling ini file" pos:[228,5] width:192 height:122
	dropdownList drp_scaleini "" pos:[237,23] width:174 height:21
	label lbl_inidescr "" pos:[239,50] width:170 height:70
	
	GroupBox grp_options "4. Race Processing and Over-rides" pos:[228,132] width:192 height:230
	checkbox chk_human "Human" pos:[237,151] width:58 height:15 checked:false across:2
	checkbox chk_elf "Elf" pos:[332,151] width:36 height:15 checked:false
	checkbox chk_dwarf "Dwarf" pos:[237,172] width:52 height:15 checked:false across:2
	checkbox chk_halfling "Halfling" pos:[332,172] width:59 height:15 checked:false
	checkbox chk_gnome "Gnome" pos:[237,193] width:58 height:15 checked:false across:2
	checkbox chk_orc "Half Orc" pos:[332,193] width:63 height:15 checked:false
		
	radiobuttons rdo_process_sex "Sex processing Over-rides:" pos:[237,213] width:195 height:30 labels:#("Default", "Male", "Female") default:1 columns:3
	radiobuttons rdo_process_pheno "Pheno processing Over-rides:" pos:[237,249] width:131 height:30 labels:#("Default", "0", "2") default:1 columns:3
	
	label lbl_scaleadj "Global scale adjust\n(added to scale factors):" pos:[237,281] width:130 height:30
	spinner spn_x "x:" pos:[240,312] width:50 height:16 range:[0,1,0] across:3
	spinner spn_y "y:" pos:[303,312] width:50 height:16 range:[0,1,0]
	spinner spn_z "z:" pos:[365,312] width:50 height:16 range:[0,1,0]
	checkbox chk_snappos "Snap Pivots for Robe bones" pos:[240,340] checkd:true
	
	-- scale start buttons
	GroupBox grp_build "5. Build the Armour or Robes" pos:[228,370] width:192 height:44
	button btn_build_armour "Build Armour" pos:[238,387] width:75 height:21 toolTip:"Using the base models listed build armour using the supplied scale file" across:2
	button btn_build_robes "Build Robes" pos:[337,387] width:73 height:21 toolTip:"Using the base models listed build robes using the supplied scale file"
	
	GroupBox grp_status "Status" pos:[228,430] width:192 height:125
	listbox lst_history "" pos:[237,450] width:174 height:6
	label lbl_status "Ready" pos:[310,534] width:31 height:13
	
	GroupBox grp_util1 "Utility: Load Armour Pieces" pos:[4,337] width:192 height:140
	label lbl25 "Path to armour pieces" pos:[15,352] width:168 height:16
	edittext edt_arloadptrn text:((getdir #export)+"\\") pos:[10,367] width:174 height:24
	editText edt_arsrp "sex/race/pheno" text:"pmh0" pos:[40,396] width:144 height:24
	editText edt_arnum "Armour Num:" text:"001" pos:[56,424] width:128 height:24
	button btn_loadarmour "Load Armour" pos:[59,453] width:70 height:18 toolTip:"Load all armour pieces matching a pattern"
	
	
	GroupBox grp_util2 "Utility: Mass Export" pos:[5,481] width:192 height:76
	edittext edt_masstarget text:((getdir #export)+"\\") pos:[11,497] width:180 height:24
	button btn_massexport "Mass Export" pos:[55,528] width:86 height:20 toolTip:"Mass export all gmax models in \"2. Export Path\" to Target"
	

	-- to support standlone operation these functions get defined here if they
	-- are not already available (i.e. operating without NWmax
	
	fn nxra_upateList =
	(
		local tmp = #()
		local m
		
		for m in basemodels do
		(
			-- only add in the file name
			append tmp (getFilenameFile m)
		)
		lst_basemodels.items = tmp
	)
	
	on nx_ramaker open do
	(
    	local inis = #()
    	local tmp = getFiles (g_startpath+"sc_*.ini")
    	nx_ramaker_flag = true
    	-- sort the file list
    	sort tmp
    	for s in tmp do
    	(
        	append inis (filenameFromPath s)
    	)
    	drp_scaleini.items = inis
    	drp_scaleini.selection = 1
    	-- get scale file descr
    	lbl_inidescr.text = getINISetting tmp[1] "init" "descr"
    	
    	-- get the default races this file will generate
    	chk_human.checked = false
    	chk_elf.checked = false
    	chk_dwarf.checked = false
    	chk_halfling.checked = false
    	chk_gnome.checked = false
    	chk_orc.checked = false
    	local defaultRaces = getINISetting tmp[1] "roberaces" "races"
    	local validProcess = getINISetting tmp[1] "init" "type"
    	local i
    	for i = 1 to (defaultRaces.count) do
    	(
	    	case defaultRaces[i] of
	    	(
		    	"h": chk_human.checked = true
		    	"e": chk_elf.checked = true
		    	"d": chk_dwarf.checked = true
		    	"a": chk_halfling.checked = true
		    	"g": chk_gnome.checked = true
		    	"o": chk_orc.checked = true
	    	)
    	)
    	
    	btn_build_armour.enabled = false
    	btn_build_robes.enabled = false
    	case validProcess of
    	(
	    	"a": btn_build_armour.enabled = true
	    	"r": btn_build_robes.enabled = true
    	)
    	
    	-- load in last used paths
		local loadptrn = getINISetting (gNX_prefsFile) "ramaker" "ra_load_pattern"
		local exportpath = getINISetting (gNX_prefsFile) "ramaker" "ra_export_path"
		local ardummyloadptrn = getINISetting (gNX_prefsFile) "ramaker" "ra_dummyload_pattern"
		local trgt = getINISetting (gNX_prefsFile) "ramaker" "ra_mass_target_path"
		
		if loadptrn != undefined then edt_loadpattern.text = loadptrn
		if exportpath != undefined then edt_path.text = exportpath
		if ardummyloadptrn != undefined then edt_arloadptrn.text = ardummyloadptrn
		if trgt != undefined then edt_masstarget.text = trgt
	)
	
	on nx_ramaker close do
	(
		nx_ramaker_flag = false
		if g_ismax then
		(
			setINISetting (gNX_prefsFile) "ramaker" "ra_load_pattern" edt_loadpattern.text
			setINISetting (gNX_prefsFile) "ramaker" "ra_export_path" edt_path.text
			setINISetting (gNX_prefsFile) "ramaker" "ra_dummyload_pattern" edt_arloadptrn.text
			setINISetting (gNX_prefsFile) "ramaker" "ra_mass_target_path" edt_masstarget.text
		) else
		(
			-- gmax processing. Verbose data dumping
			clearListener()
			format "<snoopstart file=%>~\n\n" (gNX_scratchPath+"setini.txt")
			format "<snoopset %,%,\"%\",%,\>~\n" "ramaker" "ra_load_pattern" edt_loadpattern.text (gNX_prefsFile)
			format "<snoopset %,%,\"%\",%,\>~\n" "ramaker" "ra_export_path" edt_path.text (gNX_prefsFile)
			format "<snoopset %,%,\"%\",%,\>~\n" "ramaker" "ra_dummyload_pattern" edt_arloadptrn.text (gNX_prefsFile)
			format "<snoopset %,%,\"%\",%,\>~\n" "ramaker" "ra_mass_target_path" edt_masstarget.text (gNX_prefsFile)
			format "</snoopstart>~\n"
			format "</snoopend>~\n"
		)
	)
		
	on btn_browsemodel pressed do
	(
	    local filename = getOpenFileName caption:"Base Model" types:("(*"+g_fextn+")|*"+g_fextn+"|")
	    if (filename != undefined) then
	    (
		    append basemodels filename
	    )
	    nxra_upateList()
	)
	
	on btn_delete pressed do
	(
    	local sel = lst_basemodels.selection
    	if sel == 0 then return 0
    	deleteItem basemodels sel
    	nxra_upateList()
	)
	
	on btn_loadpattern pressed do
	(
		local files, f
		files = getFiles (edt_loadpattern.text)
		for f in files do
		(
			append basemodels f
		)
		nxra_upateList()
	)
	
	on btn_browseexp pressed do
	(
	    local filename = getOpenFileName caption:"Base Export" types:"All Files (*.*)|*.*|"
	    if (filename != undefined) then
	    (
		    edt_path.text = getFilenamePath filename
	    )
	    if ( (edt_path.text)[edt_path.text.count] != "\\" ) then (
    	    edt_path.text += "\\"
	    )
	)
	
	on drp_scaleini selected val do
	(
    	lbl_inidescr.text = ""
    	lbl_inidescr.text = getINISetting \
    	    (g_startpath+"" + (drp_scaleini.items[val])) \
    	    "init" "descr"
    	    
    	-- get the default races this file will generate
    	chk_human.checked = false
    	chk_elf.checked = false
    	chk_dwarf.checked = false
    	chk_halfling.checked = false
    	chk_gnome.checked = false
    	chk_orc.checked = false
    	local defaultRaces = getINISetting \
    		(g_startpath+"" + (drp_scaleini.items[val])) \
    		"roberaces" "races"
    	local i
    	for i = 1 to (defaultRaces.count) do
    	(
	    	case defaultRaces[i] of
	    	(
		    	"h": chk_human.checked = true
		    	"e": chk_elf.checked = true
		    	"d": chk_dwarf.checked = true
		    	"a": chk_halfling.checked = true
		    	"g": chk_gnome.checked = true
		    	"o": chk_orc.checked = true
	    	)
    	)
    	
    	local validProcess = getINISetting \
				(g_startpath+"" + (drp_scaleini.items[val])) \
				"init" "type"
    	btn_build_armour.enabled = false
    	btn_build_robes.enabled = false
    	case validProcess of
    	(
	    	"a": btn_build_armour.enabled = true
	    	"r": btn_build_robes.enabled = true
    	)
	)
	
	on btn_loadarmour pressed do
	(
		local robeparts = #("head_g", "neck_g", \
							"Lshoulder_g","lbicep_g","lforearm_g","lhand_g", \
							"Rshoulder_g","rbicep_g","rforearm_g","rhand_g", \
							"torso_g","belt_g","pelvis_g", \
							"lthigh_g","lshin_g","lfoot_g", \
							"rthigh_g", "rshin_g","rfoot_g")
	
		local armourparts = #("head", "neck", \
		                    "shol", "bicepl", "forel", "handl", \
							"shor", "bicepr", "forer", "handr", \
							"chest", "belt", "pelvis", \
							"legl", "shinl", "footl", \
							"legr", "shinr", "footr")
		
		local fileList
	
		-- some sanity checks before getting too far
		if (edt_arloadptrn.text[edt_arloadptrn.text.count]) != "\\" and \
		   (edt_arloadptrn.text[edt_arloadptrn.text.count]) != "/" then (
		   edt_arloadptrn.text += "\\"
		)
		
		-- get the template name to use to drive the armour part loading
		local super = edt_arsrp.text
		-- reset the scene and load model base dummy in from supermodels
		resetMaxFile #noPrompt
		loadMaxFile (g_startpath+"supermodels/" + super + g_fextn)
		
		local templateBase = undefined
		for h in $helpers do
		(
			if (nx_strclassof h) == "aurorabase" then
			(
				templateBase = h
				exit
			)
			
		)
		
		if templateBase == undefined then
		(
			return "no model base found."
		)
		
		
		
		-- clean out all materials from the scene
    	for o in $objects do
    	(
        	if (o.mat!=undefined) and ((classof o.mat)==Standardmaterial) then (
	    	    deleteItem sceneMaterials o.mat.name
	    	    o.mat = undefined
        	)
    	)
		
		-- models to load
		local path = edt_arloadptrn.text
		local toLoad, i, snode, tnode, gnode, toLoadName
		
		-- load it all in first
		for i = 1 to armourparts.count do
		(
	
			-- start loading
			if (edt_arnum.text == "*") then
			(
				toLoad = path + super + "_" + armourparts[i] + "*" + g_fextn
				fileList = getFiles toLoad
				toLoad = fileList[1]
				if toLoad != undefined then
				(
					toLoadName = getFilenameFile toLoad
				)
			) else
			(
				toLoad = path + super + "_" + armourparts[i] + edt_arnum.text + g_fextn
				toLoadName = getFilenameFile toLoad
			)
			try (
				if (mergeMaxFile toLoad #deleteOldDups) then
				(
				
					-- get the targetsource node and target nodes then reposition
					snode = getNodeByName toLoadName	-- loaded node
					tnode = getNodeByName robeparts[i]	-- target dummy node
					if snode != undefined then
					(
						snode.pos = tnode.pos	-- change position
						format "Loaded: %.  Moved to: %.\r\n" snode.name tnode.name
					) else
					(
						format "Error - node: % not found\r\n" toLoadName
					)
				)
			) catch (
				format "MergeMaxFile error trapped\r\n"
			)
		)
	
	)
	
	on btn_massexport pressed do
	(
		-- check that the directory exists
		local dir = edt_masstarget.text
		if dir[dir.count] != "\\" then dir += "\\"
		if not (nx_existDir dir) then
		(
			-- warning message and exit
			return 0
		)
		
		local sourcedir = edt_path.text
		if sourcedir[sourcedir.count] != "\\" then sourcedir += "\\"
		if not (nx_existDir sourcedir) then
		(
			-- warning message and exit
			return 0
		)
		
		sourcedir += ("*" + g_fextn)
		
		-- start the export process
		massexport pattern:sourcedir target:dir anims:true
	)
	
	------------------------Armour Code------------------------------
	
	-- Scale the armour parts using a recursive pattern.
	-- The scale factor is only search for once. When found it's not looked for again.
	--
	fn scaleArmourPart node objSelect scaleData race sex pheno tm_scale:undefined =
	(
    	format "Node: %\r\n" node.name
        -- perform the scale
	    lbl_status.text="Scale geom ..."
	    
	    -- based on the node part, race and sex get the scale matrix to use
        local i, r, s, p
        local part
        if (tm_scale == undefined) or (tm_scale == [1,1,1]) then
        (
	        tm_scale = [1,1,1]	-- just in case is the undefined case
	        for i = 1 to (scaleData.size()) do  -- find the scale to use
	        (
	            r = ((scaleData.get i 2)[3] == race)
	            s = ((scaleData.get i 2)[2] == sex)
	            p = ((scaleData.get i 2)[4] == pheno)
	            
	            -- build up the part name
	            part = scaleData.get i 1
	            
	            
	            if ((findstring (nx_lowercase(node.name)) part) != undefined) and r and s and p then
	            (
	                tm_scale = scaleData.get i 3
	                format "Scale found\r\n"
	                exit    -- stop the loop
	            )
	        )
        )
        
        -- adjust scale factor to anything that is an editable mesh only
        if (iskindof node Editable_Mesh) then
        (
	        tm_scale.x += spn_x.value
	        tm_scale.y += spn_y.value
	        tm_scale.z += spn_z.value
        )
        format "Scale factor %\r\n" tm_scale

        -- scale anything but skins
        if (node.modifiers["Skin"] == undefined) then
		(
            node.scale = tm_scale
        )
        
    	for part in node.children do
    	(
        	scaleArmourPart part objSelect scaleData race sex pheno tm_scale:tm_scale
    	)
	)
	
	on btn_build_armour pressed do
	(
    	local strMsg
    	local scaleINI
    	local newFileName
    	local tmpFileName
    	local modelBase
    	local tmpLst
    	
    	
    	-- sanity checks
    	scaleINI = g_startpath+"" + drp_scaleini.selected
        if not (nx_existFile scaleINI) then
        (
            strMsg = "Scale ini file does not exist"
            messageBox strMsg
            return 0
        )
        if not(nx_existDir edt_path.text) then
        (
            strMsg = "Export directory does not exist"
            messageBox strMsg
            return 0
        )
        -- make sure is a trailing "\" on the export path
        if (edt_path.text[edt_path.text.count] != "\\") and \
        		(edt_path.text[edt_path.text.count] != "/") then (
	        		edt_path.text += "\\"
     		)

    	-- empty the scene
        strMsg = "This process will empty the scene before commencing."
        if not (queryBox strMsg) then
            return 0
        
        clearListener()
        resetMaxFile #noPrompt
        
        -- load up the scale data and parts mapping data
        local scaleData = nx_MultiArray()
        scaleData.width = 3
        local maxData = ((getINISetting scaleINI "init" "nTransforms") as integer)
        local index, s, temp
        local match, part, scaleMatrix
        for index = 0 to (maxData-1) do
        (
            s = "s" + (index as string)
            match = nx_lowercase(getINISetting scaleINI s "match")
            part = nx_lowercase(getINISetting scaleINI s "part")
            temp = filterString (getINISetting scaleINI s "Scale") "(),"
            scaleMatrix = point3 (temp[1] as float) (temp[2] as float) (temp[3] as float)
            scaleData.append (#(part, match, scaleMatrix))
            temp = undefined
        )
        --print scaleData.ArrayData
        local raceStr = ""	-- = getINISetting scaleINI "roberaces" "races"
        
		if chk_human.checked then raceStr += "h"
		if chk_elf.checked then raceStr += "e"
		if chk_dwarf.checked then raceStr += "d"
		if chk_halfling.checked then raceStr += "a"
		if chk_gnome.checked then raceStr += "g"
		if chk_orc.checked then raceStr += "o"

        
        -- reset history
        lst_history.items = #()
        
        -- start processing the models in the base model list
        for mf in basemodels do
        (
            format "Processing basemodel: %\r\n" mf
            tmpLst = lst_history.items
            append tmpLst ("Model: " + (getFilenameFile mf))
            lst_history.items = tmpLst
            -- we need to process for each roberace
            local raceIndex
            for raceIndex = 1 to raceStr.count do
            (
                -- for speed we don't want to waste time in screen updates
                DisableSceneRedraw()
                format "processing race: %\r\n" raceStr[raceIndex]
                if (loadMaxFile mf) then
                (
                    format "gmax file loaded\r\n"
                    
                    -- update model status
                    tmpLst = lst_history.items
                    /*case (raceStr[raceIndex]) of
                    (
	                    "a": append tmpLst "...Halfling"
	                    "d": append tmpLst "...Dwarf"
	                    "e": append tmpLst "...Elf"
	                    "g": append tmpLst "...Gnome"
	                    "o": append tmpLst "...Half-Orc"
	                    "h": append tmpLst "...Human"
	                    "p": append tmpLst "...Phenotype"
                    )
                    */
                    lst_history.items = tmpLst
                    
                    -- prep for scaling
            	    local skinslist = #()
            	    local selectedSkins = #()
                    local lParents = #()
                    local objSelect = #()
                    
                    -- determine some key info
                    local sex
                    local pheno
                    case (rdo_process_sex.state) of
                    (
	                    1: sex = (getFilenameFile mf)[2]    -- 2nd char in file name
	                    2: sex = "m"
	                    3: sex = "f"
                    )
                    case (rdo_process_pheno.state) of
                    (
	                    1: pheno  = (getFilenameFile mf)[4]	-- 4th char in file name
	                    2: pheno = "0"
	                    3: pheno = "2"
                    )
                    format "processing for sex = %\r\n" sex
                    format "processing for pheno = %\r\n" pheno
                    
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
            
                    	append swl (nx_SkinWeights s weightBuffer)
                	)
                    
                    -- parse through the model file in the scene in a tree like way
                    for tmp in $helpers do -- to find the model base
                    (
                        if (nx_strclassof tmp) == "aurorabase" then
                        (
	                        modelBase = tmp
                            scaleArmourPart modelBase objSelect scaleData \
                                            raceStr[raceIndex] \        -- race
                                            sex \
                                            pheno
                            exit    -- found model base so stop loop
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
                	
	                -- work out new file name and save as new gmax file to export path
	                tmpFileName = getFilenameFile mf
	                tmpFileName[2] = sex
	                tmpFileName[3] = raceStr[raceIndex]
	                tmpFileName[4] = pheno
	                -- correct model name
	            	lbl_status.text="Update model bases ..."
	                modelBase.name = tmpFileName
	                -- also need to do a special update on the only child of the model base
	                modelBase.children[1].name = tmpFileName + "g"
	                -- finalise file name
	                newFileName = edt_path.text + tmpFileName
	                -- save the file out to disk
	                saveMaxFile newFileName
                    
                ) else
                (
                    -- max file load failed
                    strMsg = "Failed to load: " + mf
                    messageBox strMsg
                )
                
                -- turn screen drawing back on again
                EnableSceneRedraw()
                -- reset the scene before loading the next file
                resetMaxFile #noPrompt
            )   -- end For: raceStr loop
        )   -- end For: basemodels
        lbl_status.text = "Done."
	)
	
	
	------------------------Robe Code-----------------------------------
	
	fn scaleRobePart node scaleData race sex pheno tm_scale:undefined =
	(
		-- all the robe body parts
    local bodyparts = #("neck_g","head_g","head", \
                        "torso_g", \
                        "Lshoulder_g","lbicep_g","lforearm_g","lforearm","lhand_g","lhand", \
                        "Rshoulder_g","rbicep_g","rforearm_g","rhand_g","rhand", \
                        "pelvis_g","belt_g", \
                        "rthigh_g","rshin_g","rfoot_g", \
                        "lthigh_g","lshin_g","lfoot_g", \
                        "handconjure","headconjure","rootdummy","Impact","wings","tail", \                        
                        "belt1_g","FB1_g01", "FB2_g01", "FB4_g01", \
                        "TF1_g", "TF1L_g", "TF1R_g" ,"TF2_g", "TF3_g01", \
                        "Cloak_g", "CL1_fg", "CL1_g", "CL2_g", "CL3_g", "CL4_g", \
                        "cloak_shL", "cloak_shR", \
                        "CM1_g", "CM2_g", "CM3_g", "CM4_g", \
                        "CR1_fg", "CR1_g", "CR2_g", "CR3_g", "CR4_g", \
                        "Coat_top","Arm_L","Arm_R", \
                        "coat_root", \
                        "coat_BL1","coat_BL1a","coat_BL2", \
                        "coat_BR1","coat_BR1a","coat_BR2", \
                        "coat_FL1","coat_FL1a","coat_FL2", \
                        "coat_FR1","coat_FR1a","coat_FR2")
						
    	format "Node: %\r\n" node.name
        -- perform the scale
	    lbl_status.text="Scale geom ..."
	    
	    -- based on the node part, race and sex get the scale matrix to use
        if	(tm_scale == undefined) or \
        	(tm_scale == [1,1,1]) or \
        	((findItem bodyparts node.name) != 0)
    	then
	    (
	        tm_scale = [1,1,1]
	        local i, r, s, p
	        local part
	        for i = 1 to (scaleData.size()) do  -- find the scale to use
	        (
	            r = ((scaleData.get i 2)[3] == race)
	            s = ((scaleData.get i 2)[2] == sex)
	            p = ((scaleData.get i 2)[4] == pheno)
	            
	            part = scaleData.get i 1
	            
	            if (part == nx_lowercase(node.name)) and r and s and p then
	            (
	                tm_scale = scaleData.get i 3
	                format "Scale found\r\n"
	                exit    -- stop the loop
	            )
	        )
	    )
	    
        -- adjust scale factor to anything that is an editable mesh only
        if (iskindof node Editable_Mesh) then
        (
	        tm_scale.x += spn_x.value
	        tm_scale.y += spn_y.value
	        tm_scale.z += spn_z.value
        )
		format "Scale factor %\r\n" tm_scale
        
		-- don't scale if is a skin mesh or if is the rootdummy
        if (node.modifiers["Skin"] == undefined) and \
           (node.name != "rootdummy") \
        then
		(
			format "Scaling part: %\r\n" node.name
            node.scale = tm_scale
        )
        
    	for c in node.children do
    	(
        	scaleRobePart c scaleData race sex pheno tm_scale:tm_scale
    	)
	)
	
	on btn_build_robes pressed do
	(
    	local strMsg
    	local scaleINI
    	local newFileName
    	local tmpFileName
    	local modelBase
    	local tmpLst
    	local animSuper
        
    	-- sanity checks
    	scaleINI = g_startpath+"" + drp_scaleini.selected
        if not (nx_existFile scaleINI) then
        (
            strMsg = "Scale ini file does not exist"
            messageBox strMsg
            return 0
        )
        if not(nx_existDir edt_path.text) then
        (
            strMsg = "Export directory does not exist"
            messageBox strMsg
            return 0
        )
        -- make sure is a trailing "\" on the export path
        if (edt_path.text[edt_path.text.count] != "\\") and \
        		(edt_path.text[edt_path.text.count] != "/") then (
	        		edt_path.text += "\\"
     		)

    	-- empty the scene
        strMsg = "This process will empty the scene before commencing."
        if not (queryBox strMsg) then
            return 0

        clearListener()            
        resetMaxFile #noPrompt
        
        -- load up the scale data and parts mapping data
        local scaleData = nx_MultiArray()
        scaleData.width = 3
        local maxData = ((getINISetting scaleINI "init" "nTransforms") as integer)
        -- if maxData is undefined then fundamental error
        if maxData == undefined then
        (
            strMsg = "Error in .ini scale file. Make sure nTransforms key is set."
            messageBox strMsg
            return 0
        )
        local index, s, temp
        local match, sub, part,  scaleMatrix
        for index = 0 to (maxData-1) do
        (
            s = "s" + (index as string)
            part = nx_lowercase(getINISetting scaleINI s "part")
            match = nx_lowercase(getINISetting scaleINI s "match")
            --sub = getINISetting scaleINI s "substitute"
            temp = filterString (getINISetting scaleINI s "Scale") "(),"
            scaleMatrix = point3 (temp[1] as float) (temp[2] as float) (temp[3] as float)
            scaleData.append ( #(part, match, scaleMatrix) )
            temp = undefined
        )
        --print scaleData.ArrayData
        local raceStr = ""	-- = getINISetting scaleINI "roberaces" "races"
        
		if chk_human.checked then raceStr += "h"
		if chk_elf.checked then raceStr += "e"
		if chk_dwarf.checked then raceStr += "d"
		if chk_halfling.checked then raceStr += "a"
		if chk_gnome.checked then raceStr += "g"
		if chk_orc.checked then raceStr += "o"
        
        -- start processing the models in the base model list
        lst_history.items = #()
        for mf in basemodels do	-- mf --> model file
        (
            format "Processing basemodel: %\r\n" mf
            tmpLst = lst_history.items
            append tmpLst ("Model: " + (getFilenameFile mf))
            lst_history.items = tmpLst
            -- we need to process for each roberace
            local raceIndex
            for raceIndex = 1 to raceStr.count do
            (
                -- for speed we don't want to waste time in screen updates
                DisableSceneRedraw()
                format "processing race: %\r\n" raceStr[raceIndex]
                if (loadMaxFile mf) then	-- load the model file
                (
                    format "gmax file loaded\r\n"
                    
                    -- update model status
                    tmpLst = lst_history.items
                    case (raceStr[raceIndex]) of
                    (
	                    "a": append tmpLst "...Halfling"
	                    "d": append tmpLst "...Dwarf"
	                    "e": append tmpLst "...Elf"
	                    "g": append tmpLst "...Gnome"
	                    "o": append tmpLst "...Half-Orc"
	                    "h": append tmpLst "...Human"
	                    "p": append tmpLst "...Phenotype"
                    )
                    lst_history.items = tmpLst
                    
                    -- prep for scaling
            	    local skinslist = #()
            	    local selectedSkins = #()
                    local lParents = #()
                    local objSelect = #()
                    
                    -- determine some key info
                    local sex
                    local pheno
                    case (rdo_process_sex.state) of
                    (
	                    1: sex = (getFilenameFile mf)[2]    -- 2nd char in file name
	                    2: sex = "m"
	                    3: sex = "f"
                    )
                    case (rdo_process_pheno.state) of
                    (
	                    1: pheno  = (getFilenameFile mf)[4]	-- 4th char in file name
	                    2: pheno = "0"
	                    3: pheno = "2"
                    )
                    format "processing for sex = %\r\n" sex
                    format "processing for pheno = %\r\n" pheno
                    
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
            
                    	append swl (nx_SkinWeights s weightBuffer)
                	)
                    
                    -- parse through the model file in the scene in a tree like way
                    for tmp in $helpers do -- to find the model base
                    (
                        if (nx_strclassof tmp) == "aurorabase" then
                        (
	                        modelBase = tmp
                            scaleRobePart modelBase scaleData raceStr[raceIndex] sex pheno
                            exit    -- found model base so stop loop
                        )
                    )
                    
	                -- work out new file name and save as new gmax file to export path
	                tmpFileName = getFilenameFile mf
	                tmpFileName[2] = sex
	                tmpFileName[3] = raceStr[raceIndex]
	                tmpFileName[4] = pheno
                    
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
                	
                	
                	-- where original snapper code was
                	/*
                	-- do pivot snap if needed
                	format "Snap Pivot\r\n"
                	if chk_snappos.checked then (
	                	nx_snaptonormalpivots ((substring tmpFileName 1 3) + "0")
                	)
                	*/
                	
                	
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
                	
                	-- do pivot snap if needed
                	format "Snap Pivot\r\n"
                	if chk_snappos.checked then (
	                	nx_snaptonormalpivots (substring tmpFileName 1 4)
                	)
                	
                	-- relink selection
            	    lbl_status.text="Relink Geom ..."
                	for n = 1 to lParents.count by 2 do
                	(
                    	lParents[n].parent = lParents[n+1]
                	)
                	
	                -- correct model name
	            	lbl_status.text="Update model bases ..."
	                modelBase.name = tmpFileName
	                -- set the model animsuper
	                animSuper = getINISetting scaleINI "skeleton" (substring tmpFileName 1 4)
	                format "Supermodel: %\r\n" animSuper
	                modelBase.setsupermodel = animSuper
	                -- finalise file name
	                newFileName = edt_path.text + tmpFileName
	                -- save the file out to disk
	                saveMaxFile newFileName
                    
                ) else
                (
                    -- max file load failed
                    strMsg = "Failed to load: " + mf
                    messageBox strMsg
                )
                
                -- turn screen drawing back on again
                EnableSceneRedraw()
                -- reset the scene before loading the next file
                resetMaxFile #noPrompt
            )   -- end For: raceStr loop
        )   -- end For: basemodels
        lbl_status.text = "Done."
        
	)   -- end Robe/Armour maker
	
)

if not nx_ramaker_flag then
(
	createDialog nx_ramaker style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox)
)