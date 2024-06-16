using System;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long totalBytes = sourceStream.Length;
                long partOneSize = (totalBytes + 1) / 2; 
                long partTwoSize = totalBytes - partOneSize;

                byte[] partOneBuffer = new byte[partOneSize];
                byte[] partTwoBuffer = new byte[partTwoSize];

                sourceStream.Read(partOneBuffer, 0, partOneBuffer.Length);
                sourceStream.Read(partTwoBuffer, 0, partTwoBuffer.Length);

                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    partOneStream.Write(partOneBuffer, 0, partOneBuffer.Length);
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    partTwoStream.Write(partTwoBuffer, 0, partTwoBuffer.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joinedStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    partOneStream.CopyTo(joinedStream);
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    partTwoStream.CopyTo(joinedStream);
                }
            }
        }
    }
}