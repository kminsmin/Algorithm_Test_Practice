using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                char[] arr = input.ToCharArray();
                int openCount = 0;
                foreach (char element in arr)
                {
                    switch (element)
                    {
                        case '(':
                            openCount++;
                            break;
                        case ')':
                            if (openCount > 0) openCount--;
                            else openCount = 100;
                            break;
                        default:
                            break;
                    }
                }
                if (openCount == 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}