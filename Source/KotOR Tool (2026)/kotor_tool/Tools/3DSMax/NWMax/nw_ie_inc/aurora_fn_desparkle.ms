/*-----------------------------------------------------------------------------\

    Aurora Desparkle Code


    GMAX MDL Tool for NWN
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

fn nx_mesh_desparkle node =
(
    if DEBUG then format "#nx_mesh_desparkle\r\n"

    -- only fix IF is a trimesh.
    if (canConvertTo node Editable_mesh) then
    (
        -- Code from Bioware's scripts
        -- Takes care of sparkly-bit removal for tiles.
        -- It then rounds off the vertices to the nearest centimetre.
    
        -- work through the mesh and apply the vertice roundings
        -- to do this we need to collapse the mesh. We keep a copy of the mesh
        -- hold all the modifiers and then reapply them later.
    	local i
    	
    	format "Node Mesh: % :- %\r\n" node.name node
    	format "Saving copy of node ...\r\n"
    	local copy_of_meshnode = copy node
    	local node_mods_count = (node.modifiers).count
    	--local nodeMesh = node.mesh
    	
    	convertToMesh node
    	
    	for i= 1 to node.numverts do
    	(
    		local v,p3
    		--v = in coordsys local getvert node i
    		v = getvert node i
    		-- We round to the nearest centimetre.
    		-- MAXscript doesn't have a round function, so we make our own
			p3 = nx_roundp3 v
    		format "  Vertex [%]: % % % --> % % %\r\n" i v.x v.y v.z p3.x p3.y p3.z
    		setVert node i p3
    	)
    	
    	update node
    	
    	-- Copy modifiers from node copy to original collapsed node
    	if node_mods_count != 0 then
    	(
    		for i = node_mods_count to 1 by -1 do
    		(
    			addmodifier node copy_of_meshnode.modifiers[i]
    		)
    		format "  Deleted duplicate mesh.\r\n"
    	)
   		delete copy_of_meshnode

        -----------------------------------------------------
        ---- End sparkly bit removal
        ----------------------------------------------------
    ) else
    (
        format "Node [%] not Editable_Mesh, skipped.\r\n" node.name
    )-- end if
    
	for child in node.children do
	(
    	nx_mesh_desparkle child
	)

) -- end fn
