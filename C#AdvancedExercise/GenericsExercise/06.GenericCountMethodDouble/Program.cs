﻿namespace _06.GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Items.Add(input);
            }

            double value = double.Parse(Console.ReadLine());


            int result = box.Count(value);

            Console.WriteLine(result);
        }
    }
}
