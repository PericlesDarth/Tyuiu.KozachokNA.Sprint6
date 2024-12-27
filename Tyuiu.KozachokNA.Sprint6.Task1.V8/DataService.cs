using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task1.V8
{
    internal class DataService
    {
        static double func(double x)
        {
            return Math.Round(Math.Cos(x) / (x - 0.4) + 8 * x * Math.Sin(x) + 2, 2);
        }

        static double[] ResultArray(int a, int b)
        {
            double[] res = new double[b - a + 1];
            for (int i = a; i <= b; i++)
            {
                if (i - 0.4 != 0)
                {
                    res[i - a] = func(i);
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
