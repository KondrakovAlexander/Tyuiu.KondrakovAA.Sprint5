using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.KondrakovAA.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            // https://pstrtns.screenshotmaker.repl.co/

            string[] lines = File.ReadAllLines(path);
            string fileContent = File.ReadAllText(path);

            MatchCollection nums = Regex.Matches(fileContent, @"\b\d{2}\b");

            return nums.Count;
        }
    }
}
