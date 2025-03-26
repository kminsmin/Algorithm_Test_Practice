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
            int v = int.Parse(digits[2]);
            int perDay = a - b;
            int target = v - a;
            int count = target / perDay;
            if (target % perDay == 0)
            {
                count++;
            }
            else
            {
                int temp = v - (count * perDay);
                while (temp > 0)
                {
                    count++;
                    temp -= a;
                    if (temp <= 0) break;
                    temp += b;
                }
            }

            Console.WriteLine(count);
        }
    }
}