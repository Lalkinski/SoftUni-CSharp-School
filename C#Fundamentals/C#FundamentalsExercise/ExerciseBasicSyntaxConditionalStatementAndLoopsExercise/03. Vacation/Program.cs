namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int peopleCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            //Calculation
            double price = 0;
            double pricePerPerson = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
                
                if (peopleCount >= 30)
                {
                    pricePerPerson *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 16;
                }
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }
            }
            else if(typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 22.50;
                }

                if(peopleCount >= 10 && peopleCount <= 20)
                {
                    pricePerPerson *= 0.95;
                }
            }

            price = pricePerPerson * peopleCount;


            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}