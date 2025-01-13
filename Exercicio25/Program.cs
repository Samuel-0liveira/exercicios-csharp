/*Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
utilizando as seguintes fórmulas:(h=altura)
- Para homens:(72.7*h) - 58
- Para mulheres: (62.1 *h) - 44.7
*/

using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite a altura da pessoa: ");
            float altura = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o sexo da pessoa [M / F]: ");
            char sexo = char.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            CalcularPesoIdeal(altura, sexo);
            Console.ReadKey();
        }

        static void CalcularPesoIdeal(float altura, char sexo)
        {
            double pesoIdeal = 0;

            switch(sexo)
            {
                case 'm':
                case 'M':
                    pesoIdeal = (72.7 * altura) - 58;
                    break;
                case 'f':
                case 'F':
                    pesoIdeal = (62.1 * altura) - 44.7;
                    break;
                default:
                    Console.WriteLine("Opção inexistente digitada!");
                    break;
            }

            Console.WriteLine($"O peso ideal para a pessoa em questão é: {pesoIdeal:n1}Kg");
        }
    }
}