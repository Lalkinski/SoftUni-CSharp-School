using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main(string[] args)
    {
        var StartDate = DateTime.ParseExact(Console.ReadLine(), 
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture );

        var holidaysCount = 0;
        for(var date = StartDate; date <= endDate; date = date.AddDays(1))
        {
            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }

        Console.WriteLine(holidaysCount);
    }
}
