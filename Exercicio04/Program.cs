/*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
multiplicações.
*/

using System;

namespace Exercicios04
{
    class Program
    {
        static void Main(string[] args)
        {
            RequisitarNumeros();
            Console.ReadKey();
        }

        public static void RequisitarNumeros()
        {
            Console.Clear();

            int[] valores = new int[4];

            for (int contador = 0; contador < 4; contador++)
            {
                Console.Write("Por favor, digite o " + (contador + 1) + "º valor: ");
                valores[contador] = int.Parse(Console.ReadLine()!);
                Console.WriteLine("");
            }

            SomaMultiplicacao(valores);
        }

        public static void SomaMultiplicacao(int[] valores)
        {
            Console.WriteLine($"A soma de A com B é: {valores[0] + valores[1]}");
            Console.WriteLine($"A soma de A com C é: {valores[0] + valores[2]}");
            Console.WriteLine($"A soma de A com D é: {valores[0] + valores[3]}");
            Console.WriteLine($"A soma de B com C é: {valores[1] + valores[2]}");
            Console.WriteLine($"A soma de B com D é: {valores[1] + valores[3]}");
            Console.WriteLine($"A soma de C com D é: {valores[2] + valores[3]}");
            
            Console.WriteLine("");

            Console.WriteLine($"A multiplicação de A com B é: {valores[0] * valores[1]}");
            Console.WriteLine($"A multiplicação de A com C é: {valores[0] * valores[2]}");
            Console.WriteLine($"A multiplicação de A com D é: {valores[0] * valores[3]}");
            Console.WriteLine($"A multiplicação de B com C é: {valores[1] * valores[2]}");
            Console.WriteLine($"A multiplicação de B com D é: {valores[1] * valores[3]}");
            Console.WriteLine($"A multiplicação de C com D é: {valores[2] * valores[3]}");
        }
    }
}