using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] inputNums = input.Split(' ');
            double a = (double)int.Parse(inputNums[0]);
            double b = (double)int.Parse(inputNums[1]);
            Console.WriteLine(a/b);
        }
    }
}