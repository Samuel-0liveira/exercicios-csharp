//Faça um programa para imprimir uma tabuada

using System.Net;

namespace Exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Deseja ver a tabuada de qual número?: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

                Tabuada(numero);
                Console.ReadKey();
        }

        static void Tabuada(int numero)
        {
            Console.WriteLine($"A tabuada do número: {numero}");

            for (int index = 1; index <= 10; index++) {
                Console.Write($"{index} x {numero} = {index * numero}\n");
            }
        }
    }
}