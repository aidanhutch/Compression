// See https://aka.ms/new-console-template for more information

using Compression;

Console.WriteLine("Compression example started...");

const string inputImagePath = "testimage.bmp";
const string compressedFilePath = "compressed.bin";
const string decompressedImagePath = "decompressed.bmp";

CompressionUtils.CompressFile(inputImagePath, compressedFilePath);
Console.WriteLine("Image compression complete.");

CompressionUtils.DecompressFile(compressedFilePath, decompressedImagePath);
Console.WriteLine("Image decompression complete.");

