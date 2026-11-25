/*-----------------------------------------------------------------------------\

    Tile Group Loader

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


/*
Load groups of tiles and position them.
Needs to read data from .set files.
*/


rollout nx_loadgrp "Tile Group Loader"
(
   local groups
   edittext edt_setfile "SET:"
   button btn_browse "Browse"
   listbox lst_grps "Groups" height:10 width:175
   button btn_load "Load Group"
   
   on btn_browse pressed do
   (
      local filename = getOpenFileName caption:"SET File" types:"NWN set (*.set)|*.set|All Files (*.*)|*.*|"
      if (filename == undefined) then filename = ""

      edt_setfile.text = filename
      groups = #()
      
      -- parse the groups from the set file
      local grp_count = (getINISetting filename "GROUPS" "Count") as integer
      local grp_name
      for i = 0 to (grp_count-1) do
      (
         grp_name = getINISetting filename ("GROUP" + (i as string)) "Name"
         grp_name =  "[" + (i as string) + "]  " + grp_name
         append groups grp_name
      )
      lst_grps.items = groups
      lst_grps.selection = 1
   )
   
   on btn_load pressed do
   (
      local rows, columns, grp_number, filename, tile_name, tile_number
      local rowpl, columnpl, model_base
      local model_path
      local models = #()
      
      local sel_text = lst_grps.selected
      local data = filterString sel_text " []"
      filename = edt_setfile.text
      grp_number = data[1]
      rows = (getINISetting filename ("GROUP" + grp_number) "Rows") as integer
      columns = (getINISetting filename ("GROUP" + grp_number) "Columns") as integer
      
      for i = 0 to ((rows * columns)-1) do
      (
         tile_number = getINISetting filename ("GROUP" + grp_number) ("Tile" + (i as string))
         if tile_number != "-1" then
         (
	         tile_name = getINISetting filename ("TILE" + tile_number) "Model"
         ) else
         (
	         tile_name = "RANDOM"
         )
         append models tile_name
      )
      clearListener()
      format "Models: %\r\n" models
      
      -- got the model names. Assume in same path as set file.
      model_path = getFilenamePath filename
      
      rowpl = 0
      columnpl = 0
      for model in models do
      (
		if model != "RANDOM" then
		( 
			ImportNWNmdl \
				(model_path + model + ".mdl") \
				true \
	            false
		)
         model_base = getNodeByName model
         if model_base == undefined then
         (
            format "ERROR: Can't find modelbase\r\n"
         ) else
         (
	         model_base.pos = [(columnpl * 1000),(rowpl * 1000),0]
         )
         if columnpl >= (columns-1) then
         (
            columnpl = 0
            rowpl += 1
         ) else
         (
            columnpl += 1
         )
      )
         
      -- Redraw gmax viewports
      clearSelection()
      max tool zoomextents all
      max views redraw
      
      --ImportRollout.progress.value = 0
      --percent = 0
      
      --format "Finished.\n\r\n"
      gc()
   )
)

createDialog nx_loadgrp width:200