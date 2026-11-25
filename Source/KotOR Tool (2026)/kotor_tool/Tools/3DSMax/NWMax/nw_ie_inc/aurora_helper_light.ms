/*-----------------------------------------------------------------------------\

	MDL Reference Helper Object
	
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
format "load: aurora_helper_light.ms\r\n"
nx_progressPlus()

plugin light auroralight
name:"AuroraLight" 
classID:#(0x91e8a664, 0x39b92e97) 
version:2
extends:omniLight
replaceUI:true
invisible:true
(
	parameters main rollout:params 
	(
		rgb 			type:#color default:(color 255 255 255) ui:colorpicker_color
		radius			type:#float ui:spn_radius
		multiplier		type:#float 	animatable:true default:1.0 ui:spn_multiplier
		lightpriority	type:#integer	animatable:false default:5 ui:spn_lightpriority
		nDynamicType	type:#integer	animatable:false ui:box_isdynamic
			
		ambientOnly 	type:#integer	animatable:false ui:box_ambientOnly
		affectDynamic	type:#integer	animatable:false ui:box_affectDynamic
		Shadow			type:#integer	animatable:false ui:box_Shadow
		lensflares		type:#integer	animatable:false default:0
		fadingLight 	type:#integer	animatable:false ui:box_fadingLight
		negativeLight	type:#integer	animatable:false ui:box_negative
	)
	-- from bioware. Modified by Joco
	parameters flares rollout:lensflareUI
	(
		flareRadius 	type:#float default:5000 ui:spn_flareRadius
		-- lens_flares is a list of flares with in which the string encodes the
		-- flare information. This makes it realatively easy to see the total number
		-- of flares and to delete those you don't want
		-- The flare data is held in the order:
		-- texture, flare size, position, colour shift
		lens_flares 	type:#stringtab tabsizevariable:true
	)

	rollout params "MDL Light Parameters" width:160 height:337
	(
	
		spinner spn_radius "Radius (cm):" pos:[43,10] width:106 height:16 range:[0,10000000000,500]
		spinner spn_multiplier "Multiplier:" pos:[53,30] width:96 height:16 fieldwidth:40
		spinner spn_lightpriority "Priority:" pos:[63,51] width:86 height:16 range:[1,5,5] type:#integer scale:1 fieldwidth:40
		
		GroupBox grp3 "Intensity\Colour" pos:[4,92] width:154 height:105
		colorPicker colorpicker_color "" pos:[7,113] width:44 height:50 across:2
		spinner spn_red "Red:" pos:[74,106] width:75 height:16 range:[0,255,255] fieldwidth:40
		spinner spn_green "Green:" pos:[65,126] width:84 height:16 range:[0,255,255] fieldwidth:40
		spinner spn_blue "Blue:" pos:[73,147] width:76 height:16 range:[0,255,255] fieldwidth:40
	
		checkbox box_ambientOnly "Ambient (off=Diffuse)" pos:[13,238] width:126 height:15
		checkbox box_affectDynamic "Affects Dynamic Objects" pos:[13,288] width:140 height:15
		checkbox box_shadow "Shadows" pos:[13,309] width:63 height:15
		checkbox box_fadingLight "Fading Light" pos:[73,71] width:80 height:15
		checkbox box_negative "Negative Light" pos:[13,175] width:97 height:15
		label lbl1 "Surface Type:" pos:[13,222] width:108 height:14
		checkbox box_isdynamic "Is Dynamic Light" pos:[13,268] width:106 height:15
		on colorpicker_color changed col do
		(
			spn_red.value = col.r
			spn_green.value = col.g
			spn_blue.value = col.b
			--delegate.color = col
		)
		on spn_red changed val do
		(
			colorpicker_color.color.r = val
		)
		on spn_green changed val do
		(
			colorpicker_color.color.g = val
		)
		on spn_blue changed val do
		(
			colorpicker_color.color.b = val
		)
		
		on params open do
		(
			spn_red.value = rgb.r
			spn_green.value = rgb.g
			spn_blue.value = rgb.b
			--colorpicker_color.color = rgb
		)
	)
	
	-- Originally from Bioware. Modified by Joco
	rollout lensflareUI "Lens Flares" rolledUp:true (
	-- This rollout is kinda gross. I needed some way of storing individual parameters for each separate flare, the
	-- total number of which could be increased/decreased on the fly.  As such, tying variables to UI objects
	-- wasn't feasible, and required all sorts of update checks.

	
		--spinner spn_lensflares "Number of flares:" type:#integer range:[0,25,0] fieldWidth:30
		spinner spn_flareRadius "Flare Radius:" type:#integer range:[0,10000,5000] enabled:true align:#center
		group "Flare Parameters" (
			listbox lst_flares "Flares" height:5
			button btn_add "Add" height:14 width:45 align:#left across:3
			button btn_delete "Delete" height:14 width:45 align:#center
			button btn_update "Update" height:14 width:45 align:#right
			
			edittext et_texname "Texture" text:"" enabled:true
			button bt_gettexfile "Get Texture" enabled:true
			spinner spn_size "Size" type:#float range:[0.0,10.0,0.0] enabled:true
			spinner spn_pos "Position" type:#float range:[-10.0,10.0,0.0] enabled:true
			label posDescription "Camera Position" enabled:true
			label colourshift "Colour Shift:" enabled:true
			spinner spn_r "R" type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
			spinner spn_g "G" type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
			spinner spn_b "B"  type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
		)
		
		fn updateflarelist =	
		(
			local tmpList = #()
			for f in lens_flares do (
				join tmpList #(f)
			)
			if (nx_strclassof(selection[1]) == "auroralight") then
				selection[1].lensflareUI.lst_flares.items = tmpList
		)

		on lensflareUI open do (
			updateflarelist()
			lst_flares.selection = 0
		)
		
		on lst_flares selected selindex do
		(
			local tokens = filterString (lens_flares[selindex]) " "
			et_texname.text = tokens[1]
			spn_size.value = tokens[2] as float
			spn_pos.value = tokens[3] as float
			spn_r.value = tokens[4] as float
			spn_g.value = tokens[5] as float
			spn_b.value = tokens[6] as float
			
			-- update the posDesc text
			local posVal = spn_pos.value
			if ( (posVal > -0.05) and (posVal < 0.05)) then
				posDescription.text = "Camera Position"
			else if ( (posVal > 0.95) and (posVal < 1.05) ) then
				posDescription.text = "Light Position"
			else posDescription.text = " "
		)
		
		on btn_add pressed do
		(
			local addStr = et_texname.text+" "+ \
						(spn_size.value as string)+" "+ \
						(spn_pos.value as string)+" "+ \
						(spn_r.value as string)+" "+ \
						(spn_g.value as string)+" "+ \
						(spn_b.value as string)
			append lens_flares addStr
			updateflarelist()
		)
		
		on btn_delete pressed do
		(
			local selIndex = lst_flares.selection
			if selIndex != 0 then (
				deleteItem lens_flares selIndex
			)
			updateflarelist()
		)
		
		on btn_update pressed do
		(
			local selIndex = lst_flares.selection
			if selIndex != 0 then (
				local addStr = et_texname.text+" "+ \
							(spn_size.value as string)+" "+ \
							(spn_pos.value as string)+" "+ \
							(spn_r.value as string)+" "+ \
							(spn_g.value as string)+" "+ \
							(spn_b.value as string)
				lens_flares[selIndex] = addStr
			)
			updateflarelist()
		)
		
		on bt_gettexfile pressed do (
			local filename = getOpenFileName caption:"Lens Flare Texture"
            if filename != undefined do et_texname.text = getFilenameFile filename
		)
		on spn_pos changed arg do (
			-- By pushing the little arrows on the spinner enough times, 0.0 no longer equals 0.0 even though
			-- 0.0 is displayed. 0.0 eventually turns into 0.00000001 or something equally intelligent.
			-- This necessitates the following tests for 0.0 and 1.0.....

			if ( (arg > -0.05) and (arg < 0.05)) then
				posDescription.text = "Camera Position"
			else if ( (arg > 0.95) and (arg < 1.05) ) then
				posDescription.text = "Light Position"
			else posDescription.text = " "
		)

	) -- End "Lens Flares" rollout
)







/*
	New light based on dummy
*/
plugin helper auroraDlight
name:"AuroraDLight" 
classID:#(0x678e80c2, 0xb6c98009) 
version:1
extends:dummy
replaceUI:true
(
	parameters main rollout:params 
	(
		rgb 			type:#color default:(color 255 255 255) ui:colorpicker_color
		radius			type:#float ui:spn_radius
		multiplier		type:#float 	animatable:true default:1.0 ui:spn_multiplier
		lightpriority	type:#integer	animatable:false default:5 ui:spn_lightpriority
		nDynamicType	type:#integer	animatable:false ui:box_isdynamic
			
		ambientOnly 	type:#integer	animatable:false ui:box_ambientOnly
		affectDynamic	type:#integer	animatable:false ui:box_affectDynamic
		Shadow			type:#integer	animatable:false ui:box_Shadow
		lensflares		type:#integer	animatable:false default:0
		fadingLight 	type:#integer	animatable:false ui:box_fadingLight
		negativeLight	type:#integer	animatable:false ui:box_negative
		
		Preset_Sel		type:#integer	animatable:false ui:rdo_mainlights default:1
	)
	-- from bioware. Modified by Joco
	parameters flares rollout:lensflareUI
	(
		flareRadius 	type:#float default:5000 ui:spn_flareRadius
		-- lens_flares is a list of flares with in which the string encodes the
		-- flare information. This makes it realatively easy to see the total number
		-- of flares and to delete those you don't want
		-- The flare data is held in the order:
		-- texture, flare size, position, colour shift
		lens_flares 	type:#stringtab tabsizevariable:true
	)

	rollout params "MDL Light Parameters" width:160 height:337
	(
	
		spinner spn_radius "Radius (cm):" pos:[43,10] width:106 height:16 range:[0,10000000000,500]
		spinner spn_multiplier "Multiplier:" pos:[53,30] width:96 height:16 fieldwidth:40
		spinner spn_lightpriority "Priority:" pos:[63,51] width:86 height:16 range:[1,5,5] type:#integer scale:1 fieldwidth:40
		
		GroupBox grp3 "Intensity\Colour" pos:[4,92] width:154 height:105
		colorPicker colorpicker_color "" pos:[7,113] width:44 height:50 across:2
		spinner spn_red "Red:" pos:[74,106] width:75 height:16 range:[0,255,255] fieldwidth:40
		spinner spn_green "Green:" pos:[65,126] width:84 height:16 range:[0,255,255] fieldwidth:40
		spinner spn_blue "Blue:" pos:[73,147] width:76 height:16 range:[0,255,255] fieldwidth:40
	
		checkbox box_ambientOnly "Ambient (off=Diffuse)" pos:[13,238] width:126 height:15
		checkbox box_affectDynamic "Affects Dynamic Objects" pos:[13,288] width:140 height:15
		checkbox box_shadow "Shadows" pos:[13,309] width:63 height:15
		checkbox box_fadingLight "Fading Light" pos:[73,71] width:80 height:15
		checkbox box_negative "Negative Light" pos:[13,175] width:97 height:15
		label lbl1 "Surface Type:" pos:[13,222] width:108 height:14
		checkbox box_isdynamic "Is Dynamic Light" pos:[13,268] width:106 height:15
		label lbl_1 ""
		label lbl_2 ""
		label lbl_3 ""
		group "Tilelight Presets"
		(
			radiobuttons rdo_mainlights "" labels:#("No preset","Mainlight 1","Mainlight 2")
		)
		
		fn Mainlight_Preset suffix radius =
		(
			local parentname 
			if $.parent != undefined then parentname = $.parent.name
			else parentname = "INVALID_"
			$.name = (parentname + suffix)
			$.radius = radius
			$.multiplier = 1.0
			$.fadingLight = 1
			$.rgb = color 0 0 0
			$.negativeLight = 0
			$.ambientOnly = 0
			$.nDynamicType = 0
			$.affectDynamic = 1
			$.shadow = 0
			$.flareRadius = 0
		)
		
		on rdo_mainlights changed arg do
		(
			if arg == 2 then Mainlight_Preset "ml1" 1400
			else if arg == 3 then Mainlight_Preset "ml2" 500
		)
		
		on colorpicker_color changed col do
		(
			spn_red.value = col.r
			spn_green.value = col.g
			spn_blue.value = col.b
			--delegate.color = col
		)
		on spn_red changed val do
		(
			colorpicker_color.color.r = val
		)
		on spn_green changed val do
		(
			colorpicker_color.color.g = val
		)
		on spn_blue changed val do
		(
			colorpicker_color.color.b = val
		)
		
		on params open do
		(
			spn_red.value = rgb.r
			spn_green.value = rgb.g
			spn_blue.value = rgb.b
			--colorpicker_color.color = rgb
		)
	)
	
	-- Originally from Bioware. Modified by Joco
	rollout lensflareUI "Lens Flares" rolledUp:true (
	-- This rollout is kinda gross. I needed some way of storing individual parameters for each separate flare, the
	-- total number of which could be increased/decreased on the fly.  As such, tying variables to UI objects
	-- wasn't feasible, and required all sorts of update checks.

	
		--spinner spn_lensflares "Number of flares:" type:#integer range:[0,25,0] fieldWidth:30
		spinner spn_flareRadius "Flare Radius:" type:#integer range:[0,10000,5000] enabled:true align:#center
		group "Flare Parameters" (
			listbox lst_flares "Flares" height:5
			button btn_add "Add" height:14 width:45 align:#left across:3
			button btn_delete "Delete" height:14 width:45 align:#center
			button btn_update "Update" height:14 width:45 align:#right
			
			edittext et_texname "Texture" enabled:true
			button bt_gettexfile "Get Texture" enabled:true
			spinner spn_size "Size" type:#float range:[0.0,10.0,0.0] enabled:true
			spinner spn_pos "Position" type:#float range:[-10.0,10.0,0.0] enabled:true
			label posDescription "Camera Position" enabled:true
			label colourshift "Colour Shift:" enabled:true
			spinner spn_r "R" type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
			spinner spn_g "G" type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
			spinner spn_b "B"  type:#float range:[-1.0,1.0,0.0] enabled:true align:#center
		)
		
		fn updateflarelist =	
		(
			local tmpList = #()
			for f in lens_flares do (
				join tmpList #(f)
			)
			if (nx_strclassof(selection[1]) == "auroraDlight") then
				selection[1].lensflareUI.lst_flares.items = tmpList
		)

		on lensflareUI open do (
			updateflarelist()
			lst_flares.selection = 0
		)
		
		on lst_flares selected selindex do
		(
			local tokens = filterString (trimleft(lens_flares[selindex])) " "
			
			if tokens.count == 6 then
			(
				et_texname.text = tokens[1] as string
				spn_size.value = tokens[2] as float
				spn_pos.value = tokens[3] as float
				spn_r.value = tokens[4] as float
				spn_g.value = tokens[5] as float
				spn_b.value = tokens[6] as float
				
				-- update the posDesc text
				local posVal = spn_pos.value
				if ( (posVal > -0.05) and (posVal < 0.05)) then
					posDescription.text = "Camera Position"
				else if ( (posVal > 0.95) and (posVal < 1.05) ) then
					posDescription.text = "Light Position"
				else posDescription.text = " "
			)
		)
		
		on btn_add pressed do
		(
			if (trimleft(et_texname.text)).count > 0 then
			(
				local addStr = et_texname.text+" "+ \
							(spn_size.value as string)+" "+ \
							(spn_pos.value as string)+" "+ \
							(spn_r.value as string)+" "+ \
							(spn_g.value as string)+" "+ \
							(spn_b.value as string)
				append lens_flares addStr
				updateflarelist()
			)
		)
		
		on btn_delete pressed do
		(
			local selIndex = lst_flares.selection
			if selIndex != 0 then (
				deleteItem lens_flares selIndex
			)
			updateflarelist()
		)
		
		on btn_update pressed do
		(
			local selIndex = lst_flares.selection
			
			if (trimleft(et_texname.text)).count > 0 then
			(
				if selIndex != 0 then (
					local addStr = et_texname.text+" "+ \
								(spn_size.value as string)+" "+ \
								(spn_pos.value as string)+" "+ \
								(spn_r.value as string)+" "+ \
								(spn_g.value as string)+" "+ \
								(spn_b.value as string)
					lens_flares[selIndex] = addStr
				)
				updateflarelist()
			)
		)
		
		on bt_gettexfile pressed do (
			local filename = getOpenFileName caption:"Lens Flare Texture"
            if filename != undefined do et_texname.text = getFilenameFile filename
		)
		on spn_pos changed arg do (
			-- By pushing the little arrows on the spinner enough times, 0.0 no longer equals 0.0 even though
			-- 0.0 is displayed. 0.0 eventually turns into 0.00000001 or something equally intelligent.
			-- This necessitates the following tests for 0.0 and 1.0.....

			if ( (arg > -0.05) and (arg < 0.05)) then
				posDescription.text = "Camera Position"
			else if ( (arg > 0.95) and (arg < 1.05) ) then
				posDescription.text = "Light Position"
			else posDescription.text = " "
		)

	) -- End "Lens Flares" rollout
)