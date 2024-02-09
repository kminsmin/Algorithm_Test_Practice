using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string[] input = Console.ReadLine().Split(' ');
            long a = 0;
            foreach(string digit in input){
                a += long.Parse(digit);
            }
            Console.WriteLine(a);
        }
    }
}