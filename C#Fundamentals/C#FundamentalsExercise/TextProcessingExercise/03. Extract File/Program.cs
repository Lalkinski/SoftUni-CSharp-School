namespace ExtractFile;

public class Program
{
    public static void Main(string[] args)
    {
        string path = Console.ReadLine();

        int lastSlashIndex = path.LastIndexOf('\\');

        string fullName = path.Substring(lastSlashIndex + 1);
        int dotIndex = fullName.IndexOf('.');

        Console.WriteLine($"File name: {fullName.Substring(0, dotIndex)}");
        Console.WriteLine($"File extension: {fullName.Substring(dotIndex + 1)}");
    }
}