/*-----------------------------------------------------------------------------\

    Aurora Trimesh Modifer
    
    This modifier stores the information needed by the Aurora engine for Trimeshes.
    
    BioWare noted in their original script that it would be better to create a NULL modifier
    in the SDK and them extend that.  Under GMAX we don't have that option unless you
    own the game developers SDK.  And I DON'T!   :-)
 
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
format "load: aurora_mod_trimesh.ms\r\n"
nx_progressPlus()

plugin SimpleMod auroratrimesh 
name:"AuroraTrimesh" 
classID:#(0x453cd5bb, 0x8ced9abf)   
version:1
(
	parameters paramblock rollout:auroraTrimeshParams
	(
		/*
		    All the attributes that we want to save AND export
		    for a trimesh need to be stored in this plug in.
		    These attributes are:
		    - trimesh
		    - scale
		    - colour inheritence
		    - rotation
		    - render options
		    - tile fade
		    - alpha channel options
		*/

		tilefadeprop	type:#integer   ui:radio_cap    default:1       -- defaults to "Not a cap"
		scale		    type:#float     ui:spn_scale    default:1.0
		render		    type:#integer   ui:box_render   default:1      -- defaults to render
		shadow		    type:#integer   ui:box_shadow   default:0      -- defaults to cast shadow
		beaming	        type:#integer   ui:box_beaming  default:0     -- defaults to off
		inheritcolor	type:#integer   ui:box_inheritcolor default:0   -- defaults to off
		rotatetexture	type:#integer   ui:box_rotatetexture animatable:false   default:0 -- defaults to off
		alpha           type:#float     animatable:true ui:spn_alpha default:1.0   -- defaults to no opacity
		transparencyhint type:#integer  animatable:true ui:spn_transparencyhint   default:0
		-- special data for materials
		selfillumcolor	type:#color     animatable:true ui:colorpicker_selfillum    default:[0,0,0] -- defaults to Black
		extra_mat_data	type:#integer	ui:chk_xtra_mat_data    default:0
		ambient			type:#color		ui:colorpicker_ambient default:[255,255,255]
		diffuse			type:#color		ui:colorpicker_diffuse default:[255,255,255]
		specular		type:#color		ui:colorpicker_specular default:[0,0,0]
		shininess		type:#integer	ui:spn_shininess default:1


	)

	rollout auroraTrimeshParams "MDL Trimesh Parameters" width:162 height:319
	(
		button btn_tex "test" width:120 height:15 tooltip:"Applied Texture, press to select all objects that use this texture."
		button btn_parent "" width:120 height:15 tooltip:"Parent. Press to select."
		checkbox box_render "Render"   height:15 align:#left across:2 -- pos:[13,7] width:95
		checkbox box_shadow "Shadow"   height:15 align:#right -- pos:[13,27] width:95
		checkbox box_rotatetexture "Rotate Tex"  height:15 align:#left across:2 --  pos:[13,67] width:95
		checkbox box_beaming "Beaming"  height:15 align:#right -- pos:[13,47] width:65
		checkbox box_inheritcolor "Inherit Color" height:15 align:#left -- pos:[13,87]  width:80 

		GroupBox grp1 "Fading Tile Properties" pos:[4,106] width:154 height:85
		radiobuttons radio_cap "" pos:[27,122] width:72 height:64 labels:#("Not a cap", "Fadable", "Neighbour", "Base") columns:1
		--groupBox grp2 "Aplha Channel Options" pos:[4,218] width:154 height:80
		--radiobuttons radio_alpha "" pos:[24,238] width:112 height:48 labels:#("Don't Use", "Transparency Map", "Reflection Map")
		spinner spn_scale "Scale Factor" pos:[31,198] width:118 height:16 range:[0,1000,1] scale:0.1 fieldwidth:46
		spinner spn_transparencyhint "Transparency Hint" pos:[17,224] width:132 height:16 range:[0,9,0] type:#integer fieldwidth:33 ---align:#center
		--label lbl2 "(1=Transparent, 2=Env Map)" pos:[5,241] width:153 height:16
		-- no longer synching alpha with material
		--button btn_refresh "Refresh" pos:[7,262] width:57 height:18 toolTip:"Refresh the alpha value to synch with material opacity"
		spinner spn_alpha "Alpha" pos:[77,263] width:72 height:16 range:[0,1,1] fieldwidth:33 ---align:#center

		colorPicker colorpicker_selfillum "Self Illum. Color" color:[0,0,0] align:#right
		button btn_selfillum_fromwire "Get Self Illum From Wire Color"
		
		-- extra optional data
		checkbox chk_xtra_mat_data "Over-ride Mat Values" default:false
		colorPicker colorpicker_ambient "Ambient" color:[255,255,255] enabled:false align:#right
		colorPicker colorpicker_diffuse "Diffuse" color:[255,255,255] enabled:false align:#right
		colorPicker colorpicker_specular "Specular" color:[0,0,0] enabled:false align:#right
		spinner spn_shininess "Shininess" type:#integer enabled:false align:#right
		
		-- refresh the alpha spinner control
		/*
		fn refreshAlpha node =
		(
    		local mat
    		if node != undefined then
    		(
        		mat = node.material
        		if mat != undefined then
        		(
	        		try (
		        		with animate off (
		            		alpha = mat.opacity / 100
	            		)
            		) catch
            		(
	            		-- not dealing with multi material at this point.
	            		format "refreshAlpha: opacity refresh from material failed.\r\n"
            		)
        		)
    		)
		)
		*/
		
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

		fn get_material_name o =
		(
			local tempstring = ""
			local m			
			if ( superclassof o == GeometryClass ) then
			(
				if o.material != undefined then
				(
					m = o.material
					--- multimaterial support
					if(classof(m) == Multimaterial ) do
					(
						try
						(
							local m_id = getFaceMatID o 1
							m = m[m_id]
						)
						catch()
					)
					try
						(
							tempstring = m.name
							if m.diffuseMap != undefined then tempstring = (getfilenamefile m.diffuseMap.filename)
						)
					catch
						(
							tempstring = ""
						)
				)
				else tempstring = "" -- "No material set"
			)
			tempstring = lowercase (tempstring as string)
			return tempstring
		)

		on auroraTrimeshParams open do
		(
		    -- ensure alpha's are in synch with material map opacity
		    -- only do if not in animation mode
				--refreshAlpha selection[1]
				if chk_xtra_mat_data.checked then
				(
					colorpicker_ambient.enabled = true
					colorpicker_diffuse.enabled = true
					colorpicker_specular.enabled = true
					spn_shininess.enabled = true
				)
				local parentname = ""
				if selection[1].parent != undefined then
				    parentname = selection[1].parent.name
				else
				    parentname = "NONE"
				    
				btn_parent.caption = ( "Parent: " + parentname )
				if selection[1].material != undefined then
				(
					try 
					(
						btn_tex.caption = (get_material_name selection[1])
					)
					catch()
				) else
				(
    				btn_tex.caption = ""
				)

		)
		
		on btn_parent pressed do
		(
			if selection[1].parent != undefined then undo on ( select selection[1].parent )
		)
		
		on btn_tex pressed do
		(
			if btn_tex.caption == "" then return 0
			else 
			(
				local selectme = #()
				local texname = lowercase (btn_tex.caption)
				for obj in $geometry do
				(
					tempstring = get_material_name obj
					if tempstring == texname then append selectme obj
				)
				select selectme
			)
		)

		on auroraTrimeshParams close do
		(
			-- nothing to do.
		)
		
		on spn_alpha changed val do
		(
			local node
			local mat
			node = selection[1]
			if node != undefined then
			(
				mat = node.material
				if mat != undefined then
				(
					try (
			    		mat.opacity = val * 100
		    		) catch
		    		(
			    		format "spn_alpha: opacity set on material failed.\r\n"
		    		)
				)
			)
		)
		
		on chk_xtra_mat_data changed val do
		(
				if val then
				(
					colorpicker_ambient.enabled = true
					colorpicker_diffuse.enabled = true
					colorpicker_specular.enabled = true
					spn_shininess.enabled = true
				) else
				(
					colorpicker_ambient.enabled = false
					colorpicker_diffuse.enabled = false
					colorpicker_specular.enabled = false
					spn_shininess.enabled = false
				)
		)
		
		on btn_selfillum_fromwire pressed do
		(
    		colorpicker_selfillum.color = selection[1].wirecolor
    		selfillumcolor = selection[1].wirecolor
		)
		
		/*
		on btn_refresh pressed do
		(
    		refreshAlpha selection[1]
		)
		*/
	)

	on map i p do
	(
		-- We do nothing here
		-- Per BioWare:
		-- This is a simplemod so it expects us to be adjusting
		-- the point positions, but we dont want to do that.
	)
)
