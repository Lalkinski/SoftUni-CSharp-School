using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    public class Tuple<T>
    {
        public T Item1 { get; set; }

        public T Item2 { get; set; }

        public T Item3 { get; set; }

        public Tuple(T item1, T item2, T item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = Item3;
        }
    }
}
