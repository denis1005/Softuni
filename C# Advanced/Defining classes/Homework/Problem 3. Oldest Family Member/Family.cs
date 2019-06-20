using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3._Oldest_Family_Member
{
   public class Family
    {
        private List<Person> member = new List<Person>();

        public List<Person> Member
        {
            get => this.member;
            set => this.member = value;
        }

        public void AddMember(Person member)
        {
            Member.Add(member);
        }

        public Person GetOldestMember()
        {
            int indexOfOldestPerson = 0;
            for (int i = 0; i < this.Member.Count-1; i++)
            {
                if (this.Member[i].Age>this.Member[i+1].Age)
                {
                    indexOfOldestPerson = i;
                }
                else
                {
                    indexOfOldestPerson = i + 1;
                }
            }
            return this.Member[indexOfOldestPerson];
            
        }
    }
}
