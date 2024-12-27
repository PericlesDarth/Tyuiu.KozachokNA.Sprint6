using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task0.V22
{
    internal class DataService
    {
        public static double func(double x)
        {
            return Math.Round(0.7 * x * x * x + 1.52 * x * x, 3);
        }
    }
}
