/*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
V = 3.14159 * R * R * A
Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
*/

using System;
using System.Reflection;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDeVolume();
            Console.ReadKey();
        }

        public static void CalculoDeVolume()
        {
            Console.Clear();

            Console.Write("Para o cálculo de volume, por favor, digite o raio da lata: ");
            float raio = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite a altura da lata: ");
            float altura = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float volume = 3.14159f * raio * raio * altura;

            Console.WriteLine($"De acordo com os dados passados, o volume da lata é: {volume:n1}");
        } 
    }
}