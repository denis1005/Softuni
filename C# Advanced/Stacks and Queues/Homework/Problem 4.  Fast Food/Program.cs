using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quentity = int.Parse(Console.ReadLine());
            string [] Orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<int> stack = new Queue<int>();
            for (int i = 0; i < Orders.Length; i++)
            {
                stack.Enqueue(int.Parse(Orders[i]));
            }
            int biggestOreder = stack.Max();
            while(stack.Count!=0)
            {
                int Order = stack.Dequeue();
                if (quentity-Order>=0)
                {
                    quentity = quentity - Order;
                }
                else
                {
                    Console.WriteLine($@"{biggestOreder}
                    Orders left:{String.Join(' ',stack)}");
                    break;

                }
            }

            Console.WriteLine($@"{biggestOreder}
            Orders complete");
        }
    }
}
