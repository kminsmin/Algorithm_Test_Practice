using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            string input = "";
            string temp = "";
            string[] numbers = new string[2];
            List<string> answers = new List<string>();
            
            
            for(int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                numbers = input.Split();
                a = int.Parse(numbers[0]);
                b = int.Parse(numbers[1]);
                temp += (a + b).ToString() + '\n';
                
                if(temp.Length > 1000)
                {
                    temp = temp.TrimEnd('\n');
                    answers.Add(temp);
                    temp = "";
                }
            }
            temp = temp.TrimEnd('\n');
            answers.Add(temp);
            
            foreach(string answer in answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}