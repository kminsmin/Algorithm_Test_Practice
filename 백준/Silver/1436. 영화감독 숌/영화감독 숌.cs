using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            int movieNum = 0;
            int temp = 666;
            while(movieNum < count)
            {
                if(IsDoom(temp))
                {
                    movieNum++;
                    temp++;
                }
                else temp++;
            }
            Console.WriteLine(temp-1);
            
        }
        static bool IsDoom(int num)
        {
            string temp = num.ToString();
            char[] digits = temp.ToCharArray();
            int doomCount = 0;
            foreach(char digit in digits)
            {
                if(digit=='6')
                {
                    doomCount++;
                    if(doomCount == 3) break;
                }
                else doomCount = 0;
            }
            return (doomCount==3)? true : false;
        }
    }
}