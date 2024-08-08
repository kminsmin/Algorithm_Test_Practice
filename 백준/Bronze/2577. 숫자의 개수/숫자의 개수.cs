using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                num *= int.Parse(Console.ReadLine());
            }
            string numString = num.ToString();
            char[] nums = numString.ToCharArray();
            int[] numCount = new int[10];
            foreach (char numChar in nums)
            {
                switch (numChar)
                {
                    case '0':
                        numCount[0] += 1;
                        break;
                    case '1':
                        numCount[1] += 1;
                        break;
                    case '2':
                        numCount[2] += 1;
                        break;
                    case '3':
                        numCount[3] += 1;
                        break;
                    case '4':
                        numCount[4] += 1;
                        break;
                    case '5':
                        numCount[5] += 1;
                        break;
                    case '6':
                        numCount[6] += 1;
                        break;
                    case '7':
                        numCount[7] += 1;
                        break;
                    case '8':
                        numCount[8] += 1;
                        break;
                    case '9':
                        numCount[9] += 1;
                        break;
                }
            }
            foreach(int count in numCount)
            {
                Console.WriteLine(count);
            }

        }
    }
}