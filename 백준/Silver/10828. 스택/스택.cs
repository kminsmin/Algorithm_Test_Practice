using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int count = int.Parse(sr.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                string command = sr.ReadLine();
                int temp = 0;
                switch(command)
                {
                    case "top":
                        temp = (stack.Count > 0) ? stack.Peek() : -1;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "pop":
                        temp = (stack.Count > 0) ? stack.Pop() : -1;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "size":
                        temp = stack.Count;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "empty":
                        temp = (stack.Count > 0) ? 0 : 1;
                        sb.AppendLine(temp.ToString());
                        break;
                    default:
                        string[] arr = command.Split(' ');
                        stack.Push(int.Parse(arr[1]));
                        break;
                }
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}