/*Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
entre O (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem "valor válido".
Caso contrário, apresentar a mensagem "valor inválido".
*/

using System;

namespace Exercicio17;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Olá, por favor, digite um número entre 0 e 9: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        VerificarIntervalo(valor);
        Console.ReadKey();
    }

    static void VerificarIntervalo(int numero)
    {
        if (numero >= 0 && numero <= 9)
        {
            Console.WriteLine("Valor válido!");
        } else {
            Console.WriteLine("Valor inválido!");
        }
    }
}