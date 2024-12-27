using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint6.Task6.V17
{
    internal class DataService
    {
        public static string ProcessData(string input)
        {
            string res = "";
            string[] foo = input.Split("\n");
            List<string> bar = [];
            foreach (string line in foo)
            {
                if (line == "")
                {
                    continue;
                }
                bar = [];
                foreach (string line2 in line.Split(" "))
                {
                    bar.Add(line2);
                }
                res += bar[2] + " ";
            }
            return res;
        }
    }
}
