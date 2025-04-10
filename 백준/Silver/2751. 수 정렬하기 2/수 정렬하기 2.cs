using System;
using System.IO;

namespace Baekjoon
{
    class Program
    {
        static int[]? positiveArr = new int[1000001];
        static int[]? negativeArr = new int[1000001];
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if(temp<0)
                {
                    negativeArr[-temp]++;
                }
                else
                {
                    positiveArr[temp]++;
                }
            }
            using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {       
                for (int i = 1000000; i>0; i--)
                {
                    if (negativeArr[i] == 0) continue;
                    for (int j = 0; j < negativeArr[i]; j++)
                    {
                        print.WriteLine("-"+i);
                    }
                }
                for (int i = 0; i <= 1000000; i++)
                {
                    if (positiveArr[i] == 0) continue;
                    for (int j = 0; j < positiveArr[i]; j++)
                    {
                        print.WriteLine(i);
                    }
                }
            }
        }

    }
}