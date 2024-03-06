using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[] word = Console.ReadLine().ToCharArray();
            bool isPal = true;
            for(int i = 0; i < word.Length/2; i++)
            {
                if(word[i]==word[word.Length-1-i]) continue;
                else
                {
                    isPal = false;
                    break;
                }
            }
            if(isPal) Console.WriteLine(1);
            else Console.WriteLine(0);
        }
    }
}