using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Hello LP1!");
            //Input variable
            string string_unicode;
            //Request caracter unicode
            Console.Write("Insere código   : ");
            string_unicode = Console.ReadLine();
            //Convert string to int
            int int_unicode = System.Int32.Parse(string_unicode,
            NumberStyles.HexNumber);
            //Convert int to unicode
            string code_unicode = char.ConvertFromUtf32(int_unicode).ToString();
            //Print caracter from unicode
            Console.WriteLine($"Caráter Unicode : {code_unicode}");
        }
    }
}
