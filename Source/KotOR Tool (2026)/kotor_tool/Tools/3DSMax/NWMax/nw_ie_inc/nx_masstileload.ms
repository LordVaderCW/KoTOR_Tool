/*-----------------------------------------------------------------------------\

    Mass Tile Loader:
    Loads tiles into a scene and positions into a grid

    NWmax (gmax)
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



rollout nx_masstileload "Mass Tile/Model Loader"
(
   local groups
   edittext edt_sourcedir "Source Dir:"
   button btn_browse "Browse"
   edittext edt_pattern "Pattern:" text:"*.mdl"
   spinner spn_cols "Num Columns:" type:#integer range:[1,500,10]
   spinner spn_space "Inter model spacing:" type:#integer range:[0,1000,0]
   spinner spn_modelsize "Model x/y width:" type:#integer range:[0,1000,1000]
   button btn_check "Check Modelcount" across:3 align:#left
   label lbl_count "Count: 0" align:#center
   label lbl_Dummy1 ""
   checkbox chk_clear "Clear Scene" checked:true align:#left across:2
   button btn_load "Load Tile Models" align:#right width:120
   
   on btn_check pressed do
   (
      local model_path = edt_sourcedir.text
      if (model_path == undefined) or (not nx_existDir(model_path)) then
      (
	      messagebox "No valid path provided"
	      return false
      )
      if (model_path[model_path.count] != "\\") or (model_path[model_path.count] != "/") then
      (
	      model_path += "\\"
      )
      local models = getFiles (model_path + edt_pattern.text)
	  lbl_count.caption = ( "Count: " + models.count as string )
   )
   
   on btn_browse pressed do
   (
		local result_value = getSavePath()
		if result_value != undefined then
		(
			edt_sourcedir.text = result_value
		)
   )
   
   on btn_load pressed do
   (
      local columns
      local rowpl, columnpl, modelcount
      local pwk_file
      local dwk_file
      local model_path = edt_sourcedir.text
      
      -- sanity checks
      if (model_path == undefined) or (not nx_existDir(model_path)) then
      (
	      messagebox "No valid path provided"
	      return false
      )
      
      if (model_path[model_path.count] != "\\") or (model_path[model_path.count] != "/") then
      (
	      model_path += "\\"
      )
      
      
      local models = getFiles (model_path + edt_pattern.text)
      columns = spn_cols.value
      
      if chk_clear.checked then resetMaxFile #noPrompt
      clearListener()
      -- got the model names.
      rowpl = 0
      columnpl = 0
      modelcount = 0
      disableSceneRedraw()
      progressStart "Loading models"
      for model in models do
      (
		/*
		fn ImportNWNmdl pFile importAnims showWarnings \
						loadGeom:true \
						animLoadBase:undefined \
						insertpoint:0 \
						mappingtbl:undefined \
						loadanimlist:undefined \
						animloadtype:0 \
						showprogress:false \
						location:[0,0,0]
		*/
		modelcount += 1.00
		progressUpdate ((modelcount * 100)/models.count)
		ImportNWNmdl \
			model \
			true \
            false \
            location:[(columnpl * (spn_modelsize.value + spn_space.value)),(rowpl * (spn_modelsize.value + spn_space.value)),0]
            
        -- import pwk file if available
        pwk_file = (getFilenamePath model)+(getFilenameFile  model)+".pwk"
        if ( nx_existFile pwk_file ) then ImportNWNwk pwk_file "pwk"
        -- import dwk file if available
        dwk_file = (getFilenamePath model)+(getFilenameFile  model)+".dwk"
        if ( nx_existFile dwk_file ) then ImportNWNwk dwk_file "dwk"
        
		if columnpl >= (columns-1) then
		(
			columnpl = 0
			rowpl += 1
		) else
		(
			columnpl += 1
		)
      )
      progressEnd()
      enableSceneRedraw()
         
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

createDialog nx_masstileload width:300