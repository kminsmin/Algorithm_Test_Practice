using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int bonus;
            int score;
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                score = 0;
                bonus = 1;
                string test = Console.ReadLine();
                char[] answers = test.ToCharArray();
                foreach(char answer in answers)
                {
                    if(answer == 'O')
                    {
                        score += bonus;
                        bonus++; 
                    }
                    else
                    {   
                        bonus = 1;
                    }
                }
                Console.WriteLine(score);
            }
        }
    }
}