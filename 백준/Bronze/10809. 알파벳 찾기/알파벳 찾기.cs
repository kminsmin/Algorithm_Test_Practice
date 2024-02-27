using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[] alphaArr = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] letterArr = Console.ReadLine().ToCharArray();
            int[] posArr = new int[26];
            
            for(int i = 0; i < 26; i++)
            {
                for(int j = 0; j < letterArr.Length; j++)
                {
                    if(alphaArr[i] == letterArr[j])
                    {
                        posArr[i] = j;
                        break;
                    }
                    else if(j == letterArr.Length-1)
                    {
                        posArr[i] = -1;
                    }
                }
            }
            
            string answer = "";
            foreach(int pos in posArr)
            {
                answer += pos.ToString() + " ";
            }
            answer = answer.TrimEnd(' ');
            Console.WriteLine(answer);
        }
    }
}