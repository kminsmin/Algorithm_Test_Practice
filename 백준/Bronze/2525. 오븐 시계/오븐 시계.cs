using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            int cookingTime = int.Parse(Console.ReadLine());
            
            string[] time = input.Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            
            int cookingHour = cookingTime / 60;
            int cookingMinute = cookingTime % 60;
            hour += cookingHour;
            minute += cookingMinute;
            
            if(minute >= 60)
            {
                minute -= 60;
                hour++;
            }
            
            if(hour >= 24)
            {
                hour -= 24;
            }
            
            string answer = hour.ToString() + " " + minute.ToString();
            Console.WriteLine(answer);     
        }
    }
}