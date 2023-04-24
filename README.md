

## .NET Compression Utility 

This C# code provides a .NET compression utility for compressing and decompressing files. 

### How to Use

The `CompressionUtils` class contains two static methods:
- `CompressFile(string inputFilePath, string outputFilePath)` takes an input file path and an output file path, and compresses the input file into the output file.
- `DecompressFile(string inputFilePath, string outputFilePath)` takes an input file path and an output file path, and decompresses the input file into the output file.

To use this code, simply include the `CompressionUtils.cs` file in your project, and then call the appropriate method with the input and output file paths.

```csharp
// Compress a file
CompressionUtils.CompressFile("input.txt", "output.txt");

// Decompress a file
CompressionUtils.DecompressFile("compressed.txt", "decompressed.txt");
```

### Implementation Details

The `CompressFile` method reads the input file, creates an output file, and then uses a `DeflateStream` with `CompressionLevel.Optimal` to compress the input file and write the compressed data to the output file.

The `DecompressFile` method reads the compressed input file, creates an output file, and then uses a `DeflateStream` with `CompressionMode.Decompress` to decompress the input file and write the decompressed data to the output file.

Note that this implementation uses the DEFLATE algorithm for compression, which is a widely used algorithm that is supported by many file formats and compression tools.
