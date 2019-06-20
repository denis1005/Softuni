using System;
using System.Linq;

namespace Problem_3._Oldest_Family_Member
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int NumberOfPeople = int.Parse(Console.ReadLine());
            Family Family = new Family();
            for (int i = 0; i < NumberOfPeople; i++)
            {
                string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Family.AddMember(new Person(person[0], int.Parse(person[1])));

            }
            Person oldest = Family.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);
        }
    }
}
