using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            int count = int.Parse(digits[0]);
            int target = int.Parse(digits[1]);
            input = Console.ReadLine();
            digits = input.Split(" ");
            int sum = 0;
            int max = 0;
            
            for(int i = 0; i < count-2; i++)
            {
                for(int j = i+1; j < count-1; j++)
                {
                    for(int k = j+1; k < count; k++)
                    {
                        sum = int.Parse(digits[i]) + int.Parse(digits[j]) +int.Parse(digits[k]);
                        if(sum > max && sum <= target) max = sum;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}