using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static int nodeCount;
        static int pathCount;
        static int startNode;
        static List<int>[] paths = new List<int>[1001];
        static bool[] isVisited = new bool[1001];
        static StringBuilder sb = new StringBuilder();
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            nodeCount = input[0];
            pathCount = input[1];
            startNode = input[2];
            for (int i = 1; i <= nodeCount; i++)
            {
                paths[i] = new List<int>();
            }
            for (int i = 0; i < pathCount; i++)
            {
                input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                paths[input[0]].Add(input[1]);
                paths[input[0]].Sort();
                paths[input[1]].Add(input[0]);
                paths[input[1]].Sort();
            }
            isVisited = new bool[nodeCount+1];
            DFS(startNode);
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine();
            isVisited = new bool[nodeCount+1];
            BFS();
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine();
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
        static void DFS(int currentNode)
        {
            if (!isVisited[currentNode])
            {
                sb.Append(currentNode.ToString() + " ");
                isVisited[currentNode] = true;
                foreach (int nextNode in paths[currentNode])
                {
                    DFS(nextNode);
                }
            }
        }
        static void BFS()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                if (!isVisited[currentNode])
                {
                    sb.Append(currentNode.ToString() + " ");
                    isVisited[currentNode] = true;
                    foreach (int nextNode in paths[currentNode])
                    {
                        queue.Enqueue(nextNode);
                    }
                }
            }
        }
        
    }
}