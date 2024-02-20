using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            int index = int.Parse(Console.ReadLine()) - 1;
            char[] arr = input.ToCharArray();
            Console.WriteLine(arr[index]);
        }
    }
}