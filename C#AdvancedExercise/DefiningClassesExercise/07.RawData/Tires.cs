using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tire
    {
        public Tire(int age, double preassure)
        {
            Age = age;
            Preassure = preassure;
        }

        public int Age{ get; set; }
        public double Preassure{ get; set; }
    }
}