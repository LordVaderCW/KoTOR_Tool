/*-----------------------------------------------------------------------------\

    Aurora Animation Mesh Modifer
    
    This modifier stores the information needed by the Aurora engine for
    animated meshes.
    
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
format "load: aurora_mod_animesh.ms\r\n"
nx_progressPlus()
-- Applying this modifier to an animated mesh will allow
-- the mesh to be exported with animation into a .mdl file.
-- The user will specify how many animation subsamples they
-- wish to be taken.  


plugin Simplemod auroraanimesh
name:"AuroraAniMesh"
classID:#(0xa0deb1a3, 0xa32823d0)
(
	parameters pblock rollout:params
	(
		-- make sure all exported attributes are listed here:
		animMeshSamples type:#stringtab tabsizevariable:true
	)

	-- currently selected animation
	local current
	
	-- aurabase object that is parent to this object
	local aura = undefined
	
	-- Locate the aurabase node for this object
	function getAuroraBase a =
	(
		aura = a.parent
		if (nx_strclassof(aura) != "aurorabase") then
			if (classof(aura) != UndefinedClass) then
				getAuroraBase aura
	)
	
	rollout params "AuroraAniMesh"
	(
		local animStr
		
		Label modelname "Model: " 
		Label animname "animname:" align:#left
		Label animstart "animstart: " align:#left
		Label animend "animend: " align:#left
		listbox animlist "animations" height:5
		Label gap  ""
		Spinner spn_sample "# of Samples:" type:#integer range:[0, 65335, 1] 
		-- Joco: add to show interval details
		Label calcdinterval "Sampling Interval: " align:#left
		button btn_frames "Print Sample Frames" align:#center toolTip:"Print list of sample frames to Listener"
		
		
		-- update the labels with the values of the
		-- currently selected animation
		function updateLabels = 
		(
			if (current != 0) then (
				animStr = filterstring aura.animations[current] " "
				animname.text = "animname: " + animStr[1]
				animstart.text = "animstart: " + (start = animStr[2])
				animend.text = "animend: " + (start = animStr[3])
				--Joco
				local i = ((animStr[3] as integer) - (animStr[2] as integer)) / (spn_sample.value-1)
				calcdinterval.text = "Sampling Interval: " + (i as string)
				    
			)
		)

		-- upon selecting a new animation, update labels
		-- and load the sample value
		function selectanim a =
		(
			if (a==0) then
			(
				start = end = current = 0
				animStr = ""
				animname.text = "animname: "
				animstart.text = "animstart: "
				animend.text = "animend: "
				calcdinterval.text = "Sampling Interval: "  --Joco
				spn_sample.value = 0
			) else (
				current = a
				if (animMeshSamples[current] == undefined) then
				(
					animMeshSamples[current] = "0"
					spn_sample.value = 0
				)
				else
					spn_sample.value = animMeshSamples[current] as integer
					
				updateLabels()  --Joco: moved to ensure spn_sample is done first
			)
		)
		
		-- retrieve list of animations this aurabase
		-- node has
		function getAnimations = 
		(
			local temp = #()
			for a in aura.animations do
			(	
				join temp #(a)
			)
			this.params.animlist.items = temp
		)

		on animlist selected a do 
		(
			selectanim a
		)
		
		on animlist doubleclicked a do
		(
			-- use these variables for easier understanding
			start = (animStr[2] as integer)
			end = (animStr[3] as integer)

			if(start < end) then
				animationrange =(interval (start) (end))
		)

		on spn_sample changed num do (
			if (current != 0) then 
			(
				end = (animStr[3] as integer)
				start = (animStr[2] as integer)
				if (end-start < spn_sample.value) then
				(
					str = "The number of samples must be less \n"+
						  "or equal to the animation length."
					messageBox str title:"AnimMesh Error: Sample Value" beep:true	

					spn_sample.value = animMeshSamples[current] as integer
				) 
				else 
				(
					animMeshSamples[current] = spn_sample.value as string
				)
				-- Joco: update the sample interval
				local i = (end - start) / (spn_sample.value-1)
				calcdinterval.text = "Sampling Interval: " + (i as string)
			)
		)
		
		-- Joco
		on btn_frames pressed do
		(
    		if current == 0 then return 0    -- nothing selected so do nothing
    		local animStr = filterstring aura.animations[current] " "
    		local firstframe = (animStr[2] as integer)
    		local lastframe = (animStr[3] as integer)
    		local sample = spn_sample.value
    		local interval = (lastframe-firstframe) / (sample-1)
    		clearListener()
    		format "Sample frames from % to % with interval %:\r\n" firstframe lastframe interval
    		for i = firstframe to lastframe by interval do
    		(
        		if i > lastframe then i == lastframe
        		format "%\r\n" i
    		)
		)

		on params open do
		(
			name = ""
			current =0;
			getAuroraBase selection[1] -- Note: not $, cause $ can be multiple things
			if (nx_strclassof(aura) == "aurorabase") then 
			(
				name=aura.name
				getAnimations()
			)				
			for i=1 to animlist.items.count do
				selectanim i
			animlist.selection=0

			modelname.text = "Model: " + name
			spn_sample.value = 0

		)
	)
)