# Item Models

Inventory/module/tree models carry ResRefs, quantities, coordinates, categories and live `TreeNode` state. Keep storage identity separate from labels, preserve coordinate comparison behavior and avoid serializing UI nodes directly. Test duplicates, missing parents and all placed-object categories.
