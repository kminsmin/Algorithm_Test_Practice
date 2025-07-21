using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] times = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            int currentTIme = 0;
            int sum = 0;
            for (int i = 0; i < times.Length; i++)
            {
                currentTIme += times[i];
                sum += currentTIme;
            }
            Console.WriteLine(sum);
        }
    }
}