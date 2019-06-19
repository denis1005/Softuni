using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumbersOfrow = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> Chemicals = new SortedDictionary<string, int>();
            for (int i = 0; i < NumbersOfrow; i++)
            {
                string[] Chemical = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < Chemical.Length; j++)
                {
                    if (Chemicals.ContainsKey(Chemical[j]))
                    {
                        Chemicals[Chemical[j]]++;
                    }
                    else
                    {
                        Chemicals.Add(Chemical[j], 1);
                    }
                }
                Console.WriteLine();

            }
            foreach (var item in Chemicals)
            {
                if (item.Value==1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
