using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int a = 0;
            int b = 0;
            int c = 0;
            int n = 0;
            string temp = "";
            
            temp = Console.ReadLine();
            string[] digits = temp.Split(" ");
            a = int.Parse(digits[0]);
            b = int.Parse(digits[1]);
            c = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            
            if(a*n + b>c*n)
            {
                Console.WriteLine(0);
            }
            else if(a*100 + b>c*100)
            {
                Console.WriteLine(0); 
            }
            else Console.WriteLine(1);
        }
    }
}