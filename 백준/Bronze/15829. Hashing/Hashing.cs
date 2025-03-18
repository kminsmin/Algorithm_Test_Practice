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
            int hash = 0;
            int r = 31;
            int m = 1234567891;
            for (int i = 0; i < count; i++)
            {
                hash += (char.ToUpper(letters[i]) - 64) * (int)Math.Pow(r,i);
            }
            if (hash > m) return hash / m;
            else return hash;
        }
    }
}