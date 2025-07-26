using System;
using System.Linq;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool[] coms = new bool[n + 1];
            int[,] graph = new int[n + 1, n + 1];
            int infections = 0;
            for (int i = 0; i < m; i++)
            {
                int[] pair = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int temp = 0;
                while (graph[pair[0], temp] > 0) temp++;
                graph[pair[0], temp] = pair[1];
                temp = 0;
                while (graph[pair[1], temp] > 0) temp++;
                graph[pair[1], temp] = pair[0];
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            while (queue.Count>0)
            {
                int currentNode = queue.Dequeue();
                if (coms[currentNode]) continue;
                coms[currentNode] = true;
                int idx = 0;
                while (true)
                {
                    int nextNode = graph[currentNode, idx];
                    idx++;
                    if (nextNode > 0)
                    {
                        queue.Enqueue(nextNode);
                        
                    }
                    else break;
                }
            }
            foreach (bool infected in coms)
            {
                if (infected) infections++;
            }
            Console.WriteLine(infections-1);
        }
    }
}