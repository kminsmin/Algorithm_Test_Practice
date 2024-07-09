using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            int[] sizeArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int min = int.MaxValue;
            int temp = 0;
            char preCol = '\0';
            char[][] board = new char[sizeArr[0]][];
            for(int i = 0; i < sizeArr[0]; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }
            min = CheckMin('W', sizeArr, board);
            temp = CheckMin('B', sizeArr, board);
            min = (temp < min) ? temp : min;

            Console.WriteLine(min);
        }

        static int CheckMin(char initialCol, int[] sizeArr, char[][] board)
        {
            int min = int.MaxValue;
            int temp = 0;
            char preCol = initialCol;
            for (int a = 0; a <= sizeArr[0] - 8; a++)
            {
                for (int i = 0; i <= sizeArr[1] - 8; i++)
                {
                    for (int j = a; j < a + 8; j++)
                    {
                        if (j != a)
                        {
                            if (board[j][i] != preCol) temp++;
                        }
                        else
                        {
                            preCol = initialCol;
                            if (board[j][i] != preCol) temp++;
                        }
                        for (int k = i + 1; k < i + 8; k++)
                        {
                            if (preCol == board[j][k])
                            {
                                preCol = (board[j][k] == 'B') ? 'W' : 'B';
                                temp++;
                            }
                            else
                            {
                                preCol = board[j][k];
                            }
                        }
                    }
                    min = (temp < min) ? temp : min;
                    temp = 0;
                }
            }
            return min;
        }
    }
}