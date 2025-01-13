/* Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
1- Adição
2 - Subtração
3 - Multiplicação
4 - Divisão
*/

using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            PedirNumeros();
            Console.ReadKey();
        }

        static void PedirNumeros()
        {
            Console.Clear();

            Console.Write("Por favor, digite um número: ");
            int numeroUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Agora, digite o segundo número: ");
            int numeroDois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            OperacoesMatematicas(numeroUm, numeroDois);
        }

        static void OperacoesMatematicas(int numeroA, int numeroB)
        {
            int sair = 0;
            do {
                Console.Clear();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("");

                Console.Write("O que deseja fazer com os números digitados?: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine($"O resultado da soma é: {numeroA + numeroB}");
                        break;
                    case 2:
                        Console.WriteLine($"O resultado da subtração é: {numeroA - numeroB}");
                        break;
                    case 3:
                        Console.WriteLine($"O resultado da multiplicação é: {numeroA * numeroB}");
                        break;
                    case 4:
                        Console.WriteLine($"O resultado da divisão é: {numeroA / numeroB}");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente digitada.");
                        break;
                }

                Console.ReadKey();

                Console.WriteLine("");
                Console.Write("Deseja realizar outra operação? [1 - S / 2 - N]");
                sair = Convert.ToInt32(Console.ReadLine());

            } while (sair != 2);
        }
    }
}