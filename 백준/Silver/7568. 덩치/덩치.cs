using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int rank = count;
            List<int> heights = new List<int>();
            List<int> weights = new List<int>();
            string input;
            string[] digits;
            string answer = "";

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                digits = input.Split(' ');
                heights.Add(int.Parse(digits[0]));
                weights.Add(int.Parse(digits[1]));
            }
            for (int i = 0; i < count; i++)
            {
                int k = 1;

                for (int j = 0; j < count;j++)
                {
                    if (i == j) continue;
                    else if (heights[i] < heights[j])
                    {
                        if (weights[i] < weights[j]) k++;
                    }
                }
                answer += k.ToString()+ " ";
            }
            answer = answer.TrimEnd();
            Console.WriteLine(answer);
        }
    }
}