using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            int n = int.Parse(digits[0]);
            int k = int.Parse(digits[1]);
            int nFac = GetFactorial(n);
            int kFac = GetFactorial(k);
            int difFac = GetFactorial(n-k);
            int answer = nFac/(kFac*difFac);
            Console.WriteLine(answer);
        }
        static int GetFactorial(int num)
        {
            int temp = 1;
            for(int i = 1; i <=num; i++)
            {
                temp *= i;
            }
            return temp;
        }
    }
}