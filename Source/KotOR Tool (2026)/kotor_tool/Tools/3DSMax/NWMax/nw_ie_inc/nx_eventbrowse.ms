/*-----------------------------------------------------------------------------\

    Event Browser & Editor
    

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

global nx_eventbrowse_flag
rollout nx_eventbrowse "Event Browser"
(
	fn is_modelbase obj =
	(
    	(iskindof obj aurorabase)
	)
	
	-- gui
	label lbl_model ""
	pickbutton btn_setbase "Pick Model Base" filter:is_modelbase
	listbox lst_events "Events" height:20 width:180 align:#center
	button btn_setevent "Set event frame" tooltip:"Sets current event to current frame"
	button btn_delete "Delete Event"
	
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

	button btn_refresh "Refresh"
	
	fn refresh_list =
	(
    	local temp = #()
    	if btn_setbase.object != undefined then
    	(
        	local mbase = btn_setbase.object
        	join temp mbase.events
        	lst_events.items = temp
    	)
	)
	
	-- actions
	on nx_eventbrowse open do
	(
    	nx_eventbrowse_flag = true
	)
	
	on nx_eventbrowse close do
	(
    	nx_eventbrowse_flag = false
	)
	
	on btn_setbase picked obj do
	(
    	lbl_model.text = obj.name
    	refresh_list()
	)
	
	on lst_events doubleClicked val do
	(
    	-- parse out the selected animation
        local str_event = lst_events.selected
        if (str_event != undefined) then
        (
            -- parse the event string
            tokens = filterString str_event " "
            local first_frame = (tokens[2] as integer) - 15            
            local last_frame = (tokens[2] as integer) + 15
            if first_frame < 0 then first_frame = 0
        
            -- zoom to the double clicked animation
            if (first_frame < last_frame) then
            (
                animationRange = (interval first_frame last_frame)
                sliderTime = (tokens[2] as integer)
            )
        )
	)
	
	on btn_refresh pressed do
	(
    	refresh_list()
	)
	
	on btn_setevent pressed do
	(
        if btn_setbase.object != undefined then
        (
            local mdlbase = btn_setbase.object
        	local str_event = lst_events.selected
        	local tokens = filterstring str_event " "
        	local eventname = tokens[1]
        	local eventframe = (sliderTime.frame as integer) as string
        	str_event = eventname + " " + eventframe
        	mdlbase.events[lst_events.selection] = str_event
        	refresh_list()
    	)
	)
	
	on btn_delete pressed do
	(
        if (btn_setbase.object != undefined) and (lst_events.selection > 0) then
        (
            local mdlbase = btn_setbase.object
            deleteitem mdlbase.events (lst_events.selection)
            refresh_list()
        )
	)
	
	-- quick event code
    fn add_event strEvent =
    (
        local str_frame = (sliderTime.frame as integer) as string
        if btn_setbase.object != undefined then
        (
            local mdlbase = btn_setbase.object
            mdlbase.events[mdlbase.events.count+1] = (strEvent+" "+str_frame)
            refresh_list()
            lst_events.selection = mdlbase.events.count
        )
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
	
)

if nx_eventbrowse_flag != true then
(
    createDialog nx_eventbrowse width:200
)