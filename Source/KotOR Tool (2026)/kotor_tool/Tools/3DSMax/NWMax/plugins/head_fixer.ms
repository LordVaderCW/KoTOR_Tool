rollout nx_head_fixer "Head Fixer" width:250
(
    edittext edt_pattern "Pattern: (*.max)"
    button btn_do "Process"
    
    on btn_do pressed do
    (
        local lParents = #()
        local filelist = getFiles edt_pattern.text
        for f in filelist do
        (
            resetMaxFile #noPrompt
            loadMaxFile f useFileUnits:true quiet:true
            
            
            --
            -- Make sure all pivots are world aligned
            --
            -- select all items other than the model base
            select $geometry
            lParents = #()
            clearListener()
            -- build up parent list
            for s in selection do
            (
                append lParents s
                append lParents s.parent
            )
            -- unlink the selection
            format "unlink\r\n"
            for s in selection do
            (
                s.parent = undefined
            )
            -- do the reset
            format "reset xform\r\n"
            -- do the reset
            local rotvalue
            local piv
            local orig
            for s in selection do
            (
                if (iskindof s Editable_Mesh) then
                (
                    
                    orig = copy s
                    nx_reset_transforms s
                    format "XForm added: %\r\n" s.name
                    
                    -- collapse stack
                    try ( collapsestack s ) catch()
                    format "XForm collapsed\r\n"
                    
                    -- restore original modifiers less the Xform
                    nx_copy_modifiers s orig ignore:#("XForm")
                    delete orig
                ) else
                (
                    s.scale = [1,1,1]
                )
            )
            -- relink
            format "relink\r\n"
            for n = 1 to lParents.count by 2 do
            (
                format "n=%\r\n" n
                lParents[n].parent = lParents[n+1]
            )
            
            -- apply the offset changes to head geom
            for s in selection do
            (
                s.objectoffsetpos += [0,-2.5,-3.625]
            )
            
            -- reset xform with safe pivots
            lParents = #()
            clearListener()
            -- build up parent list
            for s in selection do
            (
                append lParents s
                append lParents s.parent
            )
            -- unlink the selection
            format "unlink\r\n"
            for s in selection do
            (
                s.parent = undefined
            )
            -- do the reset
            format "reset xform\r\n"
            -- do the reset
            local rotvalue
            local piv
            local orig
            for s in selection do
            (
                if (iskindof s Editable_Mesh) then
                (
                    orig = copy s
                    nx_reset_transforms s
                    format "XForm added: %\r\n" s.name
                    
                    -- collapse stack
                    try ( collapsestack s ) catch()
                    format "XForm collapsed\r\n"
                    
                    -- restore original modifiers less the Xform
                    nx_copy_modifiers s orig ignore:#("XForm")
                    delete orig
                ) else
                (
                    s.scale = [1,1,1]
                )
            )
            -- relink
            format "relink\r\n"
            for n = 1 to lParents.count by 2 do
            (
                format "n=%\r\n" n
                lParents[n].parent = lParents[n+1]
            )
                
            -- save file
            saveMaxFile f
            
        ) -- end file for
    )
)

createDialog nx_head_fixer