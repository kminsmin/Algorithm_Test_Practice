using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string star = "*";
            string blank = " ";
            string temp = "";
            
            for(int i = 1; i <= count; i++)
            {
                temp = "";
                for(int j = 0; j < count - i; j++)
                {
                    temp += blank;
                }
                for(int k = 0; k < i; k ++)
                {
                    temp += star;
                }
                Console.WriteLine(temp);
            }
        }
    }
}