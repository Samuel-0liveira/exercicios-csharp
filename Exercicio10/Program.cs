//Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
//entre eles. Os relacionamentos possíveis são: Igual,Não igual, Maior, Menor, Maior ou igual, Menor ou igual.

using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite um número inteiro para verificar seu relacionamento: ");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Agora, digite o segundo número: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

                VerificacaoDeRelacionamentos(primeiroNumero, segundoNumero);
        }

        static void VerificacaoDeRelacionamentos(int numeroA, int numeroB)
        {
            if (numeroA > numeroB)
            {
                Console.WriteLine($"{numeroA} não é igual a {numeroB}\n{numeroA} é maior que {numeroB}\n{numeroA} é maior ou igual a {numeroB}");
            } else if (numeroB > numeroA) {
                Console.WriteLine($"{numeroB} não é igual a {numeroA}\n{numeroB} é maior que {numeroA}\n{numeroB} é maior ou igual a {numeroA}");
            } else {
                Console.WriteLine($"{numeroA} é igual a {numeroB}\n{numeroA} não é maior nem menor que {numeroB}\n{numeroA} é maior ou igual a {numeroB}");
            }

            Console.ReadKey();
        }
    }
}