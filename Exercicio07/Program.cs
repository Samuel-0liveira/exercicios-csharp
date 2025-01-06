/*Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. A fórmula de conversão de
temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
variável C é a temperatura em graus Celsius.
*/

using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversaoFahrenheitParaCelsius();
            Console.ReadKey();
        }

        static void ConversaoFahrenheitParaCelsius()
        {
            Console.Clear();

            Console.Write("Por favor, informe a temperatura em Fahrenheit para conversão em Celsius: ");
            float fahrenheit = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"O valor {fahrenheit}°F convertido em Celsius é: {celsius:n1}°C");
        }
    }
}