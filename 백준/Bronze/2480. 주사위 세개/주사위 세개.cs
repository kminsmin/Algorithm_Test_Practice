using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] result = input.Split(' ');
            
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            int c = int.Parse(result[2]);
            int num = 0;
            int prizeTier = CheckSameNumber(a, b, c, ref num);
            int prize = 0;
            
            switch(prizeTier)
            {
                case 1:
                    prize = CheckMaxNumber(result) * 100;
                    break;
                case 2:
                    prize = 1000 + num * 100;
                    break;
                case 3:
                    prize = 10000 + num * 1000;
                    break;
            }
            
            Console.WriteLine(prize); 
        }
        
        static private int CheckSameNumber(int a, int b, int c, ref int num)
        {
            int sameNumber = 1;
            if(a == b)
            {
                sameNumber++;
                num = a;
            }
            if(a == c)
            {
                sameNumber++;
                num = a;
            }
            if(b == c)
            {
                sameNumber++;
                num = c;
            }
            
            if(sameNumber==4) sameNumber --;
            
            return sameNumber;
        }
        
        static private int CheckMaxNumber(string[] numbers)
        {
            int maxNumber = 0;
            int temp = 0;
            foreach(string number in numbers)
            {
                temp = int.Parse(number);
                if(temp > maxNumber) maxNumber = temp;
            }
            
            return maxNumber;
        }
    }
}