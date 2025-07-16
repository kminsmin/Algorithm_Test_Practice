using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            Dictionary<string, int> dDict = new Dictionary<string, int>();
            List<string> dbList = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string person = sr.ReadLine();
                dDict.Add(person, 0);
            }
            for (int i = 0; i < m; i++)
            {
                string temp = sr.ReadLine();
                if (dDict.ContainsKey(temp))
                {
                    dbList.Add(temp);
                }
            }
            dbList.Sort();
            foreach(string name in dbList) sb.AppendLine(name);
            sw.WriteLine(dbList.Count.ToString());
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}