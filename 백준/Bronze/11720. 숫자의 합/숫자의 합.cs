using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] numbers = input.ToCharArray();
            int sum = 0;
            foreach(char num in numbers)
            {
                sum += (int)char.GetNumericValue(num);
            }
            Console.WriteLine(sum);
        }
    }
}