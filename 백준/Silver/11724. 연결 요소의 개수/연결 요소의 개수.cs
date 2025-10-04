using System;
using System.IO;
using System.Linq;

namespace Baekjoon
{
    class Program
    {

        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size = input[0];
            int lineCount = input[1];
            int[,] graph = new int[size+1, size+1];
            for(int i = 0; i < lineCount; i++)
            {
                input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int j = 0;
                while (graph[input[0], j] != 0) j++;
                graph[input[0], j] = input[1];
                j = 0;
                while (graph[input[1], j] != 0) j++;
                graph[input[1], j] = input[0];
            }
            bool[] isVisitied = new bool[size+1];
            int count = 0;
            for(int i = 1;i <= size;i++)
            {
                if (!isVisitied[i])
                {
                    count++;
                    DFS(ref graph, ref isVisitied, i);
                }
            }

            sw.WriteLine(count.ToString());
            sw.Close();
        }
        static void DFS(ref int[,] graph, ref bool[]isVisited, int currentNode)
        {
            isVisited[currentNode] = true;
            for(int i = 0;i < graph.GetLength(1);i++)
            {
                if (graph[currentNode, i] == 0) return;
                if (!isVisited[graph[currentNode, i]]) 
                    DFS(ref graph, ref isVisited, graph[currentNode,i]);
            }
        }

    }
}