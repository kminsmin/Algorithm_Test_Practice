using System;
namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputNums = input.Split(' ');
            int a = Int32.Parse(inputNums[0]);
            int b = Int32.Parse(inputNums[1]);
            Console.WriteLine(a-b);
        }
    }
}