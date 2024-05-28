using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            long n = 0;
            n = long.Parse(Console.ReadLine());
            long answer = 0;
            while(n>=1)
            {
                n--;
                answer += n;
            }
            Console.WriteLine(answer);
            Console.WriteLine(2);
        }
    }
}