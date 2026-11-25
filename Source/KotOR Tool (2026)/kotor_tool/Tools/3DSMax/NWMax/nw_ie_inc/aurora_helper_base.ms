/*-----------------------------------------------------------------------------\

    AuroraBase Helper Object
 
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
format "load: aurora_helper_base.ms\r\n"
nx_progressPlus()

plugin helper aurorabase
name:"AuroraBase" 
classID:#(0xc52f72fa, 0xc48a3a16) 
version:2
extends:Dummy
replaceUI:true 
invisible:true
(
	-- local vars
    local max_anim_frame
    local master_anim_range
    --#("Character", "BodyPart", "Item", "Tile","GUI", "Effects", "Door","WalkMesh")
    --#("BodyPart", "Item", "GUI")
	local class_types = #("Character","Tile", "Door","Effect","WalkMesh","Other", "BodyPart", "Item", "GUI", "Lightsaber", "Placeable", "Flyer")
	
	-- parameters
	parameters main rollout:params 
	(
    	-- Animation data is stored in the 'animations' array as a
    	-- space delimited string of the form:
    	-- 'name' 'firstFrame' 'lastFrame' 'transition', 'active', 'animroot'
		animations      type:#stringtab tabsizevariable:true
		setsupermodel      type:#string  default:"NULL" ui:edit_supermodel
		classification  type:#string default:"Character"
		classification_sel  type:#integer default:1 ui:droplist_classui 
		setanimationscale  type:#float default:1.0 ui:spn_animscale
		events          type:#stringtab  tabsizevariable:true
		export_path     type:#string default:(getdir #export) ui:edit_exportpath
		export_binary   type:#integer default:0 ui:chk_binary
		sanity_check	type:#integer default:1 ui:chk_check
		sanity_tests	type:#string default:gnx_sanity
		copy_tga		type:#integer default:0 ui:chk_copytga
		tga2dds			type:#integer default:0 ui:chk_convdds
		sanityok        type:#integer default:1
		
		on classification_sel set val do
		(
			-- do a quick sanity check on val
			if (val < 1) or (val > class_types.count) then
			(
				val = 1
				format "Error: classification_sel set call not in bounds\r\n"
			)
			
    		classification = class_types[val]
		)
	)
	
	
	rollout params "MDL Base Parameters" 
	(
		label modelname ""
		edittext edit_supermodel "Super:"
		label classtype "Classification" across:2 
		dropdownlist droplist_classui "" items:class_types height:7 width:75

		-- export data button widgets
		group "Export"
		(
  		editText edit_exportpath "Dir:"
  		button btn_exportbrowse "Browse" align:#left across:2
		button btn_exportreset "Reset" align:#right
  		button  btn_export_mdl	"Export Model+Anim " align:#center width:140 
  		button  btn_export_noanims "Export Geom only" align:#center width:140 toolTip:"Export ONLY the geometry, no animations"
  		checkbox chk_binary "Compile exported model" align:#left checked:false
  		checkbox chk_check "Do Sanity Checks" align:#left
  		checkbox chk_copytga "Copy TGAs" align:#left checked:false
  		checkbox chk_convdds "Convert to DDS" align:#left checked:false enabled:false
  		button btn_viewsanity "View Sanity Check Results" align:#center width:140
  	)
    	
		group "Animation Parameters" (
			--label animlabel "Animation Parameters"
			spinner spn_animscale "Animation scale:" type:#float scale:0.01 range:[0,10,1] fieldwidth:40 align:#left
			listbox list_animations "Animations on Model" height:g_guiAnimListSize
			button  btn_add_anim "Add" align:#left height:14 width:45 across:3
			button  btn_delete_anim "Delete" align:#center height:14 width:45 enabled:false
			button  btn_zoom_to_anim "Zoom" align:#right height:14 width:45 enabled:false
			button  btn_zoom_reset "Reset Zoom" align:#center height:14 width:(3*45) enabled:true
			button  btn_moveup "Move Up" align:#left height:14 width:66 across:2
			button  btn_movedown "Move Down" align:#right height:14 width:66
			button  btn_allanim_y "All Active" align:#left height:14 width:66 across:2 toolTip:"Enable all animations so they export"
			button  btn_allanim_n "None Active" align:#right height:14 width:66 toolTip:"Inactivate all animations, so they don't export"

			dropdownlist  edit_anim_name "Anim name\available anims:" align:#center height:10 width:135
			spinner spn_first_frame "Start Frame:" type:#integer range:[0,1000000,0] fieldwidth:47
			spinner spn_last_frame   "End Frame:"   type:#integer range:[0,1000000,0] fieldwidth:47
			spinner spn_transition "Transition:" range:[0,1000000,0.25] scale:0.01 fieldwidth:55
			checkbox chk_will_export "Export Anim:" checked:true
			edittext edit_animroot "Anim root:"
			button  btn_animeditapply "Apply Edits" align:#center height:14
			--button button_selanimroot "Select Anim Root" align:#center    -- not yet supported
			--label lbl_animlist "Animation Name List"
			--combobox lst_animnames "" height:5
		)
		
    group "Events" (
	    listBox list_events "" height:5
	    editText edit_event_name "Name:"
	    spinner spn_event_frame "Frame:" type:#integer range:[0,100000,0]
	    button btn_event_add "Add" align:#left width:65 height:14 across:2
	    button btn_event_delete "Delete" align:#right width:65 height:14 enabled:false
		button  btn_eventeditapply "Apply Edits" align:#center height:14
	    label lbl_quickevents "Quick Events"
	    button btn_qe_blurstart "blur start" align:#left width:67 height:14 across:2
	    button btn_qe_blurend "blur end" align:#right width:67 height:14
	    button btn_qe_drawarrow "draw arrow" align:#left width:67 height:14 across:2
	    button btn_qe_drawweapon "draw weapon" align:#right width:67 height:14
	    button btn_qe_hit "hit" width:40 height:14 align:#left across:3
	    button btn_qe_parry "parry" align:#center width:40 height:14
	    button btn_qe_cast "cast" align:#right width:40 height:14
	    button btn_qe_sndfootstep "footstep" align:#left width:67 height:14 across:2
	    button btn_qe_sndhitground "hitground" align:#right width:67 height:14
	    button btn_qe_detonate "detonate" align:#center width:67 height:14
    )

		-- read list of animation names from a file
		fn ReadAnimationNameList filename =
		(
			namelist = #()
			fh = openFile filename mode:"r"
			if (fh != undefined) then
			(
				while not eof(fh) do
				(
					animname = readDelimitedString fh " \n"
					if (animname != "") then
					(
						append namelist animname
					)
					else
					(
						exit
					)
				)
				close fh
			)
			return namelist
		)
		
		
		fn refresh_anim_namelist = 
		(
			if (classification != undefined) then
			(
				namelist = readAnimationNameList (scriptsPath + "\\NWmax\\"+ classification + ".nam")
				edit_anim_name.items = namelist
			)
		)

		on open params do
		(
			refresh_anim_namelist()
		)

		on droplist_classui selected val do
		(
    		-- update the anim list
    		refresh_anim_namelist()
		)


		on edit_exportpath entered val do
		(
    		if not (nx_existDir val) then
    		    messagebox "Directory does not exist!"
		)
		
		
		fn export_start doanim:true =
		(
    		local node = selection[1]
    		local bSanityCheck
    		local mdlextn
    		local model_name
    		local strCmd
	        -- Make sure listener is clear
	        clearListener()
    		if (nx_existDir export_path) then
    		(
        		if (export_path[export_path.count] != "\\") then export_path = export_path + "\\"
        		
        		-- set the external control snoop bracket.
        		if not g_ismax then format "<snoopstart file=%%>%" gNX_scratchPath "exportcontrol.txt" g_delim to:g_strBuffer
        		-- Tell GMAX Snoop what fully qualified file name to use and keep a global copy
        		g_exportPath = export_path
        		if chk_binary.checked then
        		    mdlextn = "mdl.ascii"
    		    else
    		        mdlextn = "mdl"
				model_name = node.name
				
				-- we need to make sure that the model_name has no tabs in it
				-- as it will break things. The rule will be tabs will be changed to '_'
				if (matchPattern node.name pattern:"*	") then
				(
	   				messageBox "Model name contains a tab. ERROR!! Processing Halted."
	   				return -1
				)
				
	    		if not g_ismax then format "<snoopstart file=%%.%>%" export_path model_name mdlextn g_delim to:g_strBuffer
	    		-- we can now do some sanity checks and record the results for review
    		
	    		if not g_ismax then (
	    		   format "<snoopstart file=%%_sanitycheck.txt>%" (gNX_sanityPath) model_name g_delim to:g_strBuffer
				) else (
					g_strBuffer = createFile (gNX_sanityPath + model_name + "_sanitycheck.txt")
				) -- end ismax
				
				if chk_check.checked then
		    		bSanityCheck = SanityCheck node
	    		else
	    			bSanityCheck = 1
		    		
	    		if not g_ismax then (
		       		format "</snoopstart>%" g_delim to:g_strBuffer
	    		) else (
		       		flush g_strBuffer
		       		close g_strBuffer
	    		) -- end ismax
    		
				if bSanityCheck == 0 then 
				(
					-- Ask user if want to continue export anyway
	  				str = "SanityCheck failed for "+model_name+". Push YES to continue export."
	  				if (queryBox str  title:"Failed Sanity Check" beep:true) then
	  				    bSanityCheck = 1    -- over-ride and export
	      		)
      		
	      		if bSanityCheck == 1 then
	      		(
	         		if g_ismax then (
	            		g_strBuffer = createFile (export_path + model_name + "." + mdlextn)
	         		) -- end ismax
	         		
	         		ExAuroraMDL node anim:doanim
	         		
	         		if g_ismax then (
	            		flush g_strBuffer
	            		close g_strBuffer
	         		) -- end ismax
	      		)
      		
	      		if not g_ismax then format "</snoopstart>%" g_delim to:g_strBuffer  -- closes model export
	      		
	      		-- if we need to compile model we do it here
	      		if chk_binary.checked and (not g_ismax) then
	      		(
					format "<snoopstart file=%>%" (gNX_scratchPath+"export.bat") g_delim to:g_strBuffer
					format "\"%\" -c \"%%%\" \"%\\\" > \"%\"%" g_compiler export_path model_name ".mdl.ascii" export_path (gNX_scratchPath+"compile.txt") g_delim to:g_strBuffer
					format "</snoopstart>%" g_delim to:g_strBuffer
					
					format "<commandstart>%" g_delim to:g_strBuffer
					format "\"%export.bat\"%" (gNX_scratchPath+"") g_delim to:g_strBuffer
					format "</commandstart>%" g_delim to:g_strBuffer
	      		) else if chk_binary.checked and g_ismax then
	      		(
					format "Compile model.\r\n"
					strCmd = createFile (gNX_scratchPath+"export.bat")
					format "\"%\" -c \"%%%\" \"%\\\" > \"%\"%" g_compiler export_path model_name ".mdl.ascii" export_path (gNX_scratchPath+"compile.txt") g_delim to:strCmd
					flush strCmd
					close strCmd
					DOSCommand ("\"" + gNX_scratchPath + "export.bat\"")
	      		)
	      		
	      		-- copy the tga files to export dir. If converting to dds then put in a tga dir inside export dir
	      		if node.copy_tga == 1 then
	      		(
		      			nx_getTextures node node
      			)
	      		
	      		-- perform the tga to dds conversion
	      		if node.tga2dds == 1 then
	      		(
		      		-- process dds
		      		local cmd = g_startpath+"tga2dds\\processtextures.exe "
		      		cmd += export_path + "\\tga "
		      		cmd += export_path
		      		DOSCommand cmd
	      		)
	      		
	      		
	      		if not g_ismax then
	      		(
	        		format "\r\n%" g_delim to:g_strBuffer
	      			format "</snoopstart>%" g_delim to:g_strBuffer  -- closes exportcontrol.txt
	      			format "</snoopend>%" g_delim to:g_strBuffer
				)
    		) else (
    		    messagebox "Directory does not exist."
		    )
    		    
    	    clearSelection()
    	    select node
    	    nx_FlushBuffer force:true
		)
		
		-- support browse for export dir path
		on btn_exportbrowse pressed do
		(
			local p = getSavePath caption:"Model save path"
			if p != undefined then
			(
				edit_exportpath.text = p
			)
		)
		
		-- reset the export path
    	on btn_exportreset pressed do
		(
			edit_exportpath.text = (getDir #export)
		)
		
		-- Export model and animations
		on btn_export_mdl pressed do
		(
    		export_start()
		)

		-- Export model geomtrey only
		on btn_export_noanims pressed do
		(
    		export_start doanim:false
		)
		
		-- Copy TGA switch
		on chk_copytga changed checked do
		(
			if checked then
			(
				chk_convdds.enabled = true
			) else
			(
				chk_convdds.checked = false
				chk_convdds.enabled = false
			)
		)
		
		-- View the sanity file results
		on btn_viewsanity pressed do
		(
			local model_name = selection[1].name
			local target_file = gNX_sanityPath+model_name+"_sanitycheck.txt"
			-- test to make sure sanity file exists
			if not nx_existFile(target_file) then
			(
				messageBox "No sanity check file found.\nHave you exported the model?"
				return false
			)
      		if (not g_ismax) then
      		(
	      		clearListener()
				format "<snoopstart file=%>\r\n%" (gNX_scratchPath+"sanityviewcontrol.txt") g_delim to:g_strBuffer
				format "<commandstart>%" g_delim to:g_strBuffer
				format "\"notepad %\"%" target_file g_delim to:g_strBuffer
				format "</commandstart>%" g_delim to:g_strBuffer
        		format "\r\n%" g_delim to:g_strBuffer
        		format "\r\n%" g_delim to:g_strBuffer
      			format "</snoopstart>\r\n%" g_delim to:g_strBuffer  -- closes exportcontrol.txt
      			format "</snoopend>%" g_delim to:g_strBuffer
      			nx_FlushBuffer force:true
      		) else
      		(
				format "View sanity file.\r\n"
				shellLaunch "notepad.exe" target_file
      		)
      		
		)
		
  	fn updateanimlist =	
  	(
  		local tmpList = #()
  		for a in animations do (
  			join tmpList #(a)
  		)
  		if (nx_strclassof(selection[1]) == "aurorabase") then
  			selection[1].params.list_animations.items = tmpList
  	)
    
    fn LoadSelectedAnimation=
    (
      local str_anim = params.list_animations.selected
      if (str_anim != undefined) then
      (
          -- parse the animation string
          tokens = filterString str_anim " "
          params.edit_anim_name.selection = (findItem params.edit_anim_name.items tokens[1])
          params.spn_first_frame.value = (tokens[2] as integer)
          params.spn_last_frame.value = (tokens[3] as integer)
          params.spn_transition.value = (tokens[4] as float)
          -- to be backwards compatable we need to check if [5] is null
          if tokens[5] == undefined then
              params.chk_will_export.checked = true
          else
              params.chk_will_export.checked = (nx_itob (tokens[5] as integer))
          -- need to check if there is animroot data
          if tokens.count > 5 then
          (
            -- we have anim root data
            params.edit_animroot.text = tokens[6]
          ) else (
            params.edit_animroot.text = ""
          )
          -- enable the delete button
          params.btn_delete_anim.enabled = true
          -- enable zoom button
          params.btn_zoom_to_anim.enabled = true
      )
      else
      (
          params.edit_anim_name.selection = 1
          params.edit_animroot.text = ""
          params.spn_first_frame.value = 0
          params.spn_last_frame.value = 0
          params.spn_transition.value = 0
          params.chk_will_export.checked = true
          -- unenable the delete button
          params.btn_delete_anim.enabled = false
          -- unenable zoom button
          params.btn_zoom_to_anim.enabled = false
      )
    )
    
    fn ZoomToAnim=
    (
        local firstframe = params.spn_first_frame.value
        local lastframe = params.spn_last_frame.value
        if (firstframe < lastframe) then
        (
            animationRange = (interval firstframe lastframe)
            sliderTime = firstframe
        )
    )

    on btn_zoom_reset pressed do
    (
        animationRange = (interval 0 max_anim_frame)
    )
    
    on list_animations selected list_idx do LoadSelectedAnimation()
    
    on list_animations doubleClicked list_idx do ZoomToAnim()
    
        on btn_add_anim pressed do
        (
            local str_name = (params.edit_anim_name.text as string)
            if str_name != "" then
            (
                local str_firstframe = (params.spn_first_frame.value as string)
                local str_lastframe = (params.spn_last_frame.value as string)
                local str_transition = (params.spn_transition.value as string)
                local str_willexport = ((nx_btoi params.chk_will_export.checked) as string)
                local str_animroot = (params.edit_animroot.text as string)
                animations[animations.count+1] = \
                    (str_name+" "+str_firstframe+" "+ \
                    str_lastframe+" "+str_transition+" "+ \
                    str_willexport+" "+str_animroot)
                updateanimlist()
                list_animations.selection = animations.count
            )
        )
    
        on btn_delete_anim pressed do
        (
            local sel = params.list_animations.selection
            if (sel > 0) then
            (
                -- select nothing
                params.list_animations.selection = 0
                -- delete the item from list
                deleteItem animations sel
                updateanimlist()
                params.btn_delete_anim.enabled = false
            )
        )
    
        on btn_zoom_to_anim pressed do ZoomToAnim()
    
        --
        -- Support direct edits to the frame and transition times
        --
        fn ChangeSelAnimEntry =
        (
            -- get current selection in list box
            local selindex = list_animations.selection
            --if selindex is 0 then nothing selected so don't do anything more
            if selindex == 0 then return 0
            -- rebuild the entry and put it back in
            local str_name = (params.edit_anim_name.text as string)
            local str_firstframe = (params.spn_first_frame.value as string)
            local str_lastframe = (params.spn_last_frame.value as string)
            local str_transition = (params.spn_transition.value as string)
            local str_willexport = ((nx_btoi params.chk_will_export.checked) as string)
            local str_animroot = (params.edit_animroot.text as string)
            animations[selindex] = \
                (str_name+" "+str_firstframe+" "+ \
                str_lastframe+" "+str_transition+" "+ \
                str_willexport+" "+str_animroot)
            updateanimlist()
            list_animations.selection = selindex
        )
        --on spn_first_frame changed new_val do ChangeSelAnimEntry()
        --on spn_last_frame changed new_val do ChangeSelAnimEntry()
        --on spn_transition changed new_val do ChangeSelAnimEntry()
        --on chk_will_export changed new_val do ChangeSelAnimEntry()
        on btn_animeditapply pressed do
        (
	        ChangeSelAnimEntry()
        )
    
        on btn_moveup pressed do
        (
            -- get current selection in list box
            local selindex = list_animations.selection
            local tempStr = ""
            --if selindex is 0 then nothing selected so don't do anything more
            if selindex == 0 or selindex == 1 then return 0
            
            tempstr = animations[selindex]
            animations[selindex] = animations[selindex-1]
            animations[selindex-1] = tempstr
            
            -- after our changes do the update to the list
            updateanimlist()
            
            -- update selection
            list_animations.selection = selindex-1
        )
        
        on btn_movedown pressed do
        (
            -- get current selection in list box
            local selindex = list_animations.selection
            local tempStr = ""
            --if selindex is 0 then nothing selected so don't do anything more
            if selindex == 0 or selindex == animations.count then return 0
            
            tempstr = animations[selindex]
            animations[selindex] = animations[selindex+1]
            animations[selindex+1] = tempstr
            
            -- after our changes do the update to the list
            updateanimlist()
            
            -- update selection
            list_animations.selection = selindex+1
        )
        
        on btn_allanim_y pressed do
        (
            local i, tokens, animroot
            for i =1 to animations.count do
            (
                tokens = filterString animations[i] " "
                if tokens.count > 5 then (
	                animroot = tokens[6]
                ) else (
	                animroot = ""
                )
                animations[i] = tokens[1]+" "+ \
                                tokens[2]+" "+ \
                                tokens[3]+" "+ \
                                tokens[4]+" "+ \
                                "1 "+ \
                                animroot
            )
            updateanimlist()
        )
        
        on btn_allanim_n pressed do
        (
            local i, tokens, animroot
            for i =1 to animations.count do
            (
                tokens = filterString animations[i] " "
                if tokens.count > 5 then (
	                animroot = tokens[6]
                ) else (
	                animroot = ""
                )
                animations[i] = tokens[1]+" "+ \
                                tokens[2]+" "+ \
                                tokens[3]+" "+ \
                                tokens[4]+" "+ \
                                "0 "+ \
                                animroot
            )
            updateanimlist()
        )
        
        --
        -- Animation Event Processing
        --
        fn updateeventlist=
        (
    		local tmpList = #()
    		for e in events do (
    			join tmpList #(e)
    		)
    		if (classof($) == aurorabase) then
    			params.list_events.items = tmpList
        )
        
        fn LoadSelectedAnimEvent=
        (
            local str_event = params.list_events.selected
            if (str_event != undefined) then
            (
                -- parse the event string
                tokens = filterString str_event " "
                params.edit_event_name.text = tokens[1]
                params.spn_event_frame.value = (tokens[2] as integer)
                -- enable the delete button
                params.btn_event_delete.enabled = true
            )
            else
            (
                params.list_events.items = #()
                params.edit_event_name.text = ""
                params.spn_event_frame.value = 0
                params.btn_event_delete.enabled = false
            )
        )
    
        on btn_event_add pressed do
        (
            format "btn_add_event\r\n"
            local str_name = (params.edit_event_name.text as string)
            if str_name != "" then
            (
                local str_frame = (params.spn_event_frame.value as string)
                format "% %\r\n" str_name str_frame
                events[events.count+1] = (str_name+" "+str_frame)
                updateeventlist()
                list_events.selection = events.count
            )
        )
    
        on btn_event_delete pressed do
        (
            local sel = params.list_events.selection
            if (sel > 0) then
            (
                -- select nothing
                params.list_events.selection = 0
                -- delete the item from list
                deleteItem events sel
                updateeventlist()
                params.btn_event_delete.enabled = false
            )
        )
        
        on btn_eventeditapply pressed do
        (
            local str_name = (params.edit_event_name.text as string)
            if str_name != "" then
            (
                local str_frame = (params.spn_event_frame.value as string)
                local sel = params.list_events.selection
                events[sel] = (str_name+" "+str_frame)
                updateeventlist()
                list_events.selection = sel
            )
        )
    
        on list_events selected list_idx do LoadSelectedAnimEvent()
        
      fn add_event strEvent =
      (
         local str_frame = (sliderTime.frame as integer)  as string
         events[events.count+1] = (strEvent+" "+str_frame)
         updateeventlist()
         list_events.selection = events.count
      )

      on btn_qe_blurstart pressed do ( add_event "blur_start" )
      on btn_qe_blurend pressed do ( add_event "blur_end" )
      on btn_qe_drawarrow pressed do ( add_event "draw_arrow" )
      on btn_qe_drawweapon pressed do ( add_event "draw_weapon" )
      on btn_qe_hit pressed do ( add_event "hit" )
      on btn_qe_parry pressed do ( add_event "parry" )
      on btn_qe_cast pressed do ( add_event "cast" )
      on btn_qe_sndfootstep pressed do ( add_event "snd_footstep" )
      on btn_qe_sndhitground pressed do ( add_event "snd_hitground" )
      on btn_qe_detonate pressed do ( add_event "detonate" )
      
		--
        -- Aurora base rollout has been opened
        --
		on params open do  
		(
			--if (classification == undefined) then
			--	classification = classui.selected
			
			current =0;
			list_animations.selection=0;
			list_events.selection=0
			updateanimlist()
			updateeventlist()
			edit_supermodel.text = setsupermodel

			-- This is required in order to activate the 'classui selected' callback.
			-- See comments at the top for 'classification'
			--droplist_classui.selection = findItem droplist_classui.items classification

			if ($ != undefined) then
				modelname.text = "Model:  " + $.name
			else
				modelname.text = "Model: "	
			
			/*
			spn_animscale.enabled = false
			if (classification == "Character") then
				spn_animscale.enabled = true
			*/

		    if max_anim_frame == undefined then max_anim_frame = 0
		    if max_anim_frame < (animationrange.end) then max_anim_frame = animationrange.end
		    
		    if edit_anim_name.items.count < 1 then (
			    refresh_anim_namelist()
		    )
		    
		    -- make sure sanity bit string is correct length
		    --if sanity_tests.count < 20 then sanity_tests = sanity_tests + "1"
		    
    		--runRotationCheck = nx_itob(sanity_tests[1] as integer)
			--runAnimCheck = nx_itob(sanity_tests[2] as integer)
			--runCollisionMeshCheck = nx_itob(sanity_tests[3] as integer)
			--runTileNodeBoundaryCheck = nx_itob(sanity_tests[4] as integer)
			--runAuraEmitterCheck = nx_itob(sanity_tests[5] as integer)
			--runAuraRefCheck = nx_itob(sanity_tests[6] as integer)
			--runNameCheck = nx_itob(sanity_tests[7] as integer)
			--runScaleCheck = nx_itob(sanity_tests[8] as integer)
			--runPartTextureCheck = nx_itob(sanity_tests[9] as integer)
			--runWeldCheck = nx_itob(sanity_tests[10] as integer)
			--runClassCheck = nx_itob(sanity_tests[11] as integer)
			--runControllerCheck = nx_itob(sanity_tests[12] as integer)
			--runAnimMeshCheck = nx_itob(sanity_tests[13] as integer)
			--runDoganCheck = nx_itob(sanity_tests[14] as integer)
			--runBitmapNameCheck = nx_itob(sanity_tests[15] as integer)
			--runFaceCheck = nx_itob(sanity_tests[16] as integer)
			--runBSACheck = nx_itob(sanity_tests[17] as integer)
			--runAnimrootCheck = nx_itob(sanity_tests[18] as integer)
			--runBoneCountCheck = nx_itob(sanity_tests[19] as integer)
			--runWOKCheck = nx_itob(sanity_tests[20] as integer)
		)
	) ---- rollout params "MDL Base Parameters" 
	
	
		
	--
	-- Sanity Checks gui
	--
	/*
	No longer used
	rollout ActiveChecks "Active Sanity Checks" rolledUp:true
	(
		group "AuraBase Checks" (
			checkbox box_RotationCheck "Zero Rotation" checked:runRotationCheck
			checkbox box_AnimCheck "Valid Anim Keys" checked:runAnimCheck
		)
		group "Tile Checks" (
			checkbox box_CollisionMeshCheck "Collision/WOK Mesh Validity" checked:runCollisionMeshCheck
			checkbox box_TileNodeBoundaryCheck "Tile Node Boundary Chk" checked:runTileNodeBoundaryCheck
		)

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

		fn setsanity i val =
		(
			local t = sanity_tests
			
			-- make sure string bit array is correct min size
			if (t.count <20) then t = t + "1"
			
			t[i] = val
			sanity_tests = t
		)
		
		on box_RotationCheck changed newState do (
			runRotationCheck = newState
			setsanity 1 (nx_btoi(newState) as string)
		)
		on box_AnimCheck changed newState do (
			runAnimCheck = newState
			setsanity 2 (nx_btoi(newState) as string)
		)
		on box_CollisionMeshCheck changed newState do (
			runCollisionMeshCheck = newState
			setsanity 3 (nx_btoi(newState) as string)
		)
		on box_TileNodeBoundaryCheck changed newState do (
			runTileNodeBoundaryCheck = newState
			setsanity 4 (nx_btoi(newState) as string)
		)
		on box_AuraEmitterCheck changed newState do (
			runAuraEmitterCheck = newState
			setsanity 5 (nx_btoi(newState) as string)
		)
		on box_AuraRefCheck changed newState do (
			runAuraRefCheck = newState
			setsanity 6 (nx_btoi(newState) as string)
		)
		on box_NameCheck changed newState do (
			runNameCheck = newState
			setsanity 7 (nx_btoi(newState) as string)
		)
		on box_ScaleCheck changed newState do (
			runScaleCheck = newState
			setsanity 8 (nx_btoi(newState) as string)
		)
		on box_PartTextureCheck changed newState do (
			runPartTextureCheck = newState
			setsanity 9 (nx_btoi(newState) as string)
		)
		on box_WeldCheck changed newState do (
			runWeldCheck = newState
			setsanity 10 (nx_btoi(newState) as string)
		)
		on box_ClassCheck changed newState do (
			runClassCheck = newState
			setsanity 11 (nx_btoi(newState) as string)
		)
		on box_ControllerCheck changed newState do (
			runControllerCheck = newState
			setsanity 12 (nx_btoi(newState) as string)
		)
		on box_AnimMeshCheck changed newState do (
			runAnimMeshCheck = newState
			setsanity 13 (nx_btoi(newState) as string)
		)
		on box_DoganCheck changed newState do (
			runDoganCheck = newState
			setsanity 14 (nx_btoi(newState) as string)
		)
		on box_BitmapNameCheck changed newState do (
			runBitmapNameCheck = newState
			setsanity 15 (nx_btoi(newState) as string)
		)
		on box_FaceCheck changed newState do (
			runFaceCheck = newState
			setsanity 16 (nx_btoi(newState) as string)
		)
		on box_BSACheck changed newState do (
			runBSACheck = newState
			setsanity 17 (nx_btoi(newState) as string)
		)
		on box_AnimrootCheck changed newState do (
			runAnimrootCheck = newState
			setsanity 18 (nx_btoi(newState) as string)
		)
		on box_BoneCountCheck changed newState do (
			runBoneCountCheck = newState
			setsanity 19 (nx_btoi(newState) as string)
		)
		on box_WOKchecker changed newState do (
			runWOKCheck = newState
			setsanity 20 (nx_btoi(newState) as string)
		)

	) ---- rollout ActiveChecks
	*/

)

-- ModelBase Wizard - beta, by Joco
rollout basewiz "Model Base Wizard"
(
	local class_types = #("Character","Tile", "Door","Effect","WalkMesh","Other", "BodyPart", "Item", "GUI", "Lightsaber", "Placeable", "Flyer")
	local modelbase
	
	dropDownList ddl_type "Model Type" width:133 height:40 align:#center items:class_types selection:1
	checkbox chk_animkeys "Add standard anim keys" width:138 height:26 align:#left
	checkbox chk_helpers "Add standard helpers" width:138 height:21 align:#left
	checkbox chk_center "Center to [0,0,0]" align:#left
	edittext ed_name "Name:"
	button btn_ok "OK" width:91 height:23 align:#center
	
	fn addAnims animarray node = (
    	local maxkey = 0
    	local parsedkey
    	-- set base time 0 key
    	with animate on
    	(
           	at time 0 node.scale = [1,1,1] -- 1:1
            at time 0 node.rotation = (quat 0 [0,0,0]) -- zero rot
            at time 0 node.position = [0,0,0]
        )
        for i = 1 to animarray.count do
        (
            parsedkey = filterString animarray[i] " "
        	with animate on
        	(
            	-- start
               	at time (parsedkey[2] as integer) node.scale = [1,1,1] -- 1:1
                at time (parsedkey[2] as integer) node.rotation = (quat 0 [0,0,0]) -- zero rot
                at time (parsedkey[2] as integer) node.position = [0,0,0]
                -- end
               	at time (parsedkey[3] as integer) node.scale = [1,1,1] -- 1:1
                at time (parsedkey[3] as integer) node.rotation = (quat 0 [0,0,0]) -- zero rot
                at time (parsedkey[3] as integer) node.position = [0,0,0]
            )
            if (parsedkey[3] as integer) > maxkey then maxkey = (parsedkey[3] as integer)
        )
        return maxkey
	)
	
	on basewiz open do
	(
    	modelbase = selection[1]
	)
	
	on btn_ok pressed do
	(
   	-- Set the models name
   	modelbase.name = ed_name.text
    	--#("Character","Tile", "Door","Effect","WalkMesh","Other")
    	modelbase.classification_sel = ddl_type.selection
    	local key_list = #()
    	local maxframe = 0
    	case modelbase.classification_sel of
    	(
        	1:( -- Character
            	if chk_animkeys.checked then
            	(
                	/*
                	(creature animations ## = beetle frames per segment)
                    60 -creadyr (default ready to attack)
                    60 -creadyl (alternate ready to attack)
                    10 -cdamagel
                    10 -cdamager
                    10 -cdamages
                    90 -cpause1
                    45 -ca1slashl (defualt claw attack, slash left)
                    40 -cwalk
                    30 -cclosel (the big slam with the leg)
                    45 -ca1slashr (defualt claw attack, slash right)
                    45 -ca1stab (defualt bite attack)
                    30 -ccloseh (the head butt)
                    30 -creach (attack when target moves away)
                    30 -cparryr (parry right)
                    30 -cparryl (parry left)
                    30 -cdodgelr (big dodge)
                    30 -cdodges (small dodge)
                    30 -ckdbck
                    10 -ckdbckps
                    20 -ckdbckdmg
                    30 -ckdbckdie (dying)
                    1 -cdead (static death)
                    30 -cguptokdb (preparing to get up off back)
                    30 -cgustandb (Getting up off back)
                    15 -ccwalkf (combat motion)
                    15 -ccwalkb (backwards)
                    15 -ccwalkl (left)
                    15 -ccwalkr (right)
                    15 -cgetmid
                    30 -chturnl (head turn left)
                    30 -chturnr (head turn right)
                    30 -ctaunt (taunt)
                    43 -cconjure1 (casting motion)
                    30 -ccastoutlp (longer casting outwards motion)
                    60 -cappear Seem to be the same as pause
                    60 -cdisappear Seem to be the same as pause
                    15 -ccastout (casting outwards motion)
                    1 -cgetmidlp
                    20 -cspasm
                    30 -crun
                    15 -ccturnr
                    60 -cdisappearlp same as pause
                    */
                	key_list = #("creadyr 50 110 0.25",
                	            "creadyl 120 180 0.25",
                	            "cdamagel 190 200 0.25",
                	            "cdamager 210 220 0.25",
                	            "cdamages 230 240 0.25",
                	            "cpause1 250 340 0.25",
                	            "ca1slashl 350 395 0.25",
                	            "cwalk 410 450 0.25",
                	            "cclose1 460 490 0.25",
                	            "ca1slashr 500 545 0.25",
                	            "ca1stab 555 600 0.25",
                	            "ccloseh 610 640 0.25",
                	            "creach 650 680 0.25",
                	            "cparryr 690 720 0.25",
                	            "cparryl 730 760 0.25",
                	            "cdodgelr 770 800 0.25",
                	            "cdodges 810 840 0.25",
                	            "ckdbck 850 880 0.25",
                	            "ckdbckps 890 900 0.25",
                	            "ckdbckdmg 910 930 0.25",
                	            "ckdbckdie 940 970 0.25",
                	            "cdead 980 980 0.25",
                	            "cguptokdb 990 1020 0.25",
                	            "cgustandb 1030 1060 0.25",
                	            "ccwalkf 1070 1085 0.25",
                	            "ccwalkb 1095 1110 0.25",
                	            "ccwalkl 1120 1135 0.25",
                	            "ccwalkr 1145 1160 0.25",
                	            "cgetmid 1170 1175 0.25",
                	            "chturnl 1185 1215 0.25",
                	            "chturnr 1225 1255 0.25",
                	            "ctaunt 1265 1295 0.25",
                	            "cconjure1 1305 1348 0.25",
                	            "ccastoutlp 1358 1388 0.25",
                	            "cappear 1400 1460 0.25",
                	            "cdisappear 1470 1530 0.25",
                	            "ccastout 1540 1565 0.25",
                	            "cgetmidlp 1575 1575 0.25",
                	            "cspasm 1585 1605 0.25",
                	            "crun 1615 1645 0.25",
                	            "ccturnr 1655 1670 0.25",
                	            "cdisappearlp 1680 1740 0.25")

    	            maxframe = (addAnims key_list modelbase)
                    -- set animation data to model base gui
                    modelbase.animations = key_list
                    animationRange = (interval 0 (maxframe + 50))
                )
                
                if chk_helpers.checked then
                (
                    -- place stock helper objects for effect
                    max modify mode
					try (
						local d
						-- rootdummy
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "rootdummy"
						d.pos = [0,0,120]
						-- Impact
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "Impact"
						d.pos = [0,0,145]
						-- handconjure
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "handconjure"
						d.pos = [0,40,150]
						-- headconjure
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "headconjure"
						d.pos = [0,-14,240]
						-- lforearm
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "lforearm"
						d.pos = [-27,-3,106]
						-- lhand
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "lhand"
						d.pos = [-28,0,87]
						-- head
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "head"
						d.pos = [0,-3,200]
						-- rhand
						d = dummy()
						d.boxsize = [10,10,10]
						d.name = "rhand"
						d.pos = [28,0,87]
					) catch (format "Error creating helpers\r\n")
                )
         	)
        	2:( -- Tile
            	if chk_animkeys.checked then
            	(
                	/* add Tile anim key lists as needed
                	-animloop01  	(moving parts and emitters, like smoke)
                    -Day 	        (The rest of the animations mostly deal 	 
                    -Night 	         with changing the colors of the light 	 
                    -Night2Day 	     sources)
                    -Day2Night
                    -tiledefault
                	*/
                	key_list = #("animloop01 50 100 0.25",
                	            "Day 110 160 0.25",
                	            "Night 170 220 0.25",
                	            "Night2Day 230 280 0.25",
                	            "Day2Night 290 340 0.25",
                	            "tiledefault 350 400 0.25")
    	            
    	            maxframe = (addAnims key_list modelbase)
						-- set animation data to model base gui
						modelbase.animations = key_list
						animationRange = (interval 0 (maxframe + 50))
					)
                
					if chk_helpers.checked then
					(
						-- place stock helper/light objects for a tile
						local mlight1
						local mlight2
						max modify mode
						try (
							mlight1 = auroralight()
							mlight2 = auroralight()
                     mlight1.pos = [0,0,1000]
                     mlight1.radius = 5.0
                     mlight1.affectDynamic = 1
                     mlight2.pos = [0,0,400]
                     mlight2.radius = 5.0
                     mlight2.affectDynamic = 1
                     mlight1.name = "ml1"
                     mlight2.name = "ml2"
						) catch (format "error in creating lights\r\n")
					)
        	)
        	3:()
        	4:(
            	if chk_animkeys.checked then
            	(
                	/* add Visual Effect animations
                	-impact
                    -duration
                    -cessation
                	*/
                	key_list = #("impact 50 100 0.25",
                	            "duration 110 160 0.25",
                	            "cessation 170 220 0.25")
    	            
    	            maxframe = (addAnims key_list modelbase)
                    -- set animation data to model base gui
                    modelbase.animations = key_list
                    animationRange = (interval 0 (maxframe + 50))
                )
                
                if chk_helpers.checked then
                (
                    -- place stock helper objects for effect
                )
        	)
        	5:()
        	6:(
            	if chk_animkeys.checked then
            	(
                  	/* Placeable animations
                	-close  	ANIMATION_PLACEABLE_CLOSE (1 frame closed)  	 
                    -close2open 	(from closed to open)
                    -open 	ANIMATION_PLACEABLE_OPEN (1 frame open) 	 
                    -open2close 	(from open to closed)
                    -damage 	(3 frame position change) 	 
                    -die 	(move model below ground plane) 	 
                    -dead 	(1 frame below ground plane) 	 
                    -default 	(normal position)
                     
                    Probably can't have both open/close and on/off animations
                    in the same model. I haven't tried it though.
                     
                    -on 	ANIMATION_PLACEABLE_ACTIVATE (looping animation) 	 
                    -off 	ANIMATION_PLACEABLE_DEACTIVATE (1 frame in off position) 	 
                    -off2on 	(from off to on position) 	 
                    -on2off 	(from on to off position) 	 
     
                	*/
                 	key_list = #("close 50 51 0.25",
                	            "close2open 60 70 0.25",
                	            "open 80 81 0.25",
                	            "open2close 90 140 0.25",
                	            "damage 150 152 0.25",
                	            "die 160 210 0.25",
                	            "dead 220 221 0.25",
                	            "default 230 280 0.25")
    	            
    	            maxframe = (addAnims key_list modelbase)
                    -- set animation data to model base gui
                    modelbase.animations = key_list
                    animationRange = (interval 0 (maxframe + 50))
                )
                
                if chk_helpers.checked then
                (
	                max modify mode
                    -- place stock helper objects for placeable
						try (
							local d
							-- xxx_ground
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_ground"
							d.pos = [0,0,0]
							-- xxx_hand
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_hand"
							d.pos = [0,-70,90]
							-- xxx_head
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_head"
							d.pos = [0,0,219]
							-- xxx_head_hit
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_head_hit"
							d.pos = [0,0,170]
							-- xxx_impact
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_impact"
							d.pos = [0,0,86]
							-- xxx_pwk_use01
							d = dummy()
							d.boxsize = [10,10,10]
							d.name = "xxx_pwk_use01"
							d.pos = [0,-92,0]
						) catch (format "Error creating helpers\r\n")
                )
        	)
    	)
    	
    	if chk_center.checked then
    	(
	    	max modify mode
	    	try (
		    	modelbase.pos = [0,0,0]
	    	) catch (format "Error creating helpers\r\n")
    	)
    	
    	destroyDialog basewiz
	)
)


plugin helper aurorabasebox
name:"AuroraBase"
(
	local modelbase
	tool create
	(
		on mousePoint click do
		(
    		if click == 1 then
    		(
	    		in coordsys grid
	    		(
	    			-- we only ever do this once
	    			modelbase = aurorabase pos:[0,0,0]
	    			modelbase.pos = gridPoint
				)
    			modelbase.delegate.boxSize = [100,100,5]
    			select modelbase
    			-- make the pointer to the front
    			if g_basepointer == 1 then
    			(
                	local tri = ngon()
                	tri.radius = 25
                	tri.nsides = 3
                	tri.rotation *= (quat 90 [0,0,1])
                	tri.pos =   gridPoint + [0,50,0]
                	tri.wireColor = (color 92 179 240)
                	tri.name = "ignore_"+tri.name
                	tri.parent = modelbase
            	)
            	-- enter modify mode to exit mouse tool
            	-- and get ready for name updates
            	max modify mode
            	-- model template wizard to start
            	createDialog basewiz modal:true
            	-- flick back to max create mode as that is where we started
            	--max create mode
        	)
        	return #stop
		)
	)
)