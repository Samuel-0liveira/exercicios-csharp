//Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é
//positivo ou negativo. Pare a execução do programa quando o usuário requisitar.

using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            int numero = 0;

            while(opcao != 0)
            {
                Console.Clear();

                Console.Write("Olá, digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numero >= 0)
                {
                    Console.WriteLine("O número digitado é positivo!");
                } else {
                    Console.WriteLine("O número digitado é negativo!");
                }

                Console.WriteLine("");

                Console.Write("Deseja encerrar o programa? [0 - S / 1 - N]");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}