namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                List<string> words = new List<string>();
                while (!reader.EndOfStream)
                {
                    words = reader.ReadToEnd().Split(' ').ToList();
                }

                string[] text = File.ReadAllLines(textFilePath);
                foreach(string line in text)
                {
                    string[] textWords = 
                        line.ToLower()
                        .Split(' ', '.', ',', '!', '?', '-', '\'', '\"', '(', ')', ';', ':' );

                    foreach (var item in textWords)
                    {
                        foreach (var word in words)
                        {
                            if(item == word)
                            {
                                if (!keyValuePairs.ContainsKey(word))
                                {
                                    keyValuePairs.Add(word, 0);
                                }
                                keyValuePairs[word]++;
                            }
                        }
                    }
                }

                foreach (string word in words)
                {
                    foreach (var wordInText in text)
                    {
                        if(word == wordInText.ToLower())
                        {
                            if (!keyValuePairs.ContainsKey(word))
                            {
                                keyValuePairs.Add(word, 1);
                            }

                            keyValuePairs[word]++;
                        }
                    }
                }


                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach(var word in keyValuePairs)
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}
