using System;
using System.IO;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static int[]? trees;
        static int targetMin;
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            targetMin = input[1];
            int max = 0;
            int count = input[0];
            trees = new int[count];
            string[] arr = sr.ReadLine().Split(' ');
            for (int i = 0; i < count;i++)
            { 
                int temp = int.Parse(arr[i]);
                if (max < temp) max = temp;
                trees[i] = temp;
            }
            int height = CutTree(0, max, max / 2);
            sw.WriteLine(height);
            sw.Close();
        }
        static int CutTree(int min, int max, int mid)
        {
            long temp = 0;
            foreach (int tree in trees)
            {
                int piece = tree - mid;
                temp += ((piece) > 0) ? piece : 0;
            }
            if (temp == targetMin) return mid;
            else if (min>=mid)
            {
                temp = 0;
                foreach (int tree in trees)
                {
                    int piece = tree - max;
                    temp += ((piece) > 0) ? piece : 0;
                }
                return (temp >= targetMin) ? max : min;
            }
            else if (temp > targetMin) return CutTree(mid, max, (mid + max) / 2);
            else return CutTree(min, mid, (min+mid)/2);
        }

    }
}