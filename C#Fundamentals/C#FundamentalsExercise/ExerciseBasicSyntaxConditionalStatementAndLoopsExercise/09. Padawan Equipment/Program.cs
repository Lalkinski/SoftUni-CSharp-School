﻿

using System;


internal class Program
{

    static void Main()
    {
        double moneyAmount = double.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        double saberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double percent = (double)studentsCount * 10 / 100;

        double allSabers = studentsCount + Math.Ceiling(percent);
        double sabers = saberPrice * allSabers;
        double robes = robePrice * studentsCount;
        double beltDiss = studentsCount - Math.Ceiling((double)(studentsCount / 6)); double belts = beltPrice * beltDiss;
        double total = sabers + robes + belts;
        Console.WriteLine(total <= moneyAmount ?
        $"The money is enough - it would cost {total:F2}lv." :
        $"John will need {total - moneyAmount:F2}lv more.");
    }
}
