//Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima todos os elementos
//comuns aos dois vetores.

using System.Runtime.InteropServices;

namespace Exercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[8];

            Random valores = new Random();

            Console.Clear();

            for (int contador = 0; contador < 5; contador++) {
                vetorA[contador] = valores.Next(15);
            }

            for (int contador = 0; contador < 8; contador++) {
                vetorB[contador] = valores.Next(15);
            }

            Console.WriteLine("Os elementos comuns entre os dois vetores são: ");

            for (int contador = 0; contador < vetorA.Length; contador++) {
                for (int contador2 = 0; contador2 < vetorB.Length; contador2++) {
                    if (vetorA[contador] == vetorB[contador2]) {
                        Console.Write($"{vetorA[contador]}, ");
                    }
                }
            }

            Console.ReadKey();      
        } 
    }
}