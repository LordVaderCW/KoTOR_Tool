/*-----------------------------------------------------------------------------\

    Function Prototypes


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

--
-- Undefined Function Alert
--
function Alert=(
	messageBox "This function has not \nbeen implemented"
)

--------------------------------------------------------------------------------
-- Function Prototypes
--------------------------------------------------------------------------------
fn ShowDanglyConstraints node onoff=(Alert)
fn dump node=(Alert)
fn nx_progressPlus=(Alert)
fn nx_MakeUnqiueNodeName strName=(Alert)
fn nx_round x=(Alert)
fn nx_lowercase instring=(Alert)
fn nx_existFile fname=(Alert)
fn FindAnimByName lookup_name=(Alert)
fn FindFreeAnimNumber=(Alert)
fn FindFreeEventNumber=(Alert)
fn ShowDanglyConstraints node onoff=(Alert)
fn nx_UpdateMaterialEditor MatLib=(Alert)
fn nx_createNWNWalkMaterial=(Alert)
fn selChanged=(Alert)
fn nx_roundp3=(Alert)
fn nx_deletekeysinblock=(Alert)

--------------------------------------------------------------------------------
-- Import Functions
--------------------------------------------------------------------------------
global addMDLSkin=(Alert)
global ImportNWNmdl=(Alert)
global massload=(Alert)

--------------------------------------------------------------------------------
-- Export Functions
--------------------------------------------------------------------------------
global ExAuroraMDL=(Alert)
global massexport=(Alert)
-- broad mdl types
global ExAuroraWalkmesh=(Alert)
global ExAuroraTile=(Alert)
global ExAuroraGeometry=(Alert)
global ExAuroraAnimation=(Alert)
-- recusrive tree walkers, by node type
global Node_Tile=(Alert)
global Node_Geometry=(Alert)
-- specific export functions
--global ExAuroraDummy
global ExAuroraPoly=(Alert)
global ExAuroraTrimesh=(Alert)
global Ex3DOrientation=(Alert)
global WriteAABBTree=(Alert)
global BuildAABBTreeNode=(Alert)
global nx_ExDanglymesh=(Alert)
global nx_ExSkinweights=(Alert)
-- utility functions
global nx_fprints=(Alert)
global nx_strclassof=(Alert)
global nx_materialbitmapname=(Alert)


--------------------------------------------------------------------------------
-- Rollouts
--------------------------------------------------------------------------------
global ImportRollout=(Alert)
