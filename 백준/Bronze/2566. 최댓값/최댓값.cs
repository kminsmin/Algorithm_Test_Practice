using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            int[ , ] matrix = new int[9,9];
            int max = int.MinValue;
            int row = 0;
            int column = 0;
            matrix = SetMatrix(matrix, 9, 9);
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(matrix[i,j] > max)
                    {
                        max = matrix[i,j];
                        row = i+1;
                        column = j+1;
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(row.ToString() + " " + column.ToString());
        }
        static int[ , ] SetMatrix(int[ , ] matrix, int row, int column)
        {
            for(int i = 0; i < row; i++)
            {
                string[] currentRow = Console.ReadLine().Split(" ");
                for(int j = 0; j < column; j++)
                {
                    matrix[i,j] = int.Parse(currentRow[j]);
                }
            }
            return matrix;
        }
    }
}