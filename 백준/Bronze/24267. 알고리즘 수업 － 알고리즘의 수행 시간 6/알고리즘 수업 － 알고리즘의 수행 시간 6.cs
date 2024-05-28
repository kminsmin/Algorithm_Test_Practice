using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            ulong n = 0;
            ulong count = 0;
            n = ulong.Parse(Console.ReadLine());
            count += (n-2) * (n-1) * n / 6;
            Console.WriteLine(count);
            Console.WriteLine(3);
        }
    }
}