using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string[] foundPiece = Console.ReadLine().Split(" ");
            string fix = "";
            fix += (1-int.Parse(foundPiece[0])).ToString() + " ";
            fix += (1-int.Parse(foundPiece[1])).ToString() + " ";
            fix += (2-int.Parse(foundPiece[2])).ToString() + " ";
            fix += (2-int.Parse(foundPiece[3])).ToString() + " ";
            fix += (2-int.Parse(foundPiece[4])).ToString() + " ";
            fix += (8-int.Parse(foundPiece[5])).ToString();
            Console.WriteLine(fix);
        }
    }
}