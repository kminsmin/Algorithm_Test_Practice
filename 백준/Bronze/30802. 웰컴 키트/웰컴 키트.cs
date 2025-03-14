using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int total;
            int[] sizeCount = new int[6];
            int tBundle;
            int pBundle;
            int tBuy = 0;
            int pBuy = 0;

            string input = Console.ReadLine();
            total = int.Parse(input);
            input = Console.ReadLine();
            string[] digits = input.Split(" ");
            for (int i = 0; i < 6; i++)
            {
                sizeCount[i] = int.Parse(digits[i]);
            }
            input = Console.ReadLine();
            digits = input.Split(" ");
            tBundle = int.Parse(digits[0]);
            pBundle = int.Parse(digits[1]);

            foreach (int count in sizeCount)
            {
                if(count%tBundle == 0) tBuy += count / tBundle;
                else tBuy += count / tBundle + 1;
            }
            Console.WriteLine(tBuy);
            pBuy = total / pBundle;
            Console.WriteLine($"{pBuy} {total - (pBuy * pBundle)}");
        }
    }
}