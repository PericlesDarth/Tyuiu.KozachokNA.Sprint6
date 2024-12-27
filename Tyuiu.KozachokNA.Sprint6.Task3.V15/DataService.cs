using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task3.V15
{
    internal class DataService
    {
        public static int[,] sortColumn(int[,] olddata, int column)
        {
            int n, m;
            n = olddata.GetLength(0);
            m = olddata.GetLength(1);
            int[,] data = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    data[i, j] = olddata[i, j];
                }
            }
            List<int> ints = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ints.Add(data[i, column]);
            }
            ints.Sort();
            for (int i = 0; i < n; i++)
            {
                data[i, column] = ints[i];
            }
            return data;
        }
        public static int[,] initArray()
        {
            int[,] data = new int[5, 5];
            string foo = "";
            string[] bar = new string[5];

            foo = "33 28 31 19 4";
            bar = foo.Split(' ');
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[0, i] = int.Parse(bar[i]);
            }
            foo = "1 32 -3 -17 -12";
            bar = foo.Split(' ');
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[1, i] = int.Parse(bar[i]);
            }
            foo = "24 -19 26 31 -3";
            bar = foo.Split(' ');
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[2, i] = int.Parse(bar[i]);
            }
            foo = "30 -16 29 28 8";
            bar = foo.Split(' ');
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[3, i] = int.Parse(bar[i]);
            }
            foo = "30 5 11 7 32";
            bar = foo.Split(' ');
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[4, i] = int.Parse(bar[i]);
            }

            return data;
        }
    }
}
