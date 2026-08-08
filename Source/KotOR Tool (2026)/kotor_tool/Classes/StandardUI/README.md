# Standard UI Models and Controls

This directory contains recovered reusable WinForms infrastructure: sortable/visible grid-column lists, combo items, custom `DataGrid` columns, inventory panels, resource tree nodes and a repeat button.

`KotorTreeNode` is especially important: it carries filename, resource type, path, archive index and game index through the main browser. It is both display node and resource locator.

Preserve control lifecycle and event behavior when modernizing. Do not dispose shared images/fonts from individual controls. Column `Copy` methods currently shadow base members and contribute known warnings; fix only with compatibility tests. Validate keyboard/mouse behavior, disabled/edit states, sorting/visibility persistence and resource-node cloning/navigation.
