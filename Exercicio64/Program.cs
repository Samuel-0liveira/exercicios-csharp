/*Escreva um programa que deverá ter as seguintes opções:
1-  Carregar Vetor
2 - Listar Vetor
3 - Exibir apenas os números pares do vetor
4 - Exibir apenas os números ímpares do vetor
5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
7 - Sair
Deverá ser implementado um método para realizar cada uma das opções de 1 a 6
*/

namespace Exercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int[] vetor = new int[0];


            while (opcao != 7) {
                Console.Clear();

                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir números pares do vetor");
                Console.WriteLine("4 - Exibir números ímpares do vetor");
                Console.WriteLine("5 - Exibir números pares na posição ímpar");
                Console.WriteLine("6 - Exibir números ímpares na posição par");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("");

                Console.Write("Selecione uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        vetor = CarregarVetor();
                        Console.ReadKey();
                        break;
                    case 2:
                        ListarVetor(vetor);
                        Console.ReadKey();
                        break;
                    case 3:
                        ValoresPares(vetor);
                        Console.ReadKey();
                        break;
                    case 4:
                        ValoresImpares(vetor);
                        Console.ReadKey();
                        break;
                    case 5:
                        ParPosicaoImpar(vetor);
                        Console.ReadKey();
                        break;
                    case 6:
                        ImparPosicaoPar(vetor);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida digitada!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static int[] CarregarVetor()
        {
            Console.Clear();

            Console.Write("Digite quantas posições terá o vetor: ");
            int posicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Random aleatorio = new Random();

            int[] vetor = new int[posicao];

            for (int contador = 0; contador < posicao; contador++) {
                vetor[contador] = aleatorio.Next(100);
            }

            Console.WriteLine("Vetor carregado com sucesso!");

            return vetor;
        }

        static void ListarVetor(int[] vetor) 
        {
            Console.Clear();
            Console.Write("Valores contidos no vetor: ");

            for (int contador = 0; contador < vetor.Length; contador++) {
                Console.Write($"{vetor[contador]}, ");
            }
        }

        static void ValoresPares(int[] vetor)
        {
            Console.Clear();

            for (int contador = 0; contador < vetor.Length; contador++) {
                if (vetor[contador] % 2 == 0) {
                    Console.Write($"{vetor[contador]}, ");
                }
            }
        }

        static void ValoresImpares(int[] vetor)
        {
            Console.Clear();

            for (int contador = 0; contador < vetor.Length; contador++) {
                if (vetor[contador] % 2 != 0) {
                    Console.Write($"{vetor[contador]}, ");
                }
            }
        }

        static void ParPosicaoImpar(int[] vetor)
        {
            Console.Clear();

            int quantidade = 0;

            for (int contador = 0; contador < vetor.Length; contador++) {
                if (contador % 2 != 0) {
                    if (vetor[contador] % 2 == 0) {
                        quantidade++;
                    }
                }
            }

            Console.WriteLine($"Valores pares na posição ímpar: {quantidade}");
        }

        static void ImparPosicaoPar(int[] vetor)
        {
            Console.Clear();

            int quantidade = 0;

            for (int contador = 0; contador < vetor.Length; contador++) {
                if (contador % 2 == 0) {
                    if (vetor[contador] % 2 != 0) {
                        quantidade++;
                    }
                }
            }

            Console.WriteLine($"Valores ímpares na posição par: {quantidade}");
        }
    }
}