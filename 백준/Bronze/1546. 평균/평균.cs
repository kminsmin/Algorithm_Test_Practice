using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int subjectCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] scoreArr = input.Split(" ");
            float sum = 0f;
            int max = int.MinValue;
            int temp = 0;
            foreach(string score in scoreArr)
            {
                temp = int.Parse(score);
                if(temp>max) max = temp;
            }
            
            for(int i = 0; i < subjectCount; i++)
            {
                temp = int.Parse(scoreArr[i]);
                sum += ((float)temp/max)*100f;
            }
            float avg = sum / (float)subjectCount;
            Console.WriteLine(avg);
            
        }
    }
}