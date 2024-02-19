using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int max = int.MinValue;
            int index = 0;
            int currentNum = 0;
            
            for(int i = 1; i <= 9; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                if(currentNum>max)
                {
                    max = currentNum;
                    index = i;
                }
            }
            
            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}