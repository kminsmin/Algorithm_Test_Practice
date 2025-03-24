using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            int a = int.Parse(digits[0]);
            int b = int.Parse(digits[1]);
            int min = (a > b) ? b : a;
            int max = (a > b) ? a : b;

            for (int i = min; i > 0; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            for (int i = max; i <= a * b; i++)
            {
                if ((i % a == 0) && (i % b == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}