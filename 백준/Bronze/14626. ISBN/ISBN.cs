using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            int[] numArr = Enumerable.Range(0, arr.Length).Select(x => MyParse(arr[x])).ToArray();
            FixISBN(ref numArr);
        }
        static int MyParse(char target)
        {
            int num;
            if (int.TryParse(target.ToString(), out num))
                return num;
            else return -1;
        }
        static void FixISBN(ref int[] arr)
        {
            int sum = 0;
            int val = 0;
            int index = 0;
            int m = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= 0) sum += ((i % 2 == 0) ? 1 : 3) * arr[i];
                else
                {
                    val = (i % 2 == 0) ? 1 : 3;
                    index = i;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (10 - (sum + i * val) % 10 == m || ((sum + i * val) % 10 == 0)&&m==0)
                {
                    Console.WriteLine(i);

                }
            }
        }

    }
}