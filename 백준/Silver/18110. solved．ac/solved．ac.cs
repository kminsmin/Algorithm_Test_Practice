using System;
using System.Linq;
using static System.Math;
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
            int n = int.Parse(sr.ReadLine());
            if (n == 0)
            {
                sw.WriteLine("0");
                sr.Close();
                sw.Close();
                return;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            arr = arr.OrderBy(x => x).ToArray();
            int value = (int)Math.Round((float)n * 0.15f, MidpointRounding.AwayFromZero);
            int sum = 0;
            for (int i = value; i < n - value; i++)
            {
                sum += arr[i];
            }
            sw.WriteLine(((int)(Math.Round((float)sum / (n - value * 2), MidpointRounding.AwayFromZero))).ToString());
            sr.Close();
            sw.Close();
        }
    }
}
