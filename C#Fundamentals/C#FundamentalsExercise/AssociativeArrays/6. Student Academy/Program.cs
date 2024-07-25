namespace _6._Student_Academy
{
/*
5
John
5.5
John
4.5
Alice
6    
Alice
3 
George
5

     */
internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade[name] = new List<double>();
                }

                studentsGrade[name].Add(grade);
            }

            foreach (var student in studentsGrade)
            {
                double averageGrade = student.Value.Average();
                if(averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
