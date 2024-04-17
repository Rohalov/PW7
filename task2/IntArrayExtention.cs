using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public static class IntArrayExtention
    {
        public static int GetMaxValue(this int[] numbers)
        {
            return numbers.Max();
        }
    }
}
