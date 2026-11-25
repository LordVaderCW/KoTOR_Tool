/*-----------------------------------------------------------------------------\

    Mass Animation Key Tweaker

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

rollout nx_masskeytweak "Mass Anim Key Tweaker" width:250
(
	group "Position Keys"
	(
		label lbl_1 "x / y / z"
		spinner spn_px range:[-10000,10000,0] width:50 across:3
		spinner spn_py range:[-10000,10000,0] width:50
		spinner spn_pz range:[-10000,10000,0] width:50
	)
	
	group "Rotation Keys"
	(
		label lbl_2 "x / y / z"
		spinner spn_rx range:[-360,360,0] width:50 across:3
		spinner spn_ry range:[-360,360,0] width:50
		spinner spn_rz range:[-360,360,0] width:50
	)

	spinner spn_startframe "Start Frame:" type:#integer range:[0,100000,0] across:2
	spinner spn_endframe "End Frame:" type:#integer range:[0,100000,0]
	button btn_process "Process" align:#center
	
	on nx_masskeytweak open do
	(
		spn_startframe.value = (animationRange.start).frame as integer
		spn_endframe.value = (animationRange.end).frame as integer
	)
	
	on btn_process pressed do
	(
		clearlistener()
		-- store the current selection for processing
		local sel = #()
		join sel selection
		-- get the key frame range to process
		local startkey = spn_startframe.value
		local endkey = spn_endframe.value
		local cntrl = #(undefined, undefined, undefined)
		
		for obj in sel do
		(
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
			
			-- adjust the standard controllers
			for c in cntrl do
			(
				if c != undefined then
				(
					for k in c.keys do
					(
						if (k.time >= startkey) and (k.time <= endkey) then
						(
							format "obj: % :controler type: % : keytime: %\r\n" (obj.name) (classof c) (k.time)
							-- adjust the controllers by type
							if (iskindof c linear_position) then
							(
								k.value += [spn_px.value, spn_py.value, spn_pz.value]
							)
							
							if (iskindof c linear_rotation) then
							(
								euler_rot = k.value as eulerAngles
								euler_rot.x += spn_rx.value
								euler_rot.y += spn_ry.value
								euler_rot.z += spn_rz.value
								k.value = euler_rot as quat
							)
						)
					)
				)
			)
		)
	)
)

createDialog nx_masskeytweak