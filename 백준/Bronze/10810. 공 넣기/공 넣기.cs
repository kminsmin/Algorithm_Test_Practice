using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] initInput = input.Split(" ");
            int basketCount = int.Parse(initInput[0]);
            int fillCount =  int.Parse(initInput[1]);
            int[] baskets = new int[basketCount];
            string[] fillAction = new string[3];
            int startIndex = 0;
            int endIndex = 0;
            int ballNum = 0;
            
            for(int i = 0; i < fillCount; i++)
            {
                input = Console.ReadLine();
                fillAction = input.Split(" ");
                startIndex = int.Parse(fillAction[0]);
                endIndex = int.Parse(fillAction[1]);
                ballNum = int.Parse(fillAction[2]);
                for(int j = startIndex-1; j < endIndex; j++)
                {
                    baskets[j] = ballNum;
                }
            }
            
            string answer = "";
            foreach(int? num in baskets)
            {
                if(num == null)
                {
                    answer += "0 ";
                }
                else answer += num.ToString() + " ";
            }
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
        }
    }
}