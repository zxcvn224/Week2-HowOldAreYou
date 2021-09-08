using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsoolis

            Console.WriteLine("How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());

            int Year = 2021 - Age;

            Console.WriteLine($"You were born in the year {Year}.");
        }
    }
}
