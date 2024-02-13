using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int iteration = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            string input = "";
                        
            for(int i = 0; i < iteration; i++)
            {
                input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                Console.WriteLine(a+b);
            }
        }
    }
}