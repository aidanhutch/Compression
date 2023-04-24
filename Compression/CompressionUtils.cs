using System.IO.Compression;

namespace Compression
{
    public static class CompressionUtils
    {
        public static void CompressFile(string inputFilePath, string outputFilePath)
        {
            using (var inputFileStream = File.OpenRead(inputFilePath))
            {
                using (var outputFileStream = File.Create(outputFilePath))
                {
                    using (var deflateStream = new DeflateStream(outputFileStream, CompressionLevel.Optimal))
                    {
                        inputFileStream.CopyTo(deflateStream);
                    }
                }
            }
        }

        public static void DecompressFile(string inputFilePath, string outputFilePath)
        {
            using (var inputFileStream = File.OpenRead(inputFilePath))
            {
                using (var outputFileStream = File.Create(outputFilePath))
                {
                    using (var deflateStream = new DeflateStream(inputFileStream, CompressionMode.Decompress))
                    {
                        deflateStream.CopyTo(outputFileStream);
                    }
                }
            }
        }
    }
}