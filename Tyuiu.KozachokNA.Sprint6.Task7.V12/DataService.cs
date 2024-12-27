using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task7.V12
{
    internal class DataService
    {
        public static string[,] ProcessData(string[,] data, int column)
        {
            int n, m;
            n = data.GetLength(0);
            m = data.GetLength(1);
            string[,] res = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == column && data[i, j] != "10")
                    {
                        res[i, j] = "0";
                    }
                    else
                    {
                        res[i, j] = data[i, j];
                    }
                }
            }
            return res;
        }
    }
}
