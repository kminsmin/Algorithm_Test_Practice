using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            string[] rooms = new string[t];
            for (int i = 0; i < t; i++)
            {
                int count = 1;
                string input = Console.ReadLine();
                string[] digits = input.Split(" ");
                int h = int.Parse(digits[0]);
                int w = int.Parse(digits[1]);
                int n = int.Parse(digits[2]);
                int floorCount = 1;
                int roomCount = 1;
                while (count < n)
                {
                    count++;
                    if (floorCount < h)
                    {
                        floorCount++;
                    }
                    else
                    {
                        floorCount = 1;
                        roomCount++;
                    }
                }
                string roomNum = floorCount.ToString() + ((roomCount < 10) ? "0" : "") + roomCount.ToString();
                rooms[i] = roomNum;
            }
            foreach (string room in rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}