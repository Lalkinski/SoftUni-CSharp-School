using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string products = "";
            decimal coinSum = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                decimal coins = decimal.Parse(input);
                if (coins == 0.1m)
                {
                    coinSum += coins;
                }
                else if (coins == 0.2m)
                {
                    coinSum += coins;
                }
                else if (coins == 0.5m)
                {
                    coinSum += coins;
                }
                else if (coins == 1.0m)
                {
                    coinSum += coins;
                }
                else if (coins == 2.0m)
                {
                    coinSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

            }
            while ((products = Console.ReadLine()) != "End")
            {
                if (products == "Nuts")
                {
                    if (coinSum < 2.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    coinSum -= 2.0m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Water")
                {
                    if (coinSum < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    coinSum -= 0.7m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Crisps")
                {
                    if (coinSum < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    coinSum -= 1.5m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Soda")
                {
                    if (coinSum < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    coinSum -= 0.8m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Coke")
                {
                    if (coinSum < 1.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    coinSum -= 1.0m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coinSum:F2}");

        }
    }
}

