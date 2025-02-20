using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double xx = 1.23456;
            int ii = 19;
            string  formato_1 = $"xx = {xx:f2}";
            string  formato_2 = $"xx = {xx:p1}";
            string  formato_3 = $"ii = {ii:x}";
            string  formato_4 = $"ii = {ii:c}";

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

            string concatenado_1 = "Isto é conca"+"tenação.";
            string concatenado_2 = "Isto também é "+"concatenação.";
            int conc_x = 2;
            int conc_y = 3;
            string concatenado_3 = "2 + " + conc_x + " = 4";
            string concatenado_4 = conc_y + " + 2 = 5";
            int inter_x = 4;
            int inter_y = 5;
            string interpolacao_1 = $"O valor da variável x é {inter_x}.";
            string interpolacao_2 = $"{inter_x} mais {inter_y} é igual a "+
            $"{inter_x + inter_y}";

            

            Console.WriteLine("Hello LP1!");
            Console.WriteLine(teste);
            Console.WriteLine(aspas);
            Console.WriteLine(tabulacao);
            Console.WriteLine(zero);

            Console.WriteLine(parenteses);
            Console.WriteLine(soma);
            Console.WriteLine(nome);
            Console.WriteLine(caracter_unicode);

            Console.WriteLine(concatenado_1);
            Console.WriteLine(concatenado_2);
            Console.WriteLine(concatenado_3);
            Console.WriteLine(concatenado_4);

            Console.WriteLine(interpolacao_1);
            Console.WriteLine(interpolacao_2);

            Console.WriteLine(formato_1);
            Console.WriteLine(formato_2);
            Console.WriteLine(formato_3);
            Console.WriteLine(formato_4);


        }
    }
}
