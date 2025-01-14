//Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Esses são os números ímpares que estão entre 100 e 200: ");

            for (int contador = 100; contador <= 200; contador++) {
                if (contador % 2 != 0) {
                    Console.WriteLine(contador);
                }
            }

            Console.ReadKey();
        }
    }
}