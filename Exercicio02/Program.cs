/*Faça um programa que:
- Leia a cotação do dólar
- Leia um valor em dólares
- Converta esse valor para Real
- Mostre o resultado
*/

using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite a cotação atual do dólar: ");
            decimal cotacaoDolar = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite digite o valor em dólares para conversão: ");
            decimal valorEmDolar = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            ConversaoDolarParaReal(cotacaoDolar, valorEmDolar);
        }

        public static void ConversaoDolarParaReal(decimal cotacao, decimal valorDolar)
        {
            decimal valorEmReal = cotacao * valorDolar;

            Console.WriteLine($"O valor em dólar digitado convertido para real é igual a: {valorEmReal.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
            Console.ReadKey();
        }
    }
}