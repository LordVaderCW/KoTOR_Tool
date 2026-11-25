/*-----------------------------------------------------------------------------\

    MDL Placeable/Door Modifer
    
    This modifier stores the information needed by the Aurora engine for
    placeable and door walk meshes.
    
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
format "load: aurora_mod_placeable.ms\r\n"
nx_progressPlus()

plugin simpleMod auroraplaceable
name:"AuroraPlaceable" 
classID:#(0x7b1334e9, 0x4179231c)
version:1
(
	parameters paramblock rollout:mdlPlaceableParams
	(
    	meshtype        type:#integer default:1 ui:radio_meshtype
	)

	rollout mdlPlaceableParams "MDL Placeable/Door" width:162 height:335
    (
        radiobuttons radio_meshtype "" labels:#("Placeable [PWK]", "Door [DWK]") align:#left
    )

	on map i p do
	(
		-- We do nothing here
		-- Per BioWare:
		-- This is a simplemod so it expects us to be adjusting
		-- the point positions, but we dont want to do that.
	)
)
