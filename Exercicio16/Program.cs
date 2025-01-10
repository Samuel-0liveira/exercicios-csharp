//Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
//menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite o primeiro número: ");
            float numeroA = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o segundo número: ");
            float numeroB = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            VerificarNumeros(numeroA, numeroB);
            Console.ReadKey();
        }

        static void VerificarNumeros(float numeroUm, float numeroDois)
        {
            string resultado;

            if (numeroUm == numeroDois)
            {
                resultado = "Ambos os números digitados são iguais!";
            } else {
                resultado = numeroUm > numeroDois ? $"Dentre os números digitados o maior é: {numeroUm}\nE o menor: {numeroDois}":$"Dentre os números digitados o maior é: {numeroDois}\nE o menor: {numeroUm}";
            }

            Console.WriteLine(resultado);
        }
    }
}