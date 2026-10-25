# Custom Controls

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/CustomControls/README.md
This directory implements restored themed WinForms controls:

- `DarkPictureBox` (`CustomPictureBoxControl.vb`) draws themed borders/chrome around images.
- `CustomProgressBar` draws the themed track/fill/animation used by progress dialogs.
- `CustomTabControl` and `CustomTabBorderStyle` replace native tab rendering with theme-aware chrome.
- `DarkByteViewerControl` renders bytes/ASCII with selection, current-byte and semantic color modes.

## Heuristics

Controls are owner-drawn and theme-sensitive. Avoid allocating brushes, pens, fonts or bitmaps on every paint without disposal/caching ownership. Painting must handle zero size, partial visibility, disabled state, high DPI and rapid resize. Animation timers must stop on disposal. Selection/scroll calculations in the byte viewer must use byte indices independent of pixel coordinates.

Verify controls in the designer and runtime under every bundled theme, 100%/150%/200% DPI, keyboard navigation, empty/large data and repeated open/close cycles. Keep public properties designer-serializable.
=======
Owner-drawn themed picture box, progress bar, tabs and byte viewer live here. Manage GDI/timer ownership, byte-index versus pixel calculations, designer serialization, zero-size/large-data behavior and high DPI. Test every theme and repeated open/close.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/CustomControls/README.md
