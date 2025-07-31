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
            int count = int.Parse(sr.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < count; i++)
            {
                Dictionary<string, int> closet = new Dictionary<string, int>();
                int temp = int.Parse(sr.ReadLine());
                for (int j = 0; j < temp; j++)
                {
                    string[] gear = sr.ReadLine().Split(' ');
                    if (closet.ContainsKey(gear[1]))
                    {
                        closet[gear[1]]++;
                    }
                    else
                        closet.Add(gear[1], 1);
                }
                int combo = 1;
                foreach (string gear in closet.Keys)
                {
                    combo *= (closet[gear] + 1);
                }
                combo--;
                sb.AppendLine(combo.ToString());
            }
            
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}