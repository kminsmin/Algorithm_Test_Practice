using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string star = "*";
            string temp = "";
            
            for(int i = 1; i <= count; i++)
            {
                temp += star;
                Console.WriteLine(temp);
            }
        }
    }
}