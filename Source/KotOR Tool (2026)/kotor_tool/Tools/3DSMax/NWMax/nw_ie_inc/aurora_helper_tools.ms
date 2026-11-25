/*-----------------------------------------------------------------------------\

    Aurora Helper Tools


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

plugin helper auroramonsterbox
name:"MonsterNode"
(
	tool create
	(
    	local node
		local crrntMCount = 0
		local modelBase
	
    	on start do
    	(
        	crrntMCount = 0
    		for h in $helpers do
    		(
        		if (matchPattern h.name pattern:"monster?") and \
        		    (classof h) == Dummy then
    		    (
        		    crrntMCount += 1
    		    )
    		    if (nx_strclassof h) == "aurorabase" then
    		        modelBase = h
    		)
    	)
    	
		on mousePoint click do
		(
    		if click < 10 and crrntMCount < 10 then
    		(
    			-- we make monster bases here.
    			crrntMCount += 1
    			in coordsys grid node = dummy pos:gridPoint
    			node.boxSize = [10,10,10]
    			node.name = "monster" + ((crrntMCount-1) as string)
    			node.parent = modelBase
        	)
        	return #stop
		)
	)
)