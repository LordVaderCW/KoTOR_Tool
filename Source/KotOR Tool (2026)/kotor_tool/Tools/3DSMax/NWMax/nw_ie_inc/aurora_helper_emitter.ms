/*-----------------------------------------------------------------------------\

    MDL Emitter Helper Object
 
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
format "load: aurora_helper_emitter.ms\r\n"
nx_progressPlus()

plugin helper auroraemitter
name:"AuroraEmitter" 
classID:#(0xa6d521dc, 0xb8417188) 
version:3
extends:Cone_Angle
replaceUI:true
invisible:true
(
    --
    -- Function prototypes (well what passes for them in MaxScript)
    --
	local update_ui
	local myrect = undefined
	
	parameters EmitStyle rollout:EmitStyleRollout 
	(
    	-- update
    	update_sel  type:#integer animatable:false ui:radio_update default:1
    	update      type:#string default:"Fountain"
    	on update_sel set val do
    	(
    	    case val of
    	    (
    	        1:  update = "Fountain"
    	        2:  update = "Single"
    	        3:  update = "Explosion"
    	        4:
    	        (
    	            update = "Lightning"
    	            -- Also set the linked property as lightning MUST be linked
--    	            render_sel = 2
    	        )
    	    )
    	)
    	-- render
    	render_sel  type:#integer animatable:false ui:radio_render default:1
    	render      type:#string default:"Normal"
    	on render_sel set val do
    	(
    	    case val of
    	    (
    	        1:  render = "Normal"
    	        2:  render = "Linked"
    	        3:  render = "Billboard_to_Local_Z"
    	        4:  render = "Billboard_to_World_Z"
    	        5:  render = "Aligned_to_World_Z"
    	        6:  render = "Aligned_to_Particle_Dir"
    	        7:  render = "Motion_Blur"
    	    )
    	)
    	-- blend
    	blend_sel   type:#integer animatable:false ui:radio_Blend default:1
    	blend       type:#string default:"Normal"
    	on blend_sel set val do
    	(
    	    case val of
    	    (
    	        1:  blend = "Normal"
    	        2:	blend = "Punch-Through"
    	        3:  blend = "Lighten"
    	    )
    	)
    	-- spawn type
    	spawntype_sel   type:#integer animatable:false ui:radio_spawnType default:0
    	spawntype   type:#integer animatable:false
    	on spawntype_sel set val do
    	(
	    	spawnType = val - 1
    	)
	)
	
	parameters EmitParam rollout:EmitParamRollout
	(
    	-- display
    	iconSize        type:#float animatable:false ui:spn_iconSize default:100
    	-- emitter size
    	xsize           type:#float animatable:true ui:spn_xSize default:0.0f
    	ysize           type:#float animatable:true ui:spn_ySize default:0.0f
		-- geomdisp		type:#boolean default:on ui:chk_displayXYsize
    	-- inherit props
    	inherit         type:#integer animatable:false ui:box_inherit default:0
    	inherit_local   type:#integer animatable:false ui:box_inherit_local default:0
    	inheritvel      type:#integer animatable:false ui:box_inheritvel default:0
    	inherit_part    type:#integer animatable:false ui:box_inherit_part default:0
    	-- misc
    	renderorder     type:#integer animatable:false ui:spn_renderorder default:0
    	threshold       type:#float animatable:false ui:spn_threshold default:0  -- is this a p2p property?
    	combinetime     type:#float range:[0,15,0] animatable:true ui:spn_combinetime default:0 -- is this a p2p property?
    	deadspace       type:#float animatable:false ui:spn_deadspace default:0.0
    	opacity         type:#float animatable:true ui:spn_opacity  default:0.5
	)
	
	parameters EmitParticles rollout:EmitParticlesRollout
	(
    	-- start/end
    	colorStart  type:#color animatable:true ui:colorPicker_colorStart
    	colorEnd    type:#color animatable:true ui:colorPicker_colorEnd
    	alphaStart  type:#float animatable:true ui:spn_alphaStart default:1.0
    	alphaEnd    type:#float animatable:true ui:spn_alphaEnd default:1.0
    	sizeStart   type:#float animatable:true ui:spn_sizeStart default:0.00
    	sizeEnd     type:#float animatable:true ui:spn_sizeEnd default:0.00
    	sizeStart_y type:#float animatable:true ui:spn_sizeStart_y default:0.00
    	sizeEnd_y   type:#float animatable:true ui:spn_sizeEnd_y default:0.00
    	
    	birthrate   type:#integer animatable:true ui:spn_birthrate default:0
    	lifeExp     type:#float animatable:true ui:spn_lifeExp default:0.0
    	mass        type:#float animatable:true ui:spn_mass default:0.0
    	spread      type:#float animatable:true ui:spn_spread default:0.0
    	particleRot type:#float animatable:true ui:spn_particleRot default:0.0
    	velocity    type:#float animatable:true ui:spn_velocity default:0.0
    	randvel     type:#float animatable:false ui:spn_randvel default:0.0
    	bounce_co   type:#float animatable:true ui:spn_bounce_co default:0.0
    	blurlength  type:#float animatable:true ui:spn_blurlength default:10.0
    	
    	loop        type:#integer animatable:false ui:box_loop default:0
    	bounce      type:#integer animatable:false ui:box_bounce default:0
    	m_isTinted  type:#integer animatable:false ui:box_m_isTinted default:0
    	splat       type:#integer animatable:false ui:box_Splat default:0
    	affectedByWind type:#boolean animatable:false ui:box_affectedbyWind default:false
	)
	
	parameters EmitTextChunk rollout:EmitTextChunkRollout
	(
    	-- texture
    	texture     type:#string animatable:false ui:edit_texture
    	twosidedtex type:#integer animatable:false ui:box_twosidedtex default:0
    	twosidedtext type:#integer animatable:false default:0 -- wrong, for backwards compat of loading
    	-- animation
    	xgrid       type:#integer animatable:false	ui:spn_xgrid default:0
    	ygrid       type:#integer animatable:false	ui:spn_ygrid default:0
    	fps         type:#integer animatable:true		ui:spn_fps default:0
    	frameStart  type:#integer animatable:true		ui:spn_frameStart default:0
    	frameEnd    type:#integer animatable:true		ui:spn_frameEnd default:0
    	random      type:#integer animatable:false	ui:box_random default:0
    	
    	-- chunk
    	chunky		type:#integer default:0		ui:chk_chunk
    	chunkName   type:#string  default:"NULL"
    	chunk		type:#string	-- for compatability, but is wrong
	)
	
	parameters EmitAdv rollout:EmitAdvRollout
	(
    	-- lightning props
    	lightningDelay      type:#float animatable:true ui:spn_lightningDelay default:0.0
    	lightningRadius     type:#float animatable:true ui:spn_lightningRadius default:0.0
    	lightningSubDiv		type:#integer animatable:true ui:spn_lightningSubDiv default:0
    	lightningScale		type:#float animatable:true ui:spn_lightningScale default:0
    	-- blast props
    	blastRadius         type:#float animatable:false ui:spn_blastRadius default:0
    	blastLength         type:#float animatable:false ui:spn_blastLength default:0
    	-- p2p props
    	p2p                 type:#integer animatable:false ui:box_p2p default:0
    	p2p_type            type:#string animatable:false default:"Bezier"
    	p2p_sel             type:#integer animatable:false default:1 ui:radio_p2p_type
    	p2p_bezier2         type:#float animatable:true ui:spn_p2p_bezier2 default:0
    	p2p_bezier3         type:#float animatable:true ui:spn_p2p_bezier3 default:0
    	grav                type:#float animatable:true ui:spn_grav default:0
    	drag                type:#float animatable:true ui:spn_drag default:0
    	
    	on p2p_sel set val do
    	(
        	case val of
			(
        		1: p2p_type = "Bezier"
        		2: p2p_type = "Gravity"
			)
    	)
	)

	rollout EmitStyleRollout "Emitter Style" width:162 height:321
    (
    	group "Update" 
		(
    		radiobuttons radio_update "" align:#left labels:#("Fountain", "Single", "Explosion", "Lightning") columns:1
        )
    	group "Render" 
		(
	    	radiobuttons radio_render "" align:#left labels:#("Normal", "Linked", "Billboard to Local Z", "Billboard to World Z", "Aligned to World Z", "Aligned to Particle", "Motion Blur") columns:1
        )
    	group "Blend"
		(
	    	radiobuttons radio_Blend "" align:#left labels:#("Normal","Punch-Through", "Lighten")
        )
    	group "Spawn Type"
		(
	    	radiobuttons radio_spawnType "" align:#left labels:#("Normal", "Trail") columns:2
		)
    	on EmitStyleRollout open do
    	(
	    	format "EmitStyleRollout opened\r\n"
    	)
    	
    	on radio_update changed state do update_ui()
    	    	
    	--on radio_spawnType changed state do
    	--(
    	--    spawnType = state - 1
    	--)
    	
    	on radio_Blend changed state do update_ui()
    )
    
    rollout EmitParamRollout "Emitter Parameters" width:162 height:293
    (
    	-- GroupBox grp1 "Display"  width:154 height:41
		label lbl_iconsize "Display Icon Size:" across:2
    	spinner spn_iconSize ""  fieldwidth:48 height:16        
        
    	-- GroupBox grp2 "Emitter Size (cm)"  width:154 height:62
		Label lbl_emittersize "Emitter Size (cm)" align:#left
    	spinner spn_xSize "X:" fieldwidth:38 height:16 range:[0,36000,0] scale:1.0 across:2
    	spinner spn_ySize "Y:" fieldwidth:38 height:16 range:[0,36000,0] scale:1.0
        -- checkbox chk_displayXYsize "Display"
		----
		---- INHERIT PROPS:
		---- THIS NEEDS A CHANGE
		---- CAN`T HAVE ALL PROPERTIES AT ONCE
		---- BUT ONLY ONE
		----
    	group "Inherit Properties"  
		(
	    	checkbox box_inherit "Inherit"  width:53 height:15 across:2
	    	checkbox box_inherit_local "Local"  width:50 height:15
	    	checkbox box_inheritvel "Velocity"  width:61 height:15 across:2
	    	checkbox box_inherit_part "Part"  width:43 height:15
        )
    	group "Miscellaneous"
		(
			label lbl_renderorder "Render Order:" align:#left across:2
	    	spinner spn_renderorder ""  fieldwidth:40 height:16 range:[0,255,0] type:#integer
			label lbl_threshold "Threshold:" align:#left across:2
	    	spinner spn_threshold  "" fieldwidth:40 height:16 range:[0,1000,0]
		)
		group "Blur Params"
		(
			label lbl_combinetime "Combine Time:" align:#left across:2
	    	spinner spn_combinetime "" fieldwidth:40 height:16
			label lbl_deadspace "Deadspace:" align:#left across:2
	    	spinner spn_deadspace "" fieldwidth:40 height:16
			label lbl_opacity "Opacity" align:#left align:#left across:2
	    	spinner spn_opacity "" fieldwidth:40 height:16			
		)
		
    	fn create_rectangle o =
		(
			-- try
			if true then
			(
				myrect = rectangle name:( o.name + "_XYdimension" )
				myrect.length = spn_Ysize.value
				myrect.width = spn_Xsize.value
				myrect.wirecolor = yellow
				myrect.rotation = o.rotation
				myrect.pos = o.pos
				myrect.parent = o
			)
			-- catch
			else
			(
				myrect = undefined
			)
		)
		
		fn destroy_rectangle o =
		(
			if myrect != undefined then
			(
				delete myrect
				myrect = undefined
			)
		)
		
		fn update_rectangle =
		(
			if myrect != undefined then
			(
				myrect.length = spn_Ysize.value
				myrect.width = spn_Xsize.value
			)
		)
		
		on spn_Xsize changed val do
		(
			update_rectangle()
		)
		on spn_Ysize changed val do
		(
			update_rectangle()
		)

    	on EmitParamRollout open do
    	(
			if myrect == undefined then create_rectangle $
	    --  format "EmitParamRollout opened\r\n"
    	)
    	on EmitParamRollout close do
		(
			destroy_rectangle $
		)
    )
    
    
    rollout EmitParticlesRollout "Emitter Particles" -- width:162 height:431
    (
    	--GroupBox grp1 "Start and End"  width:154 height:171
		group "Start and End"
		(
			label lbl_dummy1 across:3
			label lbl_start "Start" 
			label lbl_end "End"
			label lbl_dummy2 across:3
	    	colorPicker colorPicker_colorStart ""  height:20 color:[255,255,255]
	    	colorPicker colorPicker_colorEnd ""   height:20 color:[255,255,255]
	    	checkbox box_m_isTinted "Allow Color Tint"  height:15 align:#left
	
			label lbl_alpha "Alpha:" across:3
			spinner spn_alphaStart ""  fieldwidth:34 height:16 range:[0,1,0] --align:#left
	    	spinner spn_alphaEnd "" fieldwidth:34 height:16 range:[0,1,0] --align:#right
			
			label lbl_sizex "Size X:" across:3
	    	spinner spn_sizeStart ""  fieldwidth:34 height:16 range:[0,255,0] -- align:#left
	    	spinner spn_sizeEnd "" fieldwidth:34 height:16 range:[0,255,0] --align:#right
	    	
			label lbl_sizey "Size Y:" across:3
			spinner spn_sizeStart_y ""  fieldwidth:34 height:16 range:[0,255,0] --align:#left
	    	spinner spn_sizeEnd_y "" fieldwidth:34 height:16 range:[0,255,0] --align:#right
        )
		label lbl_1 "Birthrate (per s):" align:#left across:2
    	spinner spn_birthrate ""  type:#integer fieldwidth:40 height:16 range:[0,9999,0]
		label lbl_2 "Life Exp(s; -1=inf):" align:#left across:2
    	spinner spn_lifeExp ""  fieldwidth:40 height:16 range:[-1,1000,0]
		label lbl_3 "Mass:" align:#left across:2
    	spinner spn_mass "" fieldwidth:40 height:16 range:[-10000,10000,0]
		label lbl_4 "Spread (degrees):" align:#left across:2
    	spinner spn_spread ""  fieldwidth:40 height:16 range:[0,360,0]
		label lbl_5 "Particle Rot (rot/s):" align:#left across:2
    	spinner spn_particleRot "" fieldwidth:40 height:16 range:[-10000,10000,0]
		label lbl_6 "Velocity (m/s):" align:#left across:2
    	spinner spn_velocity ""  fieldwidth:40 height:16 range:[0,1000,0]
		label lbl_7 "Random Vel:" align:#left across:2
    	spinner spn_randvel ""  fieldwidth:40 height:16 range:[0,1000,0]
		label lbl_9 "Blur Length:" align:#left across:2
    	spinner spn_blurlength "" fieldwidth:40 height:16
		
    	checkbox box_bounce "Bounce"  width:61 height:15
		label lbl_8 "Bounce Coef:" align:#left across:2
    	spinner spn_bounce_co ""  fieldwidth:40 height:16
		--- WHAT IS THIS FOR 'Loop' ?        
    	checkbox box_loop "Loop"  height:15
    	checkbox box_Splat "Splat" height:15
    	checkbox box_affectedbyWind "Affected By Wind" height:15
    	
		on EmitParticlesRollout open do
		(
			format "EmitParticlesRollout opened\r\n"
		)
    )
    
	rollout EmitTextChunkRollout "Emitter Texture/Chunk" width:162 height:270
	(
		group "Texture"
		(
			edittext edit_texture height:17
			checkbox box_twosidedtex "Two-Sided Texture" height:15
			label lbl_animation "Texture Animation" align:#left
		
			-- label lbl_textgrid "Texture Grid"
			label lbl_a1 "Grid:" align:#left across:3
			spinner spn_xgrid "x" fieldwidth:28 height:16 type:#integer
			spinner spn_ygrid "y" fieldwidth:28 height:16 type:#integer
			
			label lbl_a2 "Speed (fps):" align:#left across:2
			spinner spn_fps "" fieldwidth:40 height:16 range:[0,1000,0] type:#integer
			label lbl_a3 "First Frame:" align:#left across:2
			spinner spn_frameStart "" fieldwidth:40 height:16 range:[0,255,0] type:#integer
			label lbl_a4 "Last Frame:" align:#left across:2
			spinner spn_frameEnd "" fieldwidth:40 height:16 range:[0,255,0] type:#integer
			checkbox box_random "Random Playback" width:111 height:15
		)
		group "Chunk Model"
		(
			checkbox chk_chunk "Chunky Particles" align:#left
			edittext edit_chunk height:17 enabled:false
		)
		
		on EmitTextChunkRollout open do
		(
			format "EmitTextChunkRollout opened\r\n"
			if chunky == 0 then (
				edit_chunk.enabled = false
			)
			if (chunkName != undefined) and (chunkName != "NULL")then (
				edit_chunk.text = chunkName
			)
		)
		
		on chk_chunk changed val do
		(
			if chk_chunk.checked then
				edit_chunk.enabled = true
			else
				edit_chunk.enabled = false
		)
		
		on edit_chunk changed val do
		(
			-- put new data into the parameters
			chunkName = val
			update_ui()
		)
	)
    
    rollout EmitAdvRollout "Emitter Advanced" width:162 height:369
    (
    	group "Lightning Properties" 
		(
			label lbl_l1 "Delay (s):" align:#left across:2
	    	spinner spn_lightningDelay "" fieldwidth:40 height:16 range:[0,1000,0]
			label lbl_l2 "Peak Radius (m):" align:#left across:2
	    	spinner spn_lightningRadius "" fieldwidth:40 height:16 range:[0,1000,0]
			label lbl_l3 "Subdivisions:" align:#left across:2
	    	spinner spn_lightningSubDiv "" fieldwidth:40 height:16 range:[0,12,0] type:#integer
			label lbl_l4 "Scale:" align:#left across:2
	    	spinner spn_lightningScale "" fieldwidth:40 height:16 range:[0,1,0]
        )
    	group "Blast Properties"
		(
			label lbl_l5 "Radius (m):" align:#left across:2
	    	spinner spn_blastRadius "" fieldwidth:40 height:16 range:[0,20,0]
			label lbl_l6 "Length (s):" align:#left across:2
	    	spinner spn_blastLength "" fieldwidth:40 height:16 range:[0,10,0]
        )
    	group "P2P Properties"
		(
	    	checkbox box_p2p "Use P2P" height:15
	    	radiobuttons radio_p2p_type "" labels:#("Bezier", "Gravity") columns:1
	    	label lbl_l8 "SRC Tanget (m):" align:#left across:2
	    	spinner spn_p2p_bezier2 "" fieldwidth:40 height:16 range:[-1000,1000,0]
	    	label lbl_l9 "TRG Tangent (m):" align:#left across:2
	    	spinner spn_p2p_bezier3 "" fieldwidth:40 height:16 range:[-1000,1000,0]
	    	label lbl_l10 "Gravity (m/s^2):" align:#left across:2
	    	spinner spn_grav "" fieldwidth:40 height:16 range:[0,1000,0]
	    	label lbl_l11 "Drag (m/s^2):" align:#left across:2
	    	spinner spn_drag "" fieldwidth:40 height:16 range:[0,1,0]
		)
    	on box_p2p changed state do
        (
			update_ui()
    	)
    	
    	on radio_p2p_type changed state do
    	(
        	update_ui()
    	)
    	
    	on EmitAdvRollout open do
    	(
	    	format "EmitAdvRollout opened\r\n"
        	update_ui()
    	)
    )
    
    --
    -- Event handling code.  Specifically around making sure interdependent
    -- options have effect on various things.
    --
    local oldLife = -1.0
    local oldBirth = -1.0
    local oldMass = 0.0
    local lockAxes = 1
    
    
    fn update_ui=
    (
	    --format "Update Emitter UI\r\n"
        -- update emitter rules
/*        if update_sel == 1 then
            box_spawnType.enabled = true
        else
        (
            box_spawnType.enabled=false
            box_spawnType.checked=false
            spawnType=0
        )
*/        
        if update_sel == 2 then
        (
            -- not sure about what goes in here
            EmitParticlesRollout.box_loop.enabled = true
        ) else
        (
            -- not sure what goes in here
        )
        
        /*
        if update_sel < 3 then
            EmitAdvRollout.box_p2p.enabled = true
        else
        (
            EmitAdvRollout.box_p2p.enabled = false
            EmitAdvRollout.box_p2p.checked = false
            p2p = 0
            --update_ui()
        )
        */
        
        if update_sel == 3 then
            EmitParticlesRollout.box_loop.enabled = true
        else
        (
            loop = 0
            EmitParticlesRollout.box_loop.enabled = false
            EmitParticlesRollout.box_loop.checked = false
        )
        
        if update_sel == 4 then
        (
            EmitStyleRollout.radio_render.state = 2
            render_sel = 2
            EmitStyleRollout.radio_render.enabled = false
            EmitTextChunkRollout.edit_chunk.enabled = false
            
            EmitParticlesRollout.spn_spread.enabled = false
            EmitParticlesRollout.spn_particleRot.enabled = false
            EmitParticlesRollout.spn_velocity.enabled = false
            EmitParticlesRollout.spn_randvel.enabled = false
            EmitParticlesRollout.spn_lifeExp.enabled = false
            EmitParticlesRollout.spn_mass.enabled = false
            EmitParticlesRollout.spn_birthrate.enabled = false
            
            EmitParticlesRollout.box_affectedbyWind.enabled = false
            oldLife = lifeExp
            lifeExp = 1
            -- save old birthrate
            oldBirth = birthrate
            birthrate = 2^lightningSubDiv + 1
            
            EmitParamRollout.box_inheritvel.enabled = false
            EmitParticlesRollout.box_bounce.checked = false
            EmitParticlesRollout.box_bounce.enabled = false
            EmitParticlesRollout.spn_bounce_co.enabled = false
            
            EmitAdvRollout.spn_lightningDelay.enabled = true
            EmitAdvRollout.spn_lightningRadius.enabled = true
            EmitAdvRollout.spn_lightningSubDiv.enabled = true
            EmitAdvRollout.spn_lightningScale.enabled = true
        ) else
        (
            --EmitStyleRollout.radio_render.state = 1
            --render_sel = 1
            EmitStyleRollout.radio_render.enabled = true
            EmitTextChunkRollout.edit_chunk.enabled = true
            
            EmitParticlesRollout.spn_spread.enabled = true
            EmitParticlesRollout.spn_particleRot.enabled = true
            EmitParticlesRollout.spn_velocity.enabled = true
            EmitParticlesRollout.spn_randvel.enabled = true
            EmitParticlesRollout.spn_lifeExp.enabled = true
            EmitParticlesRollout.spn_mass.enabled = true
            EmitParticlesRollout.spn_birthrate.enabled = true
            
            EmitParticlesRollout.box_affectedbyWind.enabled = true
            if (oldLife != -1) then lifeExp = oldLife
            if (oldBirth != -1) then birthrate = oldBirth
            
            EmitParamRollout.box_inheritvel.enabled = true
            EmitParticlesRollout.box_bounce.enabled = true
            EmitParticlesRollout.spn_bounce_co.enabled = true
            
            EmitAdvRollout.spn_lightningDelay.enabled = false
            EmitAdvRollout.spn_lightningRadius.enabled = false
            EmitAdvRollout.spn_lightningSubDiv.enabled = false
            EmitAdvRollout.spn_lightningScale.enabled = false
        )
        -- chunk rules
        if (EmitTextChunkRollout.edit_chunk.text != "") and \
        	(EmitTextChunkRollout.edit_chunk.text != "NULL") then
        (
            EmitStyleRollout.radio_render.state = 1
            EmitStyleRollout.radio_render.enabled = false
            EmitStyleRollout.radio_blend.state = 1
            EmitStyleRollout.radio_blend.enabled = false
            EmitTextChunkRollout.edit_texture.enabled = false
            EmitTextChunkRollout.spn_xgrid.enabled = false
            EmitTextChunkRollout.spn_ygrid.enabled = false
            EmitStyleRollout.radio_spawnType.enabled = false
        )
        else
        (
            EmitStyleRollout.radio_render.enabled = true
            EmitStyleRollout.radio_blend.enabled = true
            EmitTextChunkRollout.edit_texture.enabled = true
            EmitTextChunkRollout.spn_xgrid.enabled = true
            EmitTextChunkRollout.spn_ygrid.enabled = true
            EmitStyleRollout.radio_spawnType.enabled = true
        )
        
        -- 
        
        -- p2p rules
        if (EmitAdvRollout.box_p2p.checked == true) then
        (
            EmitAdvRollout.radio_p2p_type.enabled = true
            if (EmitAdvRollout.radio_p2p_type.state == 1) then
            (
                EmitAdvRollout.spn_drag.enabled = \
                EmitAdvRollout.spn_grav.enabled = false
                EmitAdvRollout.spn_p2p_bezier2.enabled = \
                EmitAdvRollout.spn_p2p_bezier3.enabled = true
            )
            else
            (
                EmitAdvRollout.spn_drag.enabled = \
                EmitAdvRollout.spn_grav.enabled = true
                EmitAdvRollout.spn_p2p_bezier2.enabled = \
                EmitAdvRollout.spn_p2p_bezier3.enabled = false
            )
        )
        else
        (
            EmitAdvRollout.radio_p2p_type.enabled = false
            EmitAdvRollout.spn_p2p_bezier2.enabled = \
            EmitAdvRollout.spn_p2p_bezier3.enabled = false
            EmitAdvRollout.spn_grav.enabled = \
            EmitAdvRollout.spn_drag.enabled = false
        )
    )
)


plugin helper auroraemitterbox
name:"AuroraEmitter"
(
	local objCone
	tool create
	(
		
		on mousePoint click do
		(
			print mouse.buttonStates
			if click > 1 then	-- ignore first click, rest are releases
			(
				in coordsys grid 
				(
					objCone = auroraemitter pos:[0,0,0]
					objCone.delegate.Angle = 15
					objCone.delegate.Distance = 100
					objCone.rotation = quat 180 (point3 1 0 0)
					objCone.pos = gridPoint
				)
			)
		)
	)
)