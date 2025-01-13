/*Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
realizar:
1 - Verificar se um dos números lidos é ou não múltiplo do outro
2 - Verificar se os dois números lidos são pares
3 - Verificar se a média dos dois números é maior ou igual a 7
4 - Sair
*/

using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            RequisitarNumeros();
            Console.ReadKey();
        }

        static void RequisitarNumeros()
        {
            Console.Clear();

            Console.Write("Por favor, digite um número inteiro: ");
            int numeroUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Agora, digite o próximo número: ");
            int numeroDois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            ApresentarOpcoes(numeroUm, numeroDois);
        }

        static void ApresentarOpcoes(int numeroA, int numeroB)
        {
            int opcao = 0;
            int multiplo, media;

            do {
                Console.Clear();
                
                Console.WriteLine("1 - Verificar múltiplo");
                Console.WriteLine("2 - Verificar se são pares");
                Console.WriteLine("3 - Verificar média");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("");

                Console.Write("O que deseja realizar com os números digitados?: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(opcao)
                {
                    case 1:
                        if (numeroA >= numeroB)
                        {
                            multiplo = numeroA % numeroB;
                        } else {
                            multiplo = numeroB % numeroA;
                        }

                        if (multiplo != 0)
                        {
                            Console.WriteLine("Os números em questão não são múltiplos um do outro!");
                        } else {
                            Console.WriteLine("Os números são múltiplos um do outro!");
                        }
                        break;
                    case 2:
                        if (numeroA % 2 == 0 && numeroB % 2 == 0)
                        {
                            Console.WriteLine($"Valores: {numeroA} / {numeroB}.\nAmbos os números digitados são pares!");
                        } else if (numeroA % 2 == 0 || numeroB % 2 == 0) {
                            Console.WriteLine($"Valores: {numeroA} / {numeroB}.\nApenas um dos números é par!");
                        } else {
                            Console.WriteLine($"Valores: {numeroA} / {numeroB}.\nNenhum dos dois números digitados são pares!");
                        }
                        break;
                    case 3:
                        media = (numeroA + numeroB) / 2;

                        if (media >= 7)
                        {
                            Console.WriteLine($"Média: {media}\nA média dos valores é igual ou maior a 7");
                        } else {
                            Console.WriteLine($"Média: {media}\nA média dos valores é menor que 7");
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inexistente digitada.");
                        break;
                }

                Console.ReadKey();

            } while (opcao != 4);
        }
    }
}