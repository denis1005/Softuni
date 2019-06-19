using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            HashSet<string> FirstSet = new HashSet<string>();
            HashSet<string> SecondSet = new HashSet<string>();
           
            for (int i = 0; i < Lenghts[0]; i++)
            {
                FirstSet.Add(Console.ReadLine());
            }
            for (int i = 0; i < Lenghts[1]; i++)
            {
                SecondSet.Add(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (var item in FirstSet)
            {
                if (SecondSet.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
