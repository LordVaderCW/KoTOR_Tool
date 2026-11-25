--------------------------------------------------------------------------------
--                                                                            --
-- NWN mdl Import/Export utility for GMax, v0.3b                              --
-- by Wayland (wreid@spectrumanalytic.com)                                    --
--                                                                            --
-- (c) Wayland Reid                                                           --
-- Based on Zaddix's original WOK file importer maxscript                     --
-- Based on code by (c) Copyright Zaddix, 2002                                --
--                                                                            --
-- Use this code in any way you see fit.                                      --
-- If you use any/all of the code in your own scripts,                        --
-- just credit me and Zaddix somewhere.                                       --
--                                                                            --
--------------------------------------------------------------------------------



----------------------------------------------------------------------------
----------------------------------------------------------------------------
---
--- ImportFile routines
---
----------------------------------------------------------------------------
----------------------------------------------------------------------------
filein (g_startpath+"nw_ie_inc/aurora_fn_import.ms")

-- import function for rollout and supporting utils
fn nx_importer =
(
	local bDoAnims = true
	local bDoGeom = true
	local targetAnimBase = undefined
    local mdlFileName = ImportRollout.import_filename_edit.text
    local animname	= undefined -- for loading single anims
    local insertpoint = 10

    case ImportRollout.rdo_options.state of
    (
	    1: ( bDoGeom=true; bDoAnims=true; )
	    2: ( bDoGeom=true; bDoAnims=false; )
	    3: (
				bDoGeom=false; bDoAnims=true;
				if ImportRollout.edt_animname.text.count > 0 then
				(
					animname = #()
	    	        append animname (ImportRollout.edt_animname.text)
    	        )
    	        if animname == undefined then
    	        (
        	        insertpoint = 10
    	        ) else (
        	        insertpoint = ImportRollout.spn_startframe.value
    	        )
    	        
	            -- check to make sure we have only a model base selected
	            if selection.count != 1 then
            (
                messageBox "Select one model base for animation import." title:"NWmax"
                return false
            )
            if (nx_strclassof selection[1]) != "aurorabase" then
	            (
    	            MessageBox "No target model base selected for Animation Import" title:"No Selelction Found"
    	            return 0
	            ) else
	            (
    	            targetAnimBase = selection[1]
	            )
	       )
    )
    
    if (not nx_existFile mdlFileName) then
    (
        MessageBox ("Model not imported.  " + mdlFileName + " does not exist.") title:"File does not exist"
    )
    else
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
        local existingNodes = objects as array
        nx_refreshMapPaths()
        try
        (
        with redraw off
        (
        local importResult = ImportNWNmdl \
            mdlFileName \
            bDoAnims \
            ImportRollout.warn_checkbox.checked \
            loadGeom:bDoGeom \
            animLoadBase:targetAnimBase \
            loadanimlist:animname \
            insertpoint:insertpoint \
            showprogress:true \
            location:[ImportRollout.spn_loc_x.value, ImportRollout.spn_loc_y.value, 0]
            
        if importResult == false do throw "The model importer reported failure."

        -- import pwk file if available
        local pwk_file = (getFilenamePath mdlFileName)+(getFilenameFile  mdlFileName)+".pwk"
        if ( nx_existFile pwk_file ) then ImportNWNwk pwk_file "pwk"
        -- import dwk file if available
        local dwk_file = (getFilenamePath mdlFileName)+(getFilenameFile  mdlFileName)+".dwk"
        if ( nx_existFile dwk_file ) then ImportNWNwk dwk_file "dwk"
        ) -- with redraw off
        local importedNodes = for obj in objects where (findItem existingNodes obj) == 0 collect obj

        if ImportRollout.chk_resetctrl.checked and bDoGeom and importedNodes.count > 0 then
        (
					local objSum = importedNodes.count * 2.0
					local cnt = 0.0
					progressStart "Reset Controllers"
					format "Setting to tcb rotation\r\n"
					for o in importedNodes do
					(
			    		o.rotation.controller = tcb_rotation()
			    		o.pos.controller = tcb_position()
			    		o.scale.controller = tcb_scale()
			    		cnt += 1
			    		if (progressUpdate (((cnt*100)/objSum) as integer)) == false then throw "Controller reset cancelled. The import may be partial."
					)
					format "Setting back to linear rotation\r\n"
					for o in importedNodes do
					(
			    		o.rotation.controller = linear_rotation()
			    		o.pos.controller = linear_position()
			    		o.scale.controller = linear_scale()
			    		cnt += 1
			    		if (progressUpdate (((cnt*100)/objSum) as integer)) == false then throw "Controller reset cancelled. The import may be partial."
					)
					progressEnd()
        )
        
        ) catch
        (
            local detail = getCurrentException()
            progressEnd()
            ImportRollout.progress.value = 0
            percent = 0
            nx_reportError ("Import failed: " + mdlFileName) detail
            return false
        )
        -- Redraw viewports
        clearSelection()
        max tool zoomextents all
        max views redraw
        
        ImportRollout.progress.value = 0
        percent = 0

        --format "Finished.\n\r\n"
        gc()
        true
    )
)

rollout ImportRollout "MDL Import" width:162 height:250
(
	Group "Filename" 
	(
		edittext import_filename_edit "" width:128 height:16
		button import_browse_button "Browse" width:70 height:24 tooltip:"KotOR: choose an ASCII MDL decompiled with MDLOps or MDLEdit."
	)
	Group "Options"
	(
		radioButtons rdo_options "" width:123 height:48 labels:#("Import Geom+Anims", "Import Geom Only", "Import Anims Only") default:1
		label lbl_animname "Anim name to load:" enabled:false
		edittext edt_animname enabled:false
		spinner spn_startframe "Insert Frame:" type:#integer range:[0,100000,0] enabled:false
		checkbox chk_resetctrl "Reset New Controllers" checked:false toolTip:"Only resets newly imported objects. Can replace animation controllers."
		checkbox warn_checkbox "Show warnings" width:128 height:16
		spinner spn_loc_x "Import Loc X:" range:[0,1000000,0]
		spinner spn_loc_y "Import Loc Y:" range:[0,1000000,0]
	)
	button import_button "Import" width:144 height:24
	
	group "Specialist Tools"
	(
		button btn_removepointer "Del Base Pointer" width:144 height:18
		button btn_loadgrp "Load Tile Group" width:144 height:18
		button btn_masstileload "Mass Tile Load" width:144 height:18
	)

	progressBar progress "" width:136 height:14 
	
 	on btn_loadgrp pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_loadgrp.ms") )
 	
 	on btn_masstileload pressed do ( nx_loadTool (g_startpath+"nw_ie_inc/nx_masstileload.ms") )
 	
	on rdo_options changed val do
	(
		if val == 3 then (
			edt_animname.enabled = true
			lbl_animname.enabled = true
			spn_startframe.enabled = true
		) else (
			edt_animname.enabled = false
			lbl_animname.enabled = false
			spn_startframe.enabled = false
		)
	)
	
	on btn_removepointer pressed do
	(
		for obj in $objects do
		(
			if (matchPattern obj.name pattern:"ignore_NGon*") then (
				select obj
				max delete
			)
		)
	)
	
	on import_browse_button pressed do
	(
	    local filename = getOpenFileName caption:"Import mdl" types:"MDL Models (*.mdl)|*.mdl|ASCII Models (*.ascii)|*.ascii|All Files (*.*)|*.*|"
	    if filename != undefined do import_filename_edit.text = filename
	)
	on import_button pressed do
	(
		nx_importer()
	)
)