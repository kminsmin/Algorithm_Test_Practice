using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            double scoreSum = 0.0;
            float totalScore = 0.0f;
            while(input != null)
            {
                string[] subjectInfo = input.Split(" ");
                if(subjectInfo[2] == "P")
                {
                    input = Console.ReadLine();
                    continue;
                }
                float temp = float.Parse(subjectInfo[1]);
                scoreSum += (double)(temp * GetScore(subjectInfo[2]));
                totalScore += temp;
                input = Console.ReadLine();
            }
            double answer = scoreSum / (double)totalScore;
            Console.WriteLine(answer);
        }
        static float GetScore(string grade)
        {
            switch(grade)
            {
                case "A+":
                    return 4.5f;
                case "A0":
                    return 4.0f;
                case "B+":
                    return 3.5f;
                case "B0" :
                    return 3.0f;
                case "C+":
                    return 2.5f;
                case "C0":
                    return 2.0f;
                case "D+":
                    return 1.5f;
                case "D0":
                    return 1.0f;
                default:
                    return 0.0f;
            }
            return 0.0f;
        }
    }
}