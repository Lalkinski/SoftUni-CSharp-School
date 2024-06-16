using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    public class ListyIterator
    {
        private List<string> items;
        int index = 0;
        public ListyIterator(List<string> items)
        {
            this.items = items;
        }

        public void Create(List<string> items)
        {
            this.items = new List<string>(items);
        }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }

            index++;
            return true;
        }

        public bool HasNext()
        {
            return this.index < this.items.Count - 1;
        }

        public void Print()
        {
            Console.WriteLine(items[index]);
        }
    }
}
