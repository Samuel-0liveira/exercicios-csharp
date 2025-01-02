//Faça um programa para calcular o estoque médio de uma peça, sendo que:
//ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite a quantidade mínima da peça contida no estoque: ");
            var quantidadeMinima = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite a quantidade máxima dessa mesma peça no estoque: ");
            var quantidadeMaxima = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            CalculoDeMedia(quantidadeMinima, quantidadeMaxima);
        }

        public static void CalculoDeMedia(int quantidadeMinima, int quantidadeMaxima)
        {
            int mediaDaPeca = (quantidadeMinima + quantidadeMaxima) / 2;

            Console.WriteLine($"O estoque médio da peça é de: {mediaDaPeca}");
            Console.ReadKey();
        }
    }
}