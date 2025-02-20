using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            Console.WriteLine("Insert a int number: ");

            string input_int = Console.ReadLine();
            int int_number = int.Parse(input_int);

            Console.WriteLine($"Int number: {int_number}");

            Console.WriteLine("Insert a floating number: ");
            string input_float = Console.ReadLine();
            float float_number = float.Parse(input_float);

            Console.WriteLine($"Float number: {float_number}");
        }
    }
}
