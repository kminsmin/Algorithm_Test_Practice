using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static void Main(){
            Queue<int> deck = new Queue<int>();
            int count = int.Parse(Console.ReadLine());
            bool willDiscard = true;
            for(int i = 1;i<=count;i++)
            {
                deck.Enqueue(i);
            }
            while(deck.Count>1)
            {
                if(willDiscard)
                {
                    willDiscard = false;
                    deck.Dequeue();
                }
                else
                {
                    int temp = deck.Dequeue();
                    deck.Enqueue(temp);
                    willDiscard = true;
                }
            }
            Console.WriteLine(deck.Dequeue());
        }
    }
}