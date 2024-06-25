/*
Beer 2.20 100
IceTea 1.50 50
NukaCola 3.30 80
Water 1.00 500
buy

Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy

CesarSalad 10.20 25
SuperEnergy 0.80 400
Beer 1.35 350
IceCream 1.50 25
buy
 */
using System;
using System.Collections.Generic;


namespace _3._Orders
{
    class Product 
    {
        public string Name {  get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;
            while((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]); 


                if (products.ContainsKey(name))
                {
                    
                    products[name].Quantity += quantity;
                    if (products[name].Price != price)
                    {
                        products[name].Price = price;
                    }
                }
                else
                {
                    products.Add(name, new Product { 
                        Name = name, 
                        Price = price, 
                        Quantity = quantity });
                }

            }

            foreach (var product in products.Values)
            {
                double totalPrice = product.Price * product.Quantity;
                Console.WriteLine($"{product.Name} -> {totalPrice:F2}");
            }
        }
    }
}
