//Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
//possuir o valor da variável B,e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.

using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite um número inteiro para realizarmos a troca de valores: ");
            int valorUm = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o segundo número: ");
            int valorDois = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.WriteLine("Trocando valores....");

            TrocaDeValores(valorUm, valorDois);
        }

        static void TrocaDeValores(int valorA, int valorB)
        {
            int valorC = valorA;
            valorA = valorB;
            valorB = valorC;

            Console.WriteLine($"O primeiro valor agora é: {valorA}\nO segundo valor agora é: {valorB}");
            Console.ReadKey();
        }
    }
}