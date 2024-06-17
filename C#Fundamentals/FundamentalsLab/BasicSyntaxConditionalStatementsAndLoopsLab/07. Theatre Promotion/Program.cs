using System.Diagnostics;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            decimal sum = 0;

            if (age < 0)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (day == "Weekday")
            {
                if((age >= 0 && age <= 18) ||  (age > 64 && age <= 122))
                {
                    sum = 12;
                }
                else if(age > 18 && age <= 64)
                {
                    sum = 18;
                }
            }
            else if (day == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    sum = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 20;
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 12;
                }
                else if(age > 64 && age <= 122)
                {
                    sum = 10;
                }
            }

            if (sum != 0)
            {
                Console.WriteLine($"{sum}$");
            }
            else
            {
                Console.WriteLine("Error!");
            };
        }
    }
}