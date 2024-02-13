using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int byteCount = int.Parse(Console.ReadLine());
            string answer = "";
            
            for(int i = 0; i < byteCount/4; i++)
            {
                answer += "long ";
            }
            answer += "int";
            Console.WriteLine(answer);
        }
    }
}