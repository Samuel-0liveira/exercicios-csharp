//Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.

using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--) {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}