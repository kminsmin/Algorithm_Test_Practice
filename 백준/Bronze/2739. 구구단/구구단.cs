using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(num.ToString() + " * " +i.ToString() + " = " + (num*i).ToString());
            }
            
        }
    }
}