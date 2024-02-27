using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            int repeatCount;
            string word;
            string input;
            char[] letterArr;
            string[] testCase;
            string answer = "";
            
            for(int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                testCase = input.Split(" ");
                repeatCount = int.Parse(testCase[0]);
                word = testCase[1];
                letterArr = word.ToCharArray();
                foreach(char letter in letterArr)
                {
                    string temp = letter.ToString();
                    for(int j = 0; j < repeatCount; j++)
                    {
                        answer += temp;
                    }
                }
                Console.WriteLine(answer);
                answer = "";
            }
        }
    }
}