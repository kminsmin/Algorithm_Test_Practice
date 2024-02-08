using System;

namespace Baekjoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            string inputStr = Console.ReadLine();
            string[] inputNums = inputStr.Split(' ');
            a = Int32.Parse(inputNums[0]);
            b = Int32.Parse(inputNums[1]);
            Console.WriteLine(a+b); 
        }
         
    }
}