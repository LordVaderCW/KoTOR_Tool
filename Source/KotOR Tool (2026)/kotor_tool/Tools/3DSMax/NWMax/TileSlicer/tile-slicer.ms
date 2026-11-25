--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
--
-- NWN Tile Slicer v0.10.5
--
-- Copyright (C) 2003, Gareth Hughes <roboius@dladventures.net>
--
-- The Neverwinter Nights Tile Slicer is a utility for Discreet's 3ds max
-- and (eventually) gmax. It is designed to assist in the process of
-- creating multi-tile groups for NWN tilesets. Specifically, it automates
-- the process of converting a large model in 3ds max into a set of NWN
-- tile models, ready for use in the game.
--
-- For more information about this utility, please see the README file
-- or visit the following URL:
--
-- http://rockbottom.vtex.net/slicer.html
--
-- Revision History
-- 0.10.5:
--  * fixed guess code as dimensions were swapped
--  * fixed location calc. rows/cols were swapped
--  * made nwmax the default tool used
--
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

-- Slicing global params
global tile_names = #()
global rows = 1
global cols = 1
global location = [0,0,0]

-- Options
global opt_increment = true
global opt_variation = true
global opt_pos_num_only = false

global opt_origin = true

global opt_create_lights = true
global opt_create_anim = false
global opt_snap_vertices = true
global opt_adjust_pivot = true
global opt_convert = true
global opt_test_shadows = false
global opt_slice_exterior = true

global invalid_shadow_color = [255,0,0]
global disabled_shadow_color = [0,0,0]

-- Lighting parameters
global light_radius_1 = 1400.0
global light_radius_2 = 500.0
global light_color_1 = [0,0,0]
global light_color_2 = [0,0,0]

-- Export scripts
global use_aurora = false
global use_mdl_suite = false
global use_wayland = false
global use_nwmax = true
global nwmax_export_path = getdir #export

-- Verbose debug output
global verbose = false

-- Shortcuts for tile name generation
global grid_letters = #("a", "b", "c", "d", "e", "f", "g", "h",
						"i", "j", "k", "l", "m", "n", "o", "p",
						"q", "r", "s", "t", "u", "v", "w", "x",
						"y", "z","aa","bb","cc","dd","ee","ff")
global max_letter = 26

global alpha_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
global numeric_chars = "0123456789"

global title_string = "NWN Tile Slicer"

-- Booleans to enable certain features
global version_5000 = false

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

fn is_alpha char =
(
	try (
		local ii = findstring alpha_chars char
		return (ii != undefined)
	) catch (
		return false
	)
)

fn is_numeric char =
(
	try (
		local ii = findstring numeric_chars char
		return (ii != undefined)
	) catch (
		return false
	)
)

fn two_digit_string num =
(
	local name = ""

	if (num < 10) then ( name += "0" )
	name += num as string

	return name
)

fn uppercase instring =
(
	local upper, lower, outstring, ii, jj

	upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	lower = "abcdefghijklmnopqrstuvwxyz"
	outstring = copy instring

	for ii = 1 to outstring.count do
	(
		jj = findstring lower outstring[ii]
		if (jj != undefined) then (
			outstring[ii] = upper[jj]
		)
	)
	return outstring
)

fn lowercase instring =
(
	local upper, lower, outstring, ii, jj

	upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	lower = "abcdefghijklmnopqrstuvwxyz"
	outstring = copy instring

	for ii = 1 to outstring.count do
	(
		jj = findstring upper outstring[ii]
		if (jj != undefined) then (
			outstring[ii] = lower[jj]
		)
	)
	return outstring
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--
-- Create the list of tile names.
--
fn create_names prefix pos var =
(
	local num, tile = 1, ii, jj

	-- Make sure the prefix and grid position are valid.
	if (prefix.count == 0 or prefix.count > 5) then (
		msg = "Error: Invalid tilename prefix.  Prefixes are usually in the\n" +
			  "form of three letters followed by a two-digit number (XXX##)."
		messagebox msg title:title_string
		return false
	)
	if (pos.count != 3) then (
		msg = "Error: Invalid grid position.  Grid position should be in\n" +
			  "the form of a letter followed by a two-digit number (X##)."
		messagebox msg title:title_string
		return false
	)

	-- Transform the input strings into corresponding integer values.
	num = substring pos 2 2 as integer
	pos = substring pos 1 1
	if (pos != undefined) then ( pos = findstring alpha_chars pos )
	var = var as integer

	-- Check the input parameters for errors.
	if (num == undefined or num == 0) then (
		msg = "Error: Invalid grid position number, should be between 01 and 99.  Grid\n" +
			  "position should be in the form of a letter followed by a two-digit number (X##)."
		messagebox msg title:title_string
		return false
	)
	if (num < 1 or num > 99) then (
		messagebox "Error: Grid position number must be between 01 and 99." title:title_string
		return false
	)
	if (pos == undefined or pos == 0) then (
		msg = "Error: Invalid grid position letter, should be between A and Z.  Grid position\n" +
			  "should be in the form of a letter followed by a two-digit number (X##)."
		messagebox msg title:title_string
		return false
	)
	if (var == undefined or var == 0) then (
		messagebox "Error: Invalid variation number, should be between 01 and 99." title:title_string
		return false
	)
	if (var < 1 or var > 99) then (
		messagebox "Error: Variation number must be between 01 and 99." title:title_string
		return false
	)

	-- Okay, we have valid input if we get this far.

	if (opt_variation) then
	(
		-- Update the variation number with each tile.
		pos = alpha_chars[pos] + two_digit_string num

		for ii in 1 to rows do
		(
			for jj in 1 to cols do
			(
				tile_names[tile] = prefix + "_" + pos + "_" + two_digit_string var

				-- Increment or decrement the variation number.
				if (opt_increment) then (
					var += 1; if (var > 99) then ( var = 1 )
				) else (
					var -= 1; if (var < 1) then ( var = 99 )
				)
				tile += 1;
			)
		)
	)
	else
	(
		-- Update the grid position with each tile.
		local initial = num
		var = two_digit_string var

		for ii in 1 to rows do
		(
			for jj in 1 to cols do
			(
				tile_names[tile] = prefix + "_" + grid_letters[pos] +
					two_digit_string num + "_" + var

				-- Increment or decrement the grid position number.
				if (opt_increment) then (
					num += 1; if (num > 99) then ( num = 1 )
				) else (
					num -= 1; if (num < 1) then ( num = 99 )
				)
				tile += 1;
			)
			if (not opt_pos_num_only) then
			(
				-- Increment or decrement the grid position letter.
				if (opt_increment) then (
					pos += 1; if (pos > max_letter) then ( pos = 1 )
				) else (
					pos -= 1; if (pos < 1) then ( pos = max_letter )
				)
				-- Reset the grid position number for each row.
				num = initial
			)
		)
	)
	
	print tile_names

	return true
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--
-- Adjust the vertices of the given object, rounding them off to the
-- nearest integer value.
--
fn snap_vertices obj =
(
	if (not iskindof obj Editable_Mesh) then ( return 0 )

	if (verbose) then ( format "snapping vertices for %\n" obj.name )

	for ii = 1 to obj.numverts do
	(
		local v, x, y, z

		v = getvert obj ii

		-- Correct IEEE float rounding
		if (v.x >= 0.0) then ( x = floor(v.x + 0.5) ) else ( x = ceil(v.x - 0.5) )
		if (v.y >= 0.0) then ( y = floor(v.y + 0.5) ) else ( y = ceil(v.y - 0.5) )
		if (v.z >= 0.0) then ( z = floor(v.z + 0.5) ) else ( z = ceil(v.z - 0.5) )

		if (verbose) then ( format "   % % % => % % %\n" v.x v.y v.z x y z )

		setvert obj ii x y z
	)
)

--
-- Similar to the "Reset Transform" utility.
--
fn reset_transforms obj =
(
	local ntm, ptm, rtm = matrix3 1, tm, piv

	if (not iskindof obj Editable_Mesh) then ( return 0 )

	-- Get the parent and node TMs.
	ntm = obj.transform
	if (obj.parent != undefined) then (
		ptm = obj.parent.transform
	) else (
		ptm = matrix3 1
	)

	-- Compute the relative TM.
	ntm = ntm * inverse ptm

	-- Need to flip the normals if the determinant is negative.
	if (ntm.determinantsign < 0) then
	(
		meshop.flipnormals obj obj.faces
	)

	-- The reset TM only inherits position.
	rtm.translation = ntm.translation

	-- Set the node TM to the reset TM.
	tm = rtm * ptm
	obj.transform = tm

	-- Compute the pivot TM.
	local piv = obj.objecttransform * inverse obj.transform

	-- Reset the offset to 0.
	obj.objectoffsetpos = [0,0,0]
	obj.objectoffsetrot = (quat 0 0 0 1)
	obj.objectoffsetscale = [1,1,1]

	-- Take the position out of the original node transform matrix since
	-- we don't reset position.
	ntm.translation = [0,0,0]

	-- Apply the offset to the TM.
	ntm = piv * ntm

	-- Apply an XForm modifier to the node.
	local xform_mod = xform()
	addmodifier obj xform_mod

	xform_mod.gizmo.transform = ntm
)

--
-- Test for valid shadows.  If a ray from the pivot point hits the
-- front of any face in the object, the shadows will be off.
--
fn test_shadows obj =
(
	local face, normal, vertex, dp, errors = 0

	if (not iskindof obj Editable_Mesh) then ( return 0 )

	for ii = 1 to obj.numfaces do
	(
		face = getface obj ii
		normal = getfacenormal obj ii
		vertex = getvert obj face.x

		dp = dot normal vertex

		if ((dot normal obj.pivot) - dp > 5e-3) then ( errors += 1 )
	)

	if (errors > 0) then (
		format "Warning: Object % may have an invalid shadow.\n" obj.name
		obj.wirecolor = invalid_shadow_color
		return 1
	) else (
		return 0
	)
)

--
-- Copy the modifiers from src to dst.
--
fn copy_modifiers dst src =
(
	local ii

	for ii in src.modifiers.count to 1 by -1 do
	(
		addmodifier dst (copy src.modifiers[ii])
	)
)

--
-- Slice up the selected geometry.
--
fn slice_tiles =
(
	local mdl_bases = #()
	local xx, yy, ii, jj, errors = 0

	local tile_min = location
	local tile_max = [tile_min.x + (cols - 1) * 1000,
					  tile_min.y + (rows - 1) * 1000, 0.0]

	-- Create the MDL helper nodes.
	ii = 1

	for yy = tile_min.y to tile_max.y by 1000 do
	(
		for xx = tile_min.x to tile_max.x by 1000 do
		(
			local mdl_base, mdl_light, mdl_anim

			try (
				if (use_aurora) then
				(
					mdl_base = aurabase()
					mdl_base.classification = "Tile"
				)
				else if (use_mdl_suite) then
				(
					mdl_base = Model()
					mdl_base.size = 800.0
					mdl_base.type = 1
				)
				else if (use_wayland) then
				(
					mdl_base = dummy()
					mdl_base.boxsize = [400,400,5]

					setUserProp mdl_base "mdl_root" "true"
					setUserProp mdl_base "setsupermodel" "NULL"
					setUserProp mdl_base "classification" "Tile"
					setUserProp mdl_base "setanimationscale" "1.0"
				)
				else if (use_nwmax) then
				(
					mdl_base = aurorabase()
					mdl_base.delegate.boxsize = [400,400,5]
					mdl_base.classification_sel = 2
					mdl_base.export_path = nwmax_export_path
				)
			) catch (
				msg = "Error: Unable to create MDL helper objects.  Please\n" +
					  "verify that you have the correct export scripts selected."
				messagebox msg title:title_string
				return 0
			)

			mdl_base.name = uppercase tile_names[ii]
			mdl_base.pos = [xx + 500, yy + 500, 0]

			-- Optionally create the tile lights.
			if (opt_create_lights) then
			(
				for jj = 1 to 2 do
				(
					-- Export script specific parameters.
					if (use_aurora) then
					(
						mdl_light = auroralight()
						mdl_light.fadingLight = true
						mdl_light.lightPriority = 5
						mdl_light.affectDynamic = 1
						mdl_light.nDynamicType = 0
						mdl_light.affectDiffuse = true
						if (jj == 1) then (
							mdl_light.rgb = light_color_1
							mdl_light.farAttenEnd = light_radius_1
						) else (
							mdl_light.rgb = light_color_2
							mdl_light.farAttenEnd = light_radius_2
						)
					)
					else if (use_mdl_suite) then
					(
						mdl_light = lighthelper()
						mdl_light.iconSize = 250.0
						mdl_light.priority = 5
						mdl_light.dynamicType = false
						mdl_light.affectDynamic = true
						if (jj == 1) then (
							mdl_light.radius = light_radius_1
							mdl_light.color = light_color_1
						) else (
							mdl_light.radius = light_radius_2
							mdl_light.color = light_color_2
						)
					)
					else if (use_wayland) then
					(
						mdl_light = OmniLight()
						mdl_light.affectDiffuse = true
						if (jj == 1) then (
							-- mdl_light.rgb = light_color_1
							mdl_light.farAttenEnd = light_radius_1
						) else (
							-- mdl_light.rgb = light_color_2
							mdl_light.farAttenEnd = light_radius_2
						)
					)
					else if (use_nwmax) then
					(
						mdl_light = auroralight()
						mdl_light.lightpriority = 5
						mdl_light.affectDynamic = 1
						mdl_light.nDynamicType = 0
						if (jj == 1) then (
							mdl_light.radius = light_radius_1
							mdl_light.delegate.color = light_color_1
						) else (
							mdl_light.radius = light_radius_2
							mdl_light.delegate.color = light_color_2
						)
					)

					-- Generic parameters.
					mdl_light.name = mdl_base.name + "ml" + jj as string
					if (jj == 1) then (
						mdl_light.pos = [xx + 500, yy + 500, 500]
					) else (
						mdl_light.pos = [xx + 300, yy + 300, 400]
					)
					mdl_light.parent = mdl_base
				)
			)

			-- Optionally create the animation dummy node.
			if (opt_create_anim) then
			(
				mdl_anim = dummy()
				mdl_anim.name = mdl_base.name + "a"
				mdl_anim.pos = mdl_base.pos
				mdl_anim.boxsize = [80,80,80]
				mdl_anim.parent = mdl_base
			)

			format "Created tile %\n" mdl_base.name

			mdl_bases[ii] = mdl_base
			ii += 1
		)
	)

	progressStart "Slicing tiles..."

	-- Make a slicing box big enough to cover the selected objects.
	l = 1000
	w = 1000
	h = selection.max.z - selection.min.z + 2000

	-- Need to make a copy of the selection array, as we'll be deleting
	-- objects from it.  Things go horribly wrong if you delete objects
	-- from the selection array directly.
	selected_objects = selection as array

	-- Slice the selected objects.
	for jj = 1 to selected_objects.count do
	(
		local obj = selected_objects[jj]
		local orig = copy obj

		-- Update the progress bar, check if we should quit early.
		if (progressUpdate (100.0 * jj / selected_objects.count) == false) then (
			progressEnd()
			return 0;
		)

		ii = 1

		for yy = tile_min.y to tile_max.y by 1000 do
		(
			for xx = tile_min.x to tile_max.x by 1000 do
			(
				local mdl_base = mdl_bases[ii]

				-- Create a slicing box.
				slicing_box = box length:l width:w height:h \
					position:[xx + 500, yy + 500, obj.min.z - 1000]

				-- Do a cut/slice boolean operation.
				boolObj.createBooleanObject obj slicing_box 4 5
				boolObj.setBoolOp obj 5
				boolObj.setBoolCutType obj 2

				-- This collapses the modifier stack as well, which means all the standard
				-- 3dsmax modifiers get copied to any new objects we create.  We have to
				-- handle the MDL modifiers seperately.
				convertToMesh obj

				-- If the boolean operands overlapped, the cut faces will be selected.  We
				-- should detach them into their own object.
				if (obj.selectedFaces.count > 0) then
				(
					local new = copy obj

					-- Give the new object a sane name.
					new.name = obj.name + "_" + two_digit_string ii

					-- Detach the selected faces into the new object.
					new.mesh = meshOp.detachFaces obj obj.selectedFaces asMesh:true
					new.wirecolor = obj.wirecolor
					new.parent = mdl_base

					-- Optionally clean up the vertices.
					if (opt_snap_vertices) then ( snap_vertices new )

					-- Optionally adjust the pivot of the new object.
					if (opt_adjust_pivot) then ( new.pivot = new.center )

					-- Always Reset Transforms on the new object.
					reset_transforms new

					-- Optionally convert polygons to faces, or just collapse the stack.
					if (opt_convert) then (
						convertTo new Editable_Patch
						convertToMesh new
					) else (
						collapsestack new
					)

					-- Optionally test if the new object will cast valid shadows.
					if (opt_test_shadows) then ( errors += test_shadows new )

					-- Copy the modifers to the new object.
					copy_modifiers new orig
				)

				ii += 1
			)
		)

		-- FIXME: Shouldn't do this all the time.
		delete orig
		delete obj
	)

	progressEnd()

	-- Report any errors.
	if (errors > 0) then (
		msg = "Warning: Detected potential shadow problems in " + errors as string + " objects.\n" +
			  "These objects have had their wireframe color changed to the\n" +
			  "color you selected in the Tile Slicer rollout."
		messagebox msg title:title_string
	)

	-- Redraw all views.
	max views redraw
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--
-- Tile Slicer utility.
--
utility roboius_slicer "NWN Tile Slicer" width:162
(
	button slice_button "Slice" width:144
		tooltip:"Slice the selected objects into tile-sized chunks"

	group "Tile Names"
	(
		label lbl_name_1 "Prefix:" align:#left   offset:[0,-4] across:3
		label lbl_name_2 "Pos:"    align:#center offset:[5,-4]
		label lbl_name_3 "Var:"    align:#center offset:[7,-4]

		edittext txt_prefix    ""  fieldwidth:52 text:""    offset:[-5,-2] across:3
		edittext txt_position  "_" fieldwidth:37 text:"A01" offset:[ 8,-2]
		edittext txt_variation "_" fieldwidth:26 text:"01"  offset:[12,-2] bold:true

		dropdownlist ddl_inc_dec "" items:#("Increment","Decrement") width:78 offset:[-1,2] across:2
		dropdownlist ddl_pos_var "" items:#("Position", "Variation") width:66 offset:[ 8,2] selection:2

		checkbox chk_number "Position number only" enabled:false
	)

	group "Group Dimensions"
	(
		spinner spn_rows "Rows:" range:[1,32,rows] type:#integer scale:1
			width:68 align:#right fieldwidth:28 across:2
		spinner spn_cols "Cols:" range:[1,32,cols] type:#integer scale:1
			width:68 align:#right fieldwidth:28 offset:[-3,0]
		button guess_button "Guess" width:144
			tooltip:"Guess the dimensions of the group, using the size of the selected objects"
	)

	group "Group Location"
	(
		checkbox chk_origin "Center is at [0,0]"          checked:opt_origin

		spinner spn_location_x "Bottom Left X:" range:[-100000,100000,location.x]
			type:#worldunits scale:1 align:#right fieldwidth:62 enabled:false
		spinner spn_location_y "Bottom Left Y:" range:[-100000,100000,location.y]
			type:#worldunits scale:1 align:#right fieldwidth:62 enabled:false
	)

	group "Options"
	(
		checkbox chk_lights    "Create tile lights"       checked:opt_create_lights
		checkbox chk_anim      "Create anim nodes"        checked:opt_create_anim

		checkbox chk_snap      "Snap vertices"            checked:opt_snap_vertices
		checkbox chk_pivot     "Adjust pivots"            checked:opt_adjust_pivot
		checkbox chk_convert   "Make TriMesh"             checked:opt_convert

		checkbox chk_shadow    "Test shadow validity"     checked:opt_test_shadows
		colorpicker col_shadow "Color invalid objects:"   enabled:opt_test_shadows
			color:disabled_shadow_color align:#right fieldwidth:20

		checkbox chk_exterior  "Slice exterior edges"     checked:opt_slice_exterior enabled:false
	)

	group "Export Scripts"
	(
		radiobuttons rdo_export ""
			labels:#("BioWare Aurora","MDL Plugin Suite","Wayland's GMax","NWmax") default:4
	)

	-- Tile Names:
	on ddl_inc_dec selected ii do ( opt_increment = (ii == 1) )
	on ddl_pos_var selected ii do
	(
		if (ii == 1) then (
			opt_variation = false
			txt_position.bold = true
			txt_variation.bold = false
			chk_number.enabled = true
		) else (
			opt_variation = true
			txt_position.bold = false
			txt_variation.bold = true
			chk_number.enabled = false
		)
	)
	on chk_number     changed value do ( opt_pos_num_only = value )

	-- Group Dimensions:
	on spn_rows       changed value do ( rows = value )
	on spn_cols       changed value do ( cols = value )

	on guess_button   pressed do
	(
		rows = (((selection.max.y - selection.min.y) / 1000.0) + 0.5) as integer
		cols = (((selection.max.x - selection.min.x) / 1000.0) + 0.5) as integer
		spn_rows.value = rows
		spn_cols.value = cols
	)

	-- Group Location:
	on chk_origin     changed value do
	(
		opt_origin = value
		spn_location_x.enabled = not value
		spn_location_y.enabled = not value
	)

	-- Options:
	on spn_location_x changed value do ( location.x = value )
	on spn_location_y changed value do ( location.y = value )
	on chk_lights     changed value do ( opt_create_lights = value )
	on chk_anim       changed value do ( opt_create_anim = value )
	on chk_snap       changed value do ( opt_snap_vertices = value )
	on chk_pivot      changed value do ( opt_adjust_pivot = value )
	on chk_convert    changed value do ( opt_convert = value )
	on chk_exterior   changed value do ( opt_slice_exterior = value )

	on chk_shadow changed value do
	(
		opt_test_shadows = value
		if (value) then (
			col_shadow.enabled = value
			col_shadow.color = invalid_shadow_color
		) else (
			col_shadow.enabled = false
			col_shadow.color = disabled_shadow_color
		)
	)
	on col_shadow changed value do ( invalid_shadow_color = value )

	-- Export Scripts:
	on rdo_export changed state do
	(
		if (state == 1) then (
			use_aurora = true;  use_mdl_suite = false; use_wayland = false; use_nwmax = false
		) else if (state == 2) then (
			use_aurora = false; use_mdl_suite = true;  use_wayland = false; use_nwmax = false
		) else if (state == 3) then (
			use_aurora = false; use_mdl_suite = false; use_wayland = true;  use_nwmax = false
		) else (
			use_aurora = false; use_mdl_suite = false; use_wayland = false; use_nwmax = true
		)
	)

	-- Slice:
	on slice_button pressed do undo on
	(
		local obj, ret

		-- Make sure we have objects selected.
		if (selection.count == 0) then (
			messagebox "Error: No objects selected!\n" title:title_string
			return 0
		)

		-- Make sure there are no groups in the selected objects.
		for obj in selection do (
			if (isGroupHead obj or isGroupMember obj) then (
				messagebox "Error: Cannot slice grouped objects!\n" title:title_string
				return 0
			)
		)

		-- Make sure we're using the correct version of the MDL Plug-in Suite.
		if (use_mdl_suite) then (
			obj = lighthelper()
			-- Version 1.0 has dynamicType as an integer.
			ret = (obj.dynamictype as string == "false")
			delete obj
			if (ret == false) then (
				msg = "Error: MDL Plug-in Suite version 1.1b2 is required!  It\n" +
					  "looks like you are still using version 1.0 or earlier."
				messagebox msg title:title_string
				return 0
			)
		)

		-- Make sure the user wants to slice a 1x1 tile group.
		if (rows == 1 and cols == 1) then (
			msg = "Warning: You are about to slice a 1x1 group.\n" +
				  "Are you sure this is what you want to do?"
			ret = querybox msg title:title_string
			if (ret == false) then ( return 0 )
		)

		-- Create the list of tile names.
		ret = create_names txt_prefix.text txt_position.text txt_variation.text
		if (ret == false) then ( return 0 )

		-- If the group is centered at the origin, calculate the position.
		if (opt_origin) then (
			location = [cols * -1000 / 2, rows * -1000 / 2, 0]
			format "location = %\r\n" location
		)

		--try (
			-- Slice those tiles!
			slice_tiles()
		--) catch (
		--	messagebox "Fatal Error: Slicing operation failed!"
		--)
	)
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--
-- Stand-alone MDL utilities.
--
utility roboius_mdl_utils "NWN MDL Utilities" width:162
(
	group "MDL Export"
	(
		-- This is only enabled on max 5.0 or newer.
		button export_button   "Batch Export" width:144 enabled:version_5000
			tooltip:"Export all selected MDL helper nodes, just like doing an 'Export Selected' on each one"

		checkbox chk_default   "Use default path" enabled:version_5000
		checkbox chk_overwrite "Overwrite existing files" checked:true enabled:version_5000
	)

	on export_button pressed do
	(
		local dir

		-- Make sure we have objects selected.
		if (selection.count == 0) then (
			messagebox "Error: No objects selected!\n" title:title_string
			return 0
		)

		local selected_objects = selection as array

		-- Get the export directory.
		if (chk_default.checked) then ( dir = getdir #export )
		if (dir == undefined) then ( dir = getSavePath() )
		if (dir == undefined) then ( return 0 )

		-- Slice the selected objects.
		for ii = 1 to selected_objects.count do
		(
			local path, export = true
			local obj = selected_objects[ii]

			-- Skip objects that aren't MDL root nodes.
			if (use_mdl_suite) then (
				if (not iskindof obj Model) then ( export = false )
			) else (
				if (not iskindof obj aurabase) then ( export = false )
			)

			-- Export the file.
			if (export) then (
				path = dir + "\\" + lowercase obj.name + ".mdl"
				format "Exporting %\n" path
				select obj
				if (chk_overwrite.checked) then (
					exportFile path #noPrompt selectedOnly:true
				) else (
					exportFile path selectedOnly:true
				)
				deselect obj
			)
		)
	)

	----------------------------------------------------------------------------
	----------------------------------------------------------------------------

	group "Mesh Utilities"
	(
		button convert_button "Make TriMesh"     width:144
			tooltip:"Convert the selected objects to triangle meshes, particularly useful for walkmesh objects"

		button snap_button    "Snap vertices"    width:144
			tooltip:"Move all vertices in the selected editable mesh objects to the nearest integer coordinates"

		button reset_button   "Reset Transforms" width:144
			tooltip:"Reset transforms on all selected editable mesh objects"

		button flip_button    "Flip Normals"     width:144
			tooltip:"Flip normals on all selected editable mesh objects"

		button weld_button    "Weld Vertices"    width:144
			tooltip:"Weld all vertices on all selected editable mesh objects"
	)

	on convert_button pressed do undo on
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
			copy_modifiers obj orig

			delete orig
		)
	)

	on snap_button pressed do undo on
	(
		for obj in selection do
		(
			if (iskindof obj.baseobject Editable_Mesh) then
			(
				local orig = copy obj

				collapsestack obj
				snap_vertices obj
				copy_modifiers obj orig

				delete orig
			)
			else
			(
				format "Skipping object %, not an Editable Mesh.\n" obj.name
			)
		)
	)

	on reset_button pressed do undo on
	(
		for obj in selection do
		(
			if (iskindof obj.baseobject Editable_Mesh) then
			(
				local orig = copy obj

				-- Reset Transforms on the given object.
				collapsestack obj
				reset_transforms obj
				collapsestack obj

				-- Restore the original modifiers.
				copy_modifiers obj orig

				delete orig
			)
			else
			(
				format "Skipping object %, not an Editable Mesh.\n" obj.name
			)
		)

		-- Redraw all views.
		max views redraw
	)

	on flip_button pressed do undo on
	(
		for obj in selection do
		(
			if (iskindof obj.baseobject Editable_Mesh) then
			(
				-- This is easy.
				meshop.flipnormals obj obj.faces
			)
			else
			(
				format "Skipping object %, not an Editable Mesh.\n" obj.name
			)
		)

		-- Redraw all views.
		max views redraw
	)

	--
	-- This code is based on the "Select and weld ALL verts" functionality
	-- in ChilliSkinner v3.0.2, added by request for Velmar.
	--
	on weld_button pressed do undo on
	(
		for obj in selection do
		(
			if (iskindof obj.baseobject Editable_Mesh) then
			(
				max modify mode
				select obj
				subobjectlevel = 1
				max select all
				meshops.weld obj
				max select none
				subobjectlevel = 0
			)
			else
			(
				format "Skipping object %, not an Editable Mesh.\n" obj.name
			)
		)

		-- Redraw all views.
		max views redraw
	)

	----------------------------------------------------------------------------
	----------------------------------------------------------------------------

	group "MDL Mirror"
	(
		button mirror_button "Mirror Models" width:144
			tooltip:"Mirrors the child nodes of the selected models around the model center"
		radiobuttons rdo_mirror "" labels:#("X","Y") default:1
	)

	fn mirror_point mirror x1 x2 =
	(
		local ret

		if (mirror) then (
			ret = x2 - (x1 - x2)
		) else (
			ret = x1
		)
		return ret
	)

	on mirror_button pressed do undo on
	(
		local axis = rdo_mirror.state - 1

		for mdl in selection do
		(
			if (iskindof mdl Model or iskindof mdl aurabase) then
			(
				-- Hmmm, what about objects linked to the anim node?
				for obj in mdl.children do
				(
					local orig = copy obj
					local x, y, z

					-- Collapse the entire modifier stack.
					collapsestack obj

					-- Mirror the position manually.
					x = mirror_point (axis == 0) obj.pos.x mdl.pos.x
					y = mirror_point (axis == 1) obj.pos.y mdl.pos.y
					z = obj.pos.z

					obj.pos = [x,y,z]

					if (iskindof obj Editable_Mesh) then
					(
						-- Snap vertices on Editable Meshes.
						snap_vertices obj

						-- Add the mirror modifier.
						local m = mirror()
						addmodifier obj m

						m.mirror_axis = axis

						-- Reset Transforms on the given object.
						collapsestack obj
						reset_transforms obj
						collapsestack obj
					)

					-- Restore the original modifiers.
					copy_modifiers obj orig

					delete orig
				)
			)
		)
	)

	----------------------------------------------------------------------------
	----------------------------------------------------------------------------

	group "MDL Lifter"
	(
		button lift_button "Adjust Models" width:144
			tooltip:"Adjust the height of the child objects of all selected MDLs"

		spinner spn_multiple "Multiplier:" range:[-5,5,1]
			type:#integer scale:1 align:#right fieldwidth:48
		spinner spn_height   "Height change:"   range:[0,10000,500]
			type:#worldunits scale:10 align:#right fieldwidth:48
	)

	on lift_button pressed do undo on
	(
		for obj in selection do
		(
			if (iskindof obj Model or iskindof obj aurabase) then
			(
				for child in obj.children do
				(
					child.pos.z = child.pos.z + spn_multiple.value * spn_height.value
				)
			)
		)
	)
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

rollout roboius_ego "About" width:162
(
	label lbl_1 "NWN Tile Slicer v0.10.5"
	label lbl_2 "Gareth Hughes (roboius)"
	label lbl_3 "roboius@dladventures.net"
	label lbl_4 "http://rockbottom.vtex.net"
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

-- Get the version information
version = maxVersion()
version_5000 = (version[1] >= 5000)

-- Grab the background color for when the shadow test is disabled
col = QuadMenuSettings.GetItemBackgroundColor 1 as string
col = filterstring col "( )"
disabled_shadow_color = [col[2] as float, col[3] as float, col[4] as float]

-- Close the old floater
if (roboius_floater != undefined) do
(
	closeRolloutFloater roboius_floater
)

-- Create a new floater
roboius_floater = newRolloutFloater title_string 180 650

addRollout roboius_slicer     roboius_floater
addRollout roboius_mdl_utils  roboius_floater rolledUp:true
addRollout roboius_ego        roboius_floater rolledUp:true
