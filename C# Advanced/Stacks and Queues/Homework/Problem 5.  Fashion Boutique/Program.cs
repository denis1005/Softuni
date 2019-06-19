using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int racks = int.Parse(Console.ReadLine());
            int numberOfRacks = 0;
            int sum = 0;
            while (clothes.Count!=0)
            {
                for (int i = 0; i < clothes.Count; i++)
                {
                   int clothe = clothes.Peek();
                    
                    if(sum+clothe<= racks)
                    {
                        if (clothes.Count == 1)
                        {
                            clothes.Pop();
                            numberOfRacks += 1;
                            break;
                        }
                        sum = sum + clothes.Pop();
                        continue;

                    }
                    
                   
                    

                    else
                    {
                        numberOfRacks += 1;
                        sum = 0;
                        break;
                    }
                }
            }
            Console.WriteLine(numberOfRacks);
            
        }
    }
}
