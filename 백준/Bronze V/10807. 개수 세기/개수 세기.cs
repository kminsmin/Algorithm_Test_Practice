using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] integers = input.Split(" ");
            int target = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = 0;
            
            for(int i = 0; i < length; i++)
            {
                temp = int.Parse(integers[i]);
                if(temp == target) count++;
            }
            Console.WriteLine(count);
            
        }
    }
}