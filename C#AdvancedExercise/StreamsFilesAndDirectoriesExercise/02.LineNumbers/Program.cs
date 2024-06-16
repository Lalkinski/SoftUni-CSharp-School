namespace LineNumber
{
    public class LineNumber
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\text.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ProccessLines(inputFilePath, outputFilePath);
        }

        public static void ProccessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while(!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        int lineNumber = 1;
                        int letterCount = 0;
                        int puntuation = 0;
                        foreach(char c in line)
                        {
                            if (char.IsLetter(c))
                            {
                                letterCount++;
                            }
                            else if(char.IsPunctuation(c))
                            {
                                puntuation++;
                            }
                        }
                        writer.WriteLine($"Line {lineNumber}: {line} ({letterCount})({puntuation})");
                    }
                }
            }
        }
    }
}
