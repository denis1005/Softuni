using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Opinion_Poll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> AllPerson = new List<Person>();
            List<Person> ResultList = new List<Person>();
            int NumberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfPeople; i++)
            {
                string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                AllPerson.Add(new Person(person[0], int.Parse(person[1])));
            }
            Console.WriteLine();
            for (int i = 0; i < AllPerson.Count; i++)
            {
                if (AllPerson[i].Age>30)
                {
                    ResultList.Add(AllPerson[i]);
                    
                }
            }
            ResultList = ResultList.OrderBy(x => x.Name).ToList();
            foreach (var item in ResultList)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
            
        }
    }
}
