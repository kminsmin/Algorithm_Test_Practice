using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int fact = Factorial(num);
            
            Console.WriteLine(fact);
        }
        static int Factorial(int num)
        {
            int temp = 1;
            int count = 0;
            for (int i = num; i > 1; i--)
            {
                temp *= i;
                if (temp % 10 == 0)
                {
                    while((temp>=10)&&(temp%10==0))
                    {
                        temp /= 10;
                        count++;
                    }
                }
                else temp %= 1000;
            }
            return count;
        }
    }
}