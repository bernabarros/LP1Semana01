﻿using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int inteiro = 1;
            uint uinteiro = 2U;
            long longo = 3L;
            ulong ulongo = 4UL;

            char letra_a = '\u0041';
            char exclamacao = '\u0021';
            char numero_nove = '\u0039';
            char sinal_igual = '\u003D';

            Console.WriteLine(inteiro);
            Console.WriteLine(uinteiro);
            Console.WriteLine(longo);
            Console.WriteLine(ulongo);

            Console.WriteLine(letra_a);
            Console.WriteLine(exclamacao);
            Console.WriteLine(numero_nove);
            Console.WriteLine(sinal_igual);


        }
    }
}
