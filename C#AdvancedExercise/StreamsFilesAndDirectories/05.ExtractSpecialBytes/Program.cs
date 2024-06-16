using System;
using System.Collections.Generic;
using System.IO;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> bytesToExtract = new List<byte>();
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (byte.TryParse(line, out byte result))
                    {
                        bytesToExtract.Add(result);
                    }
                }
            }

            using (FileStream binaryFileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                int currentByte;
                while ((currentByte = binaryFileStream.ReadByte()) != -1)
                {
                    if (bytesToExtract.Contains((byte)currentByte))
                    {
                        outputFileStream.WriteByte((byte)currentByte);
                    }
                }
            }
        }
    }
}