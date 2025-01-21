//Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4,nesta
//ordem. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1.

using System.Collections.Specialized;
using System.Data;

namespace Exercicio52
{
    class Program
    {
        static void Main(string[] args) 
        {
            int repeticao = 0;
            int quantidade = 101;

            while (quantidade > 100) {
                Console.Clear();
                Console.Write("Por favor, digite quantas posições terão o vetor (máx.100): ");
                quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            int[] valores = new int[quantidade];

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Write("Digite um valor inteiro e positivo (para sair digite -1): ");
                valores[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (valores[contador] < 0)  {
                    contador = quantidade;
                }
            }

            for (int contador = 0; contador < valores.Length; contador++) {
                if (valores[contador] == 1 && contador != valores.Length - 2) {
                    contador++;
                    if (valores[contador] == 3) {
                        contador++;
                        if (valores[contador] == 4) {
                            repeticao++;
                            contador -= 2;
                        }
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"O total de vezes que foram repetidos os números na ordem 1, 3 e 4 é: {repeticao}");
            Console.ReadKey();
        }
    }
}