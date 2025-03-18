using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();
            Console.WriteLine(Hash(letters, count));
        }
        static int Hash(char[] letters, int count)
        {
            ulong hash = 0;
            ulong r = 1;
            ulong m = 1234567891;
            for (int i = 0; i < count; i++)
            { 
                hash += (ulong)(char.ToUpper(letters[i]) - 64) * r;
                hash %= m;
                r *= 31;
                r %= m;
            }
            return (int)hash;
        }
    }
}