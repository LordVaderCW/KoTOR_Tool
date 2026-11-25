--CS v3.0.2 - 9/7/01 - 3DStudio MAXScript Utility to aid low polygon model skinning
--Copyright (C) 2001 Colin 'Chilli' Semple - Chilli@Chilliweb.co.uk
--http://www.chilliweb.co.uk/chilliskinner
--3DStudio Max 3.x & 4.x compatible

--This program is free software; you can redistribute it and/or modify it under the terms of the
--GNU General Public License as published by the Free Software Foundation; either version 2
--of the License, or (at your option) any later version. This program is distributed in the hope that
--it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
--MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
--General Public License for more details. You should have received a copy of the GNU General
--Public License along with this program; if not, write to the Free Software Foundation, Inc., 
--59 Temple Place - Suite 330, Boston, MA 02111-1307, USA. 

--User Defaults Configuration Start
--Change these default values if you like
global ccAutoSelect=true  	-- Automatically Select All after each ChilliSkinner operation: default=true
global ccAutoZoom=false 	-- Automatically zoom to show all objects in all viewports after each CSv2 operation: true or false
global NormVerifyFlag=true	-- This will make ChilliSkinner fix flipped face normals that can occur in models where faces have been manually created counter clockwise
global VerifyFlag=true		-- This will make ChilliSkinner verify that unfolded polys are not distorted from their original dimensions, and colour code them accordingly
global nSpacing =2			-- Poly Gap Spacing
global SeriousFlag=false	-- Set output for Serious Engine
global nFaceMax=300			-- Maximum number of faces that ChilliSkinner will Auto Detach as one Poly, change this at own risk as it can cause stack overflow
global nTolerence=30		-- Default Tolerance Angle
--User Defaults Configuration End

global mTolerence=0.5
global RefObj=#()
global RefObjNorm=#()
global VertsDone=#()
global RefObj=#()
global RefObjCol=0
global VertCount=0
global RedFlag=false
global PolyList=#()
global nNextTop=0.0  
global nNextLeft=0.0  
global nObjWidth=0  
global nObjHeight=0
global nMorphSrc=undefined
global nMorphTgt=undefined
global ChkSum=#()
global FacesTodo=#()
global PolyGroup=#()
global nPolyPlaced=0
global gridtype=1
global gridsizex=0
global gridsizey=0
global stackX=#()
global stackY=#()
global stackW=#()
global stackH=#()
global IndMrk=1
global nStackCount=0

global ShowWorking, CSError, PrelimCheck, FlipFaceNormal, DetachPoly, IsAdjacent, IsWithinTol, GetAdjFaces
global PolyFind, RoundUp, IsWithinVerifyTol, CheckVertDone, VertSet, GetAngle, VerifyUnfold, RotObj
global GetAverageFaceNorm, Rotater, CopyObj, UnfoldFace, UndoUnfold, UnfoldPoly, UnfoldAllPolys
global ExtremeVertex, PieceArea, GetEdgeType, OptimisePoly, OptimiseAllPolys, GridArea, MakePolyList
global MoveObj, AddToStack, RemFromStack, FindHole, PlacePoly, ArrangePolys, AttachAllPolys
global ApplyPlanarMap, ClrSmoothingGrps, WeldSel, WeldPolys, ToggleVisible, MorphPolys, CloneHidePolys
global LevelVerts, FlattenPoly, FlattenAllPolys, ShowStatus
global FixBBox, UniqueMatID , GetEdgeVerts, WeldEdges

rollout EgoStroke "Ego Stroker..."
(
	Bitmap ChilliLogo Filename:(g_startpath+"CSv3.0.2/Chillilogo.bmp")
	Label ccLab1 "ChilliSkinner v3.0.2"
	Label ccLab2 "Released: 9th July 2001"
	Label ccLab3 "GNU General Public License"
	Label ccLab4 "www.chilliweb.co.uk/chilliskinner"
	Label ccLab5 "Chilli@ChilliWeb.co.uk"
	Label ccLab6 "Chilli thanks: Azm0, Scrambler"
	Label ccLab7 "dines, Henry, Oyster, Kam"
)


rollout ExpertRollout "Chilli's Big Tool Set"
(
	group "Status"
	(
		label ccProgress "Ready" 
	)
	
	button ccSelectAll images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,1,1,1,1) width:40 height:25 pos:[6,50] tooltip:"Select All"
	on ccSelectAll pressed do
	(
		set undo off
		max select all
		set undo on
	)
	
	button ccZoomSel images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,2,2,2,2) width:40 height:25 pos:[47,50] tooltip:"Zoom Selected"
	on ccZoomSel pressed do
	(
		set undo off
		max zoomext sel
		set undo on
	)
	
	button ccZoomExtents images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,3,3,3,3) width:40 height:25 pos:[88,50] tooltip:"Zoom All"
	on ccZoomExtents pressed do
	(
		set undo off
		max tool zoomextents all
		set undo on
	)	
	
	button ccClearSGroups images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,12,12,12,12) width:40 height:25 pos:[129,50] tooltip:"Clear Smoothing Groups"
	on ccClearSGroups pressed do
	(
		undo on
		(
			ShowStatus "W"
			ObjCount=0
			Objs=$
			TmpVal=PrelimCheck Objs true true fa1se
			if TmpVal==false do return false
			TmpVal=ClrSmoothingGrps Objs	
			if TmpVal==False do CSError "Clear Smoothing Groups Error"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
	)

	button ccToggle images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,4,4,4,4) width:40 height:25 pos:[6,76] tooltip:"Toggle Visible"
	on ccToggle pressed do
	(
		set undo off
		TmpVal=ToggleVisible()	
		if TmpVal==False do CSError "Toggle Visible Error"
		set undo on
	)

	button ccHideSel images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,5,5,5,5) width:40 height:25 pos:[47,76] tooltip:"Hide Selected"
	on ccHideSel pressed do
	(
		set undo off
		max hide selection
		set undo on
	)

	button ccHideUnSel images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,6,6,6,6) width:40 height:25 pos:[88,76] tooltip:"Hide UnSelected"
	on ccHideUnSel pressed do
	(
		set undo off
		max hide inv
		set undo on
	)

	button ccUnhideAll images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,7,7,7,7) width:40 height:25 pos:[129,76]  tooltip:"Unhide All"
	on ccUnhideAll pressed do
	(
		set undo off
		max unhide all	
		set undo on
	)	
	
	button ccUndo images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,10,10,10,10) width:40 height:25 pos:[6,102] tooltip:"Undo"
	on ccUndo pressed do
	(
		set undo off
		max undo
		set undo on
	)
	
	button ccRedo images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,11,11,11,11) width:40 height:25 pos:[47,102] tooltip:"Redo"
	on ccRedo pressed do
	(
		set undo off
		max redo
		set undo on
	)
	
	button ccFreeze images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,8,8,8,8) width:40 height:25 pos:[88,102] tooltip:"Freeze Selected"
	on ccFreeze pressed do
	(
		max freeze selection
	)

	button ccUnfreezeAll images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,9,9,9,9) width:40 height:25 pos:[129,102] tooltip:"Un-Freeze All"
	on ccUnfreezeAll pressed do
	(
		set undo off
		max unfreeze all
		set undo on
	)

	Spinner  spTolerence "Detach Angle:" range:[0,360,30] align:#center enabled:True type:#integer scale:1  
	on spTolerence changed tmp do nTolerence=tmp
	
	button ccDetach images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,13,13,13,13) width:40 height:25 pos:[6,155] tooltip:"Auto Detach"
	on ccDetach pressed do
	(
		disablesceneredraw()
		undo on
		(	
			ObjCount=0
			Objs=$
			TmpVal=PrelimCheck Objs true true fa1se
			if TmpVal==false do return false
			TmpVal=PolyFind Objs
			if TmpVal==false do 
			(
				CSError "Auto Detach Polys Error"
				return false		
			)
			delete Objs
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)

	button ccClone images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,14,14,14,14) width:40 height:25 pos:[47,155] tooltip:"Clone"
	on ccClone pressed do
	(
		disablesceneredraw()
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs false true fa1se
			if TmpVal==false do return false
			TmpVal=CloneHidePolys Objs	
			if TmpVal==False do CSError "Clone + Hide Polys Error"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)	
	
	button ccUnfoldAll images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,15,15,15,15) width:40 height:25 pos:[88,155] tooltip:"Unfold Poly(s)"
	on ccUnfoldAll pressed do
	(
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs false true fa1se
			if TmpVal==false do return false
			TmpVal=UnfoldAllPolys Objs	
			if TmpVal==False do CSError "Warning! Some Polys were not unfolded"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)	
	)

	button ccFlatten images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,16,16,16,16) width:40 height:25 pos:[129,155] tooltip:"Flatten Poly(s)"
	on ccFlatten pressed do
	(	
		disablesceneredraw()
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs false true fa1se
			if TmpVal==false do return false
			TmpVal=FlattenAllPolys Objs	
			if TmpVal==False do CSError "Flatten Polys Error"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)
	
	dropdownlist spGridType "" items:#("Square 1:1","Wide Rectangle 2:1","Tall Rectangle 1:2") align:#left
	on spGridtype selected TmpVal do gridtype=TmpVal

	button ccOptimiseAll images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,17,17,17,17) width:40 height:25 pos:[6,210] tooltip:"Optimise Poly(s)"
	on ccOptimiseAll pressed do
	(
		disablesceneredraw()
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs false true fa1se
			if TmpVal==false do return false
			TmpVal=OptimiseAllPolys Objs	
			if TmpVal==False do CSError "'Poo! Optimise Error'"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)
	
	button ccArrange images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,18,18,18,18) width:40 height:25 pos:[47,210] tooltip:"Arrange Polys"
	on ccArrange pressed do
	(
		disablesceneredraw()
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs false true true
			if TmpVal==false do return false
			TmpVal=ArrangePolys Objs
			if TmpVal==false do 
			(
				CSError "Unable to Arrange Polys"
				return false		
			)
			if SeriousFlag==true do UniqueMatID Objs
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)

	button ccAttach images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,19,19,19,19) width:40 height:25 pos:[88,210] tooltip:"Attach Polys"
	on ccAttach pressed do
	(
		disablesceneredraw()
		ClearUndoBuffer()
		set undo off
		ShowStatus "W"
		Objs=$
		TmpVal=PrelimCheck Objs false true true
		if TmpVal==false do return false
		TmpVal=AttachAllPolys Objs	
		if TmpVal==False do CSError "Attach Polys Error"
		ShowStatus "R"
		enablesceneredraw()
	)
	
	button ccMapping images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,20,20,20,20) width:40 height:25 pos:[129,210] tooltip:"Apply Planar Map"
	on ccMapping pressed do
	(
		disablesceneredraw()
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs true true fa1se
			if TmpVal==false do return false
			TmpVal=ApplyPlanarMap Objs	
			if TmpVal==False do CSError "Apply Planar Mapping Error"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
		enablesceneredraw()
	)

	pickbutton ccMorphSrc "Pick Source" width:81 height:18 pos:[6,240] tooltip:"Pick Morph Source"
	on ccMorphSrc picked Obj do
	(
		nMorphSrc=Obj
		ccMorphSrc.text = Obj.name
	)
	
	pickbutton ccMorphTgt "Pick Target" width:81 height:18 pos:[88,240] tooltip:"Pick Morph Target"
	on ccMorphTgt picked Obj do
	(
		nMorphTgt=Obj
		ccMorphTgt.text = Obj.name	
	)
	
	button ccMorph images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,23,23,23,23) width:40 height:25 pos:[6,263] tooltip:"Morph Source to Target"
	on ccMorph pressed do
	(
		undo on
		(
			ShowStatus "W"
			if nMorphSrc==undefined do
			(
				CSError "You must select a valid SOURCE object"
				return false
			)
			TmpVal=PrelimCheck nMorphSrc true true false
			if TmpVal==false do return false
			if nMorphTgt==undefined do
			(
				CSError "You must select a valid TARGET object"
				return false
			)
			TmpVal=PrelimCheck nMorphTgt true true false
			if TmpVal==false do return false
			if nMorphSrc.numverts!=nMorphTgt.numverts or nMorphSrc.numfaces!=nMorphTgt.numfaces do
			(
				CSError "Objects cannot be morphed together, they have different numbers of vertices or faces"
				return false
			)
			TmpVal=MorphPolys ()
			ccMorphSrc.text ="Pick Source"
			ccMorphTgt.text ="Pick Target"
			nMorphTgt=undefined
			nMorphSrc=undefined
			if TmpVal==False do CSError "Objects Error"
			if ccAutoSelect==true do max select all
			if ccAutoZoom==true do max tool zoomextents all
			ShowStatus "R"
		)
	)

	button ccWeld images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,24,24,24,24) width:40 height:25 pos:[47,263] tooltip:"Select and weld ALL Verts"
	on ccWeld pressed do
	(
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs true true false
			if TmpVal==false do return false
			TmpVal=WeldPolys Objs	
			if TmpVal==False do CSError "Weld ALl Error"
			ShowStatus "R"
		)
	)	

	button ccWeldSel images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,25,25,25,25) width:40 height:25 pos:[88,263] tooltip:"Weld SELECTED Verts"
	on ccWeldSel pressed do
	(
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs true true false
			if TmpVal==false do return false
			TmpVal=WeldSel Objs	
			if TmpVal==False do CSError "Weld Selected Error"
			ShowStatus "R"
		)
	)

	button ccdebug images:#(g_startpath+"CSv3.0.2/CS_Buttons.bmp",g_startpath+"CSv3.0.2/CS_Buttons_Mask.bmp",27,27,27,27,27) width:40 height:25 pos:[129,263] tooltip:"Weld Selected Edge(s)" 
	on ccdebug pressed do
	(
		undo on
		(
			ShowStatus "W"
			Objs=$
			TmpVal=PrelimCheck Objs true true false
			if TmpVal==false do return false
			TmpVal=WeldEdges Objs	
			if TmpVal==False do CSError "Weld Edges Error"
			ShowStatus "R"
		)
	)
)

rollout ConfigRollout "Advanced Configuration"
(
	Checkbox ccNormVerify "Verify Normals" checked:true 
	on ccNormVerify changed Tmp do NormVerifyFlag=Tmp

	Checkbox ccVerify "Verify Unfold" checked:true 
	on ccVerify changed Tmp do VerifyFlag=Tmp

	Checkbox ccSelectAll "Auto Select All" checked:true 
	on ccSelectAll changed Tmp do ccAutoSelect=Tmp

	Checkbox ccZoomAll "Auto Zoom All" checked:true 
	on ccZoomAll changed Tmp do ccAutoZoom=Tmp	
	
	Checkbox ccSerious "Serious Engine Output" checked:false 
	on ccSerious changed Tmp do SeriousFlag=Tmp	
	
	Spinner spSpacing "Poly Gap Size:" range:[0,20,2] enabled:True align:#center type:#integer scale:1
	on spSpacing changed TmpVal do nSpacing=TmpVal
)


-- create the rollout window 
if ChilliFloater != undefined do
(
	closerolloutfloater ChilliFloater
)
		
ChilliFloater = newRolloutFloater "ChilliSkinner" 200 395 
addRollout EgoStroke ChilliFloater
addRollout ExpertRollout ChilliFloater
addRollout ConfigRollout ChilliFloater

ConfigRollout.ccNormVerify.checked=NormVerifyFlag
ConfigRollout.ccVerify.checked=VerifyFlag
ConfigRollout.ccSelectAll.checked=ccAutoSelect
ConfigRollout.ccZoomAll.checked=ccAutoZoom
ConfigRollout.ccSerious.checked=SeriousFlag
ConfigRollout.spSpacing.range=[0,20,nSpacing]

if IsSceneRedrawDisabled()==true do enablesceneredraw() --just in case CS failed whilst SceneRedraw was disabled
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

fn ShowWorking d =
(
	if IndMrk==1 do Tmp=":.)"
	if IndMrk==2 do Tmp=":o)"
	if IndMrk==3 do Tmp=":O)"
	if IndMrk==4 do Tmp=":o)"
	
	ExpertRollout.ccProgress.caption=Tmp
	IndMrk=IndMrk+1
	if IndMrk==4 do IndMrk=1 
)


fn CSError Msg=
(	
	if IsSceneRedrawDisabled()==true do enablesceneredraw()
	ShowStatus "Error!"
	messagebox Msg title:"Bad Chilli! Dirty Chilli!!"
)


fn PrelimCheck Objs nSingleObjOnly nConvertToMesh nMultiObjOnly =
(	
	local ObjCount=0
	
	if Objs==undefined do
	(
		CSError "You must select poly(s) first"
		return false
	)
	
	If nSingleObjOnly==true do
	(
		ObjCount=0
		for Obj in Objs do ObjCount = ObjCount+1
		if ObjCount>1 do
		(
			CSError "This operation requires that only one poly be selected"
			return false
		)
	)
	
	If nConvertToMesh==true do
	(		
		TmpVal=maxversion
		if TmpVal==undefined and ObjCount==1 do
		(
			ConvertToMesh Objs
		)
		for Obj in Objs do 
		(
			if TmpVal!=undefined do
			(
				Tmp=ConvertToMesh Obj
				if Tmp==undefined do
				(
					CSError "This operation requires EditableMesh objects only, there are non-mesh objects in the selected objects, deselect these and retry"
					return false
				)
			)
		)
	)
	
	if nMultiObjOnly==true do
	(
		ObjCount=0
		for Obj in Objs do ObjCount = ObjCount+1
		if ObjCount<2 do
		(
			CSError "This operation requires that more than one poly is selected"
			return false
		)
	)
	
	for Obj in Objs do 
	(
		if Obj.numverts==0 do
		(
			TmpVal = Obj.name + " has no vertices, cannot perform requested operation on this object"
			CSError TmpVal
			return false
		)
	)
	
	for Obj in Objs do 
	(
		if Obj.numfaces==0 do
		(
			TmpVal = Obj.name + " has no faces, cannot perform requested operation on this object"
			CSError TmpVal
			return false
		)
	)	
	
	return true
)


fn FlipFaceNormal Obj FaceN = 
( 
	local nVert=0
	local FaceVerts=0
	local TmpVal=0
	
	FaceVerts=getface Obj FaceN -- get Face vertices as a point3 
	TmpVal=FaceVerts.x -- swap the first and third vertices 
	FaceVerts.x=FaceVerts.z -- which flips the normal 
	FaceVerts.z=TmpVal -- (right-hand rule), and 
	setface Obj FaceN FaceVerts -- store the new vertex order for the face 
	update Obj 
) 


fn DetachPoly Obj nFaces=
(
	local AllVerts=#()
	local FaceVerts=0
	local vmap=#()
	local nVert=0
	local iCount=0
	local nSmoothGrp=0
	
	for iLoop =1 to nFaces.count do
	(
		FaceVerts= getFace Obj nFaces[iLoop]  --gets verts of all faces in Obj
		append AllVerts FaceVerts
	)
	
	vmap = #()  
	iCount=0
	for nVert in AllVerts do  -- for each vert in all verts...
	(
		if vmap[nVert.x] == undefined do vmap[nVert.x] = (iCount += 1)
		if vmap[nVert.y] == undefined do vmap[nVert.y] = (iCount += 1)
		if vmap[nVert.z] == undefined do vmap[nVert.z] = (iCount += 1)
	)

	-- adds vert x,y,z coords to vmap array
	nv = #()
	for iLoop in 1 to vmap.count do
	(
		if vmap[iLoop] != undefined do nv[vmap[iLoop]] = getVert obj iLoop
	)
	
	nf = for nVert in AllVerts collect [vmap[nVert.x], vmap[nVert.y], vmap[nVert.z]]
	
	TmpVal=mesh vertices:nv faces:nf
	
	if NormVerifyFlag==true do
	(
		for iLoop =1 to nFaces.count do
		(
			nNorm=RefObjNorm[nFaces[iLoop]]
			mNorm=GetFaceNormal TmpVal iLoop
			if mNorm.x >= (nNorm.x-mTolerence) and mNorm.x <= (nNorm.x+mTolerence) and mNorm.y >= (nNorm.y-mTolerence) and mNorm.y <= (nNorm.y+mTolerence) and mNorm.z >= (nNorm.z-mTolerence) and mNorm.z <= (nNorm.z+mTolerence) do return continue
			FlipFaceNormal TmpVal iLoop
		)
	)

	--Preserve Smoothing Groups & Mat IDs
	for iLoop =1 to nFaces.count do
	(
		SetFaceSmoothGroup TmpVal iLoop (GetFaceSmoothGroup Obj nFaces[iLoop])
		SetFaceMatID TmpVal iLoop (GetFaceMatID Obj nFaces[iLoop])
	)	

)


fn IsAdjacent Obj Face1 Face2=
(	
	local nVert=0
	local mVert=0
	local SbCount=0
	
	nVert=getface Obj Face1
	mVert=getface Obj Face2

	if nVert.x==mVert.x or nVert.x==mVert.y or nVert.x==mVert.z do
	(
		SbCount=SbCount+1
	)
	if nVert.y==mVert.x or nVert.y==mVert.y or nVert.y==mVert.z do
	(
		SbCount=SbCount+1
	)
	if nVert.z==mVert.x or nVert.z==mVert.y or nVert.z==mVert.z do
	(
		SbCount=SbCount+1
	)

	if SbCount < 2 do return False
	return true	
)


fn IsWithinTol Obj Face1 Face2=
(
	local nNorm=0
	local mNorm=0
	
	nNorm=getFaceNormal Obj Face1	--Get Face1 Normal
	mNorm=getFaceNormal Obj Face2	--Get Face2 Normal

	if nNorm==mNorm do return true
		
	TmpVal=dot nNorm mNorm
	
	x=TmpVal/((length nNorm)*(length mNorm))
	
	-- Prevent rounding errors returning >1.0
	if x>=1.0 do return true
	
	AngX=acos (x)	
	
	if AngX<=nTolerence do
	(
		return true
	)		
	return false
)


fn GetAdjFaces Obj Face1 facestodo polygroup=
(
	local FFlag=false
	local iLoop=0
	
	if nStackCount>nFaceMax do return false
		
	for iLoop=1 to facestodo.count do
	(
		if facestodo[iLoop]>0 do
		(
			if IsAdjacent Obj Face1 facestodo[iLoop]==true do
			(
				if IsWithinTol Obj Face1 facestodo[iLoop]==true do
				(
					append PolyGroup facestodo[iLoop]  --add to group to be detached
					facestodo[iLoop]=0 --drop from todo list
							
					nPolyPlaced=nPolyPlaced+1		
					FFlag=true		-- mark it done		
					nStackCount=nStackCount+1
					
					for i=1 to 3 do	
					(
						if GetAdjFaces Obj iLoop facestodo polygroup==false do exit loop
					)
					return FFlag
				)
			)
		)
	)	
	return FFlag
)


fn PolyFind Obj =
(
	local iLoop=0
	local facestodo=#()
	local eFlag=false
	local FaceNorm=[0,0,0]
	local uBound=0.0
	local nPBar=0.0

	RefObjNorm=#()
	
	uBound=Obj.numfaces
	nPBar=(100.0/uBound)
	
	nPolyPlaced=0
	
	--store Poly normals for reference later
	for iLoop=1 to Obj.numfaces do
	(
		FaceNorm=GetFaceNormal Obj iLoop
		append RefObjNorm FaceNorm
	)
	
	--add all faces to faces todo list	
	for iLoop=1 to Obj.numfaces do append facestodo iLoop	
	
	while eFlag==false do
	(
		FaceFlag=false
		for iLoop=1 to facestodo.count do
		(
			PolyGroup=#()
			nStackCount=0	
			
			ShowStatus ((ceil(nPolyPlaced*nPBar) as string + "%"))
			if facestodo[iLoop]>0 do  
			(
				-- got first face g
				FaceFlag=true
				append PolyGroup facestodo[iLoop]  --add to group to be detached
				facestodo[iLoop]=0 --drop from todo list
				nPolyPlaced=nPolyPlaced+1

				-- check adjacent faces				
				for i=1 to 3 do
				(
					if GetAdjFaces Obj iLoop facestodo polygroup==false do exit loop
				)

				TmpVal=DetachPoly Obj PolyGroup
				if TmpVal==False do 
				(
					CSError "Detach Error"
					return false
				)
			)
		)
		if FaceFlag==false do eFlag=true 
	)
	return true
)


---------------------------------------------------------------------------------
---------------------------------------------------------------------------------


fn RoundUp Num=
(
	return ceil(Num*1000.0)/1000.0
)


fn IsWithinVerifyTol Value1 Value2=
(
	local nResult=false
	local nVerifyTolerance=0.0
	local nPercentageError=15.0
	
	if Value2 >= Value1 do
	(
		nVerifyTolerance=(Value2/100)* nPercentageError
		if Value1 + nVerifyTolerance > Value2 do nResult=true
	)
	if Value2 <= Value1 do
	(
		nVerifyTolerance=(Value1/100)* nPercentageError
		if Value1 - nVerifyTolerance < Value2 do nResult=true
	)
	return nResult
)


fn CheckVertDone nVert=
(	
	local iLoop=0

	for iLoop =1 to Vertsdone.count do
	(
		If VertsDone[iLoop]==nVert do Return True
	)
	Return False
)


fn VertSet Obj nVert=
(
	--set object pivot point to first vert of face
	Obj.pivot=[nVert.x,nVert.y,nVert.z]
	--move object to world origin 
	Obj.pos=[0,0,0]
)


fn GetAngle a b c=
(
	local E1=0.0
	local E2=0.0
	local E3=0.0
	local CosineV1=0.0
	
	E1=distance a b
	E2=distance b c
	E3=distance c a
	CosineV1 = (E1 * E1 + E3 * E3 - E2 * E2) / (2 * E1 * E3)	
	
	Return CosineV1
)


fn VerifyUnfold Obj=
(
	local iLoop=0
	local FaceVerts=0.0
	local nV=[0,0,0]
	local E1=0.0
	local E2=0.0
	local E3=0.0
	local F1=0.0
	local F2=0.0
	local F3=0.0
	local nVert1=0.0
	local nVert2=0.0
	local nVert3=0.0
	local mVert1=0.0
	local mVert2=0.0
	local mVert3=0.0

	Obj.Wirecolor = [6, 134, 58]  --green

	for iLoop=1 to obj.numfaces do
	(
		FaceVerts=getface obj iLoop
	
		nVert1=getvert Obj FaceVerts.x
		nVert2=getvert Obj FaceVerts.y
		nVert3=getvert Obj FaceVerts.z
		
		F1=distance nVert1 nVert2
		F2=distance nVert2 nVert3
		F3=distance nVert1 nVert3
			
		nV=FaceVerts
			
		mVert1=[RefObj[nV.x].x,RefObj[nV.x].y,RefObj[nV.x].z]
		mVert2=[RefObj[nV.y].x,RefObj[nV.y].y,RefObj[nV.y].z]
		mVert3=[RefObj[nV.z].x,RefObj[nV.z].y,RefObj[nV.z].z]

		E1=distance mVert1 mVert2
		E2=distance mVert2 mVert3
		E3=distance mVert1 mVert3
			
		if IsWithinVerifyTol E1 F1 ==false do RedFlag=true 
		if IsWithinVerifyTol E2 F2 ==false do RedFlag=true
		if IsWithinVerifyTol E3 F3 ==false do RedFlag=true

		if RedFlag==True do 
		(
			Obj.Wirecolor = Red
			return false
		)
	)
	return true
)
	

fn RotObj Obj RotAxis VertNum =
(
	local rotatedegs=45.0
	local iLoop=0
	local a=0.0
	local b=0.0
	local c=0.0
	local TgVert=0.0
	local TmpVal=0.0
	local RotAng=0.0
	
	for iLoop =1  to 7 do
	(
		Case Of
		(
			(RotAxis=="Z"):
			(
				rotate Obj RotateDegs [0,0,1]
				TgVert=getvert Obj VertNum
				if TgVert.y >0 and TgVert.x>0 do
				(
					a=[0,0,0]
					b=[Tgvert.x,0,0]
					c=[Tgvert.x,Tgvert.y,0]
					RotAng=getangle a b c
					TmpVal= -1.0 * (acos RotAng)
					rotate Obj TmpVal [0,0,1]
					return true
				)
			)
			(RotAxis=="X"):
			(
				rotate Obj RotateDegs [1,0,0]
				TgVert=getvert Obj VertNum
				if TgVert.y <0 and TgVert.z >0 do
				(
					a=[0,0,0]
					b=[0,Tgvert.y,0]
					c=[0,Tgvert.y,Tgvert.z]
					RotAng=getangle a b c
					TmpVal=  (acos RotAng)
					rotate Obj TmpVal [1,0,0]
					return true
				)
			)
			(RotAxis=="Y"):
			(
				rotate Obj RotateDegs [0,1,0]
				TgVert=getvert Obj VertNum
				if TgVert.z >0 and TgVert.x>0 do
				(
					a=[0,0,0]
					b=[Tgvert.x,0,0]
					c=[Tgvert.x,Tgvert.z,0]
					RotAng=getangle a b c
					TmpVal=  (acos RotAng)
					rotate Obj TmpVal [0,1,0]
					return true
				)
			)
		)
	)	
	return false
)


-- works out average normal of all faces
fn GetAverageFaceNorm Obj=
(
	avgnorm=[0,0,0]
	for iLoop=1 to Obj.numfaces do
	( 
		TmpVal=normalize(getfacenormal Obj iLoop)
		avgnorm=avgnorm + TmpVal
	)
	TmpVal=normalize(avgnorm/Obj.numfaces)
	return TmpVal
)


-- re orientates an object so that it's average face normal is [0,0,1]
fn Rotater Obj=
(
	FrcInac=0.001 --ForcedInacuracy
	des=[0,0,1]  --desired final average normal
	
	--X
	x=GetAverageFaceNorm Obj
	x1=[0.0,x.y+FrcInac,x.z+FrcInac]
	TmpVal=dot des x1
	angx=0
	if TmpVal!=0 do	angx=acos (TmpVal/((length des)*(length x1)))
	if x.y<0 do angx=(angx * -1)
	Rotate Obj angx [1,0,0]

	--Y
	x=GetAverageFaceNorm Obj
	x2=[x.x+FrcInac,0.0,x.z+FrcInac]
	TmpVal=dot des x2
	angy=0
	if TmpVal!=0 do	angy=acos (TmpVal/((length des)*(length x2)))
	if x.x>0 do angy=(angy * -1)
	Rotate Obj angy [0,1,0]
	
	update Obj
)


-- makes an exact copy of an object and deletes the original object but resizes the bounding box
fn CopyObj Obj CloneFlag=
(
	local nVerts=#()
	local nFaces=#()
	local TmpObjPivot=0
	local TmpObjName
	local NewObj=0
	local iLoop=0
	
	TmpObjPivot=Obj.pivot
	TmpObjName=Obj.name

	for iLoop=1 to Obj.numverts do
	(
		TmpVal=getvert Obj iLoop
		append nVerts TmpVal
	)

	for iLoop=1 to Obj.numfaces do
	(
		TmpVal=getface Obj iLoop
		append nFaces TmpVal
	)

	NewObj=mesh vertices:nVerts faces:nFaces

	-- Preserve Smoothing Groups & Mat IDs
	for iLoop =1 to Obj.numfaces do
	(
		SetFaceSmoothGroup NewObj iLoop (GetFaceSmoothGroup Obj iLoop) 
		SetFaceMatID NewObj iLoop (GetFaceMatID Obj iLoop)
	)	

	-- Preserve Object Colour
	NewObj.wirecolor =Obj.wirecolor
	NewObj.pivot=TmpObjPivot
	if CloneFlag==true do
	(
		NewObj.name="Clone" + TmpObjName
	)
	if CloneFlag==false do
	(
		NewObj.name=TmpObjName
		delete Obj
	)
		
	update NewObj
	
	return NewObj
)


fn UnfoldFace Obj FaceN=
(
	local iLoop=0
	local FaceVerts=0.0
	local nV=[0,0,0]
	local a=0.0
	local b=0.0
	local c=0.0
	local E1=0.0
	local E2=0.0
	local E3=0.0
	local CosineV1=0.0
	local Sinev1=0.0
	local x=0.0
	local y=0.0
	local nVert1=0.0
	local nVert2=0.0
	local nVert3=0.0
	local mVert1=0.0
	local mVert2=0.0
	local mVert3=0.0

	--Get Face Verts
	FaceVerts=GetFace Obj FaceN

	if FaceN==1 do  --for face 1 only add verts 1 and two to vertsdone
	(
		append VertsDone FaceVerts.x
		append VertsDone FaceVerts.y
	)

	--need to find which verts we have done
	a=CheckVertDone FaceVerts.x
	b=CheckVertDone FaceVerts.y
	c=CheckVertDone FaceVerts.z

	Case Of
	(
		(a==True and b==True):
		(
	 		nVert1=getvert Obj FaceVerts.x
			nVert2=getvert Obj FaceVerts.y
			nVert3=getvert Obj FaceVerts.z
	 		nV=[FaceVerts.x,FaceVerts.y,FaceVerts.z]
		)
		(b==True and c==True):
		(
	 		nVert1=getvert Obj FaceVerts.y
			nVert2=getvert Obj FaceVerts.z
			nVert3=getvert Obj FaceVerts.x
			nV=[FaceVerts.y,FaceVerts.z,FaceVerts.x]
		)
		(c==True and a==True):
		(
	 		nVert1=getvert Obj FaceVerts.z
			nVert2=getvert Obj FaceVerts.x
			nVert3=getvert Obj FaceVerts.y
			nV=[FaceVerts.z,FaceVerts.x,FaceVerts.y]
		)
	)
	--drops out if face can't be done now i.e. only have one vert or no verts
	if nV.x==0 or nV.y==0 or nV.z==0 do return False
	
	--set 1st vertex
	VertSet Obj nVert1
		
	--set 2nd vertex
	a=RotObj Obj "Z" nV.y
	--only need to rotate Y X on first vertex
	if VertCount<1 do
	(
		b=RotObj Obj "Y" nV.y
		c=RotObj Obj "X" nV.y
		VertCount=1
	)

	--set third vertex
 	mVert1=[RefObj[nV.x].x,RefObj[nV.x].y,RefObj[nV.x].z]
 	mVert2=[RefObj[nV.y].x,RefObj[nV.y].y,RefObj[nV.y].z]
	mVert3=[RefObj[nV.z].x,RefObj[nV.z].y,RefObj[nV.z].z]

	E1=distance mVert1 mVert2
	E2=distance mVert2 mVert3
	E3=distance mVert1 mVert3

	CosineV1 = (E1 * E1 + E3 * E3 - E2 * E2) / (2 * E1 * E3)		
	X = CosineV1 * E3
	SineV1=sqrt(1-(CosineV1 * CosineV1))
	Y=SineV1 * E3
		
	setvert Obj nV.z [X,Y,0]

	append VertsDone nV.z

	return True
)


fn UndoUnfold Obj=
(
	-- return obj to orig vert positions
	for iLoop =1 to Obj.numverts do
	(
		setvert Obj iLoop [RefObj[iLoop].x,RefObj[iLoop].y,RefObj[iLoop].z]
	)
	Update Obj
)


fn UnfoldPoly Obj =
(
	local iLoop=0
	local facestodo=#()
	local eFlag=false
	local FaceVerts=0

	VertCount=0
	VertsDone=#()
	RedFlag=False
	
	--Clear reference arrays
	RefObj=#()
	
	--store Poly vert indices for reference later
	for iLoop=1 to Obj.numverts do
	(
		FaceVerts=getvert Obj iLoop
		append RefObj FaceVerts
	)
	
	--add all faces to faces todo list	
	for iLoop=1 to Obj.numfaces do append facestodo iLoop	
	
	while eFlag==false do
	(
		FaceFlag=false
		for g=1 to facestodo.count do
		(
			if facestodo[g]>0 do  
			(
				h=UnFoldFace Obj facestodo[g]
				if h==true do
				(	
					--if unfoldface returns true, set face value in faces todo list to zero
					facestodo[g]=0
					FaceFlag=true  --flag a succesful face unfold
				)
				if h==false do
				(
					--face can't be done yet	
				)			
			)
		)
		if FaceFlag==false do eFlag=true  
	)
	
	update Obj
	
	-- verify dimensions of unfolded poly	
	if VerifyFlag==true do 
	(
		TmpVal=VerifyUnfold Obj
		if TmpVal==false do 
		(	
			TmpVal1=Obj.name + " will be distorted if unfolded, force unfold?"
			TmpVal=querybox TmpVal1
			if TmpVal==false do
			(
				UndoUnfold Obj
				return false
			)
		)
	)
	-- check if there are outstanding faces todo...
	for iLoop=1 to facestodo.count do
	(
		if facestodo[iLoop]>0 do 
		(
			UndoUnfold Obj
			return false
		)
	)

	return true
)


-- object
fn UnfoldAllPolys Objs=
(
	local eFlag=false
	local TmpVal=false
	
	for Obj in Objs do
	(
		TmpVal=UnfoldPoly Obj
		If TmpVal==false do eFlag=true
	)
	TmpVal =FixBBox Objs
	Return not eFlag
)

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

--finds extreme vertices for obj, returns vertex
Fn ExtremeVertex Obj XYZ highlow =
(
	local HighVert =0
	local CurrVert =0.0
	
	HighVert=GetVert Obj 1  
	
	for iLoop =2 to Obj.NumVerts do
	(
		CurrVert=GetVert Obj iLoop
		case of
		(
			(XYZ == "X"):
			(
				case of
				(
					(highlow=="H"): 
					(
						if CurrVert.X > HighVert.X do HighVert=CurrVert
					)
					(highlow=="L"): 
					(
					if CurrVert.X < HighVert.X do HighVert=CurrVert
					)
				)
			)
			(XYZ == "Y"):
			(
				case of
				(
					(highlow=="H"):
					(
						if CurrVert.Y > HighVert.Y do HighVert=CurrVert
					)
					(highlow=="L"):
					(
						if CurrVert.Y < HighVert.Y do HighVert=CurrVert
					)
				)
			)
			(XYZ == "Z"):
			(
				case of
				(
					(highlow=="H"):
					(
						if CurrVert.Z > HighVert.Z do HighVert=CurrVert
					)
					(highlow=="L"):
					(
						if CurrVert.Z < HighVert.Z do HighVert=CurrVert
					)
				)
			)
		)
	)
	return HighVert
)


--Find the rectangular area of a piece assuming that the piece is oriented in the Z plane
Fn PieceArea Obj nType=
(
	local HighY=0.0
	local LowY=0.0
	local HighX=0.0
	local LowY=0.0
	
	HighY=ExtremeVertex Obj "Y" "H"
	LowY=ExtremeVertex Obj "Y" "L"
	HighX=ExtremeVertex Obj "X" "H"
	LowX=ExtremeVertex Obj "X" "L"

	case of
	(
		(nType == "A"):  --area
		(
			Return (((HighX.x - LowX.x)+nSpacing) * ((HighY.y - LowY.y)+nSpacing))
		)
		(nType == "H"):  --height
		(
			Return ((HighY.y - LowY.y)+nSpacing)
		)
		(nType == "W"):  --width
		(
			Return ((HighX.x - LowX.x)+nSpacing)
		)
		(nType == "D"):  --depth
		(
			HighZ=ExtremeVertex Obj "Z" "H"
			LowZ=ExtremeVertex Obj "Z" "L"
			Return ((HighZ.z - LowZ.z)+nSpacing)
		)				
	)
	return 0
)

	
-- works out whether two vertices are a face edge, an if so internal or external edge
-- returns 0 for non face edge, 1 for external face edge, 2 for internal face edge 
fn GetEdgeType Obj NumVert1 NumVert2=
(
	local FaceType=0
	for iLoop=1 to Obj.numfaces do
	(
		FaceVerts=getface Obj iLoop 
		if FaceVerts.x==NumVert1 or FaceVerts.y==NumVert1 or FaceVerts.z==NumVert1 do
		(
			-- got one vertex
			if FaceVerts.x==NumVert2 or FaceVerts.y==NumVert2 or FaceVerts.z==NumVert2 do
			(		
				FaceType=FaceType+1
			)
		)
	)
	return FaceType
)
					

-- optimize
fn OptimisePoly Obj=
(
	local Optim1=0
	local Optim2=0
	local BestSoFar=0.0
	local TmpVal=0.0
	local nVert1=0
	local nVert2=0
	local VertNum1=0
	local VertNum2=0
	local eFlag=false
	local FaceCount=0
	local FacVerts=0
	
	for iLoop=1 to Obj.numfaces do
	(
		FaceVerts=Getface Obj iLoop
		
		for iLoop2=1 to 3 do
		(
			Case of
			(
				(iLoop2==1):
				(
					VertNum1=Faceverts.x
					VertNum2=Faceverts.y
				)
				(iLoop2==2):
				(
					VertNum1=Faceverts.y
					VertNum2=Faceverts.z
				)
				(iLoop2==3):
				(
					VertNum1=Faceverts.z
					VertNum2=Faceverts.x
				)
			)

			nVert1=getvert Obj VertNum1
			nVert2=getvert Obj VertNum2

			TmpVal=distance nVert1 nVert2
			
			if TmpVal>BestSoFar do
			(
				-- found longest side... is it external?
				x=GetEdgeType Obj VertNum1 VertNum2
				if x==1 do
				(
					BestSoFar=TmpVal
					Optim1=nVert1
					Optim2=VertNum2
					eFlag=true
				)
			)			
		)
	)
	if eFlag==true do
	(
		Vertset Obj Optim1
		RotObj Obj "Z" Optim2
		if gridtype==1 or gridtype==3 do rotate Obj 90 [0,0,1]
		Update Obj
		return true
	)
	return false
)


--Optimise function, call OptimiseObj for each unhidden object
fn OptimiseAllPolys Objs=
(
	local eFlag=false
	local TmpVal=false
	
	for Obj in Objs do
	(
		TmpVal=OptimisePoly Obj
		If TmpVal==false do eFlag=true
	)
	Return not eFlag
)

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

--Finds total area of all rectangles
Fn GridArea Objs=
(
    local nTotalArea = 0.0
	local nWidest = 0.0
	local nHighest = 0.0

    For Obj in Objs do 
	(
		nTotalArea += PieceArea Obj "A"
		
		nTmpVal=PieceArea Obj "W"
		if nTmpVal > nWidest do nWidest=nTmpVal
		
		mTmpVal=PieceArea Obj "H"
		if mTmpVal > nHighest do nHighest=mTmpVal
	)

	if gridtype==1 do TmpVal=ceil(sqrt(nTotalArea))
	if gridtype>1 do TmpVal=ceil(2*(sqrt((nTotalArea/2))))
	
	if ceil(nWidest)>TmpVal do TmpVal=ceil(nWidest)
	
	if ceil(nHighest)>TmpVal do TmpVal=ceil(nHighest)
	
	return TmpVal
)


--builds array of polys in largest poly order
Fn MakePolyList Objs=
(
	local LargestObj =0.0
	local PolyTodo=#()
	local eFlag=false
	local fFlag=false
	local nArea=0.0
	local mArea=0.0
	local PlaceMarker=0
	local nType
	
	PolyList=#()
	
	if gridtype==1 do nType="A"
	if gridtype==2 do nType="W"
	if gridtype==3 do nType="H"
	
	For iLoop=1 to Objs.count do append PolyTodo iLoop 

	While eFlag==false do
	(
		fFlag=false
		--go through all selected Objs
		For iLoop1 =1 to PolyTodo.count do
		(
			--found an Obj that hasn't been done
			if PolyTodo[iLoop1]>0 do
			(
				nArea= PieceArea Objs[iLoop1] nType
				LargestObj=Objs[iLoop1]
				PlaceMarker=iLoop1	

				For iLoop2 =1 to PolyTodo.count do
				(
					if PolyTodo[iLoop2]>0 do
					(	
						--found another Obj not done
						mArea=PieceArea Objs[iLoop2] nType
						if mArea > nArea do
						(
							--Obj is biggest so far
							LargestObj=Objs[iLoop2]
							PlaceMarker=iLoop2
							nArea=PieceArea Objs[iLoop2] nType
						)
					)
				) --iLoop2
				--checked all not done Objs
				append PolyList LargestObj
				PolyTodo[PlaceMarker]=0
				fFlag=true
			)
		) --iLoop
		if fFlag==false do eFlag=true
	)
)


--Moves object
fn MoveObj Obj NewX NewY =
(
	local HighX=0.0
	local HighY=0.0
	local CurrX=0.0
	local CurrY=0.0
	local DiffX=0.0
	local DiffY=0.0
	local NewMaxX=0.0
	local NewMaxY=0.0
	
	HighY=ExtremeVertex Obj "Y" "H"
	LowX=ExtremeVertex Obj "X" "L"

	CurrX=Obj.pos.x
	CurrY=Obj.pos.y

	DiffY=HighY.y-CurrY
	if CurrY>HighY.y do
	(
		DiffY=CurrY-HighY.y
	)

	DiffX=LowX.x-CurrX
	if CurrX>LowX.x do
	(
		DiffX=CurrX-LowX.x
	) 

	NewMaxY=(NewY+DiffY) * -1
	NewMaxX=(NewX+DiffX)
	
	Obj.pos=[NewMaxX,NewMaxY,0]
	return True
)


--adds hole to stack
fn AddToStack x y w h=
(
	append stackx x
	append stacky y
	append stackw w
	append stackh h
)


--Removes hole from stack
fn RemFromStack f=
(
	deleteitem stackx f
	deleteitem stacky f
	deleteitem stackw f
	deleteitem stackh f
)


--searches through stack for best hole
fn FindHole Obj=
(
	local bestarea=0
	local bestspace=0
	local fflag=false
	
	polyw=ceil(piecearea obj "W")
	polyh=ceil(piecearea obj "H")
	
	bestarea=(gridsizex * gridsizey)
	
	for f=1 to stackx.count do
	(
		if stackw[f]>=polyw and stackh[f]>=polyh do
		(
			--hole is big enough for poly
			fflag=true
			tmpval=(stackh[f]*stackw[f])
			if tmpval<=bestarea do
			(
				bestarea=tmpval
				bestspace=f
			)
		)
	)	
	
	if fflag==true do return bestspace
	return false
)


fn PlacePoly Obj sh=
(
	local newspacex=#()
	local newspacey=#()
	local newspacew=#()
	local newspaceh=#()

	polyw=ceil(piecearea obj "W")
	polyh=ceil(piecearea obj "H")

	--first hole pair
	append newspacex (stackx[sh]+polyw)
	append newspacey stacky[sh]
	append newspacew (stackw[sh]-polyw)
	append newspaceh stackh[sh]

	append newspacex stackx[sh]
	append newspacey (stacky[sh]+polyh)
	append newspacew polyw
	append newspaceh (stackh[sh]-polyh)

	--second hole pair
	append newspacex (stackx[sh]+polyw)
	append newspacey stacky[sh]
	append newspacew (stackw[sh]-polyw)
	append newspaceh polyh

	append newspacex stackx[sh]
	append newspacey (stacky[sh]+polyh)
	append newspacew stackw[sh]
	append newspaceh (stackh[sh]-polyh)
	
	--find best hole pair
	bighole=0
	bestpair=0
	for iLoop=1 to 4 do
	(
		x=(newspacew[iLoop]*newspaceh[iLoop])
		if x>bighole do
		(
			bighole=x
			bestpair=iLoop
		) 
	)
	if bestpair<3 do
	(
		addtostack newspacex[1] newspacey[1] newspacew[1] newspaceh[1]
		addtostack newspacex[2] newspacey[2] newspacew[2] newspaceh[2]
	)

	if bestpair>2 do
	(
		addtostack newspacex[3] newspacey[3] newspacew[3] newspaceh[3]
		addtostack newspacex[4] newspacey[4] newspacew[4] newspaceh[4]
	)
	
	moveobj obj stackx[sh] stacky[sh]
	remfromstack sh  --take first hole from stack
)


fn ArrangePolys Objs=
(
	tmpval=makepolylist objs
	
	tmpval=gridarea objs
	if gridtype==1 do
	(
		--square 1:1
		gridsizex=tmpval
		gridsizey=tmpval
	)
	if gridtype==2 do
	(
		--rect 1:2
		gridsizex=tmpval
		gridsizey=ceil(tmpval/2)
		
	)
	if gridtype==3 do
	(
		--rect 2:1
		gridsizex=ceil(tmpval/2)
		gridsizey=tmpval		
	)	
	
	eflag=false
	
	while eflag==false do
	(
		stackx=#()
		stacky=#()
		stackw=#()
		stackh=#()
		gflag=false

		x=addtostack 1 1 gridsizex gridsizey 

		for f=1 to polylist.count do
		(
			x=findhole polylist[f]
			if x==false do
			(
				--failed to fit piece in
				gflag=true
				exit loop
			)
			
			x=placepoly polylist[f] x
		)
		if gflag==true do --can't find hole -> increase gridsize
		(
			if gridtype==1 do
			(
				--square 1:1
				gridsizex=gridsizex+1
				gridsizey=gridsizey+1
			)
			if gridtype==2 do
			(
				--rect 1:2
				gridsizex=gridsizex+2
				gridsizey=gridsizey+1
			)
			if gridtype==3 do
			(
				--rect 2:1
				gridsizex=gridsizex+1
				gridsizey=gridsizey+2
			)
		)
		if gflag==false do --finished placing polys -> drop out
		(
			eflag=true
		)
		
		ShowWorking 1
	)
	return true
)

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
fn AttachAllPolysOld Objs=
(
	while objs.count > 1 do
	(
		attach Objs[2] Objs[1]
	)
	select Objs[1]
)


fn AttachAllPolys Objs=
(
	local AttachArray  = #()
	local Obj1=0
	local Obj2=0
	local iLoop=0
	
	for Obj in Objs do append AttachArray Obj.name
	sort AttachArray

	Obj1 = execute ("$'" + AttachArray[1] + "'")

	for iLoop =  2 to AttachArray.count do 
	(
		Obj2 = execute ("$'" + AttachArray[iLoop] + "'")		
		Attach Obj1 Obj2
	)
	
	AttachArray=#()
	select Obj1
)


fn ApplyPlanarMap Obj  = 
( 
	--reset
	Obj=CopyObj Obj false
	
	local nVert, nXH, nXL, nYH, nYL, nMin, nMax

	Obj.numtverts=Obj.numverts 
	buildTVFaces Obj 

	set coordsys world
	
	nXH=extremevertex Obj "X" "H"
	nXL=extremevertex Obj "X" "L"
	nYH=extremevertex Obj "Y" "H"
	nYL=extremevertex Obj "Y" "L"
	nMin=nXL
	nMin.y=nYL.y
	nMin.z=0
	nMax=nXH
	nMax.y=nYH.y
	nMax.z=0

	for iLoop = 1 to Obj.numverts do
	(		
		nVert=((getvert Obj iLoop)-nMin)/(nMax-nMin)
		nVert.z=0 
		settvert Obj iLoop nVert 
	) 
	
	for iLoop = 1 to Obj.numfaces do setTVFace Obj iLoop (getface Obj iLoop) 
	update Obj 
) 


fn ClrSmoothingGrps Obj=
(
	for FaceN = 1 to Obj.numfaces do
	(
		SetFaceSmoothGroup Obj FaceN 0
	)	
	Update Obj
	return true
)


fn WeldSel Obj=
(	
	max modify mode 
	select Obj  --max 2 compat
	subobjectlevel=1
	meshops.weld Obj  --won't work in 2.x
	subobjectlevel=0
	--ClrSmoothingGrps Obj
)


fn WeldPolys Obj=
(	
	max modify mode 
	select Obj  --max 2 compat
	subobjectlevel=1
	max select all
	TmpVal=maxversion
	meshops.weld Obj  
	subobjectlevel=0
)


fn ToggleVisible=
(
	max select all
	max unhide all
	max hide selection
)


fn MorphPolys =
(	
	--store Poly vert indices for reference later
	RefObj=#()
	for iLoop=1 to nMorphTgt.numverts do
	(
		FaceVerts=getvert nMorphTgt iLoop
		append RefObj FaceVerts
	)
	TmpVal=nMorphTgt.pivot
	
	createmorphobject nMorphSrc
	createmorphobject nMorphTgt
	addmorphtarget nMorphSrc.morph nMorphTgt 2
	delete nMorphTgt
	select nMorphSrc
	
	--reset vert positions
	for iLoop =1 to nMorphSrc.numverts do
	(
		setvert nMorphSrc iLoop [RefObj[iLoop].x,RefObj[iLoop].y,RefObj[iLoop].z]
	)
	
	nMorphSrc.pivot=TmpVal
	
	ConvertToMesh nMorphSrc
	
	update nMorphSrc
	
	return true	
)


fn CloneHidePolys Objs =
(	
	local CloneArray=#()
	
	for Obj in Objs do append CloneArray Obj.name
	
	for iLoop=1 to CloneArray.count do
	(	
		Obj = execute ("$'" + CloneArray[iLoop] + "'")
		TmpVal=CopyObj Obj true
		
		TmpVal.IsHidden=true
	)
	
	CloneArray=#()
)


-- flattens an objects vertices in the Z plane
fn LevelVerts Obj=
(
	for iLoop =1 to Obj.numverts do
	(
		TmpVal=getvert Obj iLoop
		setvert Obj iLoop [TmpVal.x,TmpVal.y,0]
	)
	Update Obj
)


-- flattens down a poly
fn FlattenPoly Obj=
(
	TmpVal=Rotater Obj
	TmpVal=LevelVerts Obj
	Update Obj
	
	return true
)


fn FlattenAllPolys Objs=
(
	local eFlag=false
	local TmpVal=false
	
	for Obj in Objs do
	(
		TmpVal=FlattenPoly Obj
		If TmpVal==false do eFlag=true
	)
	
	TmpVal =FixBBox Objs
	
	Return not eFlag
)


fn ShowStatus Valu =
(
	if Valu == "W" do valu="Working..."
	if Valu == "R" do valu="Ready"
	ExpertRollout.ccProgress.caption=(Valu)
)


---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

-- New functions - being tested

-- Fix bounding box 
fn FixBBox Objs=
(
	ObjCount=0
	for Obj in Objs do ObjCount = ObjCount+1
	
	if ObjCount==1 do
	(
		TmpVal=CopyObj Objs false
	)
	if ObjCount>1 do
	(
		for iLoop =1 to ObjCount do
		(
			Tmp=CopyObj Objs[1] false
		)
	)
	return true
)


-- for serious Sam
fn UniqueMatID Objs=
(	
	local nMatID=1
	
	for Obj in Objs do
	(
		AddModifier Obj(materialmodifier materialid:nMatID name:"MaterialMod")
		CollapseStack Obj
		nMatID=nMatID+1
	)
)

------------------------------------------------

fn GetEdgeVerts Obj nEdge = 
( 
--if not (classof theObj == Editable_mesh or 
--classof theObj == triMesh) do return undefined 
--if theEdge < 1 or theEdge > theObj.numverts do return undefined 
	
	local EdgeFace = ((nEdge-1)/3)+1 
	local nVerts = getFace Obj EdgeFace 
	
	if nEdge==(EdgeFace*3) do
	(
		x=point2 nVerts.z nVerts.x
	)
	if nEdge==(EdgeFace*3)-1 do
	(
		x=point2 nVerts.y nVerts.z
	)
		if nEdge==(EdgeFace*3)-2 do
	(
		x=point2 nVerts.x nVerts.y
	)

	return x
) 

fn WeldEdges Obj =
(
	local VertsArray=#()
	local EdgeVerts=0
	
	nSelEdges = for iLoop in Obj.selectededges collect iLoop.index
	if nSelEdges.count==0 do return false
	for iLoop=1 to nSelEdges.count do
	(
		EdgeVerts=GetEdgeVerts Obj nSelEdges[iLoop]
		append VertsArray EdgeVerts.x
		append VertsArray EdgeVerts.y
		
		EdgeFace = (((nSelEdges[iLoop])-1)/3)+1
						
		for iLoop=1 to Obj.numfaces do
		(
			if iLoop!=EdgeFace do
			(
				nAdjVerts=0
				nFaceVerts=getface Obj iLoop
								
				v1=getvert obj nFaceVerts.x
				v2=getvert obj nFaceVerts.y
				v3=getvert obj nFaceVerts.z
				w1=getvert obj EdgeVerts.x
				w2=getvert obj EdgeVerts.y
							
				if w1==v1 or w1==v2 or w1==v3 do nAdjVerts=nAdjVerts+1
				if w2==v1 or w2==v2 or w2==v3 do nAdjVerts=nAdjVerts+1

				if nAdjVerts>1 do
				(
					if v1==w1 or v1==w2 do append VertsArray nFaceVerts.x 
					if v2==w1 or v2==w2 do append VertsArray nFaceVerts.y
					if v3==w1 or v3==w2 do append VertsArray nFaceVerts.z
				)
			)
		)
	)
	Obj.selectedverts=VertsArray 
	update(Obj)
	max modify mode 
	subobjectlevel=1
	meshops.weld Obj  
	subobjectlevel=0
	return true
)