using System.Linq;

/*
7
John 5.20
Maria 5.50
John 3.20
Maria 2.50
Sam 2.00
Maria 3.46
Sam 3.00 
 */
class Program
{
    static void Main()
    {
        Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string nameOfStudent = input[0];
            decimal grades = decimal.Parse(input[1]);

            if (!studentGrades.ContainsKey(nameOfStudent))
            {
                studentGrades.Add(nameOfStudent, new List<decimal>());
            }

            studentGrades[nameOfStudent].Add(grades);
        }

        foreach(var item in studentGrades)
        {
            var averageGrades = item.Value.Average();
            Console.Write($"{item.Key} -> ");
            foreach(var grades in item.Value)
            {
                Console.Write($"{grades:f2} ");
            }
            Console.WriteLine($"(avg: {averageGrades:f2})");
        }
    }
}

