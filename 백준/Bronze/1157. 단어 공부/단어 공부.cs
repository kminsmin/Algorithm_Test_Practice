using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letterDic = new Dictionary<char, int>();
            char temp;
            int max = int.MinValue;
            string answer = "";
            bool isMultiple = false;
            
            foreach(char letter in word)
            {
                temp = char.IsUpper(letter)? letter : char.ToUpper(letter);
                if(!letterDic.ContainsKey(temp))
                {
                    letterDic.Add(temp, 1);
                }
                else
                {
                    letterDic[temp] += 1;
                }
            }
            foreach(char key in letterDic.Keys)
            {
                if(letterDic[key]>max)
                {
                    isMultiple = false;
                    max = letterDic[key];
                    answer = key.ToString();
                }
                else if(letterDic[key]==max)
                {
                    isMultiple = true;
                }
                else continue;
            }
            
            if(isMultiple) Console.WriteLine("?");
            else Console.WriteLine(answer);
        }
    }
}