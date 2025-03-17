using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            foreach(string digit in digits)
            {
                if(!IsPrime(int.Parse(digit))) count -= 1;
            }
            Console.WriteLine(count);
        }
        
        static bool IsPrime(int num)
        {
            if(num == 1) return false;
            for(int i = 2; i < num; i++)
            {
                if(num%i==0) return false;
            }
            return true;
        }
    }
}