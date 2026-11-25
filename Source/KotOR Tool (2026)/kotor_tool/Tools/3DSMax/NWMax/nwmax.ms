/*-----------------------------------------------------------------------------\

    NWmax
    by Joco (jameswalker@clear.net.nz)

    Credits:
    Wayland Reid :-
        Extends Wayland's (wreid@spectrumanalytic.com) Import/Export script
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
    4. In the case of code used from the Bioware scripts their intellectual
       property rights still hold.
    5. No code has been knowingly included from other sources where that code
       is sold for commercial purposes.
     
       
       

   Updates:
   .8b61    Fix for global sanity check issues.
            Enhanced wok checker tool

   .8b22    Fix for fadinglight token not being parsed
            Fix for wok test not out putting to sanity check file
            Support for wok material file being fully driven from .ini file
            A number of misc bug fixes that I have lost track of.

   0.9 KotOR fixes - lordvadercw (19-Nov-2026)
            Fixed startup errors and improved Max 2021 compatibility.
            Added lordvadercw credits.
            Renamed MDL Loading to MDL Import.
            Improved KotOR I/TSL ASCII imports, UVs and walkmesh materials.
            Fixed missing textures and textured viewport display.
            Fixed scrambled screen textures (static preview only).
\-----------------------------------------------------------------------------*/

-- Ensure stack and heap size is large enough
if ( heapSize < 7500000 ) then heapSize = 7500000
if ( stackLimit < 4000000 ) then stackLimit = 4000000

global gNX_maxver = (maxversion())[1]

-- Keep earlier Listener output available for diagnosis.
global gblVersion = "0.9"
format "--------------------------------------------------------------\r\n"
format "\r\n"
format "                        NWmax v%\r\n" gblVersion
format "\r\n"
format "--------------------------------------------------------------\r\n"

--------------------------------------------------------------------------------
---
--- Global Variables and init setups
---
--------------------------------------------------------------------------------
global DEBUG = false	-- debug flag
global SPEEDT = false	-- speed timer flag
global strIndent1 = "  "
global strIndent2 = "    "
global strIndent3 = "      "
global strIndent4 = "        "
global strIndent5 = "          "
--
-- Resolve includes independently of autostart/current working directory.
global g_startpath = getFilenamePath (getSourceFileName())
fileIn (g_startpath + "nw_ie_inc/nx_max2021.ms")
-- Close old rollouts before their definitions are replaced during a reload.
if nx_destroy_floater != undefined do nx_destroy_floater()
format "NWmax user preferences: %\n" gNX_prefsFile
global g_3dsmax = "1"
global g_ismax = true
global g_fextn = ".max"
global g_gmaxini = "3dsmax.ini"
global g_guiAnimListSize = nx_prefInt "animlistsize" 10 5 30
global g_verbose = nx_prefInt "verbose" 0 0 1
global gNX_dock = nx_prefInt "dock" 0 0 1
global gNX_visible = nx_prefInt "visible" 1 0 1
global g_basepointer = nx_prefInt "basepointer" 1 0 1
global gnx_sanity = nx_sanityFlags (nx_prefString "init" "sanity" "11000111110111111111")
global gnx_pos_nwmax = nx_parsePosition (getINISetting gNX_prefsFile "position" "nwmax")
nx_refreshMapPaths()
format "Maps search dirs: %\n" g_maps_path
--
-- Exporting stream buffer
format "Setup exporting stream\r\n"
if g_ismax then
(
   global g_strBuffer = undefined	-- file stream buffer for exporting
   global g_delim = "\n"	-- Buffered export system delimter
) else
(
   global g_strBuffer = stringStream ""	-- StringStream buffer for compressed export system
   if g_verbose == 1 then (
      g_delim = "~\n"
   ) else (
      g_delim = "~"
   )
)
-- end 3dsmax v's gmax


-- g_startpath was resolved from this script before loading preferences.
--
-- Material surfaces used in WOK walkmeshes
global matsurfs = #("Dirt","Obscuring","Grass","Stone","Wood","Water", \
                      "Nonwalk","Transparent","Carpet","Metal","Puddles", \
                      "Swamp","Mud","Leaves","Lava","BottomlessPit", \
                      "DeepWater","Door", "Snow", "Sand")
global g_plugins = #()  -- list of plugins
global g_compiler = g_startpath+"mdlcomp\\nwnmdlcomp.exe"
global g_exportPath = ""
global nwmax_handle		-- handle to the master floater window
--
-- Global stack to be used for files and generic stack routines
global g_FileHandles = #()
--
-- Specific import globals
global lastDanglyName = undefined
global AnimRootNodeName = undefined
global LastAnimNumber = undefined
global LastAnimEventNumber = undefined
--
-- Specific export globals
global animIndex = 0    -- used by animmesh routine for modelbase.animation index
--
-- used in plug in load % bar
global percent = 0
global com_load_total = 9
global com_load = 0
--
-- UI flags for active dialogs
global nx_animkeymaster_flag = false
global nx_armourcutter_flag = false
global nx_ramaker_flag = false
global nx_skindumper_flag = false
--
-- globale execute str
global nx_exec_str

--
-- These are for the Active Sanity Check rollout in aurorabase
-- per Bioware's export scripts code. Legacy system.
format "Set Sanity check default settings\r\n"
global runRotationCheck
global runAnimCheck
global runCollisionMeshCheck
global runTileNodeBoundaryCheck
global runBSACheck
global runAuraEmitterCheck
global runAuraRefCheck
global runNameCheck
global runScaleCheck
global runPartTextureCheck
global runWeldCheck
global runClassCheck
global runControllerCheck
global runAnimMeshCheck
global runDoganCheck
global runBoneCountCheck
global runBitmapNameCheck
global runFaceCheck
global runAnimrootCheck
global runWOKCheck


--
-- Include in all the global function prototypes
format "Load Function Prototypes\r\n"
nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_proto.ms")

--------------------------------------------------------------------------------
---
--- Structures
---
--------------------------------------------------------------------------------
format "Define structs and utility fns\r\n"
struct nx_Tokenizer
(
    --
    -- used to parse out the imported mdl file
    --
    tokens = #(),

    fn SetString str =
    (
        str = trimright(trimleft(str))
        tokens = filterString str "\t ,"
    ),

    fn ReadToken =
    (
        if tokens.count > 0 then
        (
            local tok = tokens[1]
            deleteItem tokens 1
            if DEBUG then format "ReadToken: %\r\n" tok
            tok
        )
        else
        (
            undefined
        )
    ),

    fn PeekToken =
    (
        if tokens.count > 0 then tokens[1] else undefined
    ),

    fn ReadPoint3 =
    (
        local x = ReadToken() as float;
        local y = ReadToken() as float;
        local z = ReadToken() as float;
        if DEBUG then format "ReadPoint3: %\r\n" (point3 x y z)
        (point3 x y z)
    ),

    -- Odyssey ASCII exporters may omit the unused third UV coordinate.
    fn ReadUVPoint3 =
    (
        local u = ReadToken() as float
        local v = ReadToken() as float
        local w = if PeekToken() == undefined then 0.0 else (ReadToken() as float)
        [u,v,w]
    ),

    fn ReadFloat =
    (
        (ReadToken() as float)
    ),

    fn ReadInteger =
    (
        (ReadToken() as integer)
    ),

    fn ReadString =
    (
        (ReadToken())
    ),

    fn ReadColor =
    (
        local r = 255 * (ReadToken() as float);
        local g = 255 * (ReadToken() as float);
        local b = 255 * (ReadToken() as float);
        (color r g b)
    ),
    
    fn ReadBoolean =
    (
        local b = ReadToken()
        if (nx_lowercase b) == "true" then
            (true)
        else
            (false)
    ),

    fn ReadRemainingTokens =
    (
        local str = ""
        while (PeekToken() != undefined) do str += ReadToken() + " "
        substring str 1 (str.count-1)
    )
)

struct nx_MultiArray
(
    -- base array store
    ArrayData = #(),
    width = 1,
    
    fn append row =
    (
        if row.count != width then
            return false
        /*
        for e in row do (
            print e
            append ArrayData e
        )
        */
        
        join ArrayData row
        
        true
    ),
    
    fn delete row =
    (
        local realIndex, i
        realIndex = row * width
        if ArrayData.count < (realIndex+width-1) then
            return false
            
        for i = realIndex to (realIndex+width-1) do
        (
            deleteItem ArrayData i
        )
        true
    ),
    
    fn get row col =
    (
        local realIndex, i
        realIndex = ((row-1) * width) + col
        if ArrayData.count < realIndex then
            return false
        
        ArrayData[realIndex]
    ),
    
    fn size =
    (
        ArrayData.count / width
    )
)

struct nx_SkinWeights
(
    -- used to store the skin object and weights data
    Object,
    WeightsData = #()
)

fn nx_coderefresh =
(
	nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_general.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_sanity.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_export.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/aurora_gui_speedbtns.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_import.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_about.ms")
	nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_updaters.ms")
	max views redraw
)

--------------------------------------------------------------------------------
--
-- General functions
--
--------------------------------------------------------------------------------
nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_general.ms")

--
-- Start progress for loading
--
progressStart "PlugIns Loading ..."

--------------------------------------------------------------------------------
---
--- Export functions
---
--------------------------------------------------------------------------------
nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_sanity.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_fn_export.ms")

--------------------------------------------------------------------------------
---
--- Scripted Plug-Ins
---
--------------------------------------------------------------------------------
nx_requireScript (g_startpath+"nw_ie_inc/aurora_mod_trimesh.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_mod_flex.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_mod_walkmesh.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_mod_placeable.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_mod_animesh.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_helper_reference.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_helper_base.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_helper_light.ms")
nx_requireScript (g_startpath+"nw_ie_inc/aurora_helper_emitter.ms")

nx_requireScript (g_startpath+"nw_ie_inc/aurora_helper_tools.ms")
--------------------------------------------------------------------------------
---
---   Rollout definitions
---
--------------------------------------------------------------------------------
nx_requireScript (g_startpath+"nw_ie_inc/aurora_gui_speedbtns.ms")
nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_import.ms")
nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_about.ms")



--------------------------------------------------------------------------------
---
---   Setup the default sanity check values per ini string
---
--------------------------------------------------------------------------------
runRotationCheck = nx_itob(gnx_sanity[1] as integer)
runAnimCheck = nx_itob(gnx_sanity[2] as integer)
runCollisionMeshCheck = nx_itob(gnx_sanity[3] as integer)
runTileNodeBoundaryCheck = nx_itob(gnx_sanity[4] as integer)
runAuraEmitterCheck = nx_itob(gnx_sanity[5] as integer)
runAuraRefCheck = nx_itob(gnx_sanity[6] as integer)
runNameCheck = nx_itob(gnx_sanity[7] as integer)
runScaleCheck = nx_itob(gnx_sanity[8] as integer)
runPartTextureCheck = nx_itob(gnx_sanity[9] as integer)
runWeldCheck = nx_itob(gnx_sanity[10] as integer)
runClassCheck = nx_itob(gnx_sanity[11] as integer)
runControllerCheck = nx_itob(gnx_sanity[12] as integer)
runAnimMeshCheck = nx_itob(gnx_sanity[13] as integer)
runDoganCheck = nx_itob(gnx_sanity[14] as integer)
runBitmapNameCheck = nx_itob(gnx_sanity[15] as integer)
runFaceCheck = nx_itob(gnx_sanity[16] as integer)
runBSACheck = nx_itob(gnx_sanity[17] as integer)
runAnimrootCheck = nx_itob(gnx_sanity[18] as integer)
runBoneCountCheck = nx_itob(gnx_sanity[19] as integer)
runWOKCheck = nx_itob(gnx_sanity[20] as integer)



--------------------------------------------------------------------------------
---
---   Rollout Window creation
---
--------------------------------------------------------------------------------

fn nx_make_floater =
(
	nwmax_handle = newRolloutFloater "NWmax" 192 600 0 100
	addRollout nx_util1			nwmax_handle rolledUp:true
	addRollout nx_util2			nwmax_handle rolledUp:true
	addRollout nx_util3			nwmax_handle rolledUp:true
	addRollout nx_util4			nwmax_handle rolledUp:true
	addRollout nx_util5			nwmax_handle rolledUp:true
	addRollout ImportRollout    nwmax_handle rolledUp:true
	addRollout nx_prefs			nwmax_handle rolledUp:true
	addRollout AboutRollout     nwmax_handle rolledUp:false
	
	-- load in old position from local ini file
	nwmax_handle.pos = gnx_pos_nwmax
)

fn nx_destroy_floater =
(
	if nwmax_handle != undefined do
	(
	    -- make sure floater is not docked and unregister it
	    try (
	        cui.FloatDialogBar nwmax_handle
	        cui.UnRegisterDialogBar nwmax_handle
	    ) catch ()
	    -- close it.
	    try (closerolloutfloater nwmax_handle) catch ()
        nwmax_handle = undefined
	)
)


-- try to close out a floater if it already exists
nx_destroy_floater()

if gNX_visible == 1 then
(
	nx_make_floater()
	if gNX_dock == 1 then
	(
		-- Register floater as a dockable bar
		cui.RegisterDialogBar nwmax_handle \
		    maxSize:[-1,-1] \
		    style:#(#cui_dock_vert, #cui_floatable, #cui_handles)
		-- By default dock the bar
		cui.DockDialogBar nwmax_handle #cui_dock_left
	)
)

-- Set app title
-- Preserve the host application and scene title.
    
    
-- Startup does not own any existing redraw suspension.

--------------------------------------------------------------------------------
---
---   GUI updaters
---
--------------------------------------------------------------------------------
nx_requireScript (g_startpath+"nw_ie_inc/nwn_gui_updaters.ms")

------------------
--- selChanged ---
------------------
fn nx_selChanged =()

-- Call this function once to set all the UI elements properly
nx_selChanged()

-- Set up a global call back for selection changes
--callbacks.addscript #selectionSetChanged "selChanged()" id:#waysNWNtool

format "------------------------------Done----------------------------\r\n"
progressEnd()
max views redraw