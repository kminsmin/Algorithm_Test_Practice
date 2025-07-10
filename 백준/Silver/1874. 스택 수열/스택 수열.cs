using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine());
            Stack<int> stack = new Stack<int>();
            int i = 1;
            int count = 0;
            StringBuilder sb = new StringBuilder();
            int[] arr = new int[n];
            for (int j = 0; j < n; j++)
            {
                arr[j] = int.Parse(sr.ReadLine());
            }
            int temp = arr[0];
            while(true)
            {
                if(stack.Count==0||temp>stack.Peek())
                {
                    stack.Push(i);
                    i++;
                    sb.AppendLine("+");
                }
                else if(temp==stack.Peek())
                {
                    stack.Pop();
                    sb.AppendLine("-");
                    count++;
                    if(count<n)temp = arr[count];
                }
                else if(temp<stack.Peek())
                {
                    sw.WriteLine("NO");
                    break;
                }

                if (count == n) break;
            }
            if (count == n) sw.WriteLine(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}