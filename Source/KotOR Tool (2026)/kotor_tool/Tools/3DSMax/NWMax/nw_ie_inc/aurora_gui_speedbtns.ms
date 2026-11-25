/*-----------------------------------------------------------------------------\

    Speed Buttons UI

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

filein (g_startpath+"nw_ie_inc\\aurora_fn_desparkle.ms")


-- Global var for holding unlnked hierarchy of selected nodes
global g_linkCopy = #()

fn LoadPlugIns =
(
    -- load plugins into g_plugins
    -- Pass through the plugins dir and process all the .ini files
    g_plugins = #()
    local filepattern = g_startpath+"plugins\\*.ini"
    local files = getFiles filepattern
    for f in files do
    (
        -- Each file is an ini file so get the keys and add to global array
        append g_plugins (getINISetting f "setup" "name")
        append g_plugins (getINISetting f "setup" "script")
    )
)


--------------------------------------------------------------------------------
rollout nx_util2 "Robes\Armour\Skin" width:162 height:68
(
    button btn_armourer "Armour Maker" width:144 height:18
    button btn_cutter "Armour Cutter" width:144 height:18
    button btn_skindumper "Skin Dumper" width:144 height:18
    button btn_weightmaster "Weight Master" width:144 height:18
    button btn_pivotsnap "PivotSnap" across:2
    dropdownlist drp_snaptypes items:#( "pmh","pfh", \
                                        "pma","pfa", \
                                        "pmd","pfd", \
                                        "pme","pfe", \
                                        "pmg","pfg", \
                                        "pmo","pfo")
    checkbox chk_pivotonly "Pivot Only" checked:false align:#left across:2
    dropdownlist drp_snappheno items:#("0","2") align:#right
    
    on btn_armourer pressed do ( nx_loadTool (g_startpath+"ramaker/nwmax_ramaker.ms") )
    on btn_cutter pressed do ( nx_loadTool (g_startpath+"ramaker/nwmax_armourcutter.ms") )
    on btn_skindumper pressed do ( nx_loadTool (g_startpath+"ramaker/nwmax_skindumper.ms") )
    on btn_weightmaster pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_weightmaster.ms") )
    
    on btn_pivotsnap pressed do (
        nx_snaptonormalpivots (drp_snaptypes.selected + drp_snappheno.selected) pivotonly:(chk_pivotonly.checked)
    )
    
    on nx_util2 open do
    (
            -- make sure some utils are available
        if not nx_existFile(g_startpath+"ramaker\\nwmax_armourcutter.ms") then
        (
            btn_cutter.enabled = false
        )
        if not nx_existFile(g_startpath+"ramaker\\nwmax_skindumper.ms") then
        (
            btn_skindumper.enabled = false
        )
    )
)

rollout nx_util3 "Mesh Tools" width:162 height:68
(
    button btn_trimesh "Trimesh"  width:144 height:18 align:#center toolTip:"Convert mesh into a trimesh, preserving modifiers"
    button btn_cryomesh "Cryomesh" width:144 height:18 align:#center toolTip:"Save selected mesh states to file for later reload"
    button btn_shadowchecker "Check Shadows" width:144 height:18 align:#center toolTip:"Check shadow validity of all selected objects"
    button btn_tidy_materials "Rationalise Materials" width:144 height:18 align:#center toolTip:"Rationalise the materials in the scene"
    button btn_tvertdisplace "TVert Displacer" width:144 height:18 align:#center toolTip:"Scale/Move tverts on a material that has been resized"
    button btn_randomisecolor "Random Wirecolor" width:144 height:18 align:#center toolTip:"Randomise the wirecolor of all selected objects"
    button btn_resetxform "ResetXForm" width:70 height:18 toolTip:"Auto unlinks selection, reset xforms the editable meshes and relinks. Pivots can be preserved or not." across:2
    checkbox chk_keeppivots "Safe Pivots" checked:true
    checkbutton btn_linkcopy "Copy/Paste Links" width:90 height:18 align:#left across:2 toolTip:"Copy linkages of selected nodes, then on 2nd push restore them."
    button btn_copyreset "Reset" width:44 height:18 align:#right toolTip:"Clear copy link buffer"
    button btn_orderchildren "Order Children" width:144 height:18 align:#center toolTip:"Manually reorder children of selected object"
    button btn_desparkle "\"Desparkle\" Model" width:144 height:18 align:#center toolTip:"Desparkle by rounding all verts to nearest cm"
    button btn_woktool "WOK Checker Tool" width:144 height:18 align:#center toolTip:"Tests WOKs for validty and assist in finding the offending Verts/Edges"
    
    on btn_trimesh pressed do undo on
    (
        for obj in selection do
        (
            local orig = copy obj

            -- Converting to an Editable Patch and back again splits the
            -- given object's polygons into faces (triangles).
            convertToMesh obj
            convertTo obj Editable_Patch
            convertToMesh obj

            -- Restore the original modifiers.
            nx_copy_modifiers obj orig

            delete orig
        )
    )
    
    on btn_cryomesh pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_cryomesh.ms")
    )
    
    on btn_tvertdisplace pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_tvertdisplacer.ms")
    )
    
    on btn_copyreset pressed do
    (
        g_linkCopy = #()
        btn_linkcopy.checked = false
    )
    
    on btn_orderchildren pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_orderchildren.ms") )
    
    -- Perform a model desparkle
    on btn_desparkle pressed do
    (
        if (nx_strclassof selection[1]) == "aurorabase" then
        (
            clearListener()
            --format "<snoopstart file=%>\r\n" (selection[1].name + "_desparklelog.txt")
            nx_mesh_desparkle selection[1]
            --format "</snoopstart>\r\n"
        ) else
            MessageBox "No AuroraBase selected."
    )
    
    on btn_woktool pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_woktool.ms")
    )
    
    on btn_linkcopy changed down do
    (
        if down then
        (
            -- copy links
            g_linkCopy = #()
            for s in selection do
            (
                append g_linkCopy s
                append g_linkCopy s.parent
            )
        ) else
        (
            -- restore links
            local i
            for i = 1 to g_linkCopy.count by 2 do
            (
                try
                    g_linkCopy[i].parent = g_linkCopy[i+1]
                catch ()
            )
        )
    )

    on btn_resetxform pressed do
    (
        local lParents = #()
        clearListener()
        -- build up parent list
        for s in selection do
        (
            append lParents s
            append lParents s.parent
        )
        -- unlink the selection
        format "unlink\r\n"
        for s in selection do
        (
            s.parent = undefined
        )
        -- do the reset
        format "reset xform\r\n"
        -- do the reset
        local rotvalue
        local piv
        local orig
        for s in selection do
        (
            if (iskindof s Editable_Mesh) then
            (
                -- preserve pivots orientation/rotation
                if chk_keeppivots.checked then
                (
                    rotvalue = s.rotation
                    s.rotation = (quat 0 0 0 1)
                )
                orig = copy s
                nx_reset_transforms s
                if chk_keeppivots.checked then
                (
                    s.rotation = rotvalue
                )
                format "XForm added: %\r\n" s.name
                
                -- collapse stack
                try ( collapsestack s ) catch()
                format "XForm collapsed\r\n"
                
                -- restore original modifiers less the Xform
                nx_copy_modifiers s orig ignore:#("XForm")
                delete orig
            ) else
            (
                s.scale = [1,1,1]
            )
        )
        -- relink
        format "relink\r\n"
        for n = 1 to lParents.count by 2 do
        (
            format "n=%\r\n" n
            lParents[n].parent = lParents[n+1]
        )
    )

        
    -- Tidy Materials
    --  
    fn qcompare obj1 obj2 =
    (
        local s1 = obj1.mat.diffusemap.filename
        local s2 = obj2.mat.diffusemap.filename
        
        if s1 < s2 then return -1
        if s1 > s2 then return 1
        0   -- they must be equal
    )
    fn matcompare mat1 mat2 =
    (
        if  (mat1.name != mat2.name) and \
            (mat1.diffusemap.filename == mat2.diffusemap.filename) and \
            (mat1.diffuse == mat2.diffuse) and \
            (mat1.ambient == mat2.ambient) and \
            (mat1.specular == mat2.specular) and \
            (mat1.specularlevel == mat2.specularlevel) and \
            (mat1.glossiness == mat2.glossiness) and \
            (mat1.selfillumcolor == mat2.selfillumcolor) and \
            (mat1.opacity == mat2.opacity) \
        then return true
        false   -- assume not the same unless proven otherwise
    )
    
    on btn_tidy_materials pressed do
    (
        local objlist = #()
        format "Material Rationalisation\r\n"
        format "... Getting objects\r\n"

        -- get the list of objs that have standard materials with a bitmap
        for o in $objects do
        (
            if (o.mat!=undefined) and ((classof o.mat)==Standardmaterial) then (
                if o.mat.diffusemap != undefined then (
                    append objlist o
                )
            )
        )
        format "... Sorting objects\r\n"
        -- sort the array by the filename on the material
        qsort objlist qcompare
        
        -- start the rationalisation
        format "... Rationalise objects\r\n"
        local matDeleteList = #()
        local i, j, m
        for i = 1 to objlist.count do
        (
            j = i + 1
            -- make sure that j is within array bounds
            if j <= objlist.count then
            (
                while (matcompare objlist[i].mat objlist[j].mat) do
                (
                    format "... Object >>  %  << rationalised\r\n" objlist[j]
                    -- put this material on the delete list
                    append matDeleteList objlist[j].mat
                    -- rationalise the assigned material
                    objlist[j].mat = objlist[i].mat
                    -- move pointer forward 1
                    j += 1
                    -- make sure j is within array bounds
                    if j > objlist.count then exit
                )
                -- move i forward to j-1
                i = j - 1
            )
        )
        -- Now clean out the materials to be deleted from the scene
        format "... Remove redundant materials\r\n"
        for m in matDeleteList do (
            format "... Material >>  %  << removed\r\n" m.name
            deleteItem sceneMaterials m.name
        )
        format "Material Rationalisation Ends\r\n"
    )
    -- End Tidy Materials
    --  

    on btn_randomisecolor pressed do
    (
        local sel = selection as array
        for s in sel do
        (
            try (
                s.wirecolor = random black white
            ) catch()
        )
    )
    
    --
    -- Test for valid shadows.  If a ray from the pivot point hits the
    -- front of any face in the object, the shadows will be off.
    -- Code by roboius (http://rockbottom.vtex.net/)
    --
    fn make_color_str c = 
    (
        local r,g,b
        r = c.red as string
        g = c.green as string
        b = c.blue as string
        r+"|"+g+"|"+b
    )
    fn parse_color_str s =
    (
        local list
        local r,g,b
        list = filterString s "|"
        r = list[1] as integer
        g = list[2] as integer
        b = list[3] as integer
        return (color r g b)
    )
    fn test_shadows obj =
    (
        local invalid_shadow_color = [255,0,0]
        local disabled_shadow_color = [0,0,0]
        local face, normal, vertex, dp, errors = 0
        local bHasFailed = 0
    
        if (not iskindof obj Editable_Mesh) then ( return 0 )

        try 
            bHasFailed = (getUserProp obj "shadowfailed") as integer
        catch( bHasFailed = 0 )

        if bHasFailed == 0 then (
            setUserProp obj "wirecolor" (make_color_str obj.wirecolor)
            originalcolor = obj.wirecolor
        ) else (
            originalcolor = parse_color_str (getUserProp obj "wirecolor")
            if originalcolor == undefined then (
                originalcolor = obj.wirecolor
            )
        )
        
        for ii = 1 to obj.numfaces do
        (
            face = getface obj ii
            normal = getfacenormal obj ii
            vertex = getvert obj face.x
    
            dp = dot normal vertex
    
            if ((dot normal obj.pivot) - dp > 5e-3) then ( errors += 1 )
        )
    
        if (errors > 0) then (
            format "Warning: Object % may have an invalid shadow.\r\n" obj.name
            obj.wirecolor = invalid_shadow_color
            setUserProp obj "shadowfailed" 1
            return 1
        ) else (
            obj.wirecolor = originalcolor
            setUserProp obj "shadowfailed" 0
            return 0
        )
    )
    on btn_shadowchecker pressed do
    (
        for obj in selection do
            test_shadows obj
    )
    -- End shadow test functions
    --
)

rollout nx_util4 "Anim Tools" width:162 height:68
(
    button btn_reset_controllers "Reset Controllers" width:144 height:18 toolTip:"Resets the rotation controller to tcb then back to linear"
    button btn_animcopy "Copy animation keys" width:144 height:18 toolTip:"Copy Anim keys in the specified range to a target start frame"
    button btn_animapper "Anim Mapper" width:144 height:18 toolTip:"Import animations off nodes in an MDL and map to scene nodes"
    button btn_keymaster "Key Master" width:144 height:18 toolTip:"A number of mass key manipulation functions"
    button btn_keytweak "Mass Key Tweaker" width:144 height:18 toolTip:"Mass tweaking of rot and pos keys"
    button btn_bakeanim "Bake Anims" width:144 height:18
    button btn_keyreduct "Reduce Anim Keys" width:144 height:18 toolTip:"Rationalise the animation keys for the selected nodes"
    button btn_animbrowse "Anim Broswer" width:144 height:18
    button btn_eventbrowse "Event Broswer" width:144 height:18
    --button btn_mayakeyrests "Reset Maya Rot Keys" width:144 height:18
    
    on btn_keymaster pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_animkeymaster.ms") )
    
    on btn_reset_controllers pressed do
    (
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


    on btn_animcopy pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_animkeycopy.ms")
    )
    
    on btn_animapper pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_mapper.ms")
    )

    on btn_keytweak pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_masskeytweak.ms")
    )
    
    on btn_bakeanim pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_animbaker.ms")
    )

    on btn_keyreduct pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_keyreduct.ms")
    )
    
    on btn_animbrowse pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_animbrowse.ms")
    )
    
    on btn_eventbrowse pressed do
    (
        nx_loadTool (g_startpath+"nw_ie_inc/nx_eventbrowse.ms")
    )
    
    on btn_mayakeyrests pressed do
    (
        -- go through all scene objects and for each rotation key value
        -- swap the x and y parts of the axis
        for obj in $objects do
        (
            -- trap for errors
        )
    )
)

rollout nx_util5 "Texture Tools" width:162 height:68
(
    -- ui
    button btn_texlib "TexLib" width:144 height:18 align:#center
    button btn_texlibmaker "TexLib Maker" width:144 height:18 align:#center
    button btn_minimap "MiniMap Maker" width:144 height:18 align:#center

    -- ensure only active if running max version of nwmax
    on nx_util5 open do
    (
	    if ( not g_ismax ) then
	    (
		    btn_texlib.enabled = false
		    btn_texlibmaker.enabled = false
		    btn_minimap.enabled = false
	    )
    )
    
    -- actions
    on btn_texlib pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_texturelib.ms") )
    on btn_texlibmaker pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_texturelibmaker.ms") )
    on btn_minimap pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_minimap_maker.ms") )
)

rollout nx_prefs "Preferences" width:162 height:68
(
    label lbl_wip "Max 2021 preferences"
    
    checkbox chk_autodock "Autodock" checked:(nx_itob(gNX_dock))
    
    button btn_exportpath "Export Path" width:144 height:18
    label lbl_xpath ""
    
    button btn_skinpath "SkinDumper Path" width:144 height:18
    label lbl_xpathskin ""
    
    button btn_xpathcryo "CyroMesh Path" width:144 height:18
    label lbl_xpathcryp ""
    
    spinner spn_animheight "Anim List Length:" type:#integer range:[5,30,g_guiAnimListSize]

    on chk_autodock changed value do
    (
        gNX_dock = if value then 1 else 0
        nx_savePreference "init" "dock" gNX_dock
    )
    on spn_animheight changed value do
    (
        g_guiAnimListSize = value
        nx_savePreference "init" "animlistsize" value
    )
)

rollout nx_util1 "General Utils" width:162 height:68
(
    local vp_layout
    local plugin_scripts

    -- speedbar #1
    checkbutton btn_rollup "Float Speedbar" width:144 height:14 offset:[0,-5] align:#center checked:false
    button btn_sel_parent "Parent" width:68 height:18 align:#left across:2 toolTip:"Select Parent"
    button btn_sel_child "Child" width:68 height:18 align:#right toolTip:"Select children"
    checkbutton btn_make_dummy_helper "Dummy" width:68 height:18 align:#left across:2 toolTip:"Create a stock Dummy helper"
    button btn_environ "Set Environ" width:68 height:18 align:#right toolTip:"Set default unit scales etc."
    button btn_makeintodummy "IntoDummy" width:68 height:18 align:#left across:2 tooltop:"Make selected objects into Dummy helpers"
    button btn_linker "Fast Linker" width:68 height:18 align:#right toolTip:"Link all selected objects to the AuroraBase in the selection"

    -- speedbar #2
    --button btn_veltools "VelTools" width:144 height:18 align:#center
    button btn_chilliskinner "Chilli Skinner" width:144 height:18 align:#center
    button btn_tileslicer "Tile Slicer" width:144 height:18 align:#center
    button btn_modelscaler "Scale Wizard" width:144 height:18 align:#center
    button btn_massops "Mass Operations" width:144 height:18 align:#center
    
    
    button btn_export_all "Export all or Selected" width:144 height:18 align:#center toolTip:"Export selected models or all models if none selected."
    group "Reset Export Directory" (
        edittext edt_resetdir "Dir:" text:(getdir #export)
        button btn_resetdir "Reset" width:68 height:18 across:2 toolTip:"Reset the export directory of all selected model bases"
        button btn_resetdirbrowse "Browse" width:68 height:18 toolTip:"Select the export path"
    )
    
    group "Plug-Ins"
    (
        dropdownlist dpl_prefabs height:10 width:130 offset:[-6,0] align:#left across:2
        button btn_prefab_do "Go" height:20 width:20 offset:[7,0] align:#right 
    )
    
    group "Reset Sanity Check"
    (
        checkbox box_AuraEmitterCheck "Emitter Validity" checked:runAuraEmitterCheck
        checkbox box_AuraRefCheck "AuraRef Existence" checked:runAuraRefCheck
        checkbox box_NameCheck "Node Name Validity" checked:runNameCheck
        checkbox box_ScaleCheck "Zero World Scale" checked:runScaleCheck
        checkbox box_PartTextureCheck "Material Bitmap Name Chk" checked:runPartTextureCheck
        checkbox box_BitmapNameCheck "Bitmap Name Validity" checked:runBitmapNameCheck
        checkbox box_WeldCheck "Weld To Nearest cm" checked:runWeldCheck
        checkbox box_ClassCheck "Node Type 'boolean'" checked:runClassCheck
        checkbox box_ControllerCheck "Valid Controllers on Keys" checked:runControllerCheck
        checkbox box_AnimMeshCheck "Animated Mesh Validity" checked:runAnimMeshCheck
        checkbox box_DoganCheck "Texvert Validity" checked:runDoganCheck
        checkbox box_FaceCheck "Zero Faces On a Node" checked:runFaceCheck
        checkbox box_BSACheck "Bumpy-shiny Alignmt Chk" checked:runBSACheck
        checkbox box_AnimrootCheck "Animroot Node Existence" checked:runAnimrootCheck
        checkbox box_BoneCountCheck "Skinning:4 Bones per Vert" checked:runBoneCountCheck
        checkbox box_WOKchecker "Check WOK" checked:runWOKCheck
        --button btn_setsanities "Set Sanity Checks" tooltip:"Sets these sanity check options on all selected model bases"
    )
    


    -- Sanity reset code
	fn setsanity i val =
	(
		local t = gnx_sanity
		
		-- make sure bit string array is upgraded to new length
		if t.count < 20 then t = t + "1"
		
		t[i] = val
		gnx_sanity = t
        nx_savePreference "init" "sanity" t
	)

	
    /*  No longer used
    on btn_setsanities pressed do
    (
        for s in selection do
        (
            if (iskindof s aurorabase) then
            (
                setsanity 1 s (nx_btoi(runRotationCheck) as string)
                setsanity 2 s (nx_btoi(runAnimCheck) as string)
                setsanity 3 s (nx_btoi(runCollisionMeshCheck) as string)
                setsanity 4 s (nx_btoi(runTileNodeBoundaryCheck) as string)
                setsanity 5 s (nx_btoi(runAuraEmitterCheck) as string)
                setsanity 6 s (nx_btoi(runAuraRefCheck) as string)
                setsanity 7 s (nx_btoi(runNameCheck) as string)
                setsanity 8 s (nx_btoi(runScaleCheck) as string)
                setsanity 9 s (nx_btoi(runPartTextureCheck) as string)
                setsanity 10 s (nx_btoi(runWeldCheck) as string)
                setsanity 11 s (nx_btoi(runClassCheck) as string)
                setsanity 12 s (nx_btoi(runControllerCheck) as string)
                setsanity 13 s (nx_btoi(runAnimMeshCheck) as string)
                setsanity 14 s (nx_btoi(runDoganCheck) as string)
                setsanity 15 s (nx_btoi(runBitmapNameCheck) as string)
                setsanity 16 s (nx_btoi(runFaceCheck) as string)
                setsanity 17 s (nx_btoi(runBSACheck) as string)
                setsanity 18 s (nx_btoi(runAnimrootCheck) as string)
                setsanity 19 s (nx_btoi(runBoneCountCheck) as string)
                setsanity 20 s (nx_btoi(runWOKCheck) as string)
            )
        )
    )
    */
    
	on box_RotationCheck changed newState do (
    	-- 1
		runRotationCheck = newState
	    setsanity 1 (nx_btoi(runRotationCheck) as string)
	)
	on box_AnimCheck changed newState do (
    	-- 2
		runAnimCheck = newState
	    setsanity 2 (nx_btoi(runAnimCheck) as string)
	)
	on box_CollisionMeshCheck changed newState do (
    	-- 3
		runCollisionMeshCheck = newState
	    setsanity 3 (nx_btoi(runCollisionMeshCheck) as string)
	)
	on box_TileNodeBoundaryCheck changed newState do (
    	-- 4
		runTileNodeBoundaryCheck = newState
	    setsanity 4 (nx_btoi(runTileNodeBoundaryCheck) as string)
	)
	on box_AuraEmitterCheck changed newState do (
    	-- 5
		runAuraEmitterCheck = newState
		setsanity 5 (nx_btoi(runAuraEmitterCheck) as string)
	)
	on box_AuraRefCheck changed newState do (
    	-- 6
		runAuraRefCheck = newState
	    setsanity 6 (nx_btoi(runAuraRefCheck) as string)
	)
	on box_NameCheck changed newState do (
    	-- 7
		runNameCheck = newState
	    setsanity 7 (nx_btoi(runNameCheck) as string)
	)
	on box_ScaleCheck changed newState do (
    	-- 8
		runScaleCheck = newState
	    setsanity 8 (nx_btoi(runScaleCheck) as string)
	)
	on box_PartTextureCheck changed newState do (
    	-- 9
		runPartTextureCheck = newState
	    setsanity 9 (nx_btoi(runPartTextureCheck) as string)
	)
	on box_WeldCheck changed newState do (
    	-- 10
		runWeldCheck = newState
	    setsanity 10 (nx_btoi(runWeldCheck) as string)
	)
	on box_ClassCheck changed newState do (
    	-- 11
		runClassCheck = newState
	    setsanity 11 (nx_btoi(runClassCheck) as string)
	)
	on box_ControllerCheck changed newState do (
    	-- 12
		runControllerCheck = newState
	    setsanity 12 (nx_btoi(runControllerCheck) as string)
	)
	on box_AnimMeshCheck changed newState do (
    	-- 13
		runAnimMeshCheck = newState
	    setsanity 13 (nx_btoi(runAnimMeshCheck) as string)
	)
	on box_DoganCheck changed newState do (
    	-- 14
		runDoganCheck = newState
	    setsanity 14 (nx_btoi(runDoganCheck) as string)
	)
	on box_BitmapNameCheck changed newState do (
    	-- 15
		runBitmapNameCheck = newState
	    setsanity 15 (nx_btoi(runBitmapNameCheck) as string)
	)
	on box_FaceCheck changed newState do (
    	-- 16
		runFaceCheck = newState
	    setsanity 16 (nx_btoi(runFaceCheck) as string)
	)
	on box_BSACheck changed newState do (
    	-- 17
		runBSACheck = newState
	    setsanity 17 (nx_btoi(runBSACheck) as string)
	)
	on box_AnimrootCheck changed newState do (
    	-- 18
		runAnimrootCheck = newState
	    setsanity 18 (nx_btoi(runAnimrootCheck) as string)
	)
	on box_BoneCountCheck changed newState do (
    	-- 19
		runBoneCountCheck = newState
	    setsanity 19 (nx_btoi(runBoneCountCheck) as string)
	)
	on box_WOKchecker changed newState do (
    	-- 20
    	runWOKCheck = newState
	    setsanity 20 (nx_btoi(runWOKCheck) as string)
	)


    -- old speed bar code
    on nx_util1 open do
    (
        local temp = #()
        local i
        
        LoadPlugIns()
        
        plugin_scripts = #()
        -- load scripts list into drop down
        for i = 1 to g_plugins.count by 2 do
        (
            append temp g_plugins[i]
            append plugin_scripts g_plugins[i+1]
        )
        dpl_prefabs.items = temp
        
        -- correctly set the floating button state
        try (
            tst_state = cui.getDockState nwmax_handle
            -- is docked
            btn_rollup.checked = false
        ) catch
        (
            -- not docked
            btn_rollup.checked = true
        )       
    )
    
    on nx_util1 moved val do
    (
        -- store the current location of the NWMax Speedbar
        if g_ismax then (
            nx_savePreference "position" "nwmax" (val as string)
        )
    )
    
    -- Deal with rollup/extend feature
    on btn_rollup changed val do
    (
        if val then
        (
            try (
                cui.FloatDialogBar nwmax_handle
                cui.UnRegisterDialogBar nwmax_handle
                --nwmax_handle.size = [192,85]
                max views redraw
            ) catch ()
        ) else
        (
            try (
                nwmax_handle.size = [192,635]
                cui.RegisterDialogBar nwmax_handle \
                    maxSize:[-1,-1] \
                    style:#(#cui_dock_vert, #cui_floatable, #cui_handles)
                cui.DockDialogBar nwmax_handle #cui_dock_left
            ) catch ()
        )
    )
    
    -- select parent
    on btn_sel_parent pressed do
    (
        if selection[1] != undefined then
        (
            if selection[1].parent != undefined then
                select selection[1].parent
        )
    )
    -- select children
    on btn_sel_child pressed do
    (
        if selection[1] != undefined then
        (
            if selection[1].children != undefined then
                select selection[1].children
        )
    )
    
    -- Make a generic helper tool
    tool nwn_dummy_creator
    (
        local objDummy
        
        fn createDummy =
        (
            in coordsys grid objDummy = dummy pos:gridPoint
            objDummy.boxsize = [10,10,10]
        )
        
        on mousePoint clickNo do
        (
            if clickNo == 1 then createDummy()
            select objDummy
            #stop
        )
    )
    on btn_make_dummy_helper changed state do
    (
        if state then
            startTool nwn_dummy_creator
            
        btn_make_dummy_helper.state = false
    )
    
    on btn_environ pressed do
    (
        units.displaytype = #Metric
        units.metrictype = #Centimeters
        units.SystemType = #Centimeters
        units.SystemScale = 1.0
    )
    
    
    on btn_linker pressed do
    (
        -- First make sure only one aurabase is in the selection
        local basecnt = 0
        local base = undefined
        for obj in selection do (
            if (iskindof obj aurorabase) then
            (
                basecnt += 1
                base = obj
                format "basecnt=%\r\n" basecnt
                format "base=%\r\n" base
            )
        )
        if basecnt > 1 then (
            msg = "More than one AuroraBase found in the selection"
            messageBox msg title:"Fast Linker"
            return 0
        )
        if base == undefined then (
            msg = "No AuroraBase found in the selection"
            messageBox msg title:"Fast Linker"
            return 0
        )
        
        -- we only have one aurorabase so start the linking process
        for obj in selection do
        (
            if obj != base then (
                obj.parent = base
            )
        )
    )
    
    on btn_makeintodummy pressed do
    (
        -- take the selected objects and make each into a dummy object
        clearlistener()
        local sel = selection as array
        local p -- position of s
        local r -- rotation of s
        local par -- parent of s
        local n -- name of s
        local newdummy
        
        for s in sel do
        (
            format "Processing: %\r\n" s
            p = s.pos
            r = s.rotation
            n = s.name
            par = s.parent
            newdummy = dummy pos:p
            newdummy.rotation = r
            newdummy.parent = par
            newdummy.boxsize = [10,10,10]
            for c in s.children do
            (
                c.parent = newdummy
            )
            select s
            max delete
            newdummy.name = n
        )
    )
    
    on btn_prefab_do pressed do
    (
        local index = dpl_prefabs.selection
        nx_loadTool (g_startpath+"plugins\\"+plugin_scripts[index])
    )
    -- speed bar code stops
    
       
    on btn_veltools pressed do ( nx_loadTool (scriptsPath+"VelTools\\VT_start.ms") )
    
    on btn_chilliskinner pressed do ( nx_loadTool (g_startpath+"CSv3.0.2/CSv3-0-2.ms") )
    
    on btn_tileslicer pressed do ( nx_loadTool (g_startpath+"TileSlicer/tile-slicer.ms") )
    
    on btn_modelscaler pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nwmax_scalewiz.ms") )
    
    on btn_massops pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_massutils.ms") )
    
    on btn_export_all pressed do
    (
        ExportAll()
    )
    
    on edt_resetdir entered val do
    (
        if not (nx_existDir val) then
            messagebox "Directory does not exist!"
    )
    
    on btn_resetdir pressed do
    (
        local bIsSelection = false
        
        if not (nx_existDir edt_resetdir.text) then
        (
            messagebox "Directory does not exist!"
            return 0
        )
        for b in $helpers do
        (
            if b.isSelected and (iskindof b aurorabase) then
            (
                bIsSelection = true
                -- node is selected so reset base
                b.export_path = edt_resetdir.text
            )
        )
        if not (bIsSelection) then
        (
            messagebox "No Aurora Bases selected."
            return 0
        )
    )
    
    on btn_resetdirbrowse pressed do
    (
        local dirpath
        -- suggested by Danmar
        dirpath = getSavePath()
        if (dirpath!=undefined) then (
            edt_resetdir.text = dirpath
        )
    )
)