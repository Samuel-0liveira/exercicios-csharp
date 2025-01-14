//Faça um programa que exiba os números de 1 até 2000.

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 2000; contador++) {
                Console.Write(contador+", ");
            }

            Console.ReadKey();
        }
    }
}