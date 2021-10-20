using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            PickRandomColor(colors)

        }

        private static void PickRandomColor(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            Console.WriteLine(someArray[randomIndex]);
        }
    }
}
