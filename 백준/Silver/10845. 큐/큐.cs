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
            Queue<int> queue = new Queue<int>();
            int lastEnqueue = 0;
            for (int i = 0; i < count; i++)
            {
                string command = sr.ReadLine();
                int temp = 0;
                switch (command)
                {
                    case "front":
                        temp = (queue.Count > 0) ? queue.Peek() : -1;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "back":
                        temp = (queue.Count > 0) ? lastEnqueue: -1;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "pop":
                        temp = (queue.Count > 0) ? queue.Dequeue() : -1;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "size":
                        temp = queue.Count;
                        sb.AppendLine(temp.ToString());
                        break;
                    case "empty":
                        temp = (queue.Count > 0) ? 0 : 1;
                        sb.AppendLine(temp.ToString());
                        break;
                    default:
                        string[] arr = command.Split(' ');
                        lastEnqueue = int.Parse(arr[1]);
                        queue.Enqueue(lastEnqueue);
                        break;
                }
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}