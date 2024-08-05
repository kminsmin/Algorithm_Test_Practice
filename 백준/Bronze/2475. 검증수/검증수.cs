using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int sum = 0;
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            for(int i = 0; i < 5; i++)
            {
                int num = int.Parse(digits[i]);
                sum += num*num;
            }
            int rem = sum%10;
            Console.WriteLine(rem);
            
        }
    }
}