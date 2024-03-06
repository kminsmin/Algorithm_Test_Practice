using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string star = "*";
            string[] starArray = new string[count];
            int width = 2 * count - 1;
            string temp;
            for (int i = 0; i < count; i++)
            {
                temp = "";
                int starNum = 2 * i + 1;
                for (int j = 0; j < (width - starNum) / 2; j++)
                {
                    temp += " ";
                }
                for (int j = 0; j < starNum; j++)
                {
                    temp += star;
                }
                starArray[i] = temp;
            }
            for (int k = 0; k < width; k++)
            {
                if (k < count) Console.WriteLine(starArray[k]);
                else Console.WriteLine(starArray[width - 1 - k]);
            }
        }
    }
}