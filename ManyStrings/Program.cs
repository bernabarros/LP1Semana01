using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string teste = "Isto é um teste, \n com nova linha.";
            string aspas = "Isto é um teste, com \"aspas\".";
            string tabulacao = "Isto é um teste, com \t tabulação";
            string zero = "Isto é um teste, com nulo \0 .";

            string parenteses ="Isto é um teste, com \u0028parenteses\u0029"
            ;
            string soma = "Isto é um teste, com soma \u0031 \u002B " +
            "\u0031 \u003D \u0032.";
            string nome = "Isto é um teste, com a palavra \u004E\u004f"+
            "\u004D\u0045.";

            string caracter_unicode ="Isto é um teste, \n"+
            "com caracteres e unicode\u002E";

            Console.WriteLine("Hello LP1!");
            Console.WriteLine(teste);
            Console.WriteLine(aspas);
            Console.WriteLine(tabulacao);
            Console.WriteLine(zero);

            Console.WriteLine(parenteses);
            Console.WriteLine(soma);
            Console.WriteLine(nome);
            Console.WriteLine(caracter_unicode);


        }
    }
}
