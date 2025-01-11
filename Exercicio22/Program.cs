//Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o
//resultado

using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite um número para ser armezenado no lado A ou B: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int a, b;

            if (numero >= 0)
            {
                a = numero;
                Console.WriteLine($"O número {numero} foi armazenado em A!");
            } else {
                b = numero;
                Console.WriteLine($"O número {numero} foi armazenado em B!");
            }

            Console.ReadKey();
        }
    }
}