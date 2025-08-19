using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static List<int[]>? paper;
        static int totalCount = 0;
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int n = int.Parse(sr.ReadLine());
            paper = new List<int[]>(n);
            for (int i = 0; i < n; i++)
                paper.Add(sr.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int blueCount = DetectSquare(0, 0, n, n);
            sw.WriteLine(totalCount-blueCount);
            sw.WriteLine(blueCount);
            sw.Close();
        }
        static int DetectSquare(int minX, int minY, int maxX, int maxY)
        {
            
            int root = paper[minY][minX];
            int size = maxX - minX;
            if ((size == 1) && (root == 1))
            {
                totalCount++;
                return 1;
            }
            else if (size == 1)
            {
                totalCount++;
                return 0;
            }
            for (int i = minY; i < maxY; i++)
            {
                for (int j = minX; j < maxX; j++)
                {
                    if (paper[i][j]!=root)
                        return DetectSquare(minX, minY, (maxX+minX) / 2, (maxY+minY) / 2) 
                            + DetectSquare((maxX + minX) / 2, minY, maxX, (maxY + minY) / 2) 
                            + DetectSquare(minX, (maxY + minY) / 2, (maxX + minX) / 2, maxY) 
                            + DetectSquare((maxX + minX) / 2, (maxY + minY) / 2, maxX, maxY);
                }
            }
            totalCount++;
            return (root==1)? 1 : 0;
        }

    }
}