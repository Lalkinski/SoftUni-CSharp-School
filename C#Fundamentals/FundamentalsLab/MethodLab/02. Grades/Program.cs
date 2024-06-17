namespace _2._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 2.00 && number <= 2.99)
            {
                printFailGrade(number);
            }
            else if (number >= 3.00 && number <= 3.49)
            {
                printPoorGrade(number);
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                printGoodGrade(number);
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                printVeryGoodGrade(number);
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                printExcellentGrade(number);
            }
        }

        static void printFailGrade(double nubmer)
        {
            Console.WriteLine("Fail");
        }

        static void printPoorGrade(double nubmer)
        {
            Console.WriteLine("Poor");
        }

        static void printGoodGrade(double number)
        {
            Console.WriteLine("Good");
        }

        static void printVeryGoodGrade(double number)
        {
            Console.WriteLine("Very good");
        }

        static void printExcellentGrade(double number)
        {
            Console.WriteLine("Excellent");
        }
    }
}
