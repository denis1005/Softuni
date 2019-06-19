using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            char[] items = Console.ReadLine().ToCharArray();

            foreach (var item in items)
            {
                if (!symbols.ContainsKey(item))
                {
                    symbols.Add(item, 0);
                }

                symbols[item]++;
            }

            foreach (var symbol in symbols.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
