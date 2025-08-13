using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static int count;
        static int[]? lans;
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            lans = new int[input[0]];
            count = input[1];
            for (int i = 0; i < lans.Length; i++)
                lans[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(ParametricSearch(1, (lans[0] / 2), lans[0]));
        }
        static int ParametricSearch(int start, int mid, int end)
        {
            int sum = 0;
            if (start >= mid)
            {
                for (int i = 0; i < lans.Length; i++)
                    sum += lans[i] / end;
                if (sum >= count) return end;
                else return start;
            }
            else
            {
                for (int i = 0; i < lans.Length; i++)
                    sum += lans[i] / mid;
                if (sum >= count) return ParametricSearch(mid, (mid + end) / 2, end);
                else return ParametricSearch(start, (mid + start) / 2, mid);
            }
        }
    }
}