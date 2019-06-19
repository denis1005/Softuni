using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();
            int NumberToIncludeInStack = int.Parse(commands[0]);
            int PopOut= int.Parse(commands[1]);
            int ElementToSurch= int.Parse(commands[2]);
            for (int i = 0; i < NumberToIncludeInStack; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }
            
            for (int i = 0; i < PopOut; i++)
            {
                if (stack.Count != 0)
                {
                    stack.Pop();
                }
             
            }

                
            
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (stack.Contains(ElementToSurch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
