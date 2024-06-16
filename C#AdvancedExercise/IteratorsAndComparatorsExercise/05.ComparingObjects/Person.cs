using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person? other)
        {
            if (this.Name != other.Name)
            {
                return -1;
            }

            if (this.Age != other.Age)
            {
                return -1;
            }
            if (this.Town != other.Town)
            {
                return -1;
            }

            return 0;
        }
    }
}
