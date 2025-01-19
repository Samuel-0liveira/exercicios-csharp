/*Considere um vetor de 1O números inteiros positivos maiores que zero e um único número inteiro, também positivo
e maior que zero. Faça um programa para:
a. ler pelo teclado o vetor;
b. ler pelo teclado o número X;
c. dizer quantos números no vetor são maiores que X,menores que X e iguais a X.
*/

using System.Diagnostics.CodeAnalysis;

namespace Exercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int numeroX, menor, igual, maior;
            menor = igual = maior = 0;

            for (int contador = 0; contador < 10; contador++) {
                Console.Clear();

                Console.Write("Por favor, digite o " + (contador + 1) + "º valor do vetor (positivo e maior que 0): ");
                vetor[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.Write("Agora, digite um valor para comparar com os outros: ");
            numeroX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int contador = 0; contador < 10; contador++) {
                if (vetor[contador] > numeroX) {
                    maior++;
                } else if (vetor[contador] < numeroX) {
                    menor++;
                } else {
                    igual++;
                }
            }

            Console.Clear();

            Console.WriteLine($"Dentro do vetor foram encontrados:\n{maior} valores maiores que {numeroX}\n{menor} valores menores que {numeroX}\n{igual} valores iguais a {numeroX}");
            Console.ReadKey();
        }
    }
}