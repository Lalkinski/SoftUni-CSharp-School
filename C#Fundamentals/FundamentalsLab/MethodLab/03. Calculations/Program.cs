namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMath = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  


            switch (typeOfMath)
            {
                case "add":
                    addMath(a,b);   
                    break;
                case "multiply":
                    multiply(a,b);
                    break;
                case "subtract":
                    subtract(a, b);
                    break;
                case "divide":
                    divide(a,b);   
                    break;

            }

        }

        static void addMath(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
