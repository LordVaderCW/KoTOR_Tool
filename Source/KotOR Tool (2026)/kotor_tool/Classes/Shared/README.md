# Shared Types

`clsPluginProgressEventArgs` carries plugin/install progress text and numeric state across background work and WinForms UI.

Keep event data immutable in new revisions and define the percentage/range contract explicitly. Producers may run off the UI thread, so subscribers must marshal control updates to the owning WinForms thread and tolerate late events during form closure.
