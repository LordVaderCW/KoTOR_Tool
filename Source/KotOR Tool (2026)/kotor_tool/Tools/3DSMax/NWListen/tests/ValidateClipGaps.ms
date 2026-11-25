-- Validate in a disposable imported scene. Does not reset or load a scene.
fn NWlistenValidateClipGaps nodes =
(
    local times = #()
    local ranges = #()
    for base in nodes where isProperty base #animations do for entry in base.animations do
    (
        local parts = filterString entry " "
        local first = parts[2] as integer, last = parts[3] as integer
        append ranges #(first,last)
        for t=first to last do appendIfUnique times (t as time)
    )
    -- Include fractional authored key times as well as every integer clip frame.
    for n in nodes do for c in #(n.position.controller,n.rotation.controller,n.scale.controller) do
        for k in c.keys do for range in ranges where k.time >= range[1] and k.time <= range[2] do appendIfUnique times k.time
    local samples = for t in times collect (at time t (for n in nodes collect #(n.position.controller.value,n.rotation.controller.value,n.scale.controller.value)))
    NWlistenJoinClipGaps nodes
    for i=1 to times.count do at time times[i] for j=1 to nodes.count do
    (
        local n=nodes[j], previous=samples[i][j]
        if distance n.position.controller.value previous[1] > 0.001 then throw ("Clip position changed: " + n.name + " at " + (times[i] as string))
        local a=n.rotation.controller.value,b=previous[2]
        if abs(a.x*b.x+a.y*b.y+a.z*b.z+a.w*b.w) < 0.99999 then throw ("Clip rotation changed: " + n.name + " at " + (times[i] as string) + "; before=" + (b as string) + "; after=" + (a as string))
        if distance n.scale.controller.value previous[3] > 0.001 then throw ("Clip scale changed: " + n.name)
    )
    times.count * nodes.count
)
