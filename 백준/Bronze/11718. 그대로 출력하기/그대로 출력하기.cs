using System;
using System.Collections.Generic;

namespace Baekjoon{
    class Program{
        static void Main(){
            List<string> stringList = new List<string>();
            string temp;
            while(true)
            {
                temp = Console.ReadLine();
                if(temp == null) break;
                else stringList.Add(temp);
            }
            foreach(string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}