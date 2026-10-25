<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/StandardUI/README.md
# Standard UI Models and Controls

This directory contains recovered reusable WinForms infrastructure: sortable/visible grid-column lists, combo items, custom `DataGrid` columns, inventory panels, resource tree nodes and a repeat button.

`KotorTreeNode` is especially important: it carries filename, resource type, path, archive index and game index through the main browser. It is both display node and resource locator.

Preserve control lifecycle and event behavior when modernizing. Do not dispose shared images/fonts from individual controls. Column `Copy` methods currently shadow base members and contribute known warnings; fix only with compatibility tests. Validate keyboard/mouse behavior, disabled/edit states, sorting/visibility persistence and resource-node cloning/navigation.
=======
# Standard UI

Reusable grid-column models, combo items, inventory panel, repeat button and resource `KotorTreeNode` live here. The tree node carries archive path/type/index/game identity. Preserve cloning/navigation data, control lifecycle and designer serialization; test keyboard/mouse, disabled/edit, sorting and persisted visibility.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/StandardUI/README.md
