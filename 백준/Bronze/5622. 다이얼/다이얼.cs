using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            char[] word = Console.ReadLine().ToCharArray();
            int time = 0;
            foreach(char letter in word)
            {
                time += GetSeconds(letter);
            }
            Console.WriteLine(time);
        }
        static int GetSeconds(char letter)
        {
            switch(letter)
            {
                case 'A':
                    return 3;
                case 'B':
                    return 3;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 4;
                case 'F':
                    return 4;
                case 'G':
                    return 5;
                case 'H':
                    return 5;
                case 'I':
                    return 5;
                case 'J':
                    return 6;
                case 'K':
                    return 6;
                case 'L':
                    return 6;
                case 'M':
                    return 7;
                case 'N':
                    return 7;
                case 'O':
                    return 7;
                case 'P':
                    return 8;
                case 'Q':
                    return 8;
                case 'R':
                    return 8;
                case 'S':
                    return 8;
                case 'T':
                    return 9;
                case 'U':
                    return 9;
                case 'V':
                    return 9;
                case 'W':
                    return 10;
                case 'X':
                    return 10;
                case 'Y':
                    return 10;
                case 'Z':
                    return 10;
                default:
                    break;
            }
            return 0;
        }
    }
}