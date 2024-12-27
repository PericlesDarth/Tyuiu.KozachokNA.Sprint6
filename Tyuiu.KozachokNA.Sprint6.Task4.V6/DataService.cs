using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task4.V6
{
    internal class DataService
    {
        static double func(double x)
        {
            double res = 3 * Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2;
            return res;
        }

        static double[] ResultArray(int a, int b)
        {
            double[] res = new double[b - a + 1];
            for (int i = a; i <= b; i++)
            {
                if (4 * i - 0.5 != 0)
                {
                    res[i - a] = Math.Round(func(i), 2);
                }
                else
                {
                    res[i - a] = 0;
                }
            }
            return res;
        }

        public static string TabulatedOutput(int a, int b)
        {
            double[] values = ResultArray(a, b);
            string res = "";
            for (int i = a; i <= b; i++)
            {
                if (i > 0)
                {
                    res += " " + Convert.ToString(i) + ": " + Convert.ToString(values[i - a]);
                }
                else
                {
                    res += Convert.ToString(i) + ": " + Convert.ToString(values[i - a]);
                }
                if (i != b)
                {
                    res += "\r\n";
                }
            }
            return res;
        }
    }
}
