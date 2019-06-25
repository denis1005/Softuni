using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = int.Parse(Console.ReadLine());
            char[][] Matrix = new char[Size][];
            string[] PosibleCommands = new string[] { "up", "down", "left", "right" };
            string up = PosibleCommands[0];
            string down = PosibleCommands[1];
            string left = PosibleCommands[2];
            string right = PosibleCommands[3];
            char SymbolOfPlayer = 'S';
            char SymbolOfBlackHol = 'O';
            List<int> PlayerCordinata = new List<int>();
            List<int> BlackHolCordinata = new List<int>();

            int StarPower = 0;


            for (int row = 0; row < Matrix.Length; row++)
            {
                char[] inputNumbers = Console.ReadLine().ToCharArray();
                Matrix[row] = new char[inputNumbers.Length];

                for (int col = 0; col < Matrix[row].Length; col++)
                {
                    Matrix[row][col] = inputNumbers[col];
                    if (Matrix[row][col] == SymbolOfPlayer)
                    {
                        PlayerCordinata.Add(row);
                        PlayerCordinata.Add(col);
                    }
                    if (Matrix[row][col] == SymbolOfBlackHol)
                    {
                        BlackHolCordinata.Add(row);
                        BlackHolCordinata.Add(col);
                    }

                }
            }

            while (true)
            {
                Console.WriteLine();
                Print2DArray(Matrix);
                if (StarPower >= 50)
                {
                    Console.WriteLine("Good news!Stephen succeeded in collecting enough star power!");
                    Console.WriteLine($"Star power collected: {StarPower}");
                    break;
                }
                string command = Console.ReadLine();
                if (command == right)
                {
                    var newCordinates = Right(Matrix, PlayerCordinata[0], PlayerCordinata[1], StarPower, BlackHolCordinata,right);
                    if (newCordinates.Count == 1)
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {StarPower}");
                        break;
                    }
                    else
                    {

                        PlayerCordinata[0] = newCordinates[0];
                        PlayerCordinata[1] = newCordinates[1];
                        if (newCordinates.Count == 3)
                        {
                            StarPower = newCordinates[2];
                        }

                        if (StarPower >= 50)
                        {
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {StarPower}");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (command == left)
                {
                    var newCordinates = Right(Matrix, PlayerCordinata[0], PlayerCordinata[1], StarPower, BlackHolCordinata,left);
                    if (newCordinates.Count == 1)
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {StarPower}");
                        break;
                    }
                    else
                    {

                        PlayerCordinata[0] = newCordinates[0];
                        PlayerCordinata[1] = newCordinates[1];
                        if (newCordinates.Count == 3)
                        {
                            StarPower = newCordinates[2];
                        }

                        if (StarPower >= 50)
                        {
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {StarPower}");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (command == down)
                {
                    var newCordinates = Down(Matrix, PlayerCordinata[0], PlayerCordinata[1], StarPower, BlackHolCordinata);
                    if (newCordinates.Count == 1)
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {StarPower}");
                        break;
                    }
                    else
                    {

                        PlayerCordinata[0] = newCordinates[0];
                        PlayerCordinata[1] = newCordinates[1];
                        if (newCordinates.Count == 3)
                        {
                            StarPower = newCordinates[2];
                        }

                        if (StarPower >= 50)
                        {
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {StarPower}");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (command == up)
                {
                    var newCordinates = Up(Matrix, PlayerCordinata[0], PlayerCordinata[1], StarPower, BlackHolCordinata);
                    if (newCordinates.Count == 1)
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {StarPower}");
                        break;
                    }
                    else
                    {

                        PlayerCordinata[0] = newCordinates[0];
                        PlayerCordinata[1] = newCordinates[1];
                        if (newCordinates.Count == 3)
                        {
                            StarPower = newCordinates[2];
                        }

                        if (StarPower >= 50)
                        {
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {StarPower}");
                            break;
                        }
                        else
                        {
                            continue;
                        }
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


        public static List<int> Right(char[][] matrix, int PlayerRow, int PlayerCol, int SumOfStarPower, List<int> BlackHolCordinata,string command)
        {
            int newcordinate = 0;
            List<int> NewCordinates = new List<int>();
            if (command== "right")
            {
                newcordinate = PlayerCol + 1;
                if (newcordinate > matrix[PlayerCol].Length - 1)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
            }
            if (command == "left")
            {
                newcordinate = PlayerCol - 1;
                if (newcordinate < 0)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    NewCordinates.Add(0);
                    return NewCordinates;
                }
            }
           
            if (matrix[PlayerRow][newcordinate] != '-' && matrix[PlayerRow][newcordinate] != 'O')
            {
                int starpower = matrix[PlayerRow][newcordinate] - '0';
                SumOfStarPower = SumOfStarPower + starpower;
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[PlayerRow][newcordinate] = 'S';
                NewCordinates.Add(PlayerRow);
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(SumOfStarPower);
                return NewCordinates;

            }
            if (matrix[PlayerRow][newcordinate] == 'O')
            {
                int FristBlackHolRed = BlackHolCordinata[0];
                int FristBlackHolColona = BlackHolCordinata[1];
                int SecondBlackHolRed = BlackHolCordinata[2];
                int SecondBlackHolColona = BlackHolCordinata[3];
                if (FristBlackHolRed == PlayerRow && FristBlackHolColona == newcordinate)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(SecondBlackHolRed);
                    NewCordinates.Add(SecondBlackHolColona);
                    return NewCordinates;

                }
                if (SecondBlackHolRed == PlayerRow && SecondBlackHolColona == newcordinate)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(FristBlackHolRed);
                    NewCordinates.Add(FristBlackHolColona);
                    return NewCordinates;
                }
            }
            if (matrix[PlayerRow][newcordinate] == '-')
            {
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[PlayerRow][newcordinate] = 'S';
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(PlayerCol);
                return NewCordinates;
            }
            return NewCordinates;
        }

  

        public static List<int> Up(char[][] matrix, int PlayerRow, int PlayerCol, int SumOfStarPower, List<int> BlackHolCordinata)
        {
            int newcordinate = PlayerRow - 1;
            List<int> NewCordinates = new List<int>();
            if (newcordinate < 0)
            {
                matrix[PlayerRow][PlayerCol] = '-';
                NewCordinates.Add(0);
                return NewCordinates;
            }
            if (matrix[newcordinate][PlayerCol] != '-' && matrix[newcordinate][PlayerCol] != 'O')
            {
                int starpower = matrix[newcordinate][PlayerCol] - '0';
                SumOfStarPower = SumOfStarPower + starpower;
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[newcordinate][PlayerCol] = 'S';
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(PlayerCol);
                NewCordinates.Add(SumOfStarPower);
                return NewCordinates;

            }
            if (matrix[newcordinate][PlayerCol] == 'O')
            {
                int FristBlackHolRed = BlackHolCordinata[0];
                int FristBlackHolColona = BlackHolCordinata[1];
                int SecondBlackHolRed = BlackHolCordinata[2];
                int SecondBlackHolColona = BlackHolCordinata[3];
                if (FristBlackHolRed == newcordinate && FristBlackHolColona == PlayerCol)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(SecondBlackHolRed);
                    NewCordinates.Add(SecondBlackHolColona);
                    return NewCordinates;

                }
                if (SecondBlackHolRed == newcordinate && SecondBlackHolColona == PlayerCol)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(FristBlackHolRed);
                    NewCordinates.Add(FristBlackHolColona);
                    return NewCordinates;
                }

            }
            if (matrix[newcordinate][PlayerCol] == '-')
            {
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[newcordinate][PlayerCol] = 'S';
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(PlayerCol);
                return NewCordinates;
            }
            return NewCordinates;
        }

        public static List<int> Down(char[][] matrix, int PlayerRow, int PlayerCol, int SumOfStarPower, List<int> BlackHolCordinata)
        {
            int newcordinate = PlayerRow + 1;
            List<int> NewCordinates = new List<int>();

            if (newcordinate > matrix.Length - 1)
            {
                matrix[PlayerRow][PlayerCol] = '-';
                NewCordinates.Add(0);
                return NewCordinates;
            }
            if (matrix[newcordinate][PlayerCol] != '-' && matrix[newcordinate][PlayerCol] != 'O')
            {
                int starpower = matrix[newcordinate][PlayerCol] - '0';
                SumOfStarPower = SumOfStarPower + starpower;
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[newcordinate][PlayerCol] = 'S';
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(PlayerCol);
                NewCordinates.Add(SumOfStarPower);
                return NewCordinates;

            }
            if (matrix[newcordinate][PlayerCol] == 'O')
            {
                int FristBlackHolRed = BlackHolCordinata[0];
                int FristBlackHolColona = BlackHolCordinata[1];
                int SecondBlackHolRed = BlackHolCordinata[2];
                int SecondBlackHolColona = BlackHolCordinata[3];
                if (FristBlackHolRed == newcordinate && FristBlackHolColona == PlayerCol)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(SecondBlackHolRed);
                    NewCordinates.Add(SecondBlackHolColona);
                    return NewCordinates;

                }
                if (SecondBlackHolRed == newcordinate && SecondBlackHolColona == PlayerCol)
                {
                    matrix[PlayerRow][PlayerCol] = '-';
                    matrix[FristBlackHolRed][FristBlackHolColona] = '-';
                    matrix[SecondBlackHolRed][SecondBlackHolColona] = 'S';
                    NewCordinates.Add(FristBlackHolRed);
                    NewCordinates.Add(FristBlackHolColona);
                    return NewCordinates;
                }
            }
            if (matrix[newcordinate][PlayerCol] == '-')
            {
                matrix[PlayerRow][PlayerCol] = '-';
                matrix[newcordinate][PlayerCol] = 'S';
                NewCordinates.Add(newcordinate);
                NewCordinates.Add(PlayerCol);
                return NewCordinates;
            }
            return NewCordinates;
        }
    }
}


