using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            int min = int.MaxValue;
            int max = int.MinValue;
            int temp = 0;
            
            foreach(string number in numbers)
            {
                temp = int.Parse(number);
                min = (temp<min)? temp : min;
                max = (temp>max)? temp : max;
            }
            string answer = min.ToString() + " " + max.ToString();
            Console.WriteLine(answer);
        }
    }
}