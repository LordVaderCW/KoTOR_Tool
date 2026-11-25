/*-----------------------------------------------------------------------------\

    Order Child Nodes

    NWmax (gmax)
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
-- Used to create model dialog for Ordering Children
rollout nx_OrderChildren "Order Selected Node's Children" width:232 height:328
(
    
	listbox clist "Child Objects" pos:[27,18] width:135 height:18
	button btn_up "Up" pos:[175,121] width:45 height:24
	button btn_down "Down" pos:[175,171] width:45 height:24
	button btn_ok "OK" pos:[79,290] width:74 height:24
	--button btn_cancel "Cancel" pos:[160,291] width:74 height:24
	
	on nx_OrderChildren open do
	(
	    local strList
		-- initalise the dialog
		local sel = selection[1]
		if sel == undefined then return 0
		-- build array of text strings for list
		strList = #()
		for c in sel.children do
		    append strList c.name
		    
	    clist.items = strList
	    if strList.count > 0 then clist.selection = 1
	)
	
	on btn_up pressed do
	(
    	format "btn_up::start\n"
		if clist.selection == 1 then return 0
		local sel = selection[1]
		local list = clist.items
		-- swap the text items over
		local index = clist.selection
		local strTemp = list[index]
		list[index] = list[index-1]
		list[index-1] = strTemp
		clist.items = list
		clist.selection = index - 1
		-- swap the underlying child items over by using their parents
    	format "btn_up:: swap objects\n"
		local childrenTemp = #()
		for c in sel.children do
		    append childrenTemp c
	    
		local objTmp = childrenTemp[index]
		childrenTemp[index] = childrenTemp[index-1]
		childrenTemp[index-1] = objTmp
		-- now reset the parents of all the child nodes
    	format "btn_up:: reset\n"
		for c in childrenTemp do
		    deleteItem sel.children c
	    
	    -- re apply the children in new order
    	format "btn_up:: reassign\n"
		for c in childrenTemp do
	        append sel.children c
	        
        -- release memory
        childrenTemp = #()
	)
	on btn_down pressed do
	(
    	format "btn_down::start\n"
		if clist.selection == clist.items.count then return 0
		local sel = selection[1]
		local list = clist.items
		-- swap the text items over
    	format "btn_down:: swap text in list\n"
		local index = clist.selection
		local strTemp = list[index]
		list[index] = list[index+1]
		list[index+1] = strTemp
		clist.items = list
		clist.selection = index + 1
		-- swap the underlying child items over by using their parents
    	format "btn_down:: swap objects\n"
		local childrenTemp = #()
		for c in sel.children do
		    append childrenTemp c
	    
		local objTmp = childrenTemp[index]
		childrenTemp[index] = childrenTemp[index+1]
		childrenTemp[index+1] = objTmp
		-- now reset the parents of all the child nodes
    	format "btn_down:: reset\n"
		for c in childrenTemp do
		    deleteItem sel.children c
	    
	    -- re apply the children in new order
    	format "btn_down:: reassign\n"
		for c in childrenTemp do
	        append sel.children c
	        
        -- release memory
        childrenTemp = #()
	)
	on btn_ok pressed do
	(
		-- finish
		DestroyDialog nx_OrderChildren
	)
)

createDialog nx_OrderChildren modal:true