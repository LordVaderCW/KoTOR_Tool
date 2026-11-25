/*-----------------------------------------------------------------------------\

    Anim Key Master

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




fn nx_movekeyblock obj framestart movesize frametarget =
(
	/*
	work through the objects in the scene and move the keys
	*/
	local cntrl
	local propnames
	local mctrl
	local frameend = framestart + movesize - 1

	--format "\r\n------------------------------------------------\r\n"
	--format "Frame Start: %\r\n" framestart
	--format "Frame End: %\r\n" frameend
	--format "Frame Target: %\r\n" frametarget
	
	cntrl = #(undefined, undefined, undefined)
	-- get the standard controllers
	try (
		cntrl[1] = obj.pos.controller
	) catch (
		cntrl[1] = undefined
	)
	try (
		cntrl[2] = obj.rotation.controller
	) catch (
		cntrl[2] = undefined
	)
	
	try (
		cntrl[3] = obj.scale.controller
	) catch (
		cntrl[3] = undefined
	)
	
	-- move the standard controllers
	for c in cntrl do
	(
		if c != undefined then
		(
			for k in c.keys do
			(
				if (k.time >= framestart) and (k.time <= frameend) then
				(
					--format "key frame: %\r\n" k.time
					--format "move ot: %\r\n" (frametarget + ( k.time - framestart))
					k.time = frametarget + ( k.time - framestart)
				)
			)
			sortKeys c
		)
	)
	
	-- now deal with modifiers on obj with animated properties
	for m in obj.modifiers do
	(
		propnames = getPropNames m
		for prop in propnames do
		(
			mctrl = getPropertyController m prop
			-- if there is a controller then deal with its keys
			if mctrl != undefined then
			(
				for k in mctrl.keys do
				(
					if (k.time >= framestart) and (k.time <= frameend) then
					(
						--format "key frame: %\r\n" k.time
						--format "move ot: %\r\n" (frametarget + (k.time - framestart))
						k.time = frametarget + (k.time - framestart)
					)
				)
				sortKeys mctrl
			)
		)
	)
	
	-- work through children
	for child in obj.children do
	(
		nx_movekeyblock child framestart movesize frametarget
	)
)

fn nx_insertkeyspace obj framestart insertsize =
(
	/*
	work through the objects in the scene and move the keys defined at and
	beyond the specified location out the number of frame
	*/
	
	local cntrl
	local propnames
	local mctrl
	
	cntrl = #(undefined, undefined, undefined)
	-- get the standard controllers
	try (
		cntrl[1] = obj.pos.controller
	) catch (
		cntrl[1] = undefined
	)
	try (
		cntrl[2] = obj.rotation.controller
	) catch (
		cntrl[2] = undefined
	)
	
	try (
		cntrl[3] = obj.scale.controller
	) catch (
		cntrl[3] = undefined
	)
	
	-- move the standard controllers
	for c in cntrl do
	(
		if c != undefined then
		(
			for k in c.keys do
			(
				--print k.time
				--print framestart
				if k.time >= framestart then
				(
					k.time += insertsize
				)
			)
			sortKeys c
		)
	)
	
	-- now deal with modifiers on obj with animated properties
	for m in obj.modifiers do
	(
		propnames = getPropNames m
		for prop in propnames do
		(
			mctrl = getPropertyController m prop
			-- if there is a controller then deal with its keys
			if mctrl != undefined then
			(
				for k in mctrl.keys do
				(
					--print k.time
					--print framestart
					if k.time >= framestart then
					(
						k.time += insertsize
					)
				)
				sortKeys mctrl
			)
		)
	)
	
	-- work through children
	for child in obj.children do
	(
		nx_insertkeyspace child framestart insertsize
	)
)


fn nx_recalcanimbaseinsert modelbase framestart insertsize =
(
	-- make sure is a modelbase
	if not (iskindof modelbase aurorabase) then
	(
		format "nx_recalcanimbase::No modelbase selecetd\r\n"
		return false
	)
	
	local animlist = #()
	local eventlist = #()
	local newanimlist = #()
	local neweventlist = #()
	local tokens
	local tmpstr

	
	-- get the list of anim data from the modelbase
	join animlist modelbase.animations
	join eventlist modelbase.events
	
	-- work through the anims and recalc frame start/ends as needed
	for anim in animlist do
	(
		tokens = filterString anim " "
        anim_name = tokens[1]
        first_frame = (tokens[2] as integer)
        last_frame = (tokens[3] as integer)
        transition = tokens[4]
        -- to be backwards compatable we need to check if [5] is null
        if tokens[5] == undefined then
            will_export = 1
        else
            will_export = (tokens[5] as integer)
        -- need to check if there is animroot data
        if tokens.count > 5 then
        (
            -- we have anim root data
            animroot = tokens[6]
        ) else (
            animroot = ""
        )
        
        -- we have reauired data, lets work with it
        if first_frame >= framestart then (
	        first_frame += insertsize
        )
        if last_frame >= framestart then (
	        last_frame += insertsize
        )
        
        -- reconstruct the anim list
        tmpstr = \
            (anim_name+" "+(first_frame as string)+" "+ \
            (last_frame as string)+" "+transition+" "+ \
            (will_export as string)+" "+animroot)
        append newanimlist tmpstr
	)
	
	-- work through the event list and re calc frame as required
	for event in eventlist do
	(
	    -- parse the event string
	    tokens = filterString event " "
	    event_name = tokens[1]
	    event_frame = (tokens[2] as integer)
	    
	    -- we have the require data, lets work with it
	    if event_frame >= framestart then (
		    event_frame += insertsize
	    )
	    
	    -- reconstruct event list
	    tmpstr = event_name + " " + (event_frame as string)
	    append neweventlist tmpstr
	)
	
	-- update modelbase data
	modelbase.animations = newanimlist
	modelbase.events = neweventlist
	
)


--------------------------------------------------------------------------------
-- Recalc modelbase anim and event data based on moving whole animation
-- blocks only.  DO NOT USE FOR BLOCKS THAT DO NOT EQUAL A WHOLE ANIMATION
fn nx_recalcanimbasemove modelbase framestart movesize frametarget =
(
	-- make sure is a modelbase
	if not (iskindof modelbase aurorabase) then
	(
		format "nx_recalcanimbasemove::No modelbase selecetd\r\n"
		return false
	)
	
	local animlist = #()
	local eventlist = #()
	local newanimlist = #()
	local neweventlist = #()
	local tokens
	local tmpstr

	
	-- get the list of anim data from the modelbase
	join animlist modelbase.animations
	join eventlist modelbase.events
	
	-- work through the anims and recalc frame start/ends as needed
	for anim in animlist do
	(
		tokens = filterString anim " "
        anim_name = tokens[1]
        first_frame = (tokens[2] as integer)
        last_frame = (tokens[3] as integer)
        transition = tokens[4]
        -- to be backwards compatable we need to check if [5] is null
        if tokens[5] == undefined then
            will_export = 1
        else
            will_export = (tokens[5] as integer)
        -- need to check if there is animroot data
        if tokens.count > 5 then
        (
            -- we have anim root data
            animroot = tokens[6]
        ) else (
            animroot = ""
        )
        
        -- we have reauired data, lets work with it
        if (first_frame == framestart) and (last_frame == (framestart + movesize - 1)) then (
	        first_frame = frametarget
	        last_frame = frametarget + movesize - 1
        )
        
        -- reconstruct the anim list
        tmpstr = \
            (anim_name+" "+(first_frame as string)+" "+ \
            (last_frame as string)+" "+transition+" "+ \
            (will_export as string)+" "+animroot)
        append newanimlist tmpstr
	)
	
	-- work through the event list and re calc frame as required
	for event in eventlist do
	(
	    -- parse the event string
	    tokens = filterString event " "
	    event_name = tokens[1]
	    event_frame = (tokens[2] as integer)
	    
	    -- we have the require data, lets work with it
	    if (event_frame >= framestart) and (event_frame <= (framestart + movesize)) then (
		    event_frame = frametarget + (event_frame - framestart)
	    )
	    
	    -- reconstruct event list
	    tmpstr = event_name + " " + (event_frame as string)
	    append neweventlist tmpstr
	)
	
	-- update modelbase data
	modelbase.animations = newanimlist
	modelbase.events = neweventlist
	
)



fn nx_reorder_modelbase_anims obj workfloor =
(
	-- make sure we have a modelbase
	if not (iskindof obj aurorabase) then
	(
		format "nx_reorder_modelbase_anims::no modelbase selected\r\n"
		return false
	)
	
	/*
	Process to do:
	1. move key blocks to the workfloor point in correct order
	2. make sure all keys from 0 to workfloor-1 are deleted
	3. delete frames from 0 to workfloor-10
	*/
	
	local first_frame, last_frame, tokens
	local movepoint = workfloor
	local numtotal = obj.animations.count
	local num = 0
	-- start looping through the animlist
	for anim in obj.animations do
	(
		num += 1
		tokens = filterString anim " "
        first_frame = (tokens[2] as integer)
        last_frame = (tokens[3] as integer)
        
        --format "first frame: %\r\n" first_frame
        --format "last frame: %\r\n" last_frame
        --format "movepoint: %\r\n" movepoint
		
        -- 1. we move the block with -1 and +1 frame each side to deal with the 
        -- normal bracketing keys found there.
        nx_movekeyblock obj (first_frame-1) ((last_frame - first_frame)+3) movepoint
        -- 2. recalc the data on the model base based on the move.
		nx_recalcanimbasemove obj first_frame ((last_frame - first_frame)+1) (movepoint+1)
		
		movepoint += (last_frame - first_frame) + 3 + 10
	)
	
	-- everything is moved now so lets tidy up
	-- 1. cleanout unwanted keys
	nx_deletekeysinblock obj 0 (workfloor-1) #(true,true,true,true)
	-- 2. delete out the blank frames
	nx_insertkeyspace obj 0 -(workfloor - 9)
	nx_recalcanimbaseinsert obj 0 -(workfloor - 9)
)


rollout nx_animkeymaster "Key Master"
(
	local modelbase
	fn isaurorbase obj = ( iskindof obj aurorabase )
	
	label lbl_modelbasetxt "Selected Modelbase:"
	label lbl_base "undefined"
	pickbutton pck_selbase "Select aurorabase" filter:isaurorbase
	
	group "Rename Anim Root"
	(
		edittext edt_oldroot "Old:"
		edittext edt_newroot "New:"
		button btn_animrootrename "Rename"
	)
	
	group "Insert/Delete Frames"
	(
		spinner spn_insertpoint "Insert Point:" type:#integer range:[0,100000,0]
		spinner spn_sinsertsize "Insert Size:" type:#integer  range:[-10000,10000,0]
		button btn_insert "Insert" enabled:false
	)
	
	group "Move Block of Frames"
	(
		spinner spn_movestartframe "Start Frame:" type:#integer range:[0,100000,0]
		spinner spn_moveendframe "End Frame:" type:#integer range:[0,100000,0]
		spinner spn_movetarget "Target Frame:" type:#integer range:[0,100000,0]
		checkbox chk_recalcbase "Adjust Anim Names"
		button btn_move "Move" enabled:false
	)
	
	group "Delete Keys"
	(
		spinner spn_delstart "Start Frame:" type:#integer range:[0,100000,0]
		spinner spn_delend "End Frame:" type:#integer range:[0,100000,0]
		label lbl_delwhat "Key types to delete"
		checkbox chk_pos "Pos" across:2
		checkbox chk_rot "Rot"
		checkbox chk_scale "Scale" across:2
		checkbox chk_mod "Modifier"
		button btn_delkeys "Delete" enabled:false
	)
	
	group "Reorganise Anim Keys"
	(
		label lbl_msg1 "Reorder anim keys on timeline to the same order as listed on the model base. WARNING: This is a CPU intensive operation!" height:70 width:130 align:#left
		spinner spn_workspace "Scratch space:" type:#integer range:[0,100000,10000]
		button btn_reorder "Reorder Anims" enabled:false
	)
	
	on nx_animkeymaster open do
	(
		modelbase = undefined
		nx_animkeymaster_flag = true
	)
	
	on nx_animkeymaster close do
	(
		nx_animkeymaster_flag = false
	)
	
	-- activation functions
	on pck_selbase picked obj do
	(
		lbl_base.text = obj.name
		modelbase = obj
		btn_insert.enabled = true
		btn_move.enabled = true
		btn_delkeys.enabled = true
		btn_reorder.enabled = true
	)
	
	on btn_animrootrename pressed do
	(
		if modelbase == undefined then
		(
			format "btn_animrootrename pressed::model base undefined\r\n"
			return false
		)
		
		if isDeleted modelbase then
		(
			format "btn_animrootrename pressed::object is deleted from scene\r\n"
			return false
		)
		
		local animlist = #()
		local newanimlist = #()
		local tokens
		local tmpstr
	
		
		-- get the list of anim data from the modelbase
		join animlist modelbase.animations
		
		-- work through the anims and recalc frame start/ends as needed
		for anim in animlist do
		(
			tokens = filterString anim " "
	        anim_name = tokens[1]
	        first_frame = (tokens[2] as integer)
	        last_frame = (tokens[3] as integer)
	        transition = tokens[4]
	        -- to be backwards compatable we need to check if [5] is null
	        if tokens[5] == undefined then
	            will_export = 1
	        else
	            will_export = (tokens[5] as integer)
	        -- need to check if there is animroot data
	        if tokens.count > 5 then
	        (
	            -- we have anim root data
	            animroot = tokens[6]
	        ) else (
	            animroot = ""
	        )
	        
	        -- do the replace if search string matches
	        if edt_oldroot.text == animroot then (
		        animroot = edt_newroot.text
	        )
	        
	        -- reconstruct the anim list
	        tmpstr = \
	            (anim_name+" "+(first_frame as string)+" "+ \
	            (last_frame as string)+" "+transition+" "+ \
	            (will_export as string)+" "+animroot)
	        append newanimlist tmpstr
		)
		
		
		-- update modelbase data
		modelbase.animations = newanimlist
		select modelbase
		max create mode
		max modify mode
	)
	
	on btn_insert pressed do
	(
		nx_insertkeyspace modelbase spn_insertpoint.value spn_sinsertsize.value
		nx_recalcanimbaseinsert modelbase spn_insertpoint.value spn_sinsertsize.value
		-- update ui
		select modelbase
		max create mode
		max modify mode
	)
	
	on btn_move pressed do
	(
		nx_movekeyblock modelbase \
						spn_movestartframe.value \
						( 1 + spn_moveendframe.value - spn_movestartframe.value) \
						spn_movetarget.value
						
		if chk_recalcbase.checked then (
			nx_recalcanimbasemove modelbase \
						(spn_movestartframe.value + 1) \
						( spn_moveendframe.value - spn_movestartframe.value - 1) \
						(spn_movetarget.value + 1)
		)
		-- update ui
		select modelbase
		max create mode
		max modify mode
	)
	
	on btn_delkeys pressed do
	(
		--print spn_delstart.value
		--print spn_delend.value
		nx_deletekeysinblock modelbase \
							spn_delstart.value \
							spn_delend.value \
							#(chk_pos.checked, chk_rot.checked, chk_scale.checked, chk_mod.checked)
	)
	
	on btn_reorder pressed do
	(
		disableSceneRedraw() 
		nx_reorder_modelbase_anims modelbase spn_workspace.value
		enableSceneRedraw()
		-- update ui
		select modelbase
		max create mode
		max modify mode
	)
	
	-- spinner sanity checking functions
	on spn_sinsertsize changed val do
	(
		if val < 0 then (
			btn_insert.caption = "Delete"
		) else (
			btn_insert.caption = "Insert"
		)
	)
	
)

if not nx_animkeymaster_flag then (
	createdialog nx_animkeymaster style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox)
)