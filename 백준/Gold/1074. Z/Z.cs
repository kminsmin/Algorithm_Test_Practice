using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            int n = int.Parse(digits[0]);
            int r = int.Parse(digits[1]);
            int c = int.Parse(digits[2]);
            Console.WriteLine(FindNum(n, r, c));
        }
        static int FindNum(int n, int r, int c)
        {
            int blockSize = (int)Math.Pow(2,n) / 2;
            int squareNum = 2 * (r / blockSize) + (c / blockSize);
            int newRow = (r >= blockSize) ? r - blockSize : r;
            int newColumn = (c >= blockSize) ? c - blockSize : c;
            if (n == 1) return squareNum;
            int baseNum = FindNum(n - 1, newRow, newColumn);
            return (int)Math.Pow(blockSize,2) * squareNum + baseNum;
        }
    }
}