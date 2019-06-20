using System;

namespace Problem_4._Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier twoDates = new DateModifier(
                DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()));

            int differenceInDays = twoDates.DateDifferenceInDays();

            Console.WriteLine(differenceInDays);
        }
    }
}
