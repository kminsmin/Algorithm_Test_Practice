using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int temp = n;
            while(true)
            {
                if(temp%5==0)
                {
                    a += temp/5;
                    break;
                }
                else
                {
                    temp -= 3;
                    a++;
                    if(temp == 0)
                    {
                        break;
                    }
                    else if(temp < 3)
                    {
                        a = -1;
                        break;
                    }
                }
            }
            Console.WriteLine(a);
        }
    }
}