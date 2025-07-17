using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            List<int> coins = new List<int>();
            for (int i = 0; i < n; i++)
            {
                coins.Add(int.Parse(sr.ReadLine()));
            }
            int count = 0;
            int index = coins.Count - 1;
            while(k>0)
            {
                while (coins[index] > k)
                    index--;
                k -= coins[index];
                count++;
            }
            Console.WriteLine(count);
            sr.Close();
        }
    }
}