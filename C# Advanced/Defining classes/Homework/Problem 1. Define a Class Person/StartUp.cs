using System;

namespace Problem_1._Define_a_Class_Person
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person("Pesho", 20);
            Person Person2 = new Person("Gosho", 18);
            Person Person3 = new Person("Stamat", 20);

            Console.WriteLine(Person1.Age);
           
        }
    }
}
