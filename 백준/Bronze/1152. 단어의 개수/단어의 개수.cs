using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            bool isNewWord = true;
            int wordCount = 0;
            char blank = ' ';
            char[] sentence = Console.ReadLine().ToCharArray();
            foreach(char letter in sentence)
            {
                if(isNewWord&&letter!=blank)
                {
                    isNewWord = false;
                    wordCount++;
                }
                else if(letter == blank)
                {
                    isNewWord = true;
                }
            }
            Console.WriteLine(wordCount);
        }
    }
}