using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            int length = input.Length;
            int n = int.Parse(input);
            int maxSum = 9 * length;
            int startNum = n - maxSum;
            int answer = 0;
            for(int i = 0; i < maxSum; i++)
            {
                if(IsInit(n, startNum+i))
                {
                    answer = startNum + i;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
        static bool IsInit(int num, int init)
        {
            char[] digits = init.ToString().ToCharArray();
            int temp = init;
            foreach(char digit in digits)
            {
                if (int.TryParse(digit.ToString(), out int result))
                    temp += result;
            }
            return (temp==num)? true : false;
        }
    }
}