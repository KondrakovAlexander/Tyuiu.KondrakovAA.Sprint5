using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KondrakovAA.Sprint5.Task1.V6.Lib
{ 
        public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int a, int b)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            string resp = "";

            for (int x = a; x < b; x++) {
                double f = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                resp += Convert.ToString(Math.Round(f, 2) + " ");
            }
            File.WriteAllText(path, Convert.ToString(resp));
            return Convert.ToString(resp);
        }
    }
}
