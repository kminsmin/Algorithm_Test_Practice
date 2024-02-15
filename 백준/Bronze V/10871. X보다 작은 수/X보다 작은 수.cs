using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            int length = int.Parse(arr[0]);
            int target = int.Parse(arr[1]);
            input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            string answer = "";
            int temp = 0;
            
            foreach(string number in numbers)
            {
                temp = int.Parse(number);
                if(temp<target)
                {
                    answer += number + " ";
                }
            }
            
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
            
        }
    }
}