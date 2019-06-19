using System;
using System.Linq;

namespace _4._Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demention = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse).ToArray();
            int[,] matrix = new int[demention[0], demention[1]];
            
            //Read The matrix from the concole
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];
            }

            string ReadFirstCommand =Console.ReadLine();

            while (ReadFirstCommand!="END")
            {
                string[] commands = ReadFirstCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int FirstCordinateRow = int.Parse(commands[1]);
                int FirstCordinateColon = int.Parse(commands[2]);
                int SecondCordinateRow = int.Parse(commands[3]);
                int SecondCordinateColon = int.Parse(commands[4]);
                //Validation
               if (SecondCordinateColon > matrix.GetLength(1) || FirstCordinateColon > matrix.GetLength(1))
                {
                    Console.Write("Invalid input!");
                    continue;

                }
                else if (FirstCordinateRow > matrix.GetLength(1) || SecondCordinateRow > matrix.GetLength(1))
                {
                    Console.Write("Invalid input!");
                    continue;
                }
                else if (commands[0] != "swap" || commands.Length > 5 || commands.Length < 5)
                {
                    Console.Write("Invalid input!");
                    continue;
                }

                //Izpulnqvane na komandite
                else
                {
                    int bufer = 0;
                    bufer = matrix[FirstCordinateRow, FirstCordinateColon];
                    matrix[FirstCordinateRow, FirstCordinateColon] = matrix[SecondCordinateRow, SecondCordinateColon];
                    matrix[SecondCordinateRow, SecondCordinateColon] = bufer;

                    //peintirane na matricata
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col]+" ");
                        }
                        Console.WriteLine();
                    }
                }
                ReadFirstCommand = Console.ReadLine();
            }

        }
    }
}
