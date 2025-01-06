//Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa 
//pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            IdadeEmDias();
            Console.ReadKey();
        }

        static void IdadeEmDias()
        {
            Console.Clear();

            int totalDias = 0;

            Console.Write("Por favor, digite o dia de seu nascimento: ");
            int dia = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Por favor, digite o mês de seu nascimento: ");
            int mes = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Por favor, digite o ano de seu nascimento: ");
            int ano = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            if (dia > 31 || dia < 1) 
            {
                Console.WriteLine("Não foi possível realizar o cálculo pois o dia digitado é maior que 31 ou menor que 1.");
            } else  if (mes > 12 || mes < 1) {
                Console.WriteLine("Não foi possível realizar o cálculo pois o mês digitado é maior que 12 ou menor que 1.");
            } else {
                totalDias = (ano * 365) + (mes * 30) + dia;
                Console.WriteLine($"A data {dia} / {mes} / {ano} tem um total de: {totalDias} dias");
            }
        }
    }
}