using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KondrakovAA.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] a)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            string resp = "";

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(a[i,j] % 2 != 0)
                    {
                        a[i, j] = 0;
                    }

                    resp += Convert.ToString(a[i, j]) + "; ";

                }
                resp += "\n";
            }

            File.WriteAllText(path, Convert.ToString(resp));

            return resp;
        }
    }
}
