using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> elements = new List<string>();

            using (StreamReader reader = new StreamReader(firstInputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        elements.Add(line);
                    }
                }
            }

            using (StreamReader reader = new StreamReader(secondInputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        elements.Add(line);
                    }
                }
            }
            elements.Sort();
            using(StreamWriter output =  new StreamWriter(outputFilePath))
            {
                foreach (string line in elements)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
