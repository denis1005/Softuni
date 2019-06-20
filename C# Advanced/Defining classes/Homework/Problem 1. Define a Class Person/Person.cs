using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1._Define_a_Class_Person
{
    public class Person
    {
       
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
