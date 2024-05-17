using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static Dictionary<string, bool> plane = new Dictionary<string, bool>();
        private static int area = 0;
        private static int bugCount = 0;
        static void Main(){
            //int[ , ] plane = new int[100,100];
            
            int paperCount = int.Parse(Console.ReadLine());
            int tempX = 0;
            int tempY = 0;
            InitPlane();
            for(int i = 0; i < paperCount; i++)
            {
                string temp = Console.ReadLine();
                string[] digits = temp.Split(" ");
                tempX = int.Parse(digits[0]);
                tempY = int.Parse(digits[1]);
                CoverPlane(tempX, tempY);
            }
            GetArea();
        }
        
        static void InitPlane()
        {
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    string tempKey = i.ToString() + "," +j.ToString();
                    if (!plane.ContainsKey(tempKey))
                    {
                        plane.Add(tempKey, false);
                    }
                    else bugCount++;
                }
            }
        }
        
        static void CoverPlane(int x, int y)
        {
            for(int i = x; i < x + 10; i++)
            {
                for(int j = y; j < y + 10; j++)
                {
                    string tempKey = i.ToString() + "," + j.ToString();
                    if(!plane.ContainsKey(tempKey))
                    {
                        plane.Add(tempKey, true);
                    }
                    else
                    {
                        plane[tempKey] = true;
                    }
                }
            }
        }

        static void GetArea()
        {
            foreach (string grid in plane.Keys)
            {
                if (plane[grid]) area++;
            }
            Console.WriteLine(area);
        }
    }
}