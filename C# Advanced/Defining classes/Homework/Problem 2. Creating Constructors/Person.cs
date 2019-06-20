using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2._Creating_Constructors
{
    public class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public Person()

        {
            this.Name = "No name";
            this.Age = 1;

        }
        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;

        }
        public Person(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
