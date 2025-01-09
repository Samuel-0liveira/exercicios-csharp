//Escreva um programa que leia dois números e apresente a diferença do maior para o menor.

using System;

namespace Exercicio14
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite um número: ");
            double numeroA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o segundo número: ");
            double numeroB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            CalculoDeDiferenca(numeroA, numeroB);
        }

        static void CalculoDeDiferenca(double n1, double n2)
        {
            double diferenca = 0;

            if (n1 >= n2)
            {
                diferenca = n1 - n2;
            } else {
                diferenca = n2 - n1;
            }

            Console.WriteLine($"O valor da diferença entre {n1} e {n2} é: {diferenca}");
            Console.ReadKey();
        }
    }
}