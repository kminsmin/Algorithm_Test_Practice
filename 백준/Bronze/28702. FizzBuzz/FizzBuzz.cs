using System;

namespace Baekjoon{
    class Program{ 
        static void Main(){
            int targetNum = 0;
            for(int i = 0; i < 3; i++)
            {
                string temp = Console.ReadLine();
                if(int.TryParse(temp, out int num))
                {
                    targetNum += num+3-i;
                    break;
                }
            }
            if(targetNum%3==0)
            {
                if(targetNum%5==0) Console.WriteLine("FizzBuzz");
                else Console.WriteLine("Fizz");
            }
            else if(targetNum%5==0) Console.WriteLine("Buzz");
            else Console.WriteLine(targetNum);
        }
    }
}