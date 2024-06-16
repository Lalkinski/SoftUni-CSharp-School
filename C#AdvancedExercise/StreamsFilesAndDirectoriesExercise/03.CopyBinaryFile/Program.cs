namespace CopyBinaryFile
{
    using System;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var files = new FileStream("copyMe.png", FileMode.Open))
            {
                using (var copyFiles = new FileStream("copyMe-copy.png", FileMode.Create))
                {

                }
            }
        }
    }
}
