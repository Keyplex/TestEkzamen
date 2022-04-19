using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLib
{
    public class Program
    {
        public static int Skidkaprozent(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
        // метод считает сумму
        static public int Calculate(int a, int b)
        {
            return a - b; // b = это 10%
        }
    }
}
