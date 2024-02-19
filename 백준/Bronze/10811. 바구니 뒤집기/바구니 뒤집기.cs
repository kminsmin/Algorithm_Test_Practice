using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int basketCount = 0;
            int reverseCount = 0;
            GetDigits(ref basketCount, ref reverseCount);
            int[] basketArr = new int[basketCount];
            int startIndex = 0;
            int endIndex = 0;
            int switchCount = 0;
            int temp = 0;
            string answer = "";
            for(int i = 1; i <= basketCount; i++)
            {
                basketArr[i-1] = i;
            }
            
            for(int j = 0; j < reverseCount; j++)
            {
                GetDigits(ref startIndex, ref endIndex);
                switchCount = (endIndex - startIndex + 1)/2;
                for(int k = 0; k < switchCount; k++)
                {
                    temp = basketArr[startIndex-1];
                    basketArr[startIndex-1] = basketArr[endIndex-1];
                    basketArr[endIndex-1] = temp;
                    startIndex++;
                    endIndex--;
                }
            }
            
            foreach(int num in basketArr)
            {
                answer += num.ToString() + " ";
            }
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
        }
        
        static void GetDigits(ref int a, ref int b)
        {
            string input = Console.ReadLine();
            string[] digits = input.Split(" ");
            a = int.Parse(digits[0]);
            b = int.Parse(digits[1]);
        }
    }
}