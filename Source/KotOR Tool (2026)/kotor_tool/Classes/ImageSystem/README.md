# Image System

`clsImageSystem` coordinates TPC decoding and TGA/PNG/JPG/TPC/TXI export. Specialized classes load/write raster formats and expose decoded dimensions, bit depth, mip count, flags and pixel/TPC buffers. Preserve original TPC bytes when exporting TPC, validate dimensions/data sizes/compression, clone images away from disposed streams, and test alpha, mipmaps, vertical flipping and corrupt input.

TPC decoding treats DataSize=0 RGB/RGBA textures as uncompressed regardless of mip count. The base image precedes the lower mip levels; previously multi-mip uncompressed effect textures (for example fx_flare02) were exported as zero-filled images.
