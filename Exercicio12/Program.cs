/*Escreva um programa que leia um número inteiro e exiba o seu módulo.
O módulo de um número x é:
x se x é maior ou igual a zero
x * (-1) se x é menor que zero
*/

using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, por favor, digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            CalcularModulo(numero);

            Console.ReadKey();
        }

        static void CalcularModulo(int numeroInteiro)
        {
            int modulo = 0;

            if(numeroInteiro >= 0)
            {
                modulo = numeroInteiro;
            } else {
                modulo = numeroInteiro * (-1);
            }

            Console.WriteLine($"O módulo do número informado é: {modulo}");
        }
    }
}