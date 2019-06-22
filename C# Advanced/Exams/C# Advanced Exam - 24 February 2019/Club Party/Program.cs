using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaximumCapasity = int.Parse(Console.ReadLine());
            string[] Comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> HallAndCapacity = new Stack<string>(Comands);
            Dictionary<string,List <int>> Result = new Dictionary<string, List<int>>();
            Queue<string> Keys = new Queue<string>();
            var PrintResult =new Dictionary<string, List<int>>();




            while (HallAndCapacity.Count!=0)
            {
                
                string FirstElement = HallAndCapacity.Peek();
                
                bool IsItHallOrReservarion = int.TryParse(FirstElement,out int Reservartion);
                
                if( !IsItHallOrReservarion)
                {
                    Result[FirstElement]=new List<int>();
                    Keys.Enqueue(FirstElement);
                    
                    HallAndCapacity.Pop();
                    continue;
                }
                if (Keys.Count == 0)
                {
                    HallAndCapacity.Pop();
                    continue;

                }
                else
                {   

                    int SumOfElements = Result[Keys.Peek()].Sum();
                    if (SumOfElements+ Reservartion <= MaximumCapasity)
                    {
                        Result[Keys.Peek()].Add(Reservartion);
                        HallAndCapacity.Pop();
                        continue;

                    }
                    if (SumOfElements+ Reservartion > MaximumCapasity)
                    {
                        if (Keys.Count!=0)
                        {
                            var Colection = Keys.Peek();
                            PrintResult.Add(Colection, Result[Keys.Peek()]);
                            Keys.Dequeue();
                            continue;
                        }

                        else
                        {
                            break;
                        }
                    }
                }
            }

            
            foreach (var item in PrintResult)
            {
                
                    Console.WriteLine($"{item.Key} -> {String.Join(", ", item.Value)}");
                
               
            }

        }
    }
}
