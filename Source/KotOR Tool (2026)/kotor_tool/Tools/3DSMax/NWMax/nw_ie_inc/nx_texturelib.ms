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

rollout nx_texman "TexLib Loader" width:750 height:691
(
	local tlibFile
	local tlibTGAs
	
	-- gui
	listbox lst_libs "Texture Libs" pos:[13,7] width:200 height:10
	multiListBox lst_textures "TGA Textures" pos:[13,165] width:200 height:20
	multiListBox lst_meditmats "Mat Edit Slots" pos:[12,455] width:200 height:15
	bitmap bmp_backgrnd  pos:[225-4,28-5] filename:(g_startpath+"nw_ie_inc/520sq.jpg")
	ImgTag imgt_preview "Preview" pos:[225,28] width:512 height:512 style:#bmp_center
	label lbl_info "" pos:[227,547] width:550 height:100
	button btn_addsel "Add selected to Scene" pos:[227,650] width:124 height:21
	button btn_refreshmats "Refresh Mat Editor Slots" pos:[361,650] width:124 height:21
	button btn_rebuild "Rebuild Open Library" pos:[495,650] width:124 height:21
	
	-- actions
	on nx_texman open do
	(
		-- get the available texture libs
		tlibTGAs = #()
		local tlibs = #()
		local files = getFiles (gNX_tlibsPath+"*.tlib")
		for f in files do
		(
			append tlibs (getFilenameFile f)
		)
		lst_libs.items = tlibs
		lst_libs.selection = 0
		
		-- populate the materials editors list
		local mats = #()
		for i = 1 to 24 do
		(
			append mats (meditMaterials[i].name)
		)
		lst_meditmats.items = mats
	)
	
	on lst_libs selected val do
	(
		-- load into the tga list all the tga names from the selected texture lib
		local instr
		local fname = gNX_tlibsPath+"" + lst_libs.items[val] + ".tlib"
		local fs = openFile fname mode:"r"
		local templist = #()
		if fs == undefined then
		(
			-- can't open file
			messagebox "Unable to open texture lib file"
			return false
		)
		-- store the currently selected tlib file
		tlibFile = fname
		tlibTGAs = #()
		
		while not eof(fs) do
		(
			instr = readLine fs
			append tlibTGAs instr
			append templist (getFilenameFile instr)
		)
		lst_textures.items = templist
	)
	
	on lst_textures selected index do
	(
		if lst_textures.selection[index] then
		(
			local info = stringStream ""
			local bmp = openBitMap tlibTGAs[index]
			if bmp != undefined then
			(
				format "Location: %\nDepth: %\nFilesize: %\nKBSize: %x%" (tlibTGAs[index]) (nx_read_tga_bit tlibTGAs[index]) ((getFileSize tlibTGAs[index])/1024) (bmp.width) (bmp.height) to:info
				imgt_preview.bitmap = bmp
				lbl_info.text = info as string
			)
			--format "selected: %\r\n" tlibTGAs[index]
			freeSceneBitmaps()
			gc()
		)
	)
	
	on btn_addsel pressed do
	(
		-- work through the selected textures and add them to the material editor
		local mat
		local matselindex = 0
		for s in lst_textures.selection do
		(
			clearListener()
			format "texture num:%  name:%\r\n" s lst_textures.items[s]
			matselindex += 1
			while (not (lst_meditmats.selection[matselindex])) and (matselindex < 24) do matselindex += 1
			if matselindex < 25 then
			(
				nx_mat_from_tga tlibTGAs[s] lst_textures.items[s] index:matselindex
			)
		)
		
		-- populate the materials editors list
		local mats = #()
		for i = 1 to 24 do
		(
			append mats (meditMaterials[i].name)
		)
		lst_meditmats.items = mats
	)
	
	on btn_refreshmats pressed do
	(
		-- populate the materials editors list
		local mats = #()
		for i = 1 to 24 do
		(
			append mats (meditMaterials[i].name)
		)
		lst_meditmats.items = mats
	)
	
	on btn_rebuild pressed do
	(
		-- cycle through all the unique dirs in found in the texture list and
		-- use to rebuild the library from
		local dir_list = #()
		local this_dir
		local tga_list = #()
		local fs
		local files
		local templist = #()
		
		for f in tlibTGAs do
		(
			this_dir = getFilenamePath f
			if (findItem dir_list this_dir) == 0 then
			(
				append dir_list this_dir
			)
		)
		
		-- build up tga list
		for dir in dir_list do
		(
			files = getFiles(dir + "*.tga")
			for f in files do
			(
				append tga_list f
			)
		)

		fs = createFile tlibFile
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
		
		-- refresh the texture list
		tlibTGAs = #()
		for instr in tga_list do
		(
			append tlibTGAs instr
			append templist (getFilenameFile instr)
		)
		lst_textures.items = templist
	)
)

createDialog nx_texman