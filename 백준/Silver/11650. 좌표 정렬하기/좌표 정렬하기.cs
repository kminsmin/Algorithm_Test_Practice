using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[,] coords = new int[count, 2];
            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] digits = input.Split(' ');
                coords[i, 0] = int.Parse(digits[0]);
                coords[i, 1] = int.Parse(digits[1]);
            }
            var sorted = Enumerable.Range(0, coords.GetLength(0))
                .Select(i => new
                {
                    First = coords[i, 0],
                    Second = coords[i, 1]
                })
                .OrderBy(x => x.First)
                .ThenBy(x => x.Second);
            foreach(var element in sorted)
            {
                Console.WriteLine($"{element.First} {element.Second}");
            }
        }
    }
}