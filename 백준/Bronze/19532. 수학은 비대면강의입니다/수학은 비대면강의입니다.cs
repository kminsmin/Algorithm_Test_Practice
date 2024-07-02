using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);
            int f = int.Parse(numbers[5]);
            int x = 0;
            int y = 0;
            bool checkAgain = false;
            int temp = a;
            if (d != 0&& a!=0)
            {
                a *= d;
                b *= d;
                c *= d;
                d *= temp;
                e *= temp;
                f *= temp;

                b -= e;
                c -= f;
                y = c / b;
            }
            else if (d == 0)
            {
                y = f / e;
            }
            else if (a == 0)
            {
                y = c / b;
            }
            
            
            int tempX = -999;
            while (true)
            {
                if (a == 0)
                {
                    checkAgain = true;
                    break;
                }
                else if ((d!=0)&&((a * tempX) + ((b+e) * y) == (c+f)))
                {
                    x = tempX;
                    break;
                }

                tempX++;
            }
            tempX = -999;
            while(checkAgain)
            {
                if ((d * tempX) + (e * y) == f)
                {
                    x = tempX;
                    break;
                }
                tempX++;
            }
            Console.WriteLine($"{x} {y}");
        }
    }
}