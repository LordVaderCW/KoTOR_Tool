/*-----------------------------------------------------------------------------\

    NWmax About

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

rollout CreditDialog "Credits" width:326 height:351
(
	label lbl5 "This is based on, adapted from and an extension of code originally developed by:
Bioware
Joco
Wayland
Special thanks and acknowledgements to 
* DLA (ideas, mentoring and lots of bug reports)
* roboius (assistance, code and \"The TileSlicer\")
* Velmar (animation lists, code and \"Velmar Tools\")
* Torlack (\"nwnmdlcomp\" mdl compiler/decompiler)
* simple tim (fixes posted in the Vault for the orginal Wayland script)
* scooterpb (MDL Suite UI)
* Zaddix (original WOK file importer)
* Revinor (decoding the MDL format)
" pos:[21,10] width:284 height:235
	label lbl_modcredits "Max 2021 compatibility and modernization\nModifications by lordvadercw" pos:[21,252] width:284 height:44
	button btn_close "Close" pos:[111,310] width:104 height:32
	on btn_close pressed do
		destroyDialog CreditDialog
)
rollout AboutRollout "NWmax" width:162 height:400
(
    local bmap = g_startpath+"nw_ie_inc/nwmax_v1.bmp"
    local maskmap = g_startpath+"nw_ie_inc/nwmax_v1_mask.bmp"
	button btn_nwmax "" pos:[9,7] width:144 height:90 \
    	images:#(bmap, maskmap, 1, 1, 1, 1, 1) \
    	toolTip:"Click for About/Credits."
	
	-- shockwave: "{D27CDB6E-AE6D-11CF-96B8-444553540000}"
	--activeXControl actx "{D27CDB6E-AE6D-11CF-96B8-444553540000}" \
	--    width:144 height:90 align:#center
	label lbl_ver ""
	label lbl_modauthor "Max 2021 modifications\nby lordvadercw" width:144 height:32 align:#center
	
	HyperLink hlink_nwmax "nwmax.dladventures.com" address:"http://nwmax.dladventures.com/" align:#center
	HyperLink hlink_dla   "www.dladventures.com" address:"http://www.dladventures.com/" align:#center
	HyperLink hlink_vote  "Vote NWmax at NWVault" address:"http://nwvault.ign.com/Files/other/data/1072761698656.shtml" align:#center
	HyperLink hlink_docs  "NWmax Help" address:("file:///"+g_startpath+"docs/index.html") align:#center
	HyperLink hlink_ccg   "CCG Wiki by DLA" address:"http://ccg.dladventures.com/" align:#center

	--button btn_code_reload "Reload Code"

	on btn_nwmax pressed do
		( createDialog CreditDialog )
	
	on btn_code_reload pressed do
		(
			nx_coderefresh()
		)
	
		
    on AboutRollout open do
    (
        --format "%\r\n" (showProperties actx)
        --actx.LoadMovie 0 "e:/nwmax.swf"
        lbl_ver.text = gblVersion
    )
)

