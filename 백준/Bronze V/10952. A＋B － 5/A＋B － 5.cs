using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int a = 0;
            int b = 0;
            string input = "";
            string[] numbers = new string[2];
            
            while(true)
            {
                input = Console.ReadLine();
                numbers = input.Split(" ");
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                if(a==0&b==0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(a+b);
                }
            }
        }
    }
}