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
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> passwordDict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                passwordDict.Add(temp[0], temp[1]);
            }
            for (int i = 0; i < m; i++)
            {
                sb.AppendLine(passwordDict[sr.ReadLine()]);
            }

            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}