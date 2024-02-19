using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static void Main(){
            List<int> remainders = new List<int>();
            int input;
            int remainder;
            
            for(int i = 0; i < 10; i++)
            {
                input = int.Parse(Console.ReadLine());
                remainder = input % 42;
                if(!remainders.Contains(remainder)) remainders.Add(remainder);
            }
            Console.WriteLine(remainders.Count);
        }
    }
}