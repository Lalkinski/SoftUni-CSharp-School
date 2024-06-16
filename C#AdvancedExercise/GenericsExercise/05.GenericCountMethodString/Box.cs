using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericCountMethodString
{
    public class Box<T> 
        where T : IComparable
    {
        public List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();
        }

        public int CountOfElements { get; set; }

        public int Count(T value)
        {
            foreach (var item in this.Items)
            {
                if (item.CompareTo(value) > 0)
                {
                    CountOfElements++;
                }
            }

            return CountOfElements;
        }
    }
}