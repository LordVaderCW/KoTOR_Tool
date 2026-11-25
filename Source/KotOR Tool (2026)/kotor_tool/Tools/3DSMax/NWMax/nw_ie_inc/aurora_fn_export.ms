/*-----------------------------------------------------------------------------\

    Aurora Export Functions

    The exporting of data from the model is based on traversing a tree.
    The model is represented by tree nodes all linked directly or indirectly
    off the model base node. Often referred to as the root.


    NWmax
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

--------------------------------------------------------------------------------
-- Global working vars for exporting
--------------------------------------------------------------------------------
global g_curnode
global g_detonateKeys
global g_RoundOffVertices
global g_ModelName

global g_expprog	-- holds export progress by node/animation

--------------------------------------------------------------------------------
-- Dialogs          
--------------------------------------------------------------------------------
rollout nx_dlg_progress "Export Progress"
(
	local cnt
	local total
	label lbl_status "Exporting Geometry"
	progressBar prg_exporting align:#center
	
	fn reset s =
	(
		cnt = 0.0
		total = s
		prg_exporting.value = 0
	)
	
	fn increment=
	(
		cnt += 1.0
		prg_exporting.value = (((cnt*100)/total) as integer)
	)
	
	fn status s =
	(
		lbl_status.text = s
	)
)


--------------------------------------------------------------------------------
-- Utility functions
--------------------------------------------------------------------------------
fn nx_fprints data =
(
    -- From BioWare
    -- Formated print string in the same vein as C's formated printing
    case of
    (
    	((classof data) == color):
    	(
    		return ( ((data.r/255.0)as string) + " " + \
    		         ((data.g/255.0)as string) + " " + \
    		         ((data.b/255.0)as string) + " " )
        )

    	((classof data) == point3):
    	(
    		return ( (data.x as string) + " " + \
    		         (data.y as string) + " " + \
    		         (data.z as string) + " " )
        )

    	((classof data) == quat):
    		data = data as angleaxis

    	((classof data) == angleaxis):
    	(
    		local a = data.axis
    		return (nx_fprints a + " " + ((degtorad(data.angle)) as string) + " ")
    	)
    )

	return (data as string)
)

fn nx_materialbitmapname mat =
(
    --
    -- Gets the material bitmap name.  If it can't find it then returns NULL
    --
	if(mat == undefined) then
	(
		return "NULL"
	)
	
	if (mat.diffusemap== undefined or mat.diffusemap.filename==undefined) then
	(
		return (mat.name)
	)
	
	return (getfilenamefile mat.diffusemap.filename)
)

--------------------------------------------------------------------------------
-- texture exporting functions
--------------------------------------------------------------------------------

fn nx_copyTextureFiles nodeMaterial node exportdir = (

	type = nodeMaterial.diffusemap as string
	retval = matchPattern type pattern:"*bitmap"
	if (retval == true) then
	(
		local work
	
		-- get path of texture
		tex = nodeMaterial.diffusemap.filename

		if (BitMapNameCheck(node) == 0) then return 0
	
		-- get filename of texture
		filename = nx_lowercase( filenameFromPath tex )

		-- check to make sure source and target aren't the same
		if (tex != (exportdir+"\\"+filename)) then 
		(
			-- convert from windows path to MAX path
			--tex = convertslash tex
			--work = convertslash (getdir #export)
			work = exportdir

			-- check to see if a file already has that filename
			-- in the export directory specified in MAX
			if ((getfiles (work +"/"+ filename)).count != 0) then
			(
				-- check to see if date modified is the same
				if ((getfilemoddate tex) != (getfilemoddate (work+"/"+filename))) then
				(
					str = "The texture \"" + work+"/"+filename + "\"\n"+ 
					"already exists.  Do you want to replace it?"
					
					if ((queryBox str title:"File Exists" beep:true) == false) then
					(
						return 0
					)
					-- need to delete old file before can copy into target
					deleteFile (work+"/"+filename)
				)
			)
			copyFile (tex) (work+"/"+filename)
		)		 
	)
)

-- function to check the current model for textures.  If any are used, copy them
-- to the export directory.  If there is already a file by the same name in the
-- export directory, a dialog will ask the user if they wish to overwrite it.  If
-- the modified date of both files match, then it will skip over that file.

fn nx_getTextures node modelbase = 
(
	-- verify that the current node has a material applied to it
	local texture_exportpath = modelbase.export_path
	
	-- if we are also going to do the dds thing then we want a tga specific dir
	if modelbase.tga2dds == 1 then
	(
		texture_exportpath += "tga"
		-- does this dir exist?
		if not nx_existDir(texture_exportpath) then
		(
			-- dir does not exist so we create it
			if not (makeDir texture_exportpath) then
			(
				-- failure to make dir, abort
				messageBox "Failure to make tga export dir for dds conversion, aborting texture copy"
				return false
			)
		)
	)
	
	if (node.material != undefined) then
	(
		-- verify that the material uses a bitmap for the diffusemap
		if ((classof(node.material) == Multimaterial) or (classof(node.material) == MultiSubmaterial)) then
		(
			for i = 1 to node.material.numsubs do (


				if ((nx_copyTextureFiles node.material[i] node texture_exportpath)  == 0) then return 0
			)
		)
		else
			if ((nx_copyTextureFiles node.material node texture_exportpath) == 0) then return 0

	)
	for i in node.children do
	(
		if ((nx_getTextures i modelbase) == 0) then
			return 0
	)
	return 1

)



--------------------------------------------------------------------------------
-- Specific node oriented functions
--------------------------------------------------------------------------------
function nx_ExSkinweights node =
(
    -- Code from Bioware
	local save_selection = selection
	max modify mode
	select node

	local i,j,zeroWeights
	local m = node.modifiers["skin"]
	try
	(
		local n = skinops.getnumbervertices m
	) catch
	(
		--local n = skinops.getnumbervertices m
		format ";ERROR in nx_ExSkinweights%" g_delim to:g_strBuffer
		nx_FlushBuffer()
		select save_selection
		return 0
	)
	format "%weights %%" strIndent1 n g_delim to:g_strBuffer
	for i = 1 to n do
	(
		local w_num = skinops.getvertexweightcount m i
		local counter = 0
		format "%" strIndent2 to:g_strBuffer
		for j = 1 to w_num do
		(
			local bone_id   = (skinops.getvertexweightboneid m i j )
			local bone_name = "root"
			local weight_i_j = 1
			if(bone_id > 0) do
			(
				--bone_name = (skinops.getbonename m bone_id 0) -- could be 1 or could be 0 UNSURE!!
				bone_name = (skinops.getbonename m bone_id 1)
			)
			weight_i_j = (skinops.getvertexweight m i j )
			if (weight_i_j != 0.0) then (
				format " % % "  bone_name weight_i_j to:g_strBuffer
				counter += 1
			)
		)
		if(( w_num ==0 ) or (counter == 0) ) do
		(
			format " root 1.00 " to:g_strBuffer
		)
		format "%" g_delim to:g_strBuffer
		nx_FlushBuffer()
	)
	if(save_selection != undefined) do
	(
		select save_selection
	)
)


function nx_ExDanglymesh node = (
    -- Code from BioWare & Wayland.
	-- Export the vertex constraints.
	-- The other parameters got exported with the rest of the AuroraPoly stuff
	format "%constraints %%" strIndent1 node.numverts g_delim to:g_strBuffer

	-- Taken from the MAXscript docs....
	--//   The mesh class contains a list of color vertices which are completely independent of the regular vertices
	--// in the mesh. There is no correlation between the number of vertices in a mesh and the number of color
	--// vertices. In addition to the color vertices there are also color faces. There needs to be one color face for
	--// every regular face in the mesh.

	local colourVertIndices, faceIndices
	local colourVerts = #()

	-- collect the colour verts info by face and store in the
	-- colour 'colourVerts' array.
	for i = 1 to node.numfaces do
	(
		colourVertIndices = getVCFace node i
		faceIndices = getFace node i

		colourVerts[faceIndices.x] = getvertcolor node colourVertIndices.x
		colourVerts[faceIndices.y] = getvertcolor node colourVertIndices.y
		colourVerts[faceIndices.z] = getvertcolor node colourVertIndices.z
	)

	-- Work through the colour verts info collected above and out put it.
	local curcolour = color 255 255 255
	for i = 1 to colourVerts.count do
	(
		curcolour = colourVerts[i]

		-- If the colour is white, the vertex is fixed
		if ((curcolour != undefined) and (curcolour != (color 255 255 255))) then
		(
			-- A zero value causes discontinuities in the physics calculations,
			-- therefore we can ignore that case. Also only use one color value
			-- for the constraint. Have picked the first one in the rgb triplet.
			
-- Setting this to 1 when it should be 0 seems to have undesired results. 0 is
-- used to STOP dangly activity so setting to 1 defeats that purpose.
--			if (curcolour.red == 0) then
--				curcolour.red = 1
			format "%%%" strIndent2 (curcolour.red) g_delim to:g_strBuffer
		)
		else (
			format "%0.0%" strIndent2 g_delim to:g_strBuffer
		)
		nx_FlushBuffer()
	)
)


--
-- Original aabb code generation
--
fn BuildAABBTreeNode node facemids facelist level aabbData verbose =
(
    local maxRecursion = 100     -- 10
    -- From Waylands original script
    if (facelist.count == 0) then return 0
    if (level > maxRecursion) then
    (
        MessageBox("AABB Generation: Maximum recursion level reached.  Check for duplicate verticies and/or faces.")
        return 0
    )
    
    local aabbLine = ""    
    
    -- Calculate the size of the bounding box for the face list
    local bot_left = point3 100000.0 100000.0 100000.0
    local top_right = point3 -100000.0 -100000.0 -100000.0
    local midpoint_average = point3 0 0 0
    for i=1 to facelist.count do
    (
        local v3 = getface node.mesh facelist[i]
        local p1 = getvert node.mesh v3.x
        local p2 = getvert node.mesh v3.y
        local p3 = getvert node.mesh v3.z

        -- define the max bounding box for the faces
        -- in 'facelist'
        if (p1.x < bot_left.x) then bot_left.x = p1.x
        if (p1.y < bot_left.y) then bot_left.y = p1.y
        if (p1.z < bot_left.z) then bot_left.z = p1.z

        if (p2.x < bot_left.x) then bot_left.x = p2.x
        if (p2.y < bot_left.y) then bot_left.y = p2.y
        if (p2.z < bot_left.z) then bot_left.z = p2.z

        if (p3.x < bot_left.x) then bot_left.x = p3.x
        if (p3.y < bot_left.y) then bot_left.y = p3.y
        if (p3.z < bot_left.z) then bot_left.z = p3.z

        if (p1.x > top_right.x) then top_right.x = p1.x
        if (p1.y > top_right.y) then top_right.y = p1.y
        if (p1.z > top_right.z) then top_right.z = p1.z

        if (p2.x > top_right.x) then top_right.x = p2.x
        if (p2.y > top_right.y) then top_right.y = p2.y
        if (p2.z > top_right.z) then top_right.z = p2.z

        if (p3.x > top_right.x) then top_right.x = p3.x
        if (p3.y > top_right.y) then top_right.y = p3.y
        if (p3.z > top_right.z) then top_right.z = p3.z

        -- accumulate the midpoints in the faces for
        -- this list of faces
        midpoint_average += facemids[facelist[i]]
    )

    -- Calc the mid-point average for the facelist
    midpoint_average /= facelist.count

    -- calc the box position in 3d space. This basically the centre of the
    -- axis aligned bounding box (aabb)
    local box_pos = (bot_left+top_right)/2

--  format "DEBUG:            % %\r\n" bot_left top_right
	-- postion the aabb in 3d space relative the node
    box_pos.z = bot_left.z
    in coordsys parent ( box_pos += node.pos)

    -- convert to nwn units; meters.
    local bl = bot_left / 100
    local tr = top_right / 100
    -- output the bounding box
    if verbose then format "        % % % % % %" bl.x bl.y bl.z tr.x tr.y tr.z to:g_strBuffer
    aabbLine += (bl.x as string)+" "
    aabbLine += (bl.y as string)+" "
    aabbLine += (bl.z as string)+" "
    aabbLine += (tr.x as string)+" "
    aabbLine += (tr.y as string)+" "
    aabbLine += (tr.z as string)+" "
    if (facelist.count == 1) then   -- box bounds a single face: a leaf
    (
--  display box
--      local b = box pos:box_pos length:(top_right.y-bot_left.y) width:(top_right.x-bot_left.x) height:(top_right.z-bot_left.z)
--      sphere pos:box_pos radius:10

        if verbose then format " %%" (facelist[1]-1) g_delim to:g_strBuffer	-- links box to a specified face
        aabbLine += ((facelist[1]-1) as string)
	    -- update aabb data array
	    append aabbData aabbLine
    )
    else    -- box is a parent as bounds multiple faces
    (
        if verbose then format " -1%" g_delim to:g_strBuffer	-- indicates box is a parent box
        aabbLine += "-1"
	    -- update aabb data array
	    append aabbData aabbLine

        local bb_size = top_right - bot_left
        -- Axis 1=x 2=y 3=z
        -- Identify the longest axis for the bounding box
        local axis = 1
        if (bb_size.y > bb_size.x) then axis = 2
        if (bb_size.z > bb_size.y) then axis = 3

        -- Check exception case, where all points are coplanar with the axis-aligned split plane
        local change_axis = true
        for i=1 to facelist.count do
        (
            p1 = facemids[facelist[i]]
            case axis of
            (
                1: change_axis = change_axis and (p1.x == midpoint_average.x)
                2: change_axis = change_axis and (p1.y == midpoint_average.y)
                3: change_axis = change_axis and (p1.z == midpoint_average.z)
            )
--          format "DEBUG:            % %\r\n" p1 midpoint_average
        )
        if (change_axis) then
        (
            axis += 1
            if (axis > 3) then axis = 1
        )
        
        if DEBUG then format "DEBUG: PROCESS SPLIT LOOP%" g_delim to:g_strBuffer

        local leftside = true
        local good_split = false
        local leftlist = #()
        local rightlist = #()
        
        -- work out the split for the tree: left and right branches
        local axiscnt = 1
        while (not good_split) do
        (
	        if DEBUG then format "DEBUG: No good split found yet%" g_delim to:g_strBuffer
            leftlist = #()
            rightlist = #()
            
            -- split out the faces in facelist to the left and right tree
            -- branches. The split is based on split axis value
            for i=1 to facelist.count do
            (
                p1 = facemids[facelist[i]]
--              format "DEBUG:            % %\r\n" p1 axis
                case axis of
                (
                    1: leftside = (p1.x < midpoint_average.x)
                    2: leftside = (p1.y < midpoint_average.y)
                    3: leftside = (p1.z < midpoint_average.z)
                )
                if (leftside) then
                    append leftlist facelist[i]
                else
                    append rightlist facelist[i]
            )
            
            -- This code tries to make a split that is not down one branch only.
            -- This is probably causing more problems than it is worth.
--            good_split = true   -- force a good split
            if ((leftlist.count > 0) and (rightlist.count >0)) then
            (
                good_split = true
            )
            else
            (
                axiscnt += 1
                axis += 1
                if (axis > 3) then axis = 1
                if (axiscnt > 3) then
                (
                    -- been around all 3 axis and no good split. ERROR!
                    if verbose then format "#ERROR: aabb tree unable to get a split down both branches after testing x,y,z slicing planes.%" g_delim to:g_strBuffer
                    if verbose then format "#Midpoint Average (x,y,z): % % %%" midpoint_average.x midpoint_average.y midpoint_average.z g_delim to:g_strBuffer
                    if verbose then format "#Facelist: %%" facelist g_delim to:g_strBuffer
                    --if verbose then format "#Facemids: %%" facemids g_delim to:g_strBuffer
                    nx_FlushBuffer()
                    append aabbData "#ERROR: aabb split problem."
                    for f in facelist do
                    (
	                    append aabbData ("#  face: "+(f as string))
                    )
                    append aabbData "#ERROR-END"
                    
                    --messageBox ("ERROR: aabb tree unable to get a split down both branches.")
                    return 0
                )
            )
        )

        if DEBUG then format "Recursive calls%" g_delim to:g_strBuffer
        
        -- Flush buffer before diving down tree
        nx_FlushBuffer()
        
        -- Recursive calls
        BuildAABBTreeNode node facemids leftlist (level+1) aabbData verbose
        BuildAABBTreeNode node facemids rightlist (level+1) aabbData verbose
    )
        
)

fn WriteAABBTree node verbose:false =
(
    -- From Waylands original script
    local facemids =#()
    local facelist = #()
    local aabbData = #()
    if ((mod node.mesh.numfaces 2) == 1) then
    (
        --MessageBox("Odd number of faces in AABB tree.  Expect problems.");
    )
    for i=1 to node.mesh.numfaces do
    (
        v3 = getface node.mesh i
        p1 = getvert node.mesh v3.x
        p2 = getvert node.mesh v3.y
        p3 = getvert node.mesh v3.z
        mid = (p1+p2+p3) / 3
        append faceMids mid
        append facelist i
    )

    if verbose then format "    aabb " to:g_strBuffer -- no newline here, NWN chokes if the data doesn't start on the same line
    BuildAABBTreeNode node faceMids facelist 0 aabbData verbose
    return aabbData
)

fn ExportAABBTree node =
(
    if SPEEDT then nx_startStopWatch txt:"ExportAABBTree"
    
	local aabbmod = node.modifiers["AuroraWalkmesh"]
	if (aabbmod == undefined) then (
		str =  "ERROR: no AuroraWalkmesh modifier found on: " + node.name
		messageBox str
		return 0
	)
	if (aabbmod.ig_recalc == 1) and (aabbmod.ig_multimode == 0) then (
		local b = WriteAABBTree node verbose:false
		aabbmod.ig_boxes = #()
		aabbmod.ig_boxes.count=0 
		local p
		for p in b do (
			aabbmod.ig_boxes[aabbmod.ig_boxes.count+1] = p
		)
	) else if (aabbmod.ig_recalc == 0) and (aabbmod.ig_multimode == 0) then
	(
    	local i
    	format "aabb " to:g_strBuffer
    	for i = 1 to aabbmod.ig_boxes.count do (
    		format "  %%" aabbmod.ig_boxes[i] g_delim to:g_strBuffer
    		nx_FlushBuffer()
    	)
	) else
	(
    	WriteAABBTree node verbose:true
	)
	
    if SPEEDT then nx_stopStopWatch txt:"ExportAABBTree"
)


fn Ex3DOrientation node =
(
    if DEBUG then format "Ex3DOrientation::do %%" node.name g_delim to:g_strBuffer
    -- From Wayland's original script
    
    if DEBUG then (
        format "Data before 'in coordsys parent block'%" g_delim to:g_strBuffer
        format "objPos=%%" (at time 0 node.pos) g_delim to:g_strBuffer
    )
    
    in coordsys parent
    (
        if DEBUG then (
            format "Data in the 'in coordsys parent block'%" g_delim to:g_strBuffer
            format "objPos=%%" (at time 0 node.pos) g_delim to:g_strBuffer
        )
        -- aurora engine scale is covered by the Trimesh modifier
        --local objScale = at time 0 node.scale;
        local objPos = at time 0 node.pos;
        objPos *= 0.01  -- scale the model down by 100 to make it in meters
        local objRot = at time 0 node.rotation;

        -- Users should really apply an XForm to all p2p emitters, but in case
        -- they have forgotten we try to correct the emitters rotation
        -- back to 0 degrees.
        if ((nx_strclassof node) == "auroraemitter") and \
           (node.modifiers["XForm"]==undefined) then
               objRot += quat -180 (point3 1 0 0);
        -- MAXScript vector normalisation is not producing results consistent with the source file,
        -- but is the over all result the same?  Looks ok when viewed and seems to behave ok.
        local rotVector = normalize (point3 -objRot.x -objRot.y -objRot.z)
        local angle = -degToRad(objRot.angle)

        format "%position % % %%" strIndent1 objPos.x objPos.y objPos.z g_delim to:g_strBuffer
        format "%orientation % % % %%" strIndent1 rotVector.x rotVector.y rotVector.z angle g_delim to:g_strBuffer
        -- aurora engine scale is covered by the Trimesh modifier
        --format "%scale %\r\n" strIndent1 objScale.x
    )
    if DEBUG then format "Ex3DOrientation::End%" g_delim to:g_strBuffer
    
    nx_FlushBuffer()
)


fn ExAuroraPoly node =
(
    -- output the modifier data held against a node.
    -- We only do anything for aurora trimesh modifiers here.
    -- Helpers get their props dumped in another function.
    if DEBUG then format "#ExAuroraPoly%" g_delim to:g_strBuffer
    
    -- material prop over-ride list
    mat_prop_over_ride = #("ambient","diffuse","specular","shininess")
    
	for modifier in node.modifiers do
	(
		if (modifier.name=="AuroraTrimesh") or \
		   (modifier.name=="AuroraFlex") then
		(
           	for thisProp in (getpropnames modifier) do
           	(
        		if ((thisProp as string) == "tilefadeprop") then
        		(
        			local thisProp_val = getproperty modifier thisProp
        			local val
        			case thisProp_val of
        			(
                        1: val = 0
            			2: val = 1
            			3: val = 4
            			4: val = 2
            			default: val = 0
        			)
        			format "%tilefade %%" strIndent1 val g_delim to:g_strBuffer
        		) else if ((thisProp as string) == "alpha") then
        		(
            		-- process alpha tag support. Used to drive off the mat. Now only comes
            		-- from the trimesh modifer data. Makes it easier to animate and makes more
            		-- sense to "hardcore" users. Yes Mirko I have been listening. ;-)
            		--local alpha
            		--local mat = node.material
            		--if mat != undefined then (
	            	--	-- test for multimaterial
	            	--	if (iskindof mat Multimaterial) then
	            	--	(
		            --		mat = mat[(getFaceMatID node.mesh 1)]
	            	--	)
                	--	alpha = mat.opacity / 100.0
            		--) else (
            		alpha = modifier.alpha
            		--)
            		format "%alpha %%" strIndent1 alpha g_delim to:g_strBuffer
        		) else if	((thisProp as string) == "gizmo") or \
        					((thisProp as string) == "extra_mat_data") then
        		(
	        		-- do nothing as we done want to export out the gizmo entry
        		) else if (findItem mat_prop_over_ride (thisProp as string) != 0) then
        		(
	        		if modifier.extra_mat_data == 1 then
	        			format "%% %%" strIndent1 (thisProp as string) (nx_fprints (getproperty modifier thisProp)) g_delim to:g_strBuffer
        		) else
        		(
        			format "%% %%" strIndent1 (thisProp as string) (nx_fprints (getproperty modifier thisProp)) g_delim to:g_strBuffer
    			)
    			
    			nx_FlushBuffer()
        	) -- end for 'thisprop'
		) -- end if
		-- special case for Skins where there might be no trimesh modifier BUT
		-- there is a material with an opacity (alpha) value present.
		-- This should never be called if you construct your models correctly,
		-- but in case someone does it 'the old way' for a skin this covers it.
		if (modifier.name == "Skin") and (node.modifiers["AuroraTrimesh"] == undefined) then
		(
			local alpha
			local mat = node.material
			if mat != undefined then
			(
        		-- test for multimaterial
        		if (iskindof mat Multimaterial) then
        		(
            		mat = mat[(getFaceMatID node.mesh 1)]
        		)
	    		alpha = mat.opacity / 100.0
	    		format "%alpha %%" strIndent1 alpha g_delim to:g_strBuffer
			)
			nx_FlushBuffer()
		)
	) -- end for 'modifier'
    if DEBUG then format "#ExAuroraPoly:: End%" g_delim to:g_strBuffer
)


fn ExAuroraTrimesh mesh name mat wkmesh:false =
(
    --
    -- Build the mesh
    -- Covers:
    -- * bitmap name
    -- * verts
    -- * faces
    -- * tverts
    -- * colors
    --
    -- This code is taken from Bioware's export script. It has been modified
    -- to suit the NWmax code structure and has been cross checked with
    -- Wayland's code to check for consistency.
    --
    -- Params:
    -- mesh = the mesh obj
    -- name = ??? used ???
    -- mat = the material

    if DEBUG then format "#ExAuroraTrimesh % % %%" mesh name mat g_delim to:g_strBuffer
    if SPEEDT then nx_startStopWatch txt:"ExAuroraTrimesh"
    
	local i,v,f;
	local bitmapname

	-- determine bitmapname
	if mat == undefined then
		bitmapname = "NULL"
	else
		bitmapname = nx_materialbitmapname(mat)

	format "%bitmap %%" strIndent1 bitmapname g_delim to:g_strBuffer

	-- build vertice entry
	format "%verts %%" strIndent1 mesh.numverts g_delim to:g_strBuffer
	for i=1 to mesh.numverts do
	(
		local v,x,y,z
		local round,round_result
		v = getvert mesh i
		-- We round to the nearest centimetre before converting to metres
		-- MAXscript doesn't have a round function, so we make our own
		if (g_RoundOffVertices == true) then
            v = nx_roundp3 v
		x = v.x
		y = v.y
		z = v.z
		x = x * 0.01 -- convert to application unit length (meters)
		y = y * 0.01
		z = z * 0.01
		format "%% % %%" strIndent2 x y z g_delim to:g_strBuffer
		nx_FlushBuffer()
	)

	-- build faces entry
	format "%faces %%" strIndent1 mesh.numfaces g_delim to:g_strBuffer
	for i=1 to mesh.numfaces do
	(
		local f, v0, v1, v2 ,s ,t0,t1,t2,matid
		f = getface mesh i
		-- remember to subtract 1 since maxscript indexes from 1 instead of 0
		v0 = (f.x as integer) - 1  -- fix the index by 1 problem
		v1 = (f.y as integer) - 1
		v2 = (f.z as integer) - 1
		s  = getFaceSmoothGroup mesh i
		t0=0
		t1=0
		t2=0
		if wkmesh then (
			matid = 7	-- no walk
		) else (
			matid=getfacematid mesh i
		)
		if matid == 65536 then matid = 0	-- if the value is 65536 then there is no matid assigned
		if(mesh.numtverts>0) do
		(
			local f
			tvf = gettvface mesh i
			t0 = (tvf.x as integer) - 1
			t1 = (tvf.y as integer) - 1
			t2 = (tvf.z as integer) - 1
		)
		format  "%% % %  %  % % %  %%" strIndent2 v0 v1 v2  s  t0 t1 t2 matid g_delim to:g_strBuffer
		nx_FlushBuffer()
	)
	-- determine uv coordinate correction
	local clipu,clipv,clipw,cliph
	clipu=0
	clipv =0
	clipw=1
	cliph=1
	if(mat != undefined and mat.diffusemap!= undefined ) then
	(
		clipu = mat.diffusemap.clipu
		clipv = mat.diffusemap.clipv
		clipw = mat.diffusemap.clipw
		cliph = mat.diffusemap.cliph
		-- it might be upside down since
		-- from the aura exporter we had a line like the following:
		clipv = 1 - clipv - cliph
	)

	-- export texture coordinates if they exist
	if(mesh.numtverts >0) do
	(
		format "%tverts %%" strIndent1 mesh.numtverts g_delim to:g_strBuffer
		for i=1 to mesh.numtverts do
		(
			local v
			v = gettvert mesh i
-- z of 0 looks odd based on data from Manticore model
			format "%% % 0%" strIndent2 (v.x*clipw + clipu) (v.y*cliph + clipv) g_delim to:g_strBuffer
			nx_FlushBuffer()
		)
	)

	/*

	Not sure that this is actually require.  Wayland's script does not seem to
	make any use of colors on verts other than to calc the constraints for a
	danglymesh.  Will keep it in here comment at this point just in case ...

	if (mesh.numcpvverts > 0) then
	(
		-- Taken from the MAXscript docs....
		--//   The mesh class contains a list of color vertices which are completely independent of the regular vertices
		--// in the mesh. There is no correlation between the number of vertices in a mesh and the number of color
		--// vertices. In addition to the color vertices there are also color faces. There needs to be one color face for
		--// every regular face in the mesh.

		local colourVertIndices, faceIndices
		local colourVerts = #()

		-- build up the color vetices
		for i=1 to mesh.numfaces do
		(
			colourVertIndices = getVCFace mesh i
			faceIndices = getFace mesh i

			colourVerts[faceIndices.x] = getvertcolor mesh colourVertIndices.x
			colourVerts[faceIndices.y] = getvertcolor mesh colourVertIndices.y
			colourVerts[faceIndices.z] = getvertcolor mesh colourVertIndices.z
		)

		--
		-- Not sure if color should be goiing out when the mesh has a
		-- Flex modifier
		--
		-- export the color vertices
		format "  colors %\r\n" colourVerts.count
		for i = 1 to colourVerts.count do
		(
			-- If you read the above passage from the MXS docs, you'll note that it implies that
			-- not all sequential colour vertices are necessarily valid, requiring the following
			-- check
			if (colourVerts[i] == undefined) then
				colourVerts[i] = color 255 255 255
			format "     % % %\r\n" (colourVerts[i].red/255.0) (colourVerts[i].green/255.0) (colourVerts[i].blue/255.0)
		)

	)
	*/
    if DEBUG then format "#ExAuroraTrimesh:: End%" g_delim to:g_strBuffer
    if SPEEDT then nx_stopStopWatch txt:"ExAuroraTrimesh"
)


--------------------------------------------------------------------------------
-- Recursive tree walkers, by node
--------------------------------------------------------------------------------
-------------------------------------------------
-- Function to process Dummy Nodes
-------------------------------------------------
function do_dummy node iswalkmesh:false =
(
	if DEBUG then format "#do_dummy::on %%" node.name g_delim to:g_strBuffer

	local parent = "NULL"
	-- get the parent name and put to listener
	if(node.parent != undefined ) then parent = node.parent.name

	-- if this is a walkmesh then we need to modify the parent node string
	if iswalkmesh then
	(
    	if (nx_strclassof (node.parent)) == "aurorabase" then
    	    parent = node.name
	)
	format "%parent %%" strIndent1 parent g_delim to:g_strBuffer

	-- default position and rotation except for aurora base
	if((nx_strclassof node) != "aurorabase") then
	(
    	if DEBUG then format "node pos=%%" (at time 0 node.pos) g_delim to:g_strBuffer
    	
		Ex3DOrientation node
		local wcolor = node.wirecolor
		format "%wirecolor %%"  strIndent1 (nx_fprints wcolor) g_delim to:g_strBuffer
	)
	nx_FlushBuffer()
	ExAuroraPoly node
	
	if DEBUG then format "#do_dummy::End%" g_delim to:g_strBuffer
) -- end fn

-------------------------------------------------
-- Function to process out the nodes properties
-------------------------------------------------
function dump_node_properties node =
(
	if DEBUG then format "#dump_node_properties%" g_delim to:g_strBuffer

	-- Filter array of strings for properties we DON'T want
	local invalidProps = #("cone_angle_manipulator","gizmo", \
							"twosidedtext", "chunk", "chunky", "iconsize", \
							"sanity_check", "sanity_tests", "copy_tga", "tga2dds", "sanityok")
	local propStr
	local propVal

	for prop in (getpropnames node) do
	(
    	-- We will need to perform some filtering on what
    	-- properties we want to output
     	if (findItem invalidProps (nx_lowercase (prop as string))) == 0 then
       	(
		  	propStr = prop as string
		  	propVal = (getproperty node prop)
		  	if (getproperty node prop) != undefined then
		  	(
			  	-- special case processing required
			  	case of
			  	(
				  	((propStr == "spread") or (propStr == "deadspace")):
				  	(
					  	format "%% %%" strIndent1 propStr (nx_fprints (degtorad propVal)) g_delim to:g_strBuffer
				  	)
				  	
				  	(propStr == "chunkName"):
				  	(
					  	-- we only put out chunkName if it is not a "NULL" value
					  	if propVal != "NULL" then (
						  	format "%% %%" strIndent1 propStr (nx_fprints propVal) g_delim to:g_strBuffer
					  	)
				  	)
				  	
				  	default: format "%% %%" strIndent1 propStr (nx_fprints propVal) g_delim to:g_strBuffer
			  	)
			)
			else
			(
				format "%#% %%" strIndent1 propStr (nx_fprints propVal) g_delim to:g_strBuffer
	        )
			nx_FlushBuffer()
	    )
	)
	if DEBUG then format "#dump_node_properties:: End%" g_delim to:g_strBuffer
) -- end fn
-------------------------------------------------
-- Function to process common trimesh data
-------------------------------------------------
function do_trimesh node wkmesh:false =
(
    -- Code from Bioware's scripts with some enhancements/corrections
    -- based on data from Wayland's scripts and my own checking.
    if DEBUG then format "#do_trimesh%" g_delim to:g_strBuffer
    
    local tmod = node.modifiers["AuroraTrimesh"]
    local mat_over_ride = 0
    if tmod != undefined then
    (
	    mat_over_ride = tmod.extra_mat_data
    )

	-- Verts in 'node' are in worldspace but 'node.mesh' gives a mesh 
	-- in object space which we use to export
	local mat = node.material
	if((nx_strclassof mat) == "Multimaterial") then
	(
		format "%multimaterial %%"  strIndent1 mat.count g_delim to:g_strBuffer
		local mesh
		for mesh in mat do (
			format "%%%"  strIndent2 (nx_materialbitmapname(mesh)) g_delim to:g_strBuffer
			nx_FlushBuffer()
		)
		-- we should work out what the correct material is based on the vertex.
		-- We use the first face in the mesh and get that mat id as the index
		-- into the multimaterial.
		mat = mat[(getFaceMatID node.mesh 1)]
		--mat = undefined
	)
	if(mat != undefined) and (mat_over_ride == 0) then
	(
		local a = mat.ambient
		local d = mat.diffuse
		local sp = mat.specular * (mat.specularlevel/100.0)
		local sh = mat.glossiness
		local illum = mat.selfillumcolor
		format "%ambient %%"  strIndent1 (nx_fprints a) g_delim to:g_strBuffer
		format "%diffuse %%"  strIndent1 (nx_fprints d) g_delim to:g_strBuffer
		format "%specular %%"  strIndent1 (nx_fprints sp) g_delim to:g_strBuffer
		format "%shininess %%"  strIndent1 (nx_fprints sh) g_delim to:g_strBuffer
		-- self illum is now driven only from the trimesh modifier
		--format "%selfillumcolor %%" strIndent1 (nx_fprints illum) g_delim to:g_strBuffer
		
        --local alpha = mat.opacity / 100.0
		-- alpha is driven from the trimesh modifier on export
        --format "%alpha %%" strIndent1 alpha g_delim to:g_strBuffer
        nx_FlushBuffer()
	)
	-- export out the trimesh verts etc.
	-- NOTE: We pass a mesh to this function and the mesh has verts in
	--       object space.
	ExAuroraTrimesh node.mesh node.name mat wkmesh:wkmesh
    if DEBUG then format "#do_trimesh:: End%" g_delim to:g_strBuffer
) -- end fn

-------------------------------------------------
-- Function to process Tile trimesh data
-------------------------------------------------
struct parentPosRot
(
    pDeltaPos,
    pRot
)
function do_tiletrimesh dnode parentDeltaPos parentRot =
(
    if DEBUG then format "#START: do_tiletrimesh%" g_delim to:g_strBuffer

    -- make sure the controllers on this node are linear. This is important
    -- for the code later in this function
    if dnode.rotation.controller != linear_rotation() then dnode.rotation.controller = linear_rotation()
    if dnode.pos.controller != linear_position() then dnode.pos.controller = linear_position()
    
    -- Code from Bioware's scripts
    -- Takes care of sparkly-bit removal for tiles. It basically
    -- removes all rotations from the object and applies them directly
    -- to the vertices, thus removing that responsibility from the engine.
    -- It then rounds off the vertices to the nearest centimetre.

	local deltaPos = (point3 0.0 0.0 0.0)
	local deltaRot = (quat 0.0 0.0 0.0 1.0)
	local p = dnode.controller.position

	p = nx_roundp3 p
	
	deltaPos = dnode.controller.position - p
	deltaPos = deltaPos + parentDeltaPos
	deltaRot = dnode.controller.rotation + parentRot
	-- export parent
	local parent = "NULL"
	if(dnode.parent != undefined ) then parent = dnode.parent.name
	format "%parent %%" strIndent1 parent g_delim to:g_strBuffer

	if DEBUG then format "#do_tiletrimesh: pos and rot%" g_delim to:g_strBuffer
	-- default position and rotation
	if((nx_strclassof dnode)!="aurorabase") then (
		p = p*0.01  -- convert to application unit length (meters)
		format "%position % % %%" strIndent1 p.x p.y p.z g_delim to:g_strBuffer

		local r = quat 0.0 0.0 0.0 1.0
		local a = r.axis
		-- the following sign contains a "-" sign to rotate the opposite way
		format "%orientation  % % %  %%" strIndent1 a.x a.y a.z (-degtorad(r.angle)) g_delim to:g_strBuffer

		local c = dnode.wirecolor
		format "%wirecolor %%" strIndent1 (nx_fprints c) g_delim to:g_strBuffer
	)
	nx_FlushBuffer()
	-- Dump trimesh modifier properties
	ExAuroraPoly dnode

	if DEBUG then format "#do_tiletrimesh: process materials%" g_delim to:g_strBuffer
	-- Process the materials data
	local mat = dnode.material
	if(classof(mat) == Multimaterial ) then
	(
		format "%multimaterial %%" strIndent1 mat.count g_delim to:g_strBuffer
		local m
		for m in mat do
		(
			format "%%%" strIndent2 (nx_materialbitmapname(m)) g_delim to:g_strBuffer
			nx_FlushBuffer()
		)
		
		-- we should work out what the correct material is based on the vertex.
		-- We use the first face in the mesh and get that mat id as the index
		-- into the multimaterial.
		mat = mat[(getFaceMatID dnode.mesh 1)]
	)
    local tmod = dnode.modifiers["AuroraTrimesh"]
    local mat_over_ride = 0
    if tmod != undefined then
    (
	    mat_over_ride = tmod.extra_mat_data
    )

	if(mat != undefined) and (mat_over_ride == 0) then (
		local a = mat.ambient
		local d = mat.diffuse
		local sp = mat.specular * (mat.specularlevel/100.0)
		local sh = mat.glossiness
		local illum = mat.selfillumcolor
		format "%ambient %%" strIndent1 (nx_fprints a) g_delim to:g_strBuffer
		format "%diffuse %%" strIndent1 (nx_fprints d) g_delim to:g_strBuffer
		format "%specular %%" strIndent1 (nx_fprints sp) g_delim to:g_strBuffer
		format "%shininess %%" strIndent1 (nx_fprints sh) g_delim to:g_strBuffer
		-- selfillum is now driven solely from the trimesh modifier
		--format "%selfillumcolor %%" strIndent1 (nx_fprints illum) g_delim to:g_strBuffer
		
		-- alpha is driven from the trimesh modifier on export. See ExAuroraPoly
        --local alpha = mat.opacity / 100.0
        --format "  alpha %%" alpha g_delim to:g_strBuffer
        nx_FlushBuffer()
	)
	
    -- The following is essentially standard mesh exporting with
    -- some modifications for Tile specific stuff
    if DEBUG then format "#do_tiletrimesh: mesh exporting%" g_delim to:g_strBuffer
	local i
	local nodeMesh = dnode.mesh
	format "%bitmap %%" strIndent1 (nx_materialbitmapname(mat)) g_delim to:g_strBuffer
	format "%verts %%" strIndent1 nodeMesh.numverts g_delim to:g_strBuffer
	for i=1 to nodeMesh.numverts do
	(
		local v,x,y,z
		local p3
		local round,round_result
		v = in coordsys local getvert nodeMesh i
		v = v + deltaPos
		if (deltaRot.angle != 0.0) then	v = v * deltaRot
		
		-- round
		v = nx_roundp3 v
		x = v.x
		y = v.y
		z = v.z
		-- convert to application unit length (meters) 
		x = x * 0.01 
		y = y * 0.01
		z = z * 0.01
		format "%% % %%" strIndent2 x y z g_delim to:g_strBuffer
		nx_FlushBuffer()
	)
	
	format "%faces %%" strIndent1 nodeMesh.numfaces g_delim to:g_strBuffer
	for i=1 to nodeMesh.numfaces do (
		local f, v0, v1, v2 ,s ,t0,t1,t2,matid
		f = getface nodeMesh i
		-- remember to subtract 1 since maxscript indexes from 1 instead of 0
		v0 = (f.x as integer) - 1  -- fix the index by 1 problem
		v1 = (f.y as integer) - 1
		v2 = (f.z as integer) - 1
		s  = getFaceSmoothGroup nodeMesh i
		t0=0
		t1=0
		t2=0
		matid=getfacematid nodeMesh i
		if(nodeMesh.numtverts>0) then (
			local f
			tvf = gettvface nodeMesh i
			t0 = (tvf.x as integer) - 1
			t1 = (tvf.y as integer) - 1
			t2 = (tvf.z as integer) - 1
		)
		format  "%% % %  %  % % %  %%" strIndent2 v0 v1 v2  s  t0 t1 t2 matid g_delim to:g_strBuffer
		nx_FlushBuffer()
	)
	
	-- determine uv coordinate correction
	local clipu,clipv,clipw,cliph
	clipu=0
	clipv =0
	clipw=1
	cliph=1
	if(mat != undefined and mat.diffusemap!= undefined ) then (
		clipu = mat.diffusemap.clipu
		clipv = mat.diffusemap.clipv
		clipw = mat.diffusemap.clipw
		cliph = mat.diffusemap.cliph
		clipv = 1 - clipv - cliph
	)

	-- export texture coordinates if they exist
	if(nodeMesh.numtverts >0) then
	(
		format "%tverts %%" strIndent1 nodeMesh.numtverts g_delim to:g_strBuffer
		for i=1 to nodeMesh.numtverts do (
			local v
			v = gettvert nodeMesh i
			format "%% % 0%" strIndent2 (v.x*clipw + clipu) (v.y*cliph + clipv) g_delim to:g_strBuffer
			nx_FlushBuffer()
		)
	)
	
	/*
	not sure of this is needed as not in other scripts. Will keep around just in
	case ...
	
	if (nodeMesh.numcpvverts > 0) then
	(
		-- Taken from the MAXscript docs....
		--//   The mesh class contains a list of color vertices which are completely independent of the regular vertices
		--// in the mesh. There is no correlation between the number of vertices in a mesh and the number of color
		--// vertices. In addition to the color vertices there are also color faces. There needs to be one color face for
		--// every regular face in the mesh.

		local colourVertIndices, faceIndices
		local colourVerts = #()

		for i=1 to nodeMesh.numfaces do
		(
			colourVertIndices = getVCFace nodeMesh i
			faceIndices = getFace nodeMesh i

			colourVerts[faceIndices.x] = getvertcolor nodeMesh colourVertIndices.x
			colourVerts[faceIndices.y] = getvertcolor nodeMesh colourVertIndices.y
			colourVerts[faceIndices.z] = getvertcolor nodeMesh colourVertIndices.z
		)

		format "  colors %%" colourVerts.count
		for i = 1 to colourVerts.count do
			format "     % % %\r\n" (colourVerts[i].red/255.0) (colourVerts[i].green/255.0) (colourVerts[i].blue/255.0)
	)
	*/
	
	if DEBUG then format "#END: do_tiletrimesh%" g_delim to:g_strBuffer
	
    -- Return the the delta data to the caller for reuse in subsequent calls
    return (parentPosRot deltaPos deltaRot)
) -- end fn

-------------------------------------------------
-- Function to process master Node Geometry data
-------------------------------------------------
fn Node_Geometry node type:"mdl" isTile:false prntDeltaPos: prntRot: =
(
    /*
       A mix of My, Waylands and Bioware's code.
       
       Must deal with all the node types. These include:
       * dummy's (dummy, lights, emitters, references)
       * skin
       * danglymesh
       * trimesh

       Parameters:
       node = node to operate on
       type = optional param. Type of file being generated.
              valid types: mdl, wok, pwk, dwk
    */

    if DEBUG then format "#Node_Geometry: % of type %%" node.name (classof node) g_delim to:g_strBuffer
    if DEBUG then format "#Node_Geometry:: type=%%" type g_delim to:g_strBuffer
    if DEBUG then format "#Node_Geometry:: isTile=%%" isTile g_delim to:g_strBuffer

    -- Any local vars
    local struc_parentPosRot    -- struct of parentPosRot
    -- if we have the data then package it up for later use by tile exporting functions
    if prntDeltaPos != unsupplied and prntRot != unsupplied then
        struc_parentPosRot = parentPosRot prntDeltaPos prntRot
    
	--
	-- Work out what type of node we have here
	--
    local node_class = (nx_strclassof node)
    local node_superclass = ((superclassof node) as string)
    case of
    (
    	((node_class == "auroralight") or (node_class == "auroraDlight")): node_type = "light"
    	-------------//-------------
    	(node_class == "auroraemitter"): node_type = "emitter"
    	-------------//-------------
    	(node_class == "aurorareference"): node_type = "reference"
    	-------------//-------------
    	(node_class == "Dummy"):
    	(
        	node_type = "dummy"
        	if(node.modifiers["AuroraPlaceable"] !=undefined) then
        	(
            	case (node.modifiers["AuroraPlaceable"].meshtype) of
            	(
            	    1: node_type = "pwk_dummy"
            	    2: node_type = "dwk_dummy"
        	    )
        	)
    	)
    	-------------//-------------
    	(node_superclass == "GeometryClass"):
    	(
        	case of
        	(
	        	(type == "dwk"): node_type = "dwk"
	        	-------------==-------------
	        	(type == "pwk"): node_type = "pwk"
	        	-------------==-------------
            	(node.modifiers["AuroraAniMesh"] !=undefined): node_type = "animmesh"
            	-------------==-------------
            	(node.modifiers["AuroraPlaceable"] !=undefined):
            	(
                	case (node.modifiers["AuroraPlaceable"].meshtype) of
                	(
                	    1: node_type = "pwk"
                	    2: node_type = "dwk"
            	    )
            	)
            	-------------==-------------
            	(node.modifiers["AuroraWalkmesh"] !=undefined):
            	(
                	case (node.modifiers["AuroraWalkmesh"].meshtype) of
                	(
                    	1: node_type = "aabb"
                    	2: node_type = "pwk"
                    	3: node_type = "dwk"
                	)
            	)
            	-------------==-------------
            	(node.modifiers["AuroraFlex"] != undefined): node_type = "danglymesh"
            	-------------==-------------
            	(node.modifiers["AuroraBFlex"] != undefined): node_type = "danglymesh"
            	-------------==-------------
            	(node.modifiers["skin"] != undefined): node_type = "skin"
            	-------------==-------------
            	default: node_type = "trimesh"
        	)
    	)
    	-------------//-------------
    	default:
    	(
        	node_type = "dummy"
        	if(node.modifiers["AuroraPlaceable"] !=undefined) then
        	(
            	case (node.modifiers["AuroraPlaceable"].meshtype) of
            	(
            	    1: node_type = "pwk_dummy"
            	    2: node_type = "dwk_dummy"
        	    )
        	)
    	)
    )
    if DEBUG then format "#Node_Geometry:: node_type=%%" node_type g_delim to:g_strBuffer
    -- Filter activity based on the 'only_nodetype' filter value.
    -- This really relates to aabb, pwk & dwk nodes that need to get put into
    -- own files.  NB: AABB node also goes in with the mdl file for tiles.

    -- act on the node type
    case of
    (
    	((node_type=="dummy") and \
    	((type == "mdl") or (type == "pwk") or (type == "dwk"))):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="light")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            -- lights have all their data held on the helper obj
            -- so process for it. Color is a special case that we deal with here
                
        	local c = node.rgb
        	local r = node.radius * 0.01
        
        	format "  radius %%" r g_delim to:g_strBuffer
        	format "  multiplier %%" node.multiplier g_delim to:g_strBuffer
            if node.negativeLight == 1 then
	            format "  color %%" (nx_fprints -c) g_delim to:g_strBuffer
            else
                format "  color %%" (nx_fprints c) g_delim to:g_strBuffer
                
    		format "  ambientonly %%" node.ambientOnly g_delim to:g_strBuffer
    		format "  nDynamicType %%" node.nDynamicType g_delim to:g_strBuffer
    		format "  affectDynamic %%" node.affectDynamic g_delim to:g_strBuffer
    		format "  shadow %%" node.Shadow g_delim to:g_strBuffer
    		format "  lightpriority %%" node.lightpriority g_delim to:g_strBuffer
    		format "  fadingLight %%" node.fadingLight g_delim to:g_strBuffer
    		
    		--used??
--    		format "  lensflares %\r\n" node.lensflares

			-- If there are flares, process for them
			if node.lens_flares.count > 0 then
			(
				local flare		-- for processing flares
				local tokens	-- for parsed flare string
				format "  flareradius %%" node.flareRadius g_delim to:g_strBuffer
				format "  texturenames %%" node.lens_flares.count g_delim to:g_strBuffer
				for flare in node.lens_flares do
				(
					tokens = filterString flare " "
					format "    %%" tokens[1] g_delim to:g_strBuffer
				)
				format "  flaresizes %%" node.lens_flares.count g_delim to:g_strBuffer
				for flare in node.lens_flares do
				(
					tokens = filterString flare " "
					format "    %%" tokens[2] g_delim to:g_strBuffer
				)
				format "  flarepositions %%" node.lens_flares.count g_delim to:g_strBuffer
				for flare in node.lens_flares do
				(
					tokens = filterString flare " "
					format "    %%" tokens[3] g_delim to:g_strBuffer
				)
				format "  flarecolorshifts %%" node.lens_flares.count g_delim to:g_strBuffer
				for flare in node.lens_flares do
				(
					tokens = filterString flare " "
					format "    % % %%" tokens[4] tokens[5] tokens[6] g_delim to:g_strBuffer
				)
			)
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="emitter")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            -- emitters have all their data held on the helper obj
            -- so process for it.
            dump_node_properties node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="reference")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            -- references have all their data held on the helper obj
            -- so process for it.
            dump_node_properties node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="aabb")and(type=="mdl" or type=="wok")):
        (
            -- the only times this should be processed is when
            -- exporting a Tile mdl
            local objController     -- not sure if need this? To be deleted?
            
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            
            -- In the interests of greater control I have moved all the
            -- desparkle processing to a seperate manually initiated process,
            -- please see the Speed-Bar.
            
            do_trimesh node
            -- could be replaced with sraight dump of aabb data from the modifier
            --WriteAABBTree node
            ExportAABBTree node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        (node_type=="pwk_dummy"):
        (
            local filename
            filename = nx_lowercase( g_exportPath + g_ModelName + ".pwk" )
            if g_ismax then (
               nx_push g_FileHandles g_strBuffer
               g_strBuffer = createFile filename
               if g_strBuffer == undefined then
               (
	               format "ERROR: File creatin failure for: %\r\n" filename
               )
            ) else (
               format "<snoopstart file=%>%" filename g_delim to:g_strBuffer
           	)
            type = "pwk"
            format "# Exported from NWmax % at %%" gblVersion localtime g_delim to:g_strBuffer
            format "# pwk file%" g_delim to:g_strBuffer
            format "#%" g_delim to:g_strBuffer
           	format "#NWmax PWKMESH  ASCII%" g_delim to:g_strBuffer
        )

        ((node_type=="pwk")and(type=="pwk")):
        (
            -- the only time this should be processed is when
            -- exporting trimesh to a PWK file (pwk's not included in mdl file)
            format "node % %%" "trimesh" node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node wkmesh:true
            format "endnode%" g_delim to:g_strBuffer
        )

        (node_type=="dwk_dummy"):
        (
           	local filename
           	filename = nx_lowercase( g_exportPath + g_ModelName + ".dwk" )
            if g_ismax then (
               nx_push g_FileHandles g_strBuffer
               g_strBuffer = createFile filename
               if g_strBuffer == undefined then
               (
	               format "ERROR: File creatin failure for: %\r\n" filename
               )
            ) else (
               format "<snoopstart file=%>%" filename g_delim to:g_strBuffer
            )
            type = "dwk"
            format "# Exported from NWmax % at %%" gblVersion localtime g_delim to:g_strBuffer
            format "# dwk file%" g_delim to:g_strBuffer
            format "#%" g_delim to:g_strBuffer
           	format "#NWmax DWKMESH  ASCII%" g_delim to:g_strBuffer
        )

        ((node_type=="dwk")and(type=="dwk")):
        (
            -- the only time this should be processed is when
            -- exporting trimesh to a DWK file
            format "node % %%" "trimesh" node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node wkmesh:true
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="skin")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node
            nx_ExSkinweights node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="trimesh")and(type=="mdl")and(not isTile)):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )
        
        ((node_type=="trimesh")and(type=="mdl")and isTile):
        (
            format "#Tile trimesh node%" g_delim to:g_strBuffer
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            -- since we have a tile trimesh to operate on we dump the old
            -- struc_parentPosRot data package and get a new one based on this
            -- nodes data
            struc_parentPosRot = do_tiletrimesh node prntDeltaPos prntRot
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )

        ((node_type=="danglymesh")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node
            nx_ExDanglymesh node
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )
        
        ((node_type=="animmesh")and(type=="mdl")):
        (
        	format "node % %%" node_type node.name g_delim to:g_strBuffer
            do_dummy node
            do_trimesh node
            -- need to call mesh export again.
            ExAuroraTrimesh node.mesh node.name node.material
            -- close node entry
            format "endnode%" g_delim to:g_strBuffer
        )
    )

    -- After all this printing make sure we do a buffer flush
    nx_FlushBuffer()
	
	-- There is a special case of processing that is defined in the Aura
	-- scripts and talked about in the Bioware Tile Creation docs.
	-- Per the Bioware Tile Docs:
	/*
	Animation for tiles has to be handled differently than most other
	models, as tiles are inherently loaded as static objects. For the
	engine to know which parts are to be loaded statically and which
	are to be loaded dynamically, we use the linking/tree system again.
	We create a dummy object that has the exact same position and
	orientation as the Aurabase for the tile that we want to have
	animation on. Then we call it the exact same name as the Aurabase
	itself, with the suffix "a" (for animation). We link it to the
	Aurabase, and then link all our dynamic, animated objects to
	this dummy. 
	*/
	-- So what we do is to follow a similar approach to the Bioware
	-- scripts. When we encountered a dummy node that is exactly the
	-- same as the model name BUT with an 'a' at the end of the name
	-- we start a recursive dive into that subtree with the switch
	-- isTile set to FALSE. This ensures that the animation data is not
	-- mutilated by the tile specific processing logic. It also means that
	-- the game engine nows what we mean  :-)
	if ((classof node) == Dummy) and (node.name == (g_ModelName+"a")) then
	(
    	isTile = false
    	-- not need in this node and below so release it. Also indicates
    	-- to do none tile processing.
    	struc_parentPosRot = undefined
	)
	for child in node.children do
	(
		unfreeze child
    	-- NB: we have a special way of ignoring nodes through a naming
    	-- convention (per Bioware scripts - good idea).
    	-- Must be in training material!!
		if(not (matchpattern child.name pattern:"ignore_*")) do
		(
-- this code is a bit hacked. Will look to tidy it up in later versions.
-- Tidy up will require another look at how we deal with exporting tile models - erk!
    		if struc_parentPosRot == undefined then -- gets called for non tile processing
    		    Node_Geometry child type:type isTile:isTile
		    else    -- we have tile related data so make use of it
    			Node_Geometry child type:type isTile:isTile prntDeltaPos:(struc_parentPosRot.pDeltaPos) prntRot:(struc_parentPosRot.pRot)
		)
	)

	-- We need to close off the file processing for pwk & dwk dummy children.
	case of
	(
      ( (node_type=="pwk_dummy") or
       (node_type=="dwk_dummy")
      ):
      (
         if g_ismax then (
            flush g_strBuffer
            close g_strBuffer
            g_strBuffer = nx_pop g_FileHandles
         ) else (
            format "</snoopstart>%" g_delim to:g_strBuffer
         )
      )
    )
    nx_FlushBuffer()
    
    if DEBUG then format "#Node_Geometry: End%" g_delim to:g_strBuffer
)


--------------------------------------------------------------------------------
-- Broad mdl types
--------------------------------------------------------------------------------
fn ExAuroraWalkmesh node =
(
	-- code based on Bioware's
   if DEBUG then format "#ExAuroraWalkmesh%" g_delim to:g_strBuffer
   if SPEEDT then nx_startStopWatch txt:"ExAuroraWalkmesh"

	-- node should be an aurabase node
	local filename
	filename = nx_lowercase(g_exportPath + node.name + ".wok" )

   if g_ismax then (
      nx_push g_FileHandles g_strBuffer
      g_strBuffer = createFile filename
	if g_strBuffer == undefined then
	(
	   format "ERROR: File creatin failure for: %\r\n" filename
	)
   ) else (
   	format "<snoopstart file=%>%" filename g_delim to:g_strBuffer
	)
	-- Output the geometry:
   format "# Exported from NWmax % at %%" gblVersion localtime g_delim to:g_strBuffer
   format "# wok file%" g_delim to:g_strBuffer
   format "#%" g_delim to:g_strBuffer
	format "#NWmax WALKMESH  ASCII%" g_delim to:g_strBuffer
	format "beginwalkmeshgeom %%" node.name g_delim to:g_strBuffer

	-- This needs to be in a separate function because it's recursive
	-- Write a trimesh node (with some stuff removed) but only where the types is
	-- an aabb type node (i.e. where it has a walkmesh modifier applied).
	Node_Geometry node type:"wok"

	format "endwalkmeshgeom %%" node.name g_delim to:g_strBuffer
   if g_ismax then (
      flush g_strBuffer
      close g_strBuffer
      g_strBuffer = nx_pop g_FileHandles
   ) else (
   	format "</snoopstart>%" g_delim to:g_strBuffer
	)
	
	nx_FlushBuffer()
	
    if SPEEDT then nx_stopStopWatch txt:"ExAuroraWalkmesh"
)


fn ExAuroraTile node =
(
    if DEBUG then format "#ExAuroraTile%" g_delim to:g_strBuffer
	format "#NWmax GEOM  ASCII%" g_delim to:g_strBuffer
	format "beginmodelgeom %%" node.name g_delim to:g_strBuffer
	Node_Geometry node isTile:true prntDeltaPos:(point3 0.0 0.0 0.0) prntRot:(quat 0.0 0.0 0.0 1.0)
	format "endmodelgeom %%" node.name g_delim to:g_strBuffer
	
	nx_FlushBuffer()
	
    if DEBUG then format "#ExAuroraTile:: End%" g_delim to:g_strBuffer
)


fn ExAuroraGeometry node =
(
    if DEBUG then format "#ExAuroraGeometry%" g_delim to:g_strBuffer

	format "#NWmax GEOM  ASCII%" g_delim to:g_strBuffer
	format "beginmodelgeom %%" node.name g_delim to:g_strBuffer
    Node_Geometry node
	format "endmodelgeom %%" node.name g_delim to:g_strBuffer
	
	nx_FlushBuffer()
	
    if DEBUG then format "#ExAuroraGeometry:: End%" g_delim to:g_strBuffer
)


--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
---   Animation export routines
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--
-- DynBuildList
-- by Joco
--
-- Build the key lists for a controller object
--
global gblDynBuildList_Node

fn DynBuildKeyList node firstframe lastframe datatype keyname mdlname:"" nodetype:"" =
(
    -- node: the node of the obj
    -- firstframe: first frame of the animation
    -- lastframe: last frame of the animation
    -- datatype: type of data to be used for export
    -- keyname: name of the data member of the object to be accessed
    -- mdlname: optional parameter for string to use in the resulting mdl

    local objController
    local strMdlName
    local bIsNegLight = false

    -- only continue if node is valid
    if node == undefined then
    (
        if DEBUG then format "    #DEBUG: node not valid - exit DynBuildKeyList fn%" g_delim to:g_strBuffer
        return false
    )
    
    gblDynBuildList_Node = node
    -- using dynamic code obtain controller object
    try (
        objController = execute("gblDynBuildList_Node."+keyname+".controller")
    )
    catch (
        objController = undefined
    )

    if DEBUG then format "    #DEBUG: objController=% %" objController g_delim to:g_strBuffer
        
    local keycount = 0
    -- test to ensure that the controller is defined
    if objController != undefined then
    for t = firstframe to lastframe do
    (
        -- show the user that we are doing something
        --ExportActivityBar()
        if ((getKeyIndex objController t) > 0) then
        (
            -- we have an obj index > 0 so add a keylist entry
            if mdlname != "" then
                strMdlName = mdlname
            else
                strMdlName = keyname
            if (keycount == 0) then
            (
            	format "        %%" strMdlName g_delim to:g_strBuffer
        	)
            keycount += 1;
            at time t in coordsys parent
            (
                objVal = execute("gblDynBuildList_Node."+keyname)
            )
            key_time = ((t-firstframe) as float) / (frameRate as float);
            
            -- some special case unit conversion as needed
            case keyname of
            (
                "radius":
                (
                    -- convert radius into meters
                    objVal = objVal * 0.01
                )
            )
            
            -- out put keys by data type
            case datatype of
            (
                "float":    format "            % % %" key_time objVal g_delim to:g_strBuffer
                "integer":  format "            % % %" key_time objVal g_delim to:g_strBuffer
                "color":
                (
                    -- deal with potential for animated negative light
                    try ( bIsNegLight = nx_itob(node.negativeLight) ) catch ( bIsNegLight = false )
                    if bIsNegLight then
                        format "            % -% -% -% %" key_time (objVal.r / 255) (objVal.g / 255) (objVal.b / 255) g_delim to:g_strBuffer
                    else
                        format "            % % % % %" key_time (objVal.r / 255) (objVal.g / 255) (objVal.b / 255) g_delim to:g_strBuffer
                )
                "point3":   format "            % % % % %" key_time objVal.x objVal.y objVal.z g_delim to:g_strBuffer
                "point4":   format "            % % % % % %" key_time objVal.x objVal.y objVal.z objVal.r g_delim to:g_strBuffer
                "position":
                (
                    at time t in coordsys parent
                    (
                        objVal = execute("gblDynBuildList_Node."+keyname)
                        local objPos = objVal * 0.01
                    )
                    format "            % % % %%" key_time objPos.x objPos.y objPos.z g_delim to:g_strBuffer
                )
                "orientation":
                (
                    --local rotVector = normalize (point3 -objVal.x -objVal.y -objVal.z)
                    --local rotVector = point3 objVal.x objVal.y objVal.z   -- negative convserion not consistemt with Bioware files?
                    local rotVector
                    if nodetype == "emitter" then
                    (
                        -- to be consistent with the 180' rotation we apply to the orientation in normal export
                        -- apply it to the orientation animation data as well
                        objVal += quat -180 (point3 1 0 0);
                    )
                    
                    rotVector = point3 -objVal.x -objVal.y -objVal.z
                    
                    --format "# raw  %" rotVector
                    
                    --
                    -- Normalising a [0,0,0] vector results in [1,0,0].
                    -- The desired result is [0,0,0].

                    -- Due to some VERY strange behaviour with MAXScript the only way to get correct
                    -- behaviour on the below boolean test is to work with strings!
                    if (rotVector as string) != "[0,0,0]" then
                    (
                        --format "  N  "
                        rotVector = normalize (rotVector)
                    )
                    local angle = -DegToRad(objVal.angle)
                    format "            % % % % %%" key_time rotVector.x rotVector.y rotVector.z angle g_delim to:g_strBuffer
                )
                default:    format "#ERROR - keylist data type not defined in code. Contact the author for support. %"
            )
        )
        nx_FlushBuffer()
    )
    if (keycount > 0) then format "        endlist%" g_delim to:g_strBuffer
    
    nx_FlushBuffer()
    
    -- Just do a tidy up. Not really necessary.  :-)
    gblDynBuildList_Node = undefined
)


--
-- Exports out the various key lists for each animation.
-- Called by ExportAnimByNumber
--
fn ExportAnimKeys node firstframe lastframe=
(
    -- From Wayland's original script with emitter/light enhancements by Joco
    -- determine node type
    local node_type
    local to_export
--    if (canConvertTo node Editable_Mesh) then node_type = "trimesh"
--    if (classOf node == Cone_Angle) then node_type = "emitter"
--    if (classOf(node.baseobject) == OmniLight) then node_type = "light"



	-- if node name starts with "ignore_" we don't process it or any of it's children
	if (matchpattern node.name pattern:"ignore_*") then return false


    local node_class = (nx_strclassof node)
    local node_superclass = ((superclassof node) as string)
    
    if DEBUG then format "  #DEBUG: node: %  type: %  superclass: % %" node.name node_class node_superclass g_delim to:g_strBuffer
    
    case of
    (
    	((node_class == "auroralight") or (node_class == "auroraDlight")): node_type = "light"
    	(node_class == "auroraemitter"): node_type = "emitter"
    	(node_class == "aurorareference"): node_type = "reference"
    	(node_superclass == "GeometryClass"):
    	(
        	case of
        	(
            	(node.modifiers["AuroraAniMesh"] !=undefined): node_type = "animmesh"
            	(node.modifiers["AuroraPlaceable"] !=undefined):
            	(
                	case (node.modifiers["AuroraPlaceable"].meshtype) of
                	(
                	    1: node_type = "pwk"
                	    2: node_type = "dwk"
            	    )
            	)
            	(node.modifiers["AuroraWalkmesh"] !=undefined):
            	(
                	case (node.modifiers["AuroraWalkmesh"].meshtype) of
                	(
                	    1: node_type = "aabb"
                	    2: node_type = "pwk"
                	    3: node_type = "dwk"
            	    )
        	    )
            	(node.modifiers["AuroraFlex"] != undefined): node_type = "danglymesh"
            	(node.modifiers["AuroraBFlex"] != undefined): node_type = "danglymesh"
            	(node.modifiers["skin"] != undefined): node_type = "skin"
            	default: node_type = "trimesh"
        	)
    	)
    	default: node_type = "dummy"
    )

    /*
    We need to determine if there are any keys on the node to be exported
    before continuing. This is to prevent a memory leak situation that
    exists in the v1.62 (and perhaps before) of the game.
    */
    to_export = true	-- set base premise TO export the node

	
	-- only supress skinmesh nodes at this point - not happy that this is correct.
	-- Is this just a toolset issue?
    if node_type == "skin" then (
	    to_export = false
    )
	    
    if to_export then
    (
	    -- build the start of the animation node
	    format "    node % %%" node_type (node.name) g_delim to:g_strBuffer
	    if (node.parent != undefined) then
	        format "        parent %%" (node.parent.name) g_delim to:g_strBuffer
	    else
	        format "        parent NULL%" g_delim to:g_strBuffer
	        
	    nx_FlushBuffer()
	
	--    messagebox ("node.name=" + node.name)
	--    messagebox ("firstframe=" + (firstframe as string))
	--    messagebox ("lastframe=" + (lastframe as string))
	
	    local t
	    local keycount
	    local key_time
	
	    --
	    -- build position keylist
	    --
	    if DEBUG then format "        #DEBUG: Build position list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "position" "pos" mdlname:"positionkey"
	
	    --
	    -- build orientation keylist
	    --
	    if DEBUG then format "        #DEBUG: Build orientation list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "orientation" "rotation" mdlname:"orientationkey" nodetype:node_type
	
	    
	    ----------------------------------------------------------------
	    -- Joco 31-Mar-04: Modifer properties                         --
	    ----------------------------------------------------------------
	    --
	    -- build scale from trimesh modifier
	    --
	    if DEBUG then format "        #DEBUG: Build scale list%" g_delim to:g_strBuffer
	    DynBuildKeyList (node.modifiers["AuroraTrimesh"]) firstframe lastframe "float" "scale" mdlname:"scalekey"

	    --
	    -- build alpha from trimesh modifier
	    --
	    if DEBUG then format "        #DEBUG: Build alpha list%" g_delim to:g_strBuffer
	    -- decision is to have alpha driven only from the Trimesh Modifier. Therefore we don't support
	    -- alpha off the material anymore
	    --if node.mat != undefined then (
		--    DynBuildKeyList node.mat firstframe lastframe "float" "opacity" mdlname:"alphakey"
	    --) else (
	    DynBuildKeyList (node.modifiers["AuroraTrimesh"]) firstframe lastframe "float" "alpha" mdlname:"alphakey"
	    --)
	    
	    --
	    -- build selfillumcolor from trimesh modifier
	    --
	    if DEBUG then format "        #DEBUG: Build selfillumcolor list%" g_delim to:g_strBuffer
	    DynBuildKeyList (node.modifiers["AuroraTrimesh"]) firstframe lastframe "color" "selfillumcolor" mdlname:"selfillumcolorkey"
	    
    
	    ----------------------------------------------------------------
	    -- Joco 14-Aug-03: Emitter export code                        --
	    --                                                            --
	    -- NB: controllers on the custom addtributes only seem to be  --
	    --     created when a key frame has been set. Otherwise an    --
	    --     attempt to access the undefined controller returns     --
	    --     a script error.                                        --
	    ----------------------------------------------------------------
	    --
	    -- build alpha keylist
	    --
	    if DEBUG then format "        #DEBUG: Build alpha list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "alpha" mdlname:"alphakey"
	
	    --
	    -- build alphaStart keylist
	    --
	    if DEBUG then format "        #DEBUG: Build alphaStart list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "alphaStart" mdlname:"alphaStartkey"
	
	    --
	    -- build alphaEnd keylist
	    --
	    if DEBUG then format "        #DEBUG: Build alphaEnd list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "alphaEnd" mdlname:"alphaEndkey"
	
	    --
	    -- build birthrate keylist
	    --
	    if DEBUG then format "        #DEBUG: Build birthrate list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "birthrate" mdlname:"birthratekey"
	
	    --
	    -- build bounce_co keylist
	    --
	    if DEBUG then format "        #DEBUG: Build bounce_co list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "bounce_co" mdlname:"bounce_cokey"
	
	    --
	    -- build colorStart keylist
	    --
	    if DEBUG then format "        #DEBUG: Build colorStart list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "color" "colorStart" mdlname:"colorStartkey"
	
	    --
	    -- build colorEnd keylist
	    --
	    if DEBUG then format "        #DEBUG: Build colorEnd list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "color" "colorEnd" mdlname:"colorEndkey"
	
	    --
	    -- build combinetime keylist
	    --
	    if DEBUG then format "        #DEBUG: Build combinetime list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "combinetime" mdlname:"combinetimekey"
	
	    --
	    -- build drag keylist
	    --
	    if DEBUG then format "        #DEBUG: Build drag list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "drag" mdlname:"dragkey"
	
	    --
	    -- build fps keylist
	    --
	    if DEBUG then format "        #DEBUG: Build fps list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "integer" "fps" mdlname:"fpskey"
	
	    --
	    -- build frameStart keylist
	    --
	    if DEBUG then format "        #DEBUG: Build frameStart list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "integer" "frameStart" mdlname:"frameStartkey"
	
	    --
	    -- build frameEnd keylist
	    --
	    if DEBUG then format "        #DEBUG: Build frameEnd list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "integer" "frameEnd" mdlname:"frameEndkey"
	
	    --
	    -- build grav keylist
	    --
	    if DEBUG then format "        #DEBUG: Build grav list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "grav" mdlname:"gravkey"
	
	    --
	    -- build lifeExp keylist
	    --
	    if DEBUG then format "        #DEBUG: Build lifeExp list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "lifeExp" mdlname:"lifeExpkey"
	
	    --
	    -- build lightningDelay keylist
	    --
	    if DEBUG then format "        #DEBUG: Build lightningDelay list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "lightningDelay" mdlname:"lightningDelaykey"
	
	    --
	    -- build lightningRadius keylist
	    --
	    if DEBUG then format "        #DEBUG: Build lightningRadius list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "lightningRadius" mdlname:"lightningRadiuskey"
	
	    --
	    -- build lightningScale keylist
	    --
	    if DEBUG then format "        #DEBUG: Build lightningScale list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "lightningScale" mdlname:"lightningScalekey"
	
	    --
	    -- build lightningSubDiv keylist
	    --
	    --if DEBUG then format "        #DEBUG: Build lightningSubDiv list%" g_delim to:g_strBuffer
	    --DynBuildKeyList node firstframe lastframe "float" "lightningSubDiv" mdlname:"lightningSubDivkey"

	    --
	    -- build blurlength keylist
	    --
	    if DEBUG then format "        #DEBUG: Build blurlength list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "blurlength" mdlname:"blurlengthkey"
	    	
	    --
	    -- build sizeStart_y keylist
	    --
	    if DEBUG then format "        #DEBUG: Build sizeStart_y list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "sizeStart_y" mdlname:"sizeStart_ykey"
	    
	    --
	    -- build sizeEnd_y keylist
	    --
	    if DEBUG then format "        #DEBUG: Build sizeEnd_y list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "sizeEnd_y" mdlname:"sizeEnd_ykey"
	    
	    --
	    -- build mass keylist
	    --
	    if DEBUG then format "        #DEBUG: Build mass list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "mass" mdlname:"masskey"
	
	    --
	    -- build p2p_bezier2 keylist
	    --
	    if DEBUG then format "        #DEBUG: Build p2p_bezier2 list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "p2p_bezier2" mdlname:"p2p_bezier2key"
	
	    --
	    -- build p2p_bezier3 keylist
	    --
	    if DEBUG then format "        #DEBUG: Build p2p_bezier3 list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "p2p_bezier3" mdlname:"p2p_bezier3key"
	
	    --
	    -- build particleRot keylist
	    --
	    if DEBUG then format "        #DEBUG: Build particleRot list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "particleRot" mdlname:"particleRotkey"
	
	    --
	    -- build randvel keylist
	    --
	    if DEBUG then format "        #DEBUG: Build randvel list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "randvel" mdlname:"randvelkey"
	
	    --
	    -- build sizeStart keylist
	    --
	    if DEBUG then format "        #DEBUG: Build sizeStart list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "sizeStart" mdlname:"sizeStartkey"
	
	    --
	    -- build sizeEnd keylist
	    --
	    if DEBUG then format "        #DEBUG: Build sizeEnd list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "sizeEnd" mdlname:"sizeEndkey"
	
	    --
	    -- build spread keylist
	    --
	    if DEBUG then format "        #DEBUG: Build spread list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "spread" mdlname:"spreadkey"
	
	    --
	    -- build velocity keylist
	    --
	    if DEBUG then format "        #DEBUG: Build velocity list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "velocity" mdlname:"velocitykey"
	
	    --
	    -- build xsize keylist
	    --
	    if DEBUG then format "        #DEBUG: Build xsize list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "xsize" mdlname:"xsizekey"
	
	    --
	    -- build ysize keylist
	    --
	    if DEBUG then format "        #DEBUG: Build ysize list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "ysize" mdlname:"ysizekey"
	    -----------------------------
	    -- END Emitter export code --
	    -----------------------------
	
	
	    ----------------------------------------------------------------
	    -- Joco 19-Aug-03: Light export code                          --
	    --                                                            --
	    -- NB: controllers on the custom addtributes only seem to be  --
	    --     created when a key frame has been set. Otherwise an    --
	    --     attempt to access the undefined controller returns     --
	    --     a script error.                                        --
	    ----------------------------------------------------------------
	    --
	    -- build color keylist
	    --
	    if DEBUG then format "        #DEBUG: Build color list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "color" "rgb" mdlname:"colorkey"
	
	    --
	    -- build radius keylist
	    --
	    if DEBUG then format "        #DEBUG: Build radius list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "radius" mdlname:"radiuskey"
	    
	    --
	    -- build multiplier keylist
	    --
	    if DEBUG then format "        #DEBUG: Build multiplier list%" g_delim to:g_strBuffer
	    DynBuildKeyList node firstframe lastframe "float" "multiplier" mdlname:"multiplierkey"
	    
	    -----------------------------
	    -- END Light export code   --
	    -----------------------------
	
	    
	    ----------------------------------------------------------------
	    -- Animation Mesh                                             --
	    -- This needs some special processing hence the code block    --
	    -- NB: This is a spcialist type of animation for a mesh.      --
	    -- To get this to work correctly means using Bioware code     --
	    -- at this point. However even original code will look very   --
	    -- similar due to the specific format reqs of the output      --
	    ----------------------------------------------------------------
	    if node_type == "animmesh" then
	    (
	    	-- Change slider range to range of animation, otherwise samples won't export properly
	    	local Oldanimrange = animationrange
	    	animationrange =(interval (firstframe) (lastframe))	
	    
	    	curTime = sliderTime
	    	sliderTime = firstframe
	    
	    	if ((animIndex == 0) or (animIndex == undefined)) then 
	    		animIndex = 1
			-- Dumps properties on nodes/Mods but in this case don't think
			-- it is really needed?  May need to do own property/key dump! 
	    	--node_anim_trimesh n animstart animend
	    	-- export out the mesh
	    	ExAuroraTrimesh node.mesh node.name node.material
	    	mod = node.modifiers["AuroraAnimesh"]
	    	samples = mod.animMeshSamples[animIndex]
	    
	    	if ((samples != undefined) and ((samples as integer) > 0)) then
	    	(
	    		samples = samples as integer
	    		-- some debug data
	    		if DEBUG then format "#lastframe - firstframe = %%" (lastframe - firstframe) g_delim to:g_strBuffer
	    		if DEBUG then format "#framerate = %%" framerate g_delim to:g_strBuffer
	    		if DEBUG then format "#samples-1 = %%" (samples-1) g_delim to:g_strBuffer
	    		-- end debug
	    		local numframes = (lastframe - firstframe) as float
	    		period = (numframes/framerate/(samples-1)) as float
	    		format "    sampleperiod %%" period g_delim to:g_strBuffer
	    		format "    animverts %%" (node.numverts*samples) g_delim to:g_strBuffer
	    
	    		interval = (lastframe - firstframe)/(samples-1)
	    		--format "#interval = %%" interval
	    		
	    		for i = 1 to samples do 
	    		(
	        		if DEBUG then format "#Sample: %%" i g_delim to:g_strBuffer
	        		if DEBUG then format "#sliderTime = %%" sliderTime g_delim to:g_strBuffer
	        		
	    			for j = 1 to node.numverts do 
	    			(
	    				v = getvert node.mesh j
	    				v *= 0.01  -- convert to meters
	    				format "      % % %%" v.x v.y v.z g_delim to:g_strBuffer
	    				nx_FlushBuffer()
	    			)
	    			
	    			sliderTime += interval
	    			if ((sliderTime > lastframe) or (i == (samples))) then 
	    				sliderTime = lastframe
	    		)
	    	
	    	
	    		-- ===== Export texture coordinates =====
	    		sliderTime = firstframe
	    		--
	    		-- determine uv coordinate correction
	    		local clipu,clipv,clipw,cliph
	    		clipu=0
	    		clipv =0
	    		clipw=1
	    		cliph=1
	    		local mat = node.material
	    		if(mat != undefined and mat.diffusemap != undefined ) then
	    		(
	    			clipu = mat.diffusemap.clipu
	    			clipv = mat.diffusemap.clipv
	    			clipw = mat.diffusemap.clipw
	    			cliph = mat.diffusemap.cliph
	    			-- it might be upside down since 
	    			-- from the aura exporter we had a line like the following:
	    			clipv = 1 - clipv - cliph
	    			
	    			format "clipu %%" clipu g_delim to:g_strBuffer
	    			format "clipv %%" clipv g_delim to:g_strBuffer
	    			format "clipw %%" clipw g_delim to:g_strBuffer
	    			format "cliph %%" cliph g_delim to:g_strBuffer
	    		)
	    		else (
	    			if(mat == undefined) then format "#animmesh tverts: no material for %%" name g_delim to:g_strBuffer
	    			format "#animmesh tverts: no bitmap for object %%" name g_delim to:g_strBuffer
	    		)
	    		--		
	    		--	
	    		if node.numtverts != 0 then
	    		(	
	    			format "    animtverts %%" (node.numtverts*samples) g_delim to:g_strBuffer
	    			for i = 1 to samples do 
	    			(
	    				for j = 1 to node.numtverts do 
	    				(
	    					v = gettvert node.mesh j
	    					format "     % % 0%" (v.x*clipw + clipu) (v.y*cliph + clipv) g_delim to:g_strBuffer
	    					nx_FlushBuffer()
	    				)
	    			
	    				sliderTime += interval
	    				if ((sliderTime > lastframe) or (i == (samples))) then 
	    					sliderTime = lastframe
	    			)
	    		)
	    	
	    		sliderTime = curTime
	    		format "    endlist%" g_delim to:g_strBuffer
	    		nx_FlushBuffer()
	    	) else (
	    		format "    verts %%" node.numverts g_delim to:g_strBuffer
	    		for i=1 to node.numverts do 
	    		(
	    			local v
	    			v = getvert node.mesh i
	    			v = v * 0.01;  -- convert to application unit length (meters)
	    			format "     % % %%"  v.x v.y v.z g_delim to:g_strBuffer
	    			nx_FlushBuffer()
	    		)
	    	)
	    	
	    	nx_FlushBuffer()
	    	
	    	-- Restore anim slider range
	    	animationrange = Oldanimrange
	    )
	    
	    format "    endnode%" g_delim to:g_strBuffer
	)	-- endif  to_export
    nx_FlushBuffer()

    for c in node.children do ExportAnimKeys c firstframe lastframe
)

fn ExportAnimEvents node firstframe lastframe =
(
    -- From Wayland's original script
    -- Find the event's that have the same frame number as 'firstframe'
    local event_data
    local event_name
    local event_frame
    local event_time
    for str_eventdata in node.events do
    (
        event_data = filterString str_eventdata " "
        event_name = event_data[1]
        event_frame = (event_data[2] as integer)
        if ( (event_frame >= firstframe) and (event_frame <= lastframe) ) then
        (
            event_time = ((event_frame - firstframe) as float) / (frameRate as float)
            format "  event % %%" event_time event_name g_delim to:g_strBuffer
            nx_FlushBuffer()
        )
    )
)

--
-- Starts the Animation Export
--
fn ExAuroraAnimations node =
(
	-- From Wayland's original script
	-- Modified by Joco to suit MDL Tool structure
	if (node == undefined) then return undefined
	
	local anim_data
	local name
	local firstframe
	local lastframe
	local transtime
	local anim_length
	local will_export
	local anim_root

	animIndex = 0
	-- Cycle through the animations and export each one in the array
	for str_animdata in node.animations do
	(
		animIndex += 1
		-- parse out the animation data
		anim_data =   filterString str_animdata " "
		name = anim_data[1]
		firstframe = (anim_data[2] as integer)
		lastframe = (anim_data[3] as integer)
		transtime = (anim_data[4] as float)
		-- deal with any backwards compatability issues where this flag
		-- might not be present. If not there is assumed to == 1
		if anim_data[5] == undefined then
		(
         will_export = true
		) else
		(
         will_export = (nx_itob (anim_data[5] as integer))
      )
		anim_length = ((lastframe - firstframe) as float) / (frameRate as float)
		if anim_data.count > 5 then
		(
		  anim_root = anim_data[6]
		) else
		(
		  anim_root = node.name
		)
		if will_export then
		(
		   format "%" g_delim to:g_strBuffer
		   format "#NWmax ANIM ASCII%" g_delim to:g_strBuffer
		   format "newanim % %%" name node.name g_delim to:g_strBuffer
		   format "  length %%" anim_length g_delim to:g_strBuffer
		   format "  transtime %%" transtime g_delim to:g_strBuffer
		   format "  animroot %%" anim_root g_delim to:g_strBuffer
		   ExportAnimEvents node firstframe lastframe
		   ExportAnimKeys node firstframe lastframe
		   format "doneanim % %%" name node.name g_delim to:g_strBuffer
		   format "%" g_delim to:g_strBuffer
		)
		nx_FlushBuffer()
	)
)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
---   Exporting Starting Point
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
fn ExAuroraMDL node anim:true =
(
    -- Determine what type of node we are dealing with and set the
    -- export routines down the appropriate path.
    -- We can parse the tree for:
    -- a. WalkMesh
    -- b. Tile
    -- c. Standard Geometry
    -- d. Animations

    -- Perform some basic sanity checking before we start trying to
    -- make a model file.
    -- 1. only do this work if we have an aurorabase
    if (nx_strclassof node) != "aurorabase" then return 0
    -- 2. so we have an aurorabase, but does it have any children?
    if not (node.children.count > 0) then return 0
    
    -- make sure we are exporting starting at frame 0
    local currentFrame = sliderTime
    sliderTime = 0

    if DEBUG then format "#ExAuroraMDL: process tiles and geometry%" g_delim to:g_strBuffer
    if SPEEDT then nx_startStopWatch txt:"ExAuroraMDL"
    -- set the global name for the model. Used for pwk/dwk etc processing
    g_ModelName = node.name
    
    -- Deal with wok file creation if the model is a Tile
	if (node.classification == "Tile") then
		ExAuroraWalkmesh node
	
	format "# Exported from NWmax % at %%" gblVersion localtime g_delim to:g_strBuffer
	format "# mdl file%" g_delim to:g_strBuffer
	format "#%" g_delim to:g_strBuffer
	format "#NWmax MODEL ASCII%" g_delim to:g_strBuffer
	format "# model: %%" node.name g_delim to:g_strBuffer
	if maxfilename == "" then (
		format "#local file: Unknown%" g_delim to:g_strBuffer
		format "filedependancy Unknown%" g_delim to:g_strBuffer
	)
	else (
    	format "#local file: %%" (maxfilepath + maxfilename) g_delim to:g_strBuffer
    	format "filedependancy %%" maxfilename g_delim to:g_strBuffer
 	)
 	
	format "newmodel %%" node.name g_delim to:g_strBuffer
	-- Output the SuperModel of this model:
	local sm = "NULL"
	if( node.setsupermodel != #undefined and \
	    (filterstring node.setsupermodel " ").count > 0 ) \
	then (
		sm = (filterstring node.setsupermodel " ")[1]
	)
	
	format "setsupermodel % %%" node.name sm g_delim to:g_strBuffer
	format "classification %%" node.classification g_delim to:g_strBuffer
	if (node.classification == "Character") then
	(
		format "setanimationscale %%" node.setanimationscale g_delim to:g_strBuffer
	)
	
	nx_FlushBuffer()

	if (node.classification == "Tile")  then
	(
		g_RoundOffVertices = true
		ExAuroraTile node
	)
	else
		ExAuroraGeometry node

	if DEBUG then format "#ExAuroraMDL: process animations%" g_delim to:g_strBuffer
	-- export animations then close the model syntax
	if anim then
    	ExAuroraAnimations node
    format "donemodel %%" node.name g_delim to:g_strBuffer

	if DEBUG then format "#ExAuroraMDL: End%" g_delim to:g_strBuffer
	
	nx_FlushBuffer force:true

	-- restore slider time
	sliderTime = currentFrame
		
	-- do a general clean up as we eat some memory in these scripts
	gc()
    if SPEEDT then nx_stopStopWatch txt:"ExAuroraMDL"
)

-------------------------------------------------
-- Mass export function
-------------------------------------------------
function ExportAll = 
(
    -- Strictly speaking is based on Bioware's code but at the end of the
    -- day there are only so many ways to do this sensibly and they will all
    -- look the same.
	local export_path
	local bases
	local passSanityCheck = true
	local bSanityCheck
    local mdlextn

	local count=0;
	local models=""
	local totalBaseCount = 0
	local percentComplete = 0
	local continueExport=true

	
	-- before doing anything check for prescence of skins in scene
	for s in $objects do
	(
		if (s.modifiers["Skin"] != undefined) then
		(
			-- we have skins!!
			local msgStr = "At least one skin found in the scene.\rExporting skins using Export-All can crash NWmax.\r" + \
			" Please use the export buttons held on the models Aurorabase.\rThank you. Export-All stopped."
			messageBox msgStr title:"Skins detected!" beep:true
			return 0
		)
	)
	
		
	--progressStart "Exporting all AuraBases..."
	
	bases = #()
	if selection.count == 0 then
	(
		for s in $helpers do
		(
    		if (nx_strclassof s) == "aurorabase" then
    		    append bases s
	    )
	) else
	(
		for s in selection do
		(
    		if (nx_strclassof s) == "aurorabase" then
    		    append bases s
	    )
	)
	
	unfreeze $geometry
	unfreeze bases

	clearListener()

	if not g_ismax then format "<snoopstart file=%batchexport.txt>%" "c:\\" g_delim to:g_strBuffer
	for obj in bases do 
	(
    	-- Check to see if we should be continuing with the export
		if (continueExport == false) then
			continue
		if ((nx_strclassof obj) == "aurorabase") and (not (matchPattern obj.name pattern:"*	")) then 
		(
    		-- Only do something if there are some children.
			if (obj.children.count > 0) then
			(
	 			max modify mode -- needed?
    			select obj
     			if (obj.export_path[obj.export_path.count] != "\\") then obj.export_path = obj.export_path + "\\"
    			g_exportPath = obj.export_path
        		if obj.export_binary != 1 then
        		    mdlextn = "mdl"
    		    else
    		        mdlextn = "mdl.ascii"
        		if not g_ismax then format "<snoopstart file=%%.%>%" obj.export_path obj.name mdlextn g_delim to:g_strBuffer
        		-- we can now do some sanity checks and record the results for review
        		if g_ismax then (
	           		g_strBuffer = createFile (nx_lowercase( gNX_sanityPath + obj.name + "_sanitycheck.txt") )
					if g_strBuffer == undefined then
					(
					   format "ERROR: File creatin failure for: %\r\n" (obj.export_path + obj.name + "_sanitycheck.txt")
					)
        		) else (
	           		format "<snoopstart file=%%_sanitycheck.txt>%" (gNX_sanityPath) (nx_lowercase(obj.name)) g_delim to:g_strBuffer
        		)
        		bSanityCheck = SanityCheck obj
        		if g_ismax then
        		(
	           		flush g_strBuffer
	           		close g_strBuffer
        		) else (
	           		format "</snoopstart>%" g_delim to:g_strBuffer
        		)
				if (bSanityCheck != 0) then 
				(
        			select obj
        			max modify mode
        			if g_ismax then (
						g_strBuffer = createFile (nx_lowercase( obj.export_path + obj.name + "." + mdlextn) )
						if g_strBuffer == undefined then
						(
						   format "ERROR: File creatin failure for: %\r\n" (obj.export_path + obj.name + "." + mdlextn)
						)
        			)
					ExAuroraMDL obj
					if g_ismax then
					(
						flush g_strBuffer
						close g_strBuffer
	   				)
					models += (obj.name + " ")
					count = count +1
				) 
				else 
					passSanityCheck = false
					
				if not g_ismax then format "</snoopstart>%" g_delim to:g_strBuffer
				
				-- do we need to compile this model?
        		if obj.export_binary == 1 then
        		(
				if g_ismax then
				(
              		-- compile code
	           		format "Compile model.\r\n"
					strCmd = createFile (gNX_scratchPath+"export.bat")
					if strCmd == undefined then
					(
					   format "ERROR: File creatin failure for: %\r\n" (gNX_scratchPath+"export.bat")
					)
					format "\"%\" -c \"%%%\" \"%\\\" > \"%\"%" g_compiler obj.export_path obj.name ".mdl.ascii" obj.export_path (gNX_scratchPath+"compile_"+obj.name+".txt") g_delim to:strCmd
					flush strCmd
					close strCmd
					DOSCommand ("\"" + gNX_scratchPath + "export.bat\"")
           		) else
           		(
                  format "<snoopstart file=%>%" (gNX_scratchPath+"export.bat") g_delim to:g_strBuffer    
                  format "\"%\" -c \"%%%\" \"%\\\" > \"%\"%" g_compiler obj.export_path obj.name ".mdl.ascii" obj.export_path (gNX_scratchPath+"compile_"+obj.name+".txt") g_delim to:g_strBuffer
                  format "</snoopstart>%" g_delim to:g_strBuffer
                  
                  format "<commandstart>%" g_delim to:g_strBuffer
                  format "\"%export.bat\"%" (gNX_scratchPath+"") g_delim to:g_strBuffer
                  format "</commandstart>%" g_delim to:g_strBuffer
               )
        		)
			)
		)
		totalBaseCount += 1
		percentComplete = 100.0*(totalBaseCount as float)/(bases.count as float)
		--continueExport = progressUpdate percentComplete
	)
	--progressEnd()

	if (continueExport == false) then (
		if g_ismax then (
			format "Export cancelled: exported % models out of a possible %.%" count bases.count g_delim
		) else (
			format "Export cancelled: exported % models out of a possible %.%" count bases.count g_delim to:g_strBuffer
		)
	) else (
		if g_ismax then (
			format "Exported % models%" count g_delim
		) else (
			format "Exported % models%" count g_delim to:g_strBuffer
		)
	)
	if not g_ismax then
	(
	   	format "</snoopstart>%" g_delim to:g_strBuffer
	   	format "</snoopend>%" g_delim to:g_strBuffer
	)
	
	if (passSanityCheck == false) then (
		str = "SanityCheck failed for some models.  See the sanity check file for each model."
		messageBox str title:"Failed Sanity Check" beep:true
	)
	nx_FlushBuffer force:true
	-- do a general clean up as we eat some memory in these scripts
	gc()
)


-- listener command line command
-- Usage: massexport <file pattern> <target> {<anims:true>}
fn massexport pattern:undefined target:undefined anims:true =
(
	if (pattern == undefined) or (target==undefined) then
	(
		format "Usage:  massexport pattern:<filepath\pattern> target:<target dir> {<anims:true|false>}\r\n"
		format "example:  massexport pattern:\"d:\\\\mygmaxfiles\\\\*.gmax\" target:\"d:\\\\mymdls\"\r\n"
		format "Limitations: The total size the accumulated mdl data must be less than 3.6MB.\r\n"
		return 0
	)
	
	if not (nx_existDir target) then
	(
		messageBox "Target directory does not exist"
		return 0
	)
	
    -- get all the files to load from the pattern provided
    local modelBase
    local filesToLoad = getFiles pattern
    if target[target.count] != "\\" then target += "\\"
    -- reset scene
    resetMaxFile #noPrompt
	progressStart "Mass Export"
    clearListener()
	local doneCount = 0
    -- set the external control snoop bracket.
    if not g_ismax then format "<snoopstart file=%%>%" gNX_scratchPath "exportcontrol.txt" g_delim to:g_strBuffer
    for file in filesToLoad do
    (
      -- load the file
      if (loadMaxFile file) then
      (
         for h in $helpers do
         (
            if (nx_strclassof h) == "aurorabase" then
            (
                modelBase = h
                exit
            )
         )
         -- export the file
         if isSceneRedrawDisabled() then enableSceneRedraw()
         modelBase.export_path = target
         select modelBase
         max modify mode
         if not g_ismax then format "<snoopstart file=%%.%>%" target (nx_lowercase( modelBase.name )) "mdl" g_delim to:g_strBuffer
         -- we can now do some sanity checks and record the results for review
         if g_ismax then (
	         g_strBuffer = createFile ((gNX_sanityPath) + (nx_lowercase( modelBase.name )) + "_sanitycheck.txt")
			if g_strBuffer == undefined then
			(
				format "ERROR: File creatin failure for: %\r\n" (target + (nx_lowercase( modelBase.name )) + "_sanitycheck.txt")
			)
         )
         format "<snoopstart file=%%_sanitycheck.txt>%" (gNX_sanityPath) (nx_lowercase( modelBase.name )) g_delim to:g_strBuffer
         bSanityCheck = SanityCheck modelBase
         if g_ismax then
         (
	         flush g_strBuffer
	         close g_strBuffer
         ) else (
	         format "</snoopstart>%" g_delim to:g_strBuffer
         )
         nx_FlushBuffer()
         if g_ismax then (
	         g_strBuffer = createFile (target + (nx_lowercase( modelBase.name )) + ".mdl")
			if g_strBuffer == undefined then
			(
				format "ERROR: File creatin failure for: %\r\n" (target + (modelBase.name) + ".mdl")
			)
         )
         ExAuroraMDL modelBase anim:anims
         if g_ismax then
         (
	         flush g_strBuffer
	         close g_strBuffer
         ) else (
	         format "</snoopstart>%" g_delim to:g_strBuffer  -- closes model export
         )
         nx_FlushBuffer()
         -- reset scene
         resetMaxFile #noPrompt
        doneCount += 1
        if not (progressUpdate ((doneCount*100)/filesToLoad.count)) then exit
	    )
   )
   if not g_ismax then
   (
	   format "</snoopstart>%" g_delim to:g_strBuffer  -- closes exportcontrol.txt
	   format "</snoopend>%" g_delim to:g_strBuffer
   )
	nx_FlushBuffer force:true
	progressEnd()
	if not g_ismax then messageBox "Processing Complete.\nDO NOT CLOSE until\nSnoop has finsihed exporting out the MDLs."
)
