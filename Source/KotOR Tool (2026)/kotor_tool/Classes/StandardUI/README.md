<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/StandardUI/README.md
# Standard UI Models and Controls

This directory contains recovered reusable WinForms infrastructure: sortable/visible grid-column lists, combo items, custom `DataGrid` columns, inventory panels, resource tree nodes and a repeat button.

`KotorTreeNode` is especially important: it carries filename, resource type, path, archive index and game index through the main browser. It is both display node and resource locator.

Preserve control lifecycle and event behavior when modernizing. Do not dispose shared images/fonts from individual controls. Column `Copy` methods declare their typed overloads explicitly; regression checks cover derived and base destination lists. Validate keyboard/mouse behavior, disabled/edit states, sorting/visibility persistence and resource-node cloning/navigation.
=======
# Standard UI

Reusable grid-column models, combo items, inventory panel, repeat button and resource `KotorTreeNode` live here. The tree node carries archive path/type/index/game identity. Preserve cloning/navigation data, control lifecycle and designer serialization; test keyboard/mouse, disabled/edit, sorting and persisted visibility.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/StandardUI/README.md

## Deferred BIF tree nodes (2026-11-28)

`KotorTreeNode.Lazy.vb` separates the complete resource hierarchy from the native TreeView items. Build and group each archive while detached, then call `DeferDescendants(gameIndex)` before attaching it. Each unopened folder contains one expansion placeholder; `MaterializeChildren()` attaches its original immediate children when expanded or listed. Repeated materialization is harmless. Resource IDs, source paths, tags, labels, ordering and original node instances survive unchanged.

Recursive resource consumers must use `ResourceChildren()` and `ResourceParent`, rather than `Nodes` and `Parent`, to include unopened descendants. Game identity is assigned before detachment. UI navigation can continue using native collections after materializing the current folder. These operations remain on the UI thread; native WinForms destruction is not moved to a background worker. Opened folders retain their items, so this reduces initial/restored tree size rather than imposing a fixed item limit.
