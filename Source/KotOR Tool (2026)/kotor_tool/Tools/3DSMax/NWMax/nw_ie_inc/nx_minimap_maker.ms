/*-----------------------------------------------------------------------------\

    Tile MiniMap Maker

    NWmax (3dsmax only)
    by Joco (jameswalker@clear.net.nz)

    Credits:


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

rollout nx_tile_minimap "Tile MiniMap Maker" width:300
(
	local silentmode = true
	local bmp_black = standardmaterial diffuse:(color 0 0 0) ambient:(color 0 0 0) -- takes care of Bio's generic black texture
    -- define gui
    group "Source data"
    (
        edittext edt_source_path "Source Dir:" 
        button btn_src "Browse" tooltip:"Browse the dir with the models to process."
        edittext edt_pattern "File pattern" text:"*.mdl"
    )
    group "Destination data"
    (
        edittext edt_target_path "Target Dir:" 
        button btn_trg "Browse" tooltip:"Browse the dir to place the created Mapimages in."
        
        radiobuttons rdo_size "Image Size:" labels:#("16x16","32x32","64x64","128x128") default:1 columns:2
    )
	checkbox chk_silentmode "Only print errors" checked:silentmode
    button btn_makemaps "Create Mini Maps for all models" tooltip:"Process the directory." width:200
    button btn_dogroups "Only Process Groups" tooltip:"Reads groups from a .set in the Source Directory and creates Mapimages for it." width:200

	fn lowercase instring = 
	(
	 local upper, lower, outstring ,i
	upper="abcdefghijklmnopqrstuvwxyz"
	lower="ABCDEFGHIJKLMNOPQRSTUVWXYZ" 
	outstring=copy instring 
	for i=1 to outstring.count do 
		( 
		j=findString lower outstring[i] 
		if (j != undefined) do outstring[i]=upper[j] 
		) 
	return outstring
	)

    fn nx_load_group sel_text filename =
    (
        local rows, columns, grp_number, filename, tile_name, tile_number
        local rowpl, columnpl, model_base
        local model_path
        local models = #()
        local retarray = #()
        
        local data = filterString sel_text " []"
        grp_number = data[1]
        rows = (getINISetting filename ("GROUP" + grp_number) "Rows") as integer
        columns = (getINISetting filename ("GROUP" + grp_number) "Columns") as integer
        append retarray rows
        append retarray columns
        
        for i = 0 to ((rows * columns)-1) do
        (
            tile_number = getINISetting filename ("GROUP" + grp_number) ("Tile" + (i as string))
            if tile_number != "-1" then
            (
                tile_name = getINISetting filename ("TILE" + tile_number) "Model"
            ) else
            (
                tile_name = "RANDOM"
            )
            append models tile_name
            append retarray tile_name
        )
        --clearListener()
        if not silentmode then format "Models: %\r\n" models
        
        -- got the model names. Assume in same path as set file.
        model_path = getFilenamePath filename
        
        rowpl = 0
        columnpl = 0
        for model in models do
        (
            if model != "RANDOM" then
            ( 
                ImportNWNmdl (model_path + model + ".mdl") false false loadGeom:true loadtiff:false
            )
            model_base = getNodeByName model
            if model_base == undefined then
            (
                format "ERROR: Can't find modelbase\r\n"
            ) 
			else
            (
                model_base.pos = [(columnpl * 1000),(rowpl * 1000),0]
            )
            if columnpl >= (columns-1) then
            (
                columnpl = 0
                rowpl += 1
            ) else
            (
                columnpl += 1
            )
        )
         
        -- Redraw gmax viewports
        --clearSelection()
        --max tool zoomextents all
        --max views redraw
        --format "Finished.\n\r\n"
        gc()
        retarray
    )
    
        
    fn nx_render_tile imagename scaleit:true =
    (
        local bmp, scaled_bmp
        local logvar
		local UVlog 
        backgroundColor = color 0 255 0 0
        bgc = color 0 255 0 0
        bmp = render frame:0 outputsize:[256,256] \
                renderer:#production \
                renderType:#normal \
                antiAliasing:false \
				-- missingUVWAction:#abort \
				-- missingUVWlist:&UVlog
				-- quiet:true
				
				-- quiet:true \
				-- missingUVWAction:#logmsg
                --missingUVWAction:#logmsg \
                --missingUVWList:&logvar \
                --quiet:true
        
        
        local h = bmp.height
        local w = bmp.width
        local r     -- row counter
        local c     -- column counter
        local rowdata
        local image = #()
        local l_edge, r_edge, t_edge, b_edge
        local sc_w, sc_h
        
        --clearListener()
        
        -- build up image data
        for r = 0 to (h-1) do
        (
            rowdata = getPixels bmp [0,r] w
            append image rowdata
        )
        
        -- clean up # 1
        close bmp
        rowdata = undefined
        gc()
        
        if not silentmode then format "bmp width: %  height: %\r\n" w h
        
        -- do collison testing for left edge
        l_edge = w-1
        for r = 0 to (h-1) do
        (
            for c = 0 to (w-1) do
            (
                if (image[r+1][c+1] != bgc) and (c < l_edge) then
                (
                    l_edge = c +1
                )
            )
        )
        
        -- do collison testing for right edge
        r_edge = 0
        for r = 0 to (h-1) do
        (
            for c = (w-1) to 0 by -1 do
            (
                if (image[r+1][c+1] != bgc) and (c > r_edge) then
                (
                    r_edge = c
                )
            )
        )
        
        -- do collison testing for top edge
        --format "collison testing for top edge\r\n"
        t_edge = h-1
        for c = 0 to (w-1) do
        (
            for r = 0 to (h-1) do
            (
                if (image[r+1][c+1] != bgc) and (r < t_edge) then
                (
                    --format "%:%  " r c
                    --format "t_edge=%  " c
                    t_edge = r+1
                )
            )
        )
        --format "\r\n\r\n"
        
        -- do collison testing for bottom edge
        --format "collison testing for bottom edge\r\n"
        b_edge = 0
        for c = 0 to (w-1) do
        (
            for r = (h-1) to 0 by -1 do
            (
                if (image[r+1][c+1] != bgc) and (r > b_edge) then
                (
                    --format "%:%  " r c
                    --format "b_edge=%  " c
                    b_edge = r
                )
            )
        )
        --format "\r\n\r\n"
        
        if not silentmode then 
		(
			format "name: %\r\n" imagename
	        format "left edge: %\r\n" l_edge
	        format "right edge: %\r\n" r_edge
	        format "top edge: %\r\n" t_edge
	        format "bottom edge: %\r\n" b_edge
        )
        -- sanity checks
        if (l_edge > r_edge) or (t_edge > b_edge) then
        (
            format "Error - nothing in render\r\n"
            return false
        )
        
        -- build new bitmap
        local new_w, new_h  -- new calc'd width and height
        local new_rowdata = #()
        
        new_w = (r_edge - l_edge) + 1
        new_h = (b_edge - t_edge) + 1
        
        bmp = bitmap new_w new_h color:black
        for r = t_edge to b_edge do
        (
            for c = l_edge to r_edge do
            (
                append new_rowdata image[r+1][c+1]
            )
            
            -- ensure any bgc set pixels are now black (0 0 0 0)
            for rd = 1 to new_rowdata.count do
            (
                if new_rowdata[rd] == bgc then
                (
                    new_rowdata[rd] = color 0 0 0 0
                )
            )
            -- set pixel
            setPixels bmp [0,(r - t_edge)] new_rowdata
            --format "set row at: 0,%\r\n" (r - t_edge)
            new_rowdata = #()
        )
        
        -- determine scale target
        if scaleit == true then
        (
            case rdo_size.state of
            (
                1:
                (
                    sc_w = 16
                    sc_h = 16
                )
                2:
                (
                    sc_w = 32
                    sc_h = 32
                )
                3:
                (
                    sc_w = 64
                    sc_h = 64
                )
                4:
                (
                    sc_w = 128
                    sc_h = 128
                )
            )
        ) else
        (
            sc_w = new_w
            sc_h = new_h
        )
        if not silentmode then
		(
			format "Save as: %\r\n" imagename
	        format "Scaled image size: %, %\r\n" sc_w sc_h
		)
        scaled_bmp = bitmap sc_w sc_h color:black filename:imagename
        copy bmp scaled_bmp
        save scaled_bmp
        
        -- clean up # 2
        close bmp
        image = undefined
        new_rowdata = undefined
        scaled_bmp
    )
    
    
    fn nx_make_tile_minimap =
    (
		local chk_map
        -- make sure the stack and heap is really large!!
        if heapSize < 7500000 then heapSize = 7500000
        if stackLimit < 4000000 then stackLimit = 4000000
        
        local map_tga
        
        -- process all the files in a specified directory
        local dir_path = edt_source_path.text
        local targetdir = edt_target_path.text
        
        -- basic sanity check
        if dir_path == "" or targetdir == "" then
        (
            messageBox "Not enough path information"
            return false
        )
        
        -- correct lack of trailing /
        if (dir_path[dir_path.count] != "/") and (dir_path[dir_path.count] != "\\") then
        (
            dir_path += "\\"
        )
        if (targetdir[targetdir.count] != "/") and (targetdir[targetdir.count] != "\\") then
        (
            targetdir += "\\"
        )
        local filenum = 0
        local modelname
        
        progressStart "Making Mini Maps"
        local files = getFiles (dir_path + (edt_pattern.text))
        
        -- work through the files. Load and render, repeat until done
        local l, w, h, selected_objects, obj, slicing_box
        for f in files do
        (
            filenum += 1
            if (progressUpdate ((filenum * 100)/files.count)) == false then
            (
                -- stop the loop
                exit
            )
            -- setup
            gc()
            disableSceneRedraw()
            resetMaxFile #noPrompt
			if doesFileExist f then
			(
	            ImportNWNmdl f false false loadGeom:true loadtiff:false
			)
            enableSceneRedraw()
            
            -- Clip off any mesh that is outside the x,y plane of -500,+500 around 0,0,0.
            -- Do this using a boolean operation with a bounding dummy object.
            -- Also make the dummy object VERY high.
            -- Make a slicing box big enough to cover the selected objects.
            max select all
            l = 1000
            w = 1000
            h = selection.max.z - selection.min.z + 2000
            bottom = selection.min.z - 10
            objlist = $objects as array
            for obj in objlist do
            (
                if (iskindof obj Editable_mesh) then
                (
                    -- copy of original so we can get the modifiers back
                    orig = copy obj

                    -- Create a slicing box.
                    slicing_box = box length:l width:w height:h \
                        position:[0, 0, bottom]
                    -- Do a cut/slice and remove boolean operation.
                    boolObj.createBooleanObject obj slicing_box 4 5
                    boolObj.setBoolOp obj 5
                    boolObj.setBoolCutType obj 4
                    
                    -- convert to mesh and restore nwmax modifiers
                    convertToMesh obj
                    
                    -- restore modifiers
                    nx_copy_modifiers obj orig ignore:#("Skin")
                    delete orig
                )
            )
            
            
            -- work out which mesh objects should not be rendered
            -- 1. woks
            -- 2. any mesh with a tga that has an alpha channel
            -- 3. any mesh with a trimesh modifier with "no render" set
            for o in $objects do
            (
                if (iskindof o Editable_mesh) then
                (
                    -- is it a walkmesh
                    if (o.modifiers["AuroraWalkmesh"] != undefined) then
                    (
                        setRenderable o false
                    )
	                    else if (o.mat != undefined) and (o.mat.diffusemap != undefined) then
	                    (
	                        if (nx_read_tga_bit(o.mat.diffusemap.filename) == 32) then
	                        (
	                            -- depth of 32 means an alpha channel
	                            setRenderable o false
	                        )
	                    )
                    -- is there a trimesh modifier
                    if o.modifiers["AuroraTrimesh"] != undefined then
                    (
                        if (o.modifiers["AuroraTrimesh"].render) == 0 then
                        (
                            setRenderable o false
                        )
                    )
					-- edit by Velmar
					if o.material != undefined then
					(
						chk_mat = o.material.name
						chk_mat = lowercase chk_mat
						if chk_mat == "black" then 
						(
							o.material = bmp_black
							format "applied generic texture 'Black' \r\n"
						)
					)
					if getNumTverts o < 1 then
					(
						addModifier o (UVWmap())
					)
                )
                -- get model base name
                if (iskindof o aurorabase) then
                (
                    modelname = o.name
                )
            )
            disableSceneRedraw()
            viewport.setLayout #layout_1
            viewport.setType #view_top
            max tool zoomextents
            enableSceneRedraw()
            map_tga = nx_render_tile (targetdir + "mi_" + modelname + ".tga") 
            if map_tga != false then
            (
                close map_tga
            )
            gc()
        )
        progressEnd()
    )


    fn nx_process_groups =
    (
        -- make sure the stack and heap is really large!!
        if heapSize < 7500000 then heapSize = 7500000
        if stackLimit < 4000000 then stackLimit = 4000000
        
        local map_tga
        local retvalarray
        
        -- process all the files in a specified directory
        local dir_path = edt_source_path.text
        local targetdir = edt_target_path.text
        
        -- basic sanity check
        if dir_path == "" or targetdir == "" then
        (
            messageBox "Not enough path information"
            return false
        )
        
        -- correct lack of trailing /
        if (dir_path[dir_path.count] != "/") and (dir_path[dir_path.count] != "\\") then
        (
            dir_path += "\\"
        )
        if (targetdir[targetdir.count] != "/") and (targetdir[targetdir.count] != "\\") then
        (
            targetdir += "\\"
        )
        local filenum = 0
        local modelname
        
        --
        -- process the groups using the .set file def
        --
        -- 1. if is a .set then continue
        filenameSET = getFiles (dir_path + "*.set")
        format "Start processing groups from .set: %\r\n" filenameSET[1]
        if filenameSET.count < 1 then
        (
            format "ERROR: filenameSET.count < 1\r\n"
            return false
        )
        filenameSET = filenameSET[1]
        -- 2. get the group list from .set
        local groups = #()
        local grp_count = (getINISetting filenameSET "GROUPS" "Count") as integer
        local grp_name
        for i = 0 to (grp_count-1) do
        (
            grp_name = getINISetting filenameSET ("GROUP" + (i as string)) "Name"
            grp_name =  "[" + (i as string) + "]  " + grp_name
            append groups grp_name
        )
        
        if not silentmode then format "Group count=%, names: %\r\n" grp_count groups

        -- 3. work through the groups
        for g in groups do
        (
            if not silentmode then format "get group: %\r\n" g
            disableSceneRedraw()
            resetMaxFile #noPrompt
            retvalarray = nx_load_group g filenameSET
			
			-- EDIT BY Velmar - workaround for script stop at 'nothing to render'
			-- creates a red plane instead 
			if $geometry.count < 1 then
			(
				format "----------------------------------\r\n" 
				format "ERROR --- file % does not exist !! \r\n" retvalarray
				format "----------------------------------\r\n"
				p = plane length:1000 width:1000
				p.wirecolor = red
				convertToMesh p
			)
			else if not silentmode then format "group made of: %\r\n" retvalarray
            
            -- set up the view port correctly for rendering
            viewport.setLayout #layout_1
            viewport.setType #view_top
            max tool zoomextents
            enableSceneRedraw()
            
            -- work out which mesh objects should not be rendered
            -- 1. woks
            -- 2. any mesh with a tga that has an alpha channel
            for o in $objects do
            (
                if (iskindof o Editable_mesh) then
                (
                    -- is it a walkmesh
                    if (o.modifiers["AuroraWalkmesh"] != undefined) then
                    (
                        setRenderable o false
                    )
	                    else if (o.mat != undefined) and (o.mat.diffusemap != undefined) then
	                    (
	                        if (nx_read_tga_bit(o.mat.diffusemap.filename) == 32) then
	                        (
	                            -- depth of 32 means an alpha channel
	                            setRenderable o false
	                        )
	                    )
                    -- is there a trimesh modifier
                    if o.modifiers["AuroraTrimesh"] != undefined then
                    (
                        if (o.modifiers["AuroraTrimesh"].render) == 0 then
                        (
                            setRenderable o false
                        )
                    )
					-- edit by Velmar
					if o.material != undefined then
					(
						chk_mat = o.material.name
						chk_mat = lowercase chk_mat
						if chk_mat == "black" then 
						(
							o.material = bmp_black
							format "applied generic texture 'Black' \r\n"
						)
					)
					if getNumTverts o < 1 then
					(
						addModifier o (UVWmap())
					)

                )
                -- get model base name
                if (iskindof o aurorabase) then
                (
                    modelname = o.name
                )
            )
            
            -- for groups we don't want things scaled in the render routine.
            -- We scale after chopping
            map_tga = nx_render_tile (targetdir + "group_" +(g as string)+ ".tga") scaleit:false
            
            if map_tga == false then
            (
                gc()
                format "map_tga == FALSE\r\n"
                return false
            ) else
            (
                if not silentmode then format "map_tga == a bitmap\r\n"
            )
            
            -- chop the returned tga into the correct parts
            local rows = retvalarray[1]
            local columns = retvalarray[2]
			if not silentmode then
			(
	            format "grp rows=%\r\n" rows
	            format "grp columns=%\r\n" columns
            )
            deleteItem retvalarray 2
            deleteItem retvalarray 1
            if not silentmode then format "grp model list: %\r\n" retvalarray
            
            local cut_width = (map_tga.width) / columns
            local cut_height = (map_tga.height) / rows
			if not silentmode then
			(
	            format "cut_width = %\r\n" cut_width
	            format "cut_height = %\r\n" cut_height
	            format "map_tga.width = %\r\n" (map_tga.width)
	            format "map_tga.height = %\r\n" (map_tga.height)
			)
            
            local cut_pos_x, cut_pos_y, sc_w, sc_h
            local imagename
            
            local rowpl = 0
            local columnpl = 0

            local pixdata = #()
            

            for model in retvalarray do
            (
                -- model to cut, scale and save
                if model != "RANDOM" then
                ( 
                    -- calc upper left pos of subimage
                    cut_pos_x = (cut_width * columnpl)
                    cut_pos_y = (cut_height * (rows-rowpl-1)) 			-- VELMAR edits
                    
                    -- build up the bmp piece
                    cutbmp = bitmap cut_width cut_height color:black
                    for r = cut_pos_y to (cut_pos_y + cut_height) do
                    (
                        pixdata = getPixels map_tga [cut_pos_x, r] cut_width
                        setPixels cutbmp [0,r-cut_pos_y] pixdata
                    )
                    
                    -- scale the cutbmp
                    case rdo_size.state of
                    (
                        1:
                        (
                            sc_w = 16
                            sc_h = 16
                        )
                        2:
                        (
                            sc_w = 32
                            sc_h = 32
                        )
                        3:
                        (
                            sc_w = 64
                            sc_h = 64
                        )
                        4:
                        (
                            sc_w = 128
                            sc_h = 128
                        )
                    )
                    
                    -- set the image save name
                    imagename = targetdir + "mi_" + model + ".tga"
                    format "Save as: %\r\n" imagename
                    scaled_bmp = bitmap sc_w sc_h color:black filename:imagename
                    copy cutbmp scaled_bmp
                    save scaled_bmp
                    
                    -- clean up
                    close cutbmp
                    close scaled_bmp
                    
                )
                if columnpl >= (columns-1) then
                (
                    columnpl = 0
                    rowpl += 1
                ) 
				else
                (
                    columnpl += 1
                )
            )
            
            if map_tga != false then
            (
                -- close the bmp
                close map_tga
            )
            gc()
        )
    )


	on chk_silentmode changed val do
	(
		silentmode = val
	)

    on btn_src pressed do
    (
        local p = getsavepath()
        if p != undefined then
        (
            edt_source_path.text = p
			edt_target_path.text = p
        )
    )
    
    on btn_trg pressed do
    (
        local p = getsavepath()
        if p != undefined then
        (
            edt_target_path.text = p
        )
    )

    on btn_makemaps pressed do
    (
        nx_make_tile_minimap()
    )
    
    on btn_dogroups pressed do
    (
        clearListener()
        nx_process_groups()
    )
)

createDialog nx_tile_minimap