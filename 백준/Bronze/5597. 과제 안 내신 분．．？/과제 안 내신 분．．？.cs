using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int[] checkAssignment = new int[30];
            string input;
            int studentNum;
            string answer = "";
            for(int i = 0; i < 30; i++)
            {
                checkAssignment[i] = 0;
            }
            for(int j = 0; j < 28; j++)
            {
                input = Console.ReadLine();
                studentNum = int.Parse(input)-1;
                checkAssignment[studentNum] = 1;
            }
            for(int k = 1; k <= 30; k++)
            {
                if(checkAssignment[k-1] == 0) answer += k.ToString() + " ";
            }
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
        }
    }
}