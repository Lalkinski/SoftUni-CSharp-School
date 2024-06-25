using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

       string input;
        while ((input = Console.ReadLine()) != "End")
        {

            string[] data = input.Split(" -> ");
            string companyName = data[0];
            string employeeId = data[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new List<string>();
            }

            if (!companies[companyName].Contains(employeeId))
            {
                companies[companyName].Add(employeeId);
            }
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);
            foreach (var employeeId in company.Value)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}
