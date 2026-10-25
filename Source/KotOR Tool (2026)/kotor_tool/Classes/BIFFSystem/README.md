# BIFF System

`BIFFArchive` retains a stream, reads resource table entries and returns raw bytes; supporting types hold BIFF/index/offset/size/type data. KEY lookup supplies packed IDs. Validate counts/ranges, keep streams alive appropriately, and test truncated/large archives without writing game BIFFs.
