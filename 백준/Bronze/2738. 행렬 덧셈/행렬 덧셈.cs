using System;

namespace Baekjoon{
    class Program{
        static void Main(){
            string[] matrixSize = Console.ReadLine().Split(" ");
            int row = int.Parse(matrixSize[0]);
            int column = int.Parse(matrixSize[1]);
            int[ , ] a = new int[row,column];
            int[ , ] b = new int[row,column];
            a = SetMatrix(a, row, column);
            b = SetMatrix(b, row, column);
            AddMatrix(a,b,row,column);
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
        static void AddMatrix(int[ , ] a, int[ , ] b, int row, int column)
        {
            string temp;
            for(int i = 0; i < row; i++)
            {
                temp = "";
                for(int j = 0; j < column; j++)
                {
                    temp += (a[i,j] + b[i,j]).ToString() + " ";
                }
                temp = temp.TrimEnd(' ');
                Console.WriteLine(temp);
            }
        }
    }
}