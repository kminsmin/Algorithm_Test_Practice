using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Stack<int> numStack = new Stack<int>();
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp != 0) numStack.Push(temp);
                else numStack.Pop();
            }
            int sum = 0;
            temp = numStack.Count;
            for (int i = 0; i < temp; i++)
            {
                sum += numStack.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}