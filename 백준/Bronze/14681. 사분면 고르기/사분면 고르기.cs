using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool positive = x * y > 0;
            
            if(positive)
            {
                if(x>0) Console.WriteLine(1);
                else Console.WriteLine(3);
            }
            else
            {
                if(x>0) Console.WriteLine(4);
                else Console.WriteLine(2);
            }
        }
    }
}