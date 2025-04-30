using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] arr;
            List<char> parList = new List<char>();
            Stack<int> lastOpenStack = new Stack<int>();
            int smallLayer = 0;
            int bigLayer = 0;
            int lastOpen = -1;
            bool twisted = false;
            while (input != ".")
            {
                parList.Clear();
                lastOpenStack.Clear();
                twisted = false;
                lastOpen = -1;
                smallLayer = 0;
                bigLayer = 0;
                arr = input.ToCharArray();
                foreach (char letter in arr)
                    if (letter == ')' || letter == '(' || letter == '[' || letter == ']') parList.Add(letter);
                for (int i = 0; i < parList.Count; i++)
                {
                    switch (parList[i])
                    {
                        case '(':
                            smallLayer++;
                            lastOpen = 0;
                            lastOpenStack.Push(lastOpen);
                            break;
                        case ')':
                            try
                            {
                                lastOpen = lastOpenStack.Pop();
                            }
                            catch
                            {
                                twisted = true;
                            }
                            if (lastOpen == 0)
                            {
                                smallLayer--;
                            }
                            else twisted = true;
                            break;
                        case '[':
                            bigLayer++;
                            lastOpen = 1;
                            lastOpenStack.Push(lastOpen);
                            break;
                        case ']':
                            try
                            {
                                lastOpen = lastOpenStack.Pop();
                            }
                            catch
                            {
                                twisted = true;
                            }
                            if (lastOpen == 1) bigLayer--;
                            else twisted = true;
                            break;
                        default:
                            break;
                    }
                    if (twisted) break;
                }
                if (twisted) Console.WriteLine("no");
                else if (smallLayer == 0 && bigLayer == 0)
                {
                    Console.WriteLine("yes");
                }
                else Console.WriteLine("no");
                input = Console.ReadLine();
            }
        }
    }
}