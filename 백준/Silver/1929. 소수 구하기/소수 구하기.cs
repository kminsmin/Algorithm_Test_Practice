using System;
using System.Linq;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] arr = sr.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int m = arr[0];
            int n = arr[1];
            bool[] primeArr = new bool[n+1];
            primeArr[1] = true;
            for (int i = 2; i < n+1; i++)
            {
                if (primeArr[i]) continue;
                int temp = n / i;
                for (int j = 2;j<=temp;j++)
                {
                    primeArr[j * i] = true;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = m; i <= n; i++)
            {
                if (!primeArr[i]) sb.AppendLine(i.ToString());
            }
            sw.WriteLine(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}