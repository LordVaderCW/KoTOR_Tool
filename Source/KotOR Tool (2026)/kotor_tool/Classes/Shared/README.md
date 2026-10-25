# Shared Types

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/Shared/README.md
`clsPluginProgressEventArgs` carries plugin/install progress text and numeric state across background work and WinForms UI.

Keep event data immutable in new revisions and define the percentage/range contract explicitly. Producers may run off the UI thread, so subscribers must marshal control updates to the owning WinForms thread and tolerate late events during form closure.
=======
`clsPluginProgressEventArgs` carries progress text/value from download/build/install work. Define value ranges, prefer immutable event data and marshal subscribers to the WinForms thread; tolerate late events during form closure.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/Shared/README.md
