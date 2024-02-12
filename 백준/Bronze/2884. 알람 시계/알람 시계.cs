using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] time = input.Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            if(minute >= 45)
            {
                minute -= 45;
            }
            else
            {
                int diff = 45 - minute;
                hour = (hour >= 1)? hour - 1 : 23;
                minute = 60 - diff;
            }
            string answer = hour.ToString() + " " + minute.ToString();
            Console.WriteLine(answer);
        }
    }
}