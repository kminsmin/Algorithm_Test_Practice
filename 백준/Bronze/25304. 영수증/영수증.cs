using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int receitTotal = int.Parse(Console.ReadLine());
            int thingNum = int.Parse(Console.ReadLine());
            string input = "";
            int price = 0;
            int count = 0;
            int calcTotal = 0;
            
            for(int i = 0; i < thingNum; i++)
            {
                input = Console.ReadLine();
                string[] column = input.Split(' ');
                price = int.Parse(column[0]);
                count = int.Parse(column[1]);
                calcTotal += price * count;
            }
            
            if(calcTotal == receitTotal)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}