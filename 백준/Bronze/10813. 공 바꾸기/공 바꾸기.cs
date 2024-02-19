using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            int basketCount = int.Parse(digits[0]);
            int switchCount = int.Parse(digits[1]);
            int[] baskets = new int[basketCount];
            int a = 0;
            int b = 0;
            
            for(int i = 0; i < basketCount; i++)
            {
                baskets[i] = i+1;
            }
            
            for(int j = 0; j < switchCount; j++)
            {
                input = Console.ReadLine();
                digits = input.Split(" ");
                a = int.Parse(digits[0])-1;
                b = int.Parse(digits[1])-1;
                SwitchBalls(ref baskets[a], ref baskets[b]);
            }
            
            string answer = "";
            foreach(int num in baskets)
            {
                answer += num.ToString() + " ";
            }
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
        }
        static void SwitchBalls(ref int firstBasket, ref int secondBasket){
            int temp = firstBasket;
            firstBasket = secondBasket;
            secondBasket = temp;
        }
    }
}