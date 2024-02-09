using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] inputNums = input.Split(' ');
            int a = int.Parse(inputNums[0]);
            int b = int.Parse(inputNums[1]);
            int c = int.Parse(inputNums[2]);
            Console.WriteLine((a+b)%c);
            Console.WriteLine(((a%c) + (b%c))%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine(((a%c) * (b%c))%c);
        }
    }
}