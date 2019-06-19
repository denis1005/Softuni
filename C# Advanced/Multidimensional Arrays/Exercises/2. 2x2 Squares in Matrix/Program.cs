﻿using System;
using System.Linq;

namespace _2._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] demention = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse).ToArray();
            string[,] matrix = new string[demention[0], demention[1]];
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];
            }
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if(matrix[row,col]== matrix[row, col+1] && matrix[row, col] == matrix[row+1, col + 1] && matrix[row, col] == matrix[row+1, col])
                    {
                        count += 1;
                    }
                }
                    
            }
            Console.WriteLine(count);
        }
    }
}
