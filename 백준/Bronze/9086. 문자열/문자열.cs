using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int count = int.Parse(Console.ReadLine());
            string input;
            char[] word;
            
            for(int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                word = input.ToCharArray();
                Console.WriteLine(word[0].ToString() + word[word.Length-1].ToString());
            }
        }
    }
}