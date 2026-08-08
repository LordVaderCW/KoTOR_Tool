# Animation System

`AnimListEntry` is a small data model pairing a dialog participant with an animation value. It is consumed by dialog/animation-list UI rather than being a file codec.

Keep participant identity and animation numbering stable when changing dialog tree behavior. Equality/display assumptions are made by UI collections, so add typed comparison semantics only with focused editor tests.
