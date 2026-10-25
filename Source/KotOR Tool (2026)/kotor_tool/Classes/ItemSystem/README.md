<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/ItemSystem/README.md
# Item and Tree Models

These classes carry editor/resource-tree state rather than parsing files directly.

- `InventoryItem` stores display/ResRef/equipment/quantity/drop data.
- `ModItem` represents a placed module object with world/screen coordinates, type, geometry/spawn lists and comparison behavior.
- `ModItemTvNode` and `ProjectFileItemTreeNode` specialize `TreeNode` for module/project UI.
- `TreeBaseItem` is a basic categorized item model.

Keep storage identity (`ResRef`, path, item type) separate from display labels. Coordinate conversion and `CompareTo` behavior affect module rendering/sorting; test equal coordinates, missing parents and all placeable categories. Tree nodes often carry live UI state and should not become persistence DTOs without an explicit conversion layer.
=======
# Item Models

Inventory/module/tree models carry ResRefs, quantities, coordinates, categories and live `TreeNode` state. Keep storage identity separate from labels, preserve coordinate comparison behavior and avoid serializing UI nodes directly. Test duplicates, missing parents and all placed-object categories.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/ItemSystem/README.md
