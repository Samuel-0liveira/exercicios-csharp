/*Escreva um programa que leia:
- a quantidade de números que deverá processar;
- os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 •2 •3 •4 •5 •...•N
*/

using System;
using System.Runtime.CompilerServices;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite quantos números serão processados: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[] quantidadeN = new int[quantidade];

            for (int x = 0; x < quantidade; x++) {
                Console.Write("Digite o número para calcular o fatorial: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                quantidadeN[x] = 1;

                for (int indice = numero; indice > 0; indice--) {
                    quantidadeN[x] = quantidadeN[x] * indice;
                }
            }

            Console.WriteLine("");

            for (int contador = 0; contador < quantidadeN.Length; contador++) {
                Console.WriteLine($"Esse é o fatorial do {contador + 1}° número: {quantidadeN[contador]}");
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}