using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int check = 0;
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            int prev = int.Parse(digits[0]);
            for(int i = 1; i < 8; i++)
            {
                int temp = int.Parse(digits[i]);
                if (temp > prev) check++;
                else check--;
                prev = temp;
            }
            if(check == 7) Console.WriteLine("ascending");
            else if(check == -7) Console.WriteLine("descending");
            else Console.WriteLine("mixed");
            
        }
    }
}