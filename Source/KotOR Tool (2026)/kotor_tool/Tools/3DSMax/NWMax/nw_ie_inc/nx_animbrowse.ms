/*-----------------------------------------------------------------------------\

    Animation Browser
    

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

global nx_animbrowse_flag
rollout nx_animbrowse "Animation Browser"
(
	fn is_modelbase obj =
	(
    	(iskindof obj aurorabase)
	)
	
	-- gui
	label lbl_model ""
	pickbutton btn_setbase "Pick Model Base" filter:is_modelbase
	listbox lst_anims "Animations" height:20 width:180 align:#center
	button btn_refresh "Refresh"
	
	fn refresh_list =
	(
    	local temp = #()
    	if btn_setbase.object != undefined then
    	(
        	local mbase = btn_setbase.object
        	join temp mbase.animations
        	lst_anims.items = temp
    	)
	)
	
	-- actions
	on nx_animbrowse open do
	(
    	nx_animbrowse_flag = true
	)
	
	on nx_animbrowse close do
	(
    	nx_animbrowse_flag = false
	)
	
	on btn_setbase picked obj do
	(
    	lbl_model.text = obj.name
    	refresh_list()
	)
	
	on lst_anims doubleClicked val do
	(
    	-- parse out the selected animation
        local str_anim = lst_anims.selected
        if (str_anim != undefined) then
        (
            -- parse the animation string
            tokens = filterString str_anim " "
            local first_frame = (tokens[2] as integer)
            local last_frame = (tokens[3] as integer)
        
            -- zoom to the double clicked animation
            if (first_frame < last_frame) then
            (
                animationRange = (interval first_frame last_frame)
                sliderTime = first_frame
            )
        )
	)
	
	on btn_refresh pressed do
	(
    	refresh_list()
	)
)

if nx_animbrowse_flag != true then
(
    createDialog nx_animbrowse width:200
)