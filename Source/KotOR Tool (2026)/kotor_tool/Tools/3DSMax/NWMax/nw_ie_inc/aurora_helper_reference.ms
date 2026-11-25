/*-----------------------------------------------------------------------------\

    Aurora Reference Helper Object

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
format "load: aurora_helper_reference.ms\r\n"
nx_progressPlus()

plugin helper aurorareference
name:"AuroraRef" 
classID:#(0x994096b0, 0x2b62706c) 
version:1
extends:Dummy
replaceUI:true 
invisible:true
(
	parameters main rollout:params 
	(
		refModel        type:#string default:"fx_ref" ui:edit_refModel
		reattachable    type:#integer default:1 ui:box_reattachable
	)

	rollout params "MDL Reference Parameters" 
	(
    	edittext edit_refModel "Ref Model"
    	checkbox box_reattachable "Reattachable"
    )
)

plugin helper aurorarefbox
name:"AuroraRef"
(
	local ref
	tool create
	(
    	fn makeref =
    	(
			in coordsys grid ref = aurorareference pos:gridPoint
			ref.delegate.boxSize = [10,10,10]
        	local objCone = cone height:-25 pos:gridPoint heightsegs:1 sides:4 smooth:false
        	objCone.wireColor = (color 92 179 240)
        	objCone.parent = ref
        	objCone.name = "ignore_" + objCone.name
    	)
    	
		on mousePoint click do
		(
        		makeref()
    			select ref
		)
	)
)