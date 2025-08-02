using System;
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
            StringBuilder sb = new StringBuilder();
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            int[] nums = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sums = new int[n];
            sums[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }
            for (int i = 0; i < m; i++)
            {
                input = sr.ReadLine().Split(' ').Select(x => int.Parse(x)-1).ToArray();
                int diff = (input[0] > 0) ? sums[input[0] - 1] : 0;
                sb.AppendLine((sums[input[1]] - diff).ToString());
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}