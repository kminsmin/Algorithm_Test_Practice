using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[ , ] letterArr = new char[5,15];
            int maxLength = int.MinValue;
            
            for(int i = 0; i < 5; i++)
            {
                char[] tempArr = Console.ReadLine().ToCharArray();
                maxLength = (tempArr.Length > maxLength)? tempArr.Length : maxLength;
                for(int j = 0; j < 15; j++)
                {
                    try
                    {
                        letterArr[i,j] = tempArr[j];
                    }
                    catch
                    {
                        letterArr[i,j] = '*';    
                    }
                }
            }
            
            string answer = "";
            
            for(int i = 0; i < maxLength; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(letterArr[j,i] != '*')
                    {
                        answer += letterArr[j,i].ToString();
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}