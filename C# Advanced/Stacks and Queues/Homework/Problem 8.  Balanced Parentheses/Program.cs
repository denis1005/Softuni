using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] Siuance = Console.ReadLine().ToCharArray();
            Stack<char> Back = new Stack<char>(Siuance);
            Queue<char> Front = new Queue<char>(Siuance);
            string result = String.Empty;
            while (Back.Count!=0)
            {
                if(Back.Peek() - Front.Peek() == 2 || Back.Peek() - Front.Peek() == 1 || Back.Peek() - Front.Peek() == -2 || Back.Peek() - Front.Peek() == -1)
                {
                    Back.Pop();
                    Front.Dequeue();

                }
                else
                {
                    result = result + "NO";
                    break;
                }
               

            }
            if(result!="NO")
            {
                result = result + "YES";
            }
            
            Console.WriteLine(result);


        }
    }
}
