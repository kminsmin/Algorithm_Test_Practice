using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string ab = a+b;
            int numericSum = int.Parse(a) + int.Parse(b) - int.Parse(c);
            int stringSum = int.Parse(ab) - int.Parse(c);
            Console.WriteLine(numericSum);
            Console.WriteLine(stringSum);
        }
    }
}