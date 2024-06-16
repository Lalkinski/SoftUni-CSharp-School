/*
5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
older
20
name age

 */
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            string name = input[0];
            int age = int.Parse(input[1]);

            Student student = new Student() { Name = name, Age = age };

            students.Add(student);
        }

        string filterType = Console.ReadLine();
        int filterNumber = int.Parse(Console.ReadLine());
        Func<Student, int, bool> filter = FilterGenerator(filterType);

        students = students
            .Where(student => filter(student, filterNumber))
            .ToList();

        string format = Console.ReadLine();

        Action<Student> printer = PrinterGenetarot(format);

        students.ForEach(s => printer(s));

        Action<Student> PrinterGenetarot(string format)
        {
            if (format == "name age")
            {
                return s => Console.WriteLine($"{s.Name} - {s.Age}");
            }
            if (format == "name")
            {
                return s => Console.WriteLine($"{s.Name}");
            }
            if (format == "age")
            {
                return s => Console.WriteLine($"{s.Age}");
            }

            return null;
        }


        Func<Student, int, bool> FilterGenerator(string filterType)
        {
            Func<Student, int, bool> filter = null;
            if (filterType == "older")
            {
                filter = (student, nubmer) => student.Age >= nubmer;
            }

            if (filterType == "younger")
            {
                filter = (student, number) => student.Age < number;
            }


            return filter;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

