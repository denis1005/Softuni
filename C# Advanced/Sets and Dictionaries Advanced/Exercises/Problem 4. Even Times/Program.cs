using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumbersOfrow = int.Parse(Console.ReadLine());
            Dictionary<int, int> Numberes = new Dictionary<int, int>();

            for (int i = 0; i < NumbersOfrow; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (Numberes.ContainsKey(number))
                {
                    Numberes[number]++;
                }
                else
                {
                    Numberes[number] = 1;
                }
            }

            foreach (var item in Numberes)
            {
                if (item.Value==2)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
