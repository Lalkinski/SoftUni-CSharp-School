using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDateDiffDays(DateTime date1, DateTime date2)
        {
            TimeSpan result = date1 - date2;

            return Math.Abs(result.Days);
        }
    }
}
