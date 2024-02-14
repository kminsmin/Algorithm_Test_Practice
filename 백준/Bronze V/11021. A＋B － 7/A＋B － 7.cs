using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string input = "";
            string[] numbers = new string[2];
            int a = 0;
            int b = 0;
            
            for(int i = 1; i <= count; i++)
            {
                input = Console.ReadLine();
                numbers = input.Split(" ");
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                Console.WriteLine($"Case #{i}: {a+b}");
            }
        }
    }
}