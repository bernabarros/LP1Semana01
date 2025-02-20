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

            Console.WriteLine(int_number);
        }
    }
}
