/*Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão de
temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
Fahrenheit e a variável C representa é a temperatura em graus Celsius.
*/

using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversaoDeCelsiusParaFahrenheit();
            Console.ReadKey();
        }

        static void ConversaoDeCelsiusParaFahrenheit()
        {
            Console.Clear();

            Console.Write("Por favor, digite a temperatura em Celsius para converter em Fahrenheit: ");
            var celsius = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"O valor {celsius}°C convertido para Fahrenheit é igual a: {fahrenheit:n1}°F");
        }
    }
}