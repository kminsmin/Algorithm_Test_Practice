using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] inputNums = input.Split(' ');
            int a = int.Parse(inputNums[0]);
            int b = int.Parse(inputNums[1]);
            int[] answers = new int[5];
            answers[0] = a + b;
            answers[1] = a - b;
            answers[2] = a * b;
            answers[3] = a / b;
            answers[4] = a % b;
            foreach(int num in answers)
            {
                Console.WriteLine(num);
            }
        }
    }
}