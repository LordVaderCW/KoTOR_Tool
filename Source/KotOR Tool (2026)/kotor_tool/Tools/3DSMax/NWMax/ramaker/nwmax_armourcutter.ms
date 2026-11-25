/*
	Script to cut an NPC model into armour parts
	
	By Joco (James Walker).
	Date: 28-Dec-2003
	
	Comments: Path to look for the base models is hard-coded. Change as required.
*/

fn nx_cutarmour basename arnumber makesuper:false =
(
	local robeparts = #("head_g", "neck_g", \
						"Lshoulder_g","lbicep_g","lforearm_g","lhand_g", \
						"Rshoulder_g","rbicep_g","rforearm_g","rhand_g", \
						"torso_g","belt_g","pelvis_g", \
						"lthigh_g","lshin_g","lfoot_g", \
						"rthigh_g", "rshin_g","rfoot_g")

	local armourparts = #("head", "neck", \
	                    "shol", "bicepl", "forel", "handl", \
						"shor", "bicepr", "forer", "handr", \
						"chest", "belt", "pelvis", \
						"legl", "shinl", "footl", \
						"legr", "shinr", "footr")


	clearListener()
	format "Armour cutting started:\r\n"
	-- get the template name to use to drive the armour part loading
	local templateBase = undefined
	for h in $helpers do
	(
		if (iskindof h aurorabase) then
		(
			templateBase = h
			-- set base name correctly
			templateBase.name = basename
			exit
		)
		
	)
	
	if templateBase == undefined then
	(
		messageBox "No model base found!"
		return 0
	)
	
	local templateName = templateBase.name
	
	local toLoad, i, snode, tnode, gnode, modelbase, partname, partdummy
	
	-- load it all in first
	for i = 1 to robeparts.count do
	(
		-- get the targetsource node and target nodes then reposition
		tnode = getNodeByName robeparts[i]
		if tnode != undefined then
		(
			modelbase = aurorabase()
			modelbase.pos = tnode.pos
			modelbase.delegate.boxSize = [100,100,5]
			--select modelbase
			-- make the pointer to the front
        	local tri = ngon()
        	tri.radius = 25
        	tri.nsides = 3
        	--tri.rotation *= (quat -90 [0,0,1])
        	tri.rotation *= (quat 90 [0,0,1])
        	--tri.pos = tnode.pos + [0,-50,0]
        	tri.pos = tnode.pos + [0,50,0]
        	tri.wireColor = (color 92 179 240)
        	tri.name = "ignore_"+tri.name
        	tri.parent = modelbase
        	
			
			-- set the name of the new model base correctly
			modelBase.name = basename + "_" + armourparts[i] + arnumber
			-- set the target nodes name to the correct standard
			tnode.name = basename + "_" + armourparts[i] + arnumber + "g"
			
			-- make super dummies if needed
			if makesuper then
			(
				partdummy = dummy boxsize:[5,5,5]
				partdummy.pos = tnode.pos
				partdummy.name = robeparts[i]
				--partdummy.parent = tnode.parent
			)
			
			-- link in to new modelbase
			tnode.parent = modelbase
			
		) else (
			format "% not found\r\n" robeparts[i]
		)
	)
	
	-- if we are not making a super then go no further
	if not makesuper then return 1	-- exit early
	
	-- tidy up some "special nodes" and make sure they are all linked in
	
	-- re link our normal nodes using array of node/parent pairs
	local skeletonparts = #( \
									"head_g",		"neck_g", \
									"head",			"head_g", \
									"neck_g",		"torso_g", \
									"Lshoulder_g",	"lbicep_g", \
									"lbicep_g",		"torso_g", \
									"lforearm_g",	"lbicep_g", \
									"lforearm",		"lforearm_g", \
									"lhand_g",		"lforearm_g", \
									"lhand",			"lhand_g", \
									"Rshoulder_g",	"rbicep_g", \
									"rbicep_g",		"torso_g", \
									"rforearm_g",	"rbicep_g", \
									"rhand_g",		"rforearm_g", \
									"rhand",			"rhand_g", \
									"torso_g",		"rootdummy", \
									"impact",		"torso_g", \
									"belt_g",		"pelvis_g", \
									"pelvis_g",		"rootdummy", \
									"lthigh_g",		"pelvis_g", \
									"lshin_g",		"lthigh_g", \
									"lfoot_g",		"lshin_g", \
									"rthigh_g",		"pelvis_g", \
									"rshin_g",		"rthigh_g", \
									"rfoot_g",		"rshin_g", \
									"tail",			"pelvis_g", \
									"wings",			"torso_g", \
									"handconjure",	"base", \
									"headconjure",	"base", \
									"rootdummy",	"base" \
									)
									
	format "Linking supermodel\r\n"
	local tparent = undefined
	for i = 1 to skeletonparts.count by 2 do
	(
		tnode = getNodeByName skeletonparts[i]
		if skeletonparts[i+1] == "base" then (
			tparent = templateBase
		) else (
			tparent = getNodeByName skeletonparts[i+1]
		)
		if (tnode != undefined) and (tparent != undefined) then
		(
			tnode.parent = tparent
		) else
		(
			format "Failed link: %  --> %\r\n" (skeletonparts[i]) (skeletonparts[i+1])
		)
	)
)

rollout nx_armourcutter "Armour Cutter"
(
	edittext edt_basename "Base name" text:"pmh0"
	edittext edt_armournum "Number" text:"001"
	
	checkbox chk_createsuper "Create Super"
	
	label lbl_msg "Ready" align:#center width:110 height:40
	
	button btn_cutarmour "Cut Armour"
	
	on nx_armourcutter open do
	(
		nx_armourcutter_flag = true
	)
	
	on nx_armourcutter close do
	(
		nx_armourcutter_flag = false
	)
	
	on btn_cutarmour pressed do
	(
		nx_cutarmour (edt_basename.text) (edt_armournum.text) makesuper:(chk_createsuper.checked)
		lbl_msg.text = "Done cutting. Review listener for missed body parts."
		format "Armour cutting ended.\r\n"
	)
)

if not nx_armourcutter_flag then
(
	createdialog nx_armourcutter style:#(#style_titlebar, #style_border, #style_sysmenu, #style_minimizebox)
)