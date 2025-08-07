using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace Baekjoon
{
    struct Position
    {
        public int x; public int y; 
        public Position(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    class Program
    {
        static int sum = 0;
        // 4방향 이동을 위한 배열 (상, 하, 좌, 우)
        static int[] dx = {0, 0, -1, 1};
        static int[] dy = {-1, 1, 0, 0};
        
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int testCount = int.Parse(sr.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < testCount; i++)
            {
                sum = 0;
                int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int m = input[0];
                int n = input[1];
                bool[,] isCabbage = new bool[m, n];
                bool[,] isVisited = new bool[m, n];
                int count = input[2];
                for (int j = 0; j < count; j++)
                {
                    input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    isCabbage[input[0], input[1]] = true;
                }
                
                // 모든 위치를 확인하여 BFS 시작
                for (int x = 0; x < m; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        if (!isVisited[x, y] && isCabbage[x, y])
                        {
                            BFS(x, y, ref isCabbage, ref isVisited, m, n);
                            sum++;
                        }
                    }
                }
                sb.AppendLine(sum.ToString());
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
        
        static void BFS(int startX, int startY, ref bool[,] isCabbage, ref bool[,] isVisited, int m, int n)
        {
            Queue<Position> queue = new Queue<Position>();
            queue.Enqueue(new Position(startX, startY));
            isVisited[startX, startY] = true;
            
            while (queue.Count > 0)
            {
                Position current = queue.Dequeue();
                
                // 4방향 모두 확인
                for (int i = 0; i < 4; i++)
                {
                    int nextX = current.x + dx[i];
                    int nextY = current.y + dy[i];
                    
                    // 경계 검사
                    if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n)
                    {
                        // 방문하지 않았고 배추가 있는 경우
                        if (!isVisited[nextX, nextY] && isCabbage[nextX, nextY])
                        {
                            isVisited[nextX, nextY] = true;
                            queue.Enqueue(new Position(nextX, nextY));
                        }
                    }
                }
            }
        }
    }
}