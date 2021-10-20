using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number:");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valitehe ('+', '-', '*', '/'");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumbers(num1, secondnumber);
                    break;
                case '-':
                    SubtractTwoNumbers(num1, secondnumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(num1, secondnumber);
                    break;
                case '/':
                    DivideTwoNumbers(num1, secondnumber);
                    break;
                default:
                    Console.WriteLine("Vale tehe");
                    break;
            }
            
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }

        private static void SubtractTwoNumbers(int x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        private static void MultiplyTwoNumbers(int x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }

    }
}
