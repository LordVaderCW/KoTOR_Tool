/*-----------------------------------------------------------------------------\

    Texture Library Manager
    

    NWmax for NWN
    by Joco (jameswalker@clear.net.nz)

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

rollout nx_texmanmaker "TexLib Maker"
(
	-- vars
	local tga_list_name, tga_list
	
	-- gui
	ListBox lst_textures "TGA Textures" height:15
	edittext edt_loaddir "Load Dir" align:#left
	button btn_browse "Browse"
	button btn_add "Add TGAs in Dir"
	edittext edt_libname "Lib Name"
	button btn_save "Save Lib"
	
	-- actions
	on nx_texmanmaker open do
	(
		tga_list = #()
		tga_list_name = #()
	)
	
	on btn_browse pressed do
	(
		local dir = getSavePath caption:"TGA Files Location"
		if dir != undefined then
		(
			edt_loaddir.text = dir
		)
	)
	
	on btn_add pressed do
	(
		-- make sure exists
		if not nx_existDir(edt_loaddir.text) then
		(
			return false
		)
		local dir = edt_loaddir.text
		local files
		
		if dir[dir.count] != "/" and dir[dir.count] != "\\" then
			dir += "\\"
		
		files = getFiles(dir + "*.tga")
		for f in files do
		(
			append tga_list f
			append tga_list_name (getFilenameFile f)
		)
		-- set the display list
		lst_textures.items = tga_list_name
	)
	
	on btn_save pressed do
	(
		-- make sure we have an acceptable file name
		if(edt_libname.text == undefined) or \
			(edt_libname.text.count == 0) then
		(
			messagebox "Invalid library name"
			return false
		)
		local fs = createFile (gNX_tlibsPath+"" + edt_libname.text + ".tlib")
		if fs == undefined then
		(
			-- some file error
			messagebox "unable to create texture lib file"
			return false
		)
		for tga in tga_list do
		(
			format "%\n" (tga as string) to:fs
		)
		flush fs
		close fs
	)
)

createDialog nx_texmanmaker