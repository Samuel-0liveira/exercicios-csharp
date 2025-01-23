//Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números 
//pares e de múltiplos de 5.

using System.Runtime.CompilerServices;

namespace Exercicio56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[] vetor = new int[50];
            int pares, multiplos;
            pares = multiplos = 0;

            Random numeroAleatorio = new Random();

            Console.WriteLine("Populando o vetor com valores....");
            Console.WriteLine("");

            for (int contador = 0; contador < vetor.Length; contador++) {
                vetor[contador] = numeroAleatorio.Next(100);

                Console.Write(vetor[contador] + ", ");

                if (vetor[contador] % 2 == 0) {
                    pares++;
                }

                if (vetor[contador] % 5 == 0) {
                    multiplos++;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine($"O vetor foi populado com {pares} valores pares e {multiplos} múltiplos de 5!");
            Console.ReadKey();
        }
    }
}