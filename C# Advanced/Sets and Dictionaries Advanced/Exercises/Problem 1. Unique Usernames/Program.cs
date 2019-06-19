using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfuserNames=int.Parse(Console.ReadLine());
            HashSet<string> users = new HashSet<string>();
            for (int i = 0; i < NumberOfuserNames; i++)
            {
                users.Add(Console.ReadLine());
            }
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}
