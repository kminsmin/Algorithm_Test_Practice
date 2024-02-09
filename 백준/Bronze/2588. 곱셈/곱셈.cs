using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string str = Console.ReadLine();
            int num = int.Parse(str);
            str = Console.ReadLine();
            char[] input = str.ToCharArray();
            int one = int.Parse(input[2].ToString()) * num;
            int ten = int.Parse(input[1].ToString()) * num;
            int hundred = int.Parse(input[0].ToString()) * num;
            int total = one + 10 * ten + hundred * 100;
            Console.WriteLine(one);
            Console.WriteLine(ten);
            Console.WriteLine(hundred);
            Console.WriteLine(total);
        }
    }
}