namespace GenericScale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(6, 6);

            Console.WriteLine(scale.AreEqual());
        }
    }
}
