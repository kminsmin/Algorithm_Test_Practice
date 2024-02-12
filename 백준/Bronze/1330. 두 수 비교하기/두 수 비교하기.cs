using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            int a = int.Parse(digits[0]);
            int b = int.Parse(digits[1]);
            
            if(a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}