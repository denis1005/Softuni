using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int N =int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int PrimarySum = 0;
            int SecondarySum = 0;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];
            }

            //Primay
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(col==row)
                    {
                        PrimarySum = PrimarySum + matrix[row, col];
                    }
                    if (col + row ==N-1)
                    {
                        SecondarySum = SecondarySum + matrix[row, col];
                    }
                }
                    
            }
            Console.WriteLine(Math.Abs(PrimarySum - SecondarySum));


        }
    }
}
