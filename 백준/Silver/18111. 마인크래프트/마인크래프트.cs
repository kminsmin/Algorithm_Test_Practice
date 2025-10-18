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
            int n = input[0];
            int m = input[1];
            int blocks = input[2];
            
            int[] landHeight = new int[n * m];
            int minHeight = 256;
            int maxHeight = 0;
            
            // 1차원 배열로 변경 및 최소/최대 높이 파악
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    landHeight[idx] = input[j];
                    minHeight = Math.Min(minHeight, input[j]);
                    maxHeight = Math.Max(maxHeight, input[j]);
                    idx++;
                }
            }
            
            int minTime = int.MaxValue;
            int resultHeight = 0;
            
            // 높은 높이부터 낮은 높이로 탐색 (같은 시간이면 높이가 높은 것 선택)
            for (int targetHeight = maxHeight; targetHeight >= minHeight; targetHeight--)
            {
                int time = 0;
                int requiredBlocks = 0;
                
                for (int i = 0; i < landHeight.Length; i++)
                {
                    int diff = landHeight[i] - targetHeight;
                    
                    if (diff > 0)
                    {
                        // 블록 제거 (2초)
                        time += diff * 2;
                        requiredBlocks -= diff;
                    }
                    else if (diff < 0)
                    {
                        // 블록 추가 (1초)
                        time += -diff;
                        requiredBlocks += -diff;
                    }
                }
                
                // 블록이 충분한지 확인
                if (requiredBlocks <= blocks)
                {
                    if (time < minTime)
                    {
                        minTime = time;
                        resultHeight = targetHeight;
                    }
                }
            }
            
            sw.WriteLine($"{minTime} {resultHeight}");
            sw.Close();
        }
    }
}