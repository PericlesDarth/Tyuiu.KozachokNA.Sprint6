using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task2.V24
{
    internal class DataService
    {
        public static double func(double x)
        {
            double res = Math.Sin(x) + (Math.Cos(x) + 1)/(2 - x) + 2 * x;
            return Math.Round(res, 2);
        }
    }
}
