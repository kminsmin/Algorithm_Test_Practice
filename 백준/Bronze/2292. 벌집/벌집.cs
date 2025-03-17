using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FindLayer(num));
        }
        static int FindLayer(int roomNum)
        {
            if(roomNum == 1) return 1;
            //2~7, 8~ 19,20 ~ 37 6, 12, 18
            int roomCount = 6;
            int layer = 2;
            int temp = roomNum-1;
            while(true)
            {
                if(temp-roomCount<=0)
                {
                    break;
                }
                else
                {
                    roomCount += 6*layer;
                    layer++;
                }
            }
            return layer;
        }
    }
}