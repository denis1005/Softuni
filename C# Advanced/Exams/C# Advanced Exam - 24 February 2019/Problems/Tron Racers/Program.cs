using System;
using System.Collections.Generic;
using System.Linq;

namespace Tron_Racers
{

    class Program

    {
        static void Main(string[] args)
        {
            int SizeOfMtrix = int.Parse(Console.ReadLine());
            char[][] Matrix = new char[SizeOfMtrix][];
            List<int> FirstPlayerCordinate = new List<int>();
            List<int> SecondPlayerCordinate = new List<int>();
            char SymboForFirstPlayer = 'f';
            char SymboForSecondtPlayer = 's';
            string[] PosibleCommands = new string[] { "up", "down", "left", "right" };
            string up = PosibleCommands[0];
            string down = PosibleCommands[1];
            string left = PosibleCommands[2];
            string right = PosibleCommands[3];





            for (int row = 0; row < Matrix.Length; row++)
            {
                char[] inputNumbers = Console.ReadLine().ToCharArray();
                Matrix[row] = new char[inputNumbers.Length];

                for (int col = 0; col < Matrix[row].Length; col++)
                {
                    Matrix[row][col] = inputNumbers[col];
                    if (Matrix[row][col] == SymboForFirstPlayer)
                    {
                        FirstPlayerCordinate.Add(row);
                        FirstPlayerCordinate.Add(col);
                    }
                    if (Matrix[row][col] == SymboForSecondtPlayer)
                    {
                        SecondPlayerCordinate.Add(row);
                        SecondPlayerCordinate.Add(col);
                    }

                }
            }
            while (true)
            {
                var Commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string FirstPlayerCommand = Commands[0];
                string SeconodPlayerCommand = Commands[1];
                //LogicForDown
                if (FirstPlayerCommand == down)
                {
                    var newCordinates = Down(Matrix, FirstPlayerCordinate[0], FirstPlayerCordinate[1], SymboForSecondtPlayer, SymboForFirstPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        FirstPlayerCordinate[0] = newCordinates[0];
                        FirstPlayerCordinate[1] = newCordinates[1];

                    }
                }
                if (FirstPlayerCommand == up)
                {
                    var newCordinates = Up(Matrix, FirstPlayerCordinate[0], FirstPlayerCordinate[1], SymboForSecondtPlayer, SymboForFirstPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        FirstPlayerCordinate[0] = newCordinates[0];
                        FirstPlayerCordinate[1] = newCordinates[1];

                    }

                }
                if (FirstPlayerCommand == left)
                {
                    var newCordinates = Left(Matrix, FirstPlayerCordinate[0], FirstPlayerCordinate[1], SymboForSecondtPlayer, SymboForFirstPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        FirstPlayerCordinate[0] = newCordinates[0];
                        FirstPlayerCordinate[1] = newCordinates[1];

                    }

                }
                if (FirstPlayerCommand == right)
                {
                    var newCordinates = Right(Matrix, FirstPlayerCordinate[0], FirstPlayerCordinate[1], SymboForSecondtPlayer, SymboForFirstPlayer);
                    if (newCordinates.Count ==1)
                    {
                        break;
                    }
                    else
                    {
                        FirstPlayerCordinate[0] = newCordinates[0];
                        FirstPlayerCordinate[1] = newCordinates[1];

                    }

                }

                if (SeconodPlayerCommand == right)
                {
                    var newCordinates = Right(Matrix, SecondPlayerCordinate[0], SecondPlayerCordinate[1], SymboForFirstPlayer, SymboForSecondtPlayer);
                    if (newCordinates.Count ==1)
                    {
                        break;
                    }
                    else
                    {
                        SecondPlayerCordinate[0] = newCordinates[0];
                        SecondPlayerCordinate[1] = newCordinates[1];

                    }

                }
                if (SeconodPlayerCommand == left)
                {
                    var newCordinates = Left(Matrix, SecondPlayerCordinate[0], SecondPlayerCordinate[1], SymboForFirstPlayer, SymboForSecondtPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        SecondPlayerCordinate[0] = newCordinates[0];
                        SecondPlayerCordinate[1] = newCordinates[1];

                    }

                }
                if (SeconodPlayerCommand == up)
                {
                    var newCordinates = Up(Matrix, SecondPlayerCordinate[0], SecondPlayerCordinate[1], SymboForFirstPlayer, SymboForSecondtPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        SecondPlayerCordinate[0] = newCordinates[0];
                        SecondPlayerCordinate[1] = newCordinates[1];

                    }
                }
                if (SeconodPlayerCommand == down)
                {
                    var newCordinates = Down(Matrix, SecondPlayerCordinate[0], SecondPlayerCordinate[1], SymboForFirstPlayer, SymboForSecondtPlayer);
                    if (newCordinates.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        SecondPlayerCordinate[0] = newCordinates[0];
                        SecondPlayerCordinate[1] = newCordinates[1];

                    }
                }


               

            }
            Print2DArray(Matrix);




        }
        public static void Print2DArray<T>(T[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                    Console.Write(matrix[row][col]);
                Console.WriteLine();

            }

        }
        public static List<int> Down(char[][] Matrix, int PlayerRow, int PlayerCow, char SymbolOfOposite, char PlayerSymbol)
        {

            List<int> NewCordinates = new List<int>();
            int NewDownCordinate = PlayerRow + 1;

            if (NewDownCordinate > Matrix.Length-1)
            {
                NewDownCordinate = 0;
                if (Matrix[NewDownCordinate][PlayerCow] == SymbolOfOposite)
                {
                    Matrix[NewDownCordinate][PlayerCow] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                else
                {
                    NewDownCordinate = 0;
                    NewCordinates.Add(NewDownCordinate);
                    NewCordinates.Add(PlayerCow);
                    Matrix[NewDownCordinate][PlayerCow] = PlayerSymbol;
                    return NewCordinates;

                }
            }
            else
            {
                if (Matrix[NewDownCordinate][PlayerCow] == SymbolOfOposite)
                {
                    Matrix[NewDownCordinate][PlayerCow] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                NewCordinates.Add(NewDownCordinate);
                NewCordinates.Add(PlayerCow);
                Matrix[NewDownCordinate][PlayerCow] = PlayerSymbol;
                return NewCordinates;
            }

        }
        public static List<int> Up(char[][] Matrix, int PlayerRow, int PlayerCow, char SymbolOfOposite, char PlayerSymbol)
        {
            List<int> NewCordinates = new List<int>();
            int NewDownCordinate = PlayerRow - 1;

            if (NewDownCordinate <0)
            {
                NewDownCordinate = Matrix.Length - 1;
                if (Matrix[NewDownCordinate][PlayerCow] == SymbolOfOposite)
                {
                    Matrix[NewDownCordinate][PlayerCow] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                else
                {
                    NewDownCordinate = Matrix.Length- 1;
                    NewCordinates.Add(NewDownCordinate);
                    NewCordinates.Add(PlayerCow);
                    Matrix[NewDownCordinate][PlayerCow] = PlayerSymbol;
                    return NewCordinates;

                }
            }
            else
            {
                if (Matrix[NewDownCordinate][PlayerCow] == SymbolOfOposite)
                {
                    Matrix[NewDownCordinate][PlayerCow] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                NewCordinates.Add(NewDownCordinate);
                NewCordinates.Add(PlayerCow);
                Matrix[NewDownCordinate][PlayerCow] = PlayerSymbol;
                return NewCordinates;
            }
        }
        public static List<int> Left(char[][] Matrix, int PlayerRow, int PlayerCow, char SymbolOfOposite, char PlayerSymbol)
        {
            List<int> NewCordinates = new List<int>();
            int NewDownCordinate = PlayerCow - 1;

            if (NewDownCordinate < 0)
            {
                NewDownCordinate = Matrix[PlayerCow].Length - 1;
                if (Matrix[PlayerRow][NewDownCordinate] == SymbolOfOposite)
                {
                    Matrix[PlayerRow][NewDownCordinate] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                else
                {
                    NewDownCordinate = Matrix[PlayerCow].Length - 1;
                    NewCordinates.Add(PlayerRow);
                    NewCordinates.Add(NewDownCordinate);
                    Matrix[PlayerRow][NewDownCordinate] = PlayerSymbol;
                    return NewCordinates;

                }
            }
            else
            {
                if (Matrix[PlayerRow][NewDownCordinate] == SymbolOfOposite)
                {
                    Matrix[PlayerRow][NewDownCordinate] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                NewCordinates.Add(PlayerRow);
                NewCordinates.Add(NewDownCordinate);
                Matrix[PlayerRow][NewDownCordinate] = PlayerSymbol;
                return NewCordinates;
            }
        }
        public static List<int> Right(char[][] Matrix, int PlayerRow, int PlayerCow, char SymbolOfOposite, char PlayerSymbol)
        {
            List<int> NewCordinates = new List<int>();
            int NewDownCordinate = PlayerCow + 1;

            if (NewDownCordinate > Matrix[PlayerCow].Length-1)
            {
                NewDownCordinate = 0;
                if (Matrix[PlayerRow][NewDownCordinate] == SymbolOfOposite)
                {
                    Matrix[PlayerRow][NewDownCordinate] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                else
                {
                    NewDownCordinate = 0;
                    NewCordinates.Add(PlayerRow);
                    NewCordinates.Add(NewDownCordinate);
                    Matrix[PlayerRow][NewDownCordinate] = PlayerSymbol;
                    return NewCordinates;

                }
            }
            else
            {
                if (Matrix[PlayerRow][NewDownCordinate] == SymbolOfOposite)
                {
                    Matrix[PlayerRow][NewDownCordinate] = 'x';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
                NewCordinates.Add(PlayerRow);
                NewCordinates.Add(NewDownCordinate);
                Matrix[PlayerRow][NewDownCordinate] = PlayerSymbol;
                return NewCordinates;
            }
        }




    }
}
