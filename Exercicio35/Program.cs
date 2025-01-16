//Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador % 10 == 0) {
                    Console.WriteLine(contador + " - Múltiplo de 10!");
                } else {
                    
                Console.WriteLine(contador);
                }
            }

            Console.ReadKey();
        }
    }
}