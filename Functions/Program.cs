using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();
            Console.WriteLine("sisesta sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Greetings(userName, userAge, userLastName);
        }

        private static void Greetings(string someString, int someInt, string userLastname)
        {
            Console.WriteLine($"Tere! {someString} {userLastname}");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }

    }
}
