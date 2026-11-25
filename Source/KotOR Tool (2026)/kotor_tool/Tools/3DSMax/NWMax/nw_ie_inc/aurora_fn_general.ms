/*-----------------------------------------------------------------------------\

    NWmax General Functions
    by Joco (jameswalker@clear.net.nz)

    Credits:
    Wayland Reid :-
        Extends Wayland's (wreid@spectrumanalytic.com) Import/Export script
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
    4. In the case of code used from the Bioware scripts their intellectual
       property rights still hold.
    5. No code has been knowingly included from other sources where that code
       is sold for commercial purposes.
     
\-----------------------------------------------------------------------------*/


--------------------------------------------------------------------------------
---
--- Misc functions
---
--------------------------------------------------------------------------------

----------------------------------------
--- Dump all properties on an object ---
----------------------------------------
fn dump node =
(
    -- A generic debug routine for dumping all a nodes properties
    for p in (getPropNames node) do
        format "% = %\n" p (getProperty node p) 
)

-----------------------------------------
--- generic stack routines            ---
-----------------------------------------
fn nx_push stk e =
(
   append stk e
)

fn nx_pop stk =
(
   local e
   e = stk[stk.count]
   deleteItem stk stk.count
   e
)



----------------------------------------
--- Dump hierarchy starting at node  ---
----------------------------------------
fn nx_hierarchy node level:0 =
(
        if node != undefined then
    (
        local indent = ""
        for i = 1 to level do
        (
            indent += "  "
        )
        format "%%\r\n" indent node.name
        for c in node.children do
        (
            nx_hierarchy c level:(level+1)
        )
    ) else (
        format "nx_hierarchy: object not found\r\n"
    )
)

------------------------------
--- Timer analysis code    ---
------------------------------
global g_stopwatch = #()    -- fake stack of floats
fn nx_startStopWatch txt:"" =
(
    append g_stopwatch (timeStamp())
    format "#Timing Start %\r\n" txt
)

fn nx_stopStopWatch txt:"" =
(
    local l_stopwatch = timeStamp() - g_stopwatch[g_stopwatch.count]
    -- pop value off the stack
    deleteItem g_stopwatch (g_stopwatch.count)
    format "#Timing Stop: % secs %\r\n" (l_stopwatch/1000.0) txt
)


------------------------------
--- export buffer flusher  ---
------------------------------
fn nx_FlushBuffer force:false reset:false =
(
   if not g_ismax then
   (
    -- Test that the string stream in g_strBuffer is greater than out max size.
    -- If it is then flush the string stream to the Listener
    if ( ((filepos g_strBuffer) > 9800) or force ) and (not reset) then
    (
        -- flush the buffer to listener
        format "%" (g_strBuffer as string)
        -- reset the buffer
        g_strBuffer = undefined
        g_strBuffer = stringStream ""
        if force then
        (
            if g_delim == "~" then (
                    format "\r\n"
                )
            )
    ) else if reset then
    (
        g_strBuffer = undefined
        g_strBuffer = stringStream ""
    )
   )
)

-------------------------------
--- edges verts as a point2 ---
-------------------------------
fn nx_edgeVerts theObj theEdge = 
( 
    if not (classof theObj == Editable_mesh or 
    classof theObj == triMesh) do return undefined 
    if theEdge < 1 or theEdge > (theObj.numfaces*3) do return undefined 
    local theFace = ((theEdge-1)/3)+1 
    local theVerts = getFace theObj theFace 
    case ((mod (theEdge-1) 3) as integer) of 
    ( 
        0: point2 theVerts.x theVerts.y 
        1: point2 theVerts.y theVerts.z 
        2: point2 theVerts.z theVerts.x 
    ) 
) 

------------------------------
--- ClassOf node as String ---
------------------------------
fn nx_strclassof obj =
(
    --
    -- Get the objects class as a string
    --
    return ( (classof obj) as string )
)

--------------------------
--- Boolean to Integer ---
--------------------------
fn nx_btoi b =
(
    local r
    if b then
        r = 1
    else
        r = 0
        
    r
)

--------------------------
--- Integer to Boolean ---
--------------------------
fn nx_itob i =
(
    local r
    if i == 0 then
        r = false
    else
        r = true
        
    r
)


------------------------------
--- Read TGA bit for depth ---
------------------------------
fn nx_read_tga_bit f_file = 
( 
    -- depth of 32 means an alpha channel
    local fh = undefined 
    local depth = 0 
    fh = fopen f_file "rb" 
    if fh != undefined then 
    ( 
        fseek fh 16 #seek_set 
        depth = readByte fh 
        fclose fh 
    ) 
    else print "!! ERROR !!" 
    depth 
)


-----------------------------------
--- Do plug in loading progress ---
-----------------------------------
fn nx_progressPlus =
(
    com_load = com_load + 1
    progressUpdate ((com_load*100)/com_load_total)
)

------------------------
--- Unique node name ---
------------------------
fn nx_MakeUnqiueNodeName strName=
(
    local i = 0
    while (true) do
    (
        i += 1
        local obj_name = strName + (i as string)
        local node = getNodeByName(obj_name)
        if node == undefined then
            return obj_name
    )
)

---------------------
--- round integer ---
---------------------
fn nx_round x =
(
    local correction = 0 as integer
    local tenth = ((mod x 1) * 10) as integer
    if (tenth >= 5) then correction = 1 as integer
    return (((x as integer) + correction) as integer)
)

--------------------
--- round point3 ---
--------------------
fn nx_roundp3 pIn =
(
    p = copy pIn
    local rn
    -- round 'x'
    rn = p.x - (floor p.x)
    if (rn > 0.5) then
       p.x = ceil p.x
    else
      p.x = floor p.x
    -- round 'y'
    rn = p.y - (floor p.y)
    if (rn > 0.5) then
        p.y = ceil p.y
    else
        p.y = floor p.y
    -- round 'z'
    rn = p.z - (floor p.z)
    if (rn > 0.5) then
        p.z = ceil p.z
    else
        p.z = floor p.z
    -- return rounded point
    return p
)

------------------
--- Lower case ---
------------------
fn nx_lowercase instring =
(
    -- Joco 8-Aug-03: needed to cope with some keywords in mdl
    -- not being consistently cased when compared to peoples docs.
    -- May be made redundant very soon!
    local upper, lower, outstring

    upper="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    lower="abcdefghijklmnopqrstuvwxyz"

    -- if 'undefined' then return null string
    if instring == undefined then return ""

    outstring=copy instring -- operate on copy of instring
    for i=1 to outstring.count do
    (
        j=findString upper outstring[i]
        if j != undefined do outstring[i]=lower[j]
    )
    return outstring
)


----------------------------
--- Check if file exists ---
----------------------------
fn nx_existFile fname = (getfiles fname).count != 0

---------------------------------
--- Check if directory exists ---
---------------------------------
fn nx_existDir dname =
(
    local dirstr
    if (dname[dname.count] == "\\") or (dname[dname.count] == "/") then (
        dirstr = substring dname 1 (dname.count - 1)
    ) else (
        dirstr = dname
    )
    (getDirectories dirstr).count != 0
)

---------------------------------
--- Get the file size         ---
---------------------------------
fn nx_filesize fh =
(
    local fsize = 0
    if fh == undefined then return false
    try (
        inipos = filepos fh
        while not eof(fh) do
        (
            fsize += 1
            seek fh fsize
        )
        seek fh inipos
    ) catch ()
    return fsize
)

-------------------------------------
--- Rotating only the pivot point ---
-------------------------------------
fn nx_RotatePivotOnly obj rotation =
(
    local rotValInv=inverse (rotation as quat) 
    animate off in coordsys local obj.rotation*=RotValInv 
    obj.objectoffsetrot*=RotValInv 
    obj.objectoffsetpos*=RotValInv 
) 

------------------------------------------------------
--- Copy the modifiers from src to dst.            ---
--- Code by roboius (http://rockbottom.vtex.net/)  ---
------------------------------------------------------
fn nx_copy_modifiers dst src ignore:#()=
(
    local ii

    for ii in src.modifiers.count to 1 by -1 do
    (
        if (finditem ignore src.modifiers[ii].name) == 0 then
            addmodifier dst (copy src.modifiers[ii])
    )
)

-------------------------------------------------
--- Similar to the "Reset Transform" utility. ---
--- Thanks to Roboius                         ---
-------------------------------------------------
fn nx_reset_transforms obj =
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



-------------------------------------
--- UpdateMaterialEditor function ---
-------------------------------------
fn nx_UpdateMaterialEditor MatLib=
(
    -- from Waylands original script
    if MatLib.count > 0 then
    (
      local curLibIndex = 1
      for matIndex in 1 to 24 do
      (
        curMat = meditMaterials[matIndex]
        if findString curMat.name " - Default" != 0 then
        (
          -- Put the model material into the Material Editor
          setMeditMaterial matIndex MatLib[curLibIndex]
          -- Set the sample object type for this material to a square
          setMTLMeditObjType MatLib[curLibIndex] 3
          curLibIndex = curLibIndex + 1
          if curLibIndex > MatLib.count then
          (
            exit
          ) -- end curLibIndex > MatLib.count check
        ) -- end current material slot in editor is a standard material check
      ) -- end materials in editor loop
    ) -- end MatLib.count > 0 check
) -- end UpdateMaterialEditor function




-----------------------------------
--- Create NWN Surface Material ---
-----------------------------------
global nx_SurfaceMat = #()
fn nx_createNWNWalkMaterial =
(
    if DEBUG then format "%nx_createNWNWalkMaterial: start\r\n" strIndent1
    -- from Wayland's script
    local SurfaceMatName = #()
    nx_SurfaceMat = #()
    local matName = "NWN_WalkMaterial";

    local newMaterial = sceneMaterials[matName]
    if (newMaterial == undefined) then
    (
        -- only create the material of it's not already done
        --
        
        -- get the material count
        local num_mats = (getINISetting (g_startpath+"wokmat.ini") "init" "count") as integer
        local mat_name
        
        for m = 1 to num_mats do
        (
            mat_name = getINISetting (g_startpath+"wokmat.ini") ("m"+(m as string)) "name"
            append SurfaceMatName mat_name
            nx_exec_str = "append nx_SurfaceMat "+(getINISetting (g_startpath+"wokmat.ini") ("m"+(m as string)) mat_name)
            execute nx_exec_str
        )

       newMaterial = multimaterial name:matName numsubs:SurfaceMatName.count

       for i in 1 to SurfaceMatName.count do
       (
         newMaterial.names[i] = SurfaceMatName[i]
         -- Max 2021 may create Physical Materials as the default submaterial.
         newMaterial.materialList[i] = standardMaterial name:SurfaceMatName[i] diffuse:nx_SurfaceMat[i]
       )
    )
    nx_SurfaceMat = undefined
    if DEBUG then format "%nx_createNWNWalkMaterial: end\r\n" strIndent1
    return newMaterial
)


-----------------------------------
---                             ---
-----------------------------------
fn nx_setinivalue datalist =
(
    /*
    Data list is an array of arrays.
    Each sub array contains the section, atrrib, vlaue, file
    */
    local sublist
    
    if g_ismax then
    (
        for sublist in datalist do
        (
            setINISetting sublist[4] sublist[1] sublist[2] sublist[3]
        )
    ) else
    (
        -- gmax processing. Verbose data dumping
        clearListener()
        format "<snoopstart file=%>~\n\n" (gNX_scratchPath+"setini.txt")
        for sublist in datalist do
        (
            format "<snoopset %,%,%,%,\>~\n" sublist[1] sublist[2] sublist[3] sublist[4]
        )
        format "</snoopstart>~\n"
        format "</snoopend>~\n"
    )
)


-----------------------------------
--- Anim Key reduction          ---
-----------------------------------
fn nx_reduct obj start end pos:false rot:false sca:false \
            thresholdRot:0 thresholdPos:0 safeframes:#() =
(
   -- get all the controllers
    local ctrls = #()
    if pos then append ctrls obj.position.controller
    if rot then append ctrls obj.rotation.controller
    if sca then append ctrls obj.scale.controller
    
    -- start reduction on each controller type
    local basekey, comparekey1, comparekey2, delKey
    local delkeys
    for ctrl in ctrls do
    (
        if (ctrl != undefined) AND (ctrl.keys != undefined) then
        (
            basekey = 1
            comparekey1 = basekey + 1
            comparekey2 = basekey + 2
            while (comparekey2 <= ctrl.keys.count) and (ctrl.keys[comparekey2].time <= end) do
            (
                delKey = false
                -- get starting values
                baseval = ctrl.keys[basekey].value
                compval1 = ctrl.keys[comparekey1].value
                compval2 = ctrl.keys[comparekey2].value
                
                -- compare type depends on the control type
                if (iskindof baseval Point3) then
                (
                    -- this is a position control type
                    diff1 = abs(distance baseval compval1)
                    diff2 = abs(distance baseval compval2)
                    
                    /*
                    Convert to using a gradient based test.
                    Do this test on x,y,z and only delete key if all three are within
                    the specified threshold.
                    arctan(opp/adj) == angle
                    adj == time
                    opp == position axis difference between keys
                    
                    Appraoch is for each axis calc the angles of the vectors from
                    that axis and compare them to the threshold. If all the vector
                    angles for the key are within tolerances then delete
                    that position key
                    */
                    
                    delKeyX = false
                    delKeyY = false
                    delKeyZ = false
                    
                    -- x axis
                    if DEBUG then format "X axis\r\n"
                    opposite = compval1.x - baseval.x
                    adjacent = ctrl.keys[comparekey1].time - ctrl.keys[basekey].time
                    angle1 = atan(opposite/adjacent)
                    opposite = compval2.x - compval1.x
                    adjacent = ctrl.keys[comparekey2].time - ctrl.keys[comparekey1].time
                    angle2 = atan(opposite/adjacent)
                    if abs(angle2 - angle1) <= thresholdPos then delKeyX = true
                    if DEBUG then format "Key: %  Type: %\r\n" comparekey1 (classof baseval)
                    if DEBUG then format "Angle1: %   Angle2: %   Abs Diff: %\r\n" angle1 angle2 (abs(angle2-angle1))
                    -- y axis
                    if DEBUG then format "X axis\r\n"
                    opposite = compval1.y - baseval.y
                    adjacent = ctrl.keys[comparekey1].time - ctrl.keys[basekey].time
                    angle1 = atan(opposite/adjacent)
                    opposite = compval2.y - compval1.y
                    adjacent = ctrl.keys[comparekey2].time - ctrl.keys[comparekey1].time
                    angle2 = atan(opposite/adjacent)
                    if abs(angle2 - angle1) <= thresholdPos then delKeyY = true
                    if DEBUG then format "Key: %  Type: %\r\n" comparekey1 (classof baseval)
                    if DEBUG then format "Angle1: %   Angle2: %   Abs Diff: %\r\n" angle1 angle2 (abs(angle2-angle1))
                    -- z axis
                    if DEBUG then format "X axis\r\n"
                    opposite = compval1.z - baseval.z
                    adjacent = ctrl.keys[comparekey1].time - ctrl.keys[basekey].time
                    angle1 = atan(opposite/adjacent)
                    opposite = compval2.z - compval1.z
                    adjacent = ctrl.keys[comparekey2].time - ctrl.keys[comparekey1].time
                    angle2 = atan(opposite/adjacent)
                    if abs(angle2 - angle1) <= thresholdPos then delKeyZ = true
                    if DEBUG then format "Key: %  Type: %\r\n" comparekey1 (classof baseval)
                    if DEBUG then format "Angle1: %   Angle2: %   Abs Diff: %\r\n" angle1 angle2 (abs(angle2-angle1))
                    
                    if (delKeyX and delKeyY and delKeyZ) then delKey = true
                )
                
                if (iskindof baseval Quat) then
                (
                    diff1 = abs(baseval.angle - compval1.angle)
                    diff2 = abs(baseval.angle - compval2.angle)
                    tol = abs(baseval.angle * thresholdRot)
                    strAxis0 = baseval.axis as string
                    strAxis1 = compval1.axis as string
                    strAxis2 = compval2.axis as string
                    if DEBUG then format "KeyTime: %  Type: %\r\n" (ctrl.keys[comparekey1].time) (classof baseval)
                    if DEBUG then format "Diff1:%  Diff2:%  Tol:%  Axis:% % %\r\n" diff1 diff2 tol baseval.axis compval1.axis compval2.axis
                    if DEBUG then format "Axis test: % %\r\n" (strAxis0 == strAxis1) (strAxis0 == strAxis2)
                    if (strAxis0 == strAxis1) and (strAxis0 == strAxis2) then
                    (
                    if DEBUG then format "Tol test: % %\r\n" (diff1 <= tol) (diff2 <= tol)
                    if (diff1 <= tol) and (diff2 <= tol) then
                    (
                        delKey = true
                    )
                    )
                )
                
                -- now check that the current key is in the target frame range
                if (ctrl.keys[comparekey1].time < start) and (ctrl.keys[comparekey1].time > end) then
                (
                    delKey = false
                )
                -- check that the key frame is not a protected frame.
                -- Frames are deemed protected if they are the start and end of a
                -- NWN named animation range
                if (findItem safeframes (ctrl.keys[comparekey1].time)) != 0 then
                (
                    delKey = false
                )
                
                if delKey then
                (
                    -- delete comparekey1
                    if DEBUG then format "Del key: %\r\n" comparekey1
                    deleteKey ctrl comparekey1
                ) else
                (
                    -- move the baseline forward
                    basekey = comparekey1
                    comparekey1 += 1
                    comparekey2 += 1
                )
            )
        )
    )
)


-----------------------------------
---  Pivot Snap Function        ---
-----------------------------------
fn nx_snaptonormalpivots matchpatrn pivotonly:false =
(
    local race = matchpatrn[3]
    local sex = matchpatrn[2]
    local pheno = matchpatrn[4]
    --local snapfile = substring matchpatrn 1 3
    local snapfile = matchpatrn
    local pivotINI
    
    -- sanity checks
    if matchpatrn[1] != "p" then
    (
        strMsg = "Make sure source files are named correctly.\ne.g. pmh0_robe050.max"
        messageBox strMsg
        return 0
    )
    
    pivotINI = g_startpath+"pv_" + snapfile + ".ini"
    if not (nx_existFile pivotINI) then
    (
        strMsg = "Pivot ini file does not exist"
        messageBox strMsg
        return 0
    )
    
    local maxData = ((getINISetting pivotINI "init" "nPivots") as integer)
    -- if maxData is undefined then fundamental error
    if maxData == undefined  or maxData < 1 then
    (
        strMsg = "Pivot in .ini scale file. Make sure nTransforms key is set."
        messageBox strMsg
        return 0
    )
    format "Max entries: %\r\n" maxData
    
    -- load up the scale data and parts mapping data
    local pivotData = nx_MultiArray()
    pivotData.width = 3
    
    local index, s, temp
    local match, sub, part,  scaleMatrix
    for index = 0 to (maxData-1) do
    (
        s = "s" + (index as string)
        part = getINISetting pivotINI s "part"
        match = getINISetting pivotINI s "match"
        temp = filterString (getINISetting pivotINI s "pivot") "(),"
        pivotMatrix = point3 (temp[1] as float) (temp[2] as float) (temp[3] as float)
        pivotData.append ( #(part, match, pivotMatrix) )
        temp = undefined
    )
    
    format "Pivot data count: %\r\n" pivotData.ArrayData.count
    format "race: % sex: % pheno: %\r\n" race sex pheno
    
    -- process the pivots for the scene
    local i, r, s, p
    local part
    for node in $objects do
    (
        for i = 1 to (pivotData.size()) do  -- find the pivot to use
        (
            r = ((pivotData.get i 2)[3] == race)
            s = ((pivotData.get i 2)[2] == sex)
            p = ((pivotData.get i 2)[4] == pheno)
            
            part = pivotData.get i 1
            
            if (nx_lowercase(part) == nx_lowercase(node.name)) and r and s and p then
            (
                pos_data = pivotData.get i 3
                format "Pivot found for: % : Value: %\r\n" node.name pos_data
                if pivotonly then
                (
                    -- move the pivot only, keep mesh static
                    node.pivot = pos_data
                )
                else
                (
                    -- set the pos for pivot and mesh
                    node.pos = pos_data
                )
                exit    -- stop the loop
            )
        )
    )
)


---------------------------------------
---  Create alpha map from tga file ---
---------------------------------------
fn nx_tiff_from_tex bmp =
(
    local h = bmp.height
    local w = bmp.width
    local r     -- row counter
    local c     -- column counter
    local rowdata
    local new_bmp
    local gs_value
    local newbmp_filename

    -- create new grayscale image
    newbmp_filename = (getFilenamePath bmp.filename) + (getFilenameFile bmp.filename) + ".tif"
    new_bmp = bitmap w h color:black filename:newbmp_filename
    -- copy the bmp
    copy bmp new_bmp
	save new_bmp
	new_bmp
)


--------------------------------------
---  Create material from tga file ---
--------------------------------------
fn nx_mat_from_tga tgaFile matName index:0 =
(
    local objMaterial, tga, texMap, tgaDepth
    
    objMaterial = standardmaterial name:matName
    objMaterial.shaderType = 1 -- Blinn
    objMaterial.ambient = color 220 220 220
    objMaterial.diffuse = color 220 220 220
    objMaterial.specular = color 220 220 220
    objMaterial.glossiness = 10
    objMaterial.selfillumcolor = color 0 0 0
    objMaterial.opacity = 100
    objMaterial.soften = 0.1
    
    if (nx_existFile tgaFile) then
    (
        tga = openBitMap(tgaFile)
        tgaDepth = nx_read_tga_bit tgaFile
    )
    else
    (
        -- fundamental error, texture no longer there
        messagebox "Error in finding a tga file,\ncheck all tgas are still in place"
        return false
    )
    
    texMap = BitmapTexture bitmap:tga name:matName
    objMaterial.mapAmounts[2] = 100
    objMaterial.maps[2] = texMap
    objMaterial.mapEnables[2] = true;
    showTextureMap objMaterial texMap true
    if index > 0 then
    (
        setMeditMaterial index objMaterial
    )
    objMaterial
)


fn nx_deletekeysinblock obj framestart frameend typeslist =
(
	/*
	work through the objects in the scene and delete the keys
	*/
	local cntrl
	local propnames
	local mctrl
	
	cntrl = #(undefined, undefined, undefined)
	-- get the standard controllers
	if typeslist[1] then (
		try (
			cntrl[1] = obj.pos.controller
		) catch (
			cntrl[1] = undefined
		)
	)
	if typeslist[2] then (
		try (
			cntrl[2] = obj.rotation.controller
		) catch (
			cntrl[2] = undefined
		)
	)
	
	if typeslist[3] then (
		try (
			cntrl[3] = obj.scale.controller
		) catch (
			cntrl[3] = undefined
		)
	)
	
	-- delete the standard controllers
	for c in cntrl do
	(
		if c != undefined then
		(
			for k = c.keys.count to 1 by -1 do
			(
				if (c.keys[k].time >= framestart) and (c.keys[k].time <= frameend) then
				(
					deleteKey c.keys k
				)
			)
		)
	)
	
	-- now deal with modifiers on obj with animated properties
	if typeslist[4] then
	(
		for m in obj.modifiers do
		(
			propnames = getPropNames m
			for prop in propnames do
			(
				mctrl = getPropertyController m prop
				-- if there is a controller then deal with its keys
				if mctrl != undefined then
				(
					for k = mctrl.keys.count to 1 by -1 do
					(
						if (mctrl.keys[k].time >= framestart) and (mctrl.keys[k].time <= frameend) then
						(
							deleteKey mctrl.keys k
						)
					)
				)
			)
		)
	)
	
	-- work through children
	for child in obj.children do
	(
		nx_deletekeysinblock child framestart frameend typeslist
	)
)