//Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco.
//Imprimir também a quantidade de espaços em branco da frase

namespace Exercicio55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string frase = "";
            int espacos = 0;

            do {
                Console.Clear();
                
                Console.Write("Por favor, digite uma frase(máximo 50 caracteres): ");
                frase = Console.ReadLine()!;
                Console.WriteLine("");
            } while (frase.Length > 50);

            Console.Clear();

            char[] fraseSeparada = frase.ToCharArray();

            Console.WriteLine("\nA frase sem espaços em branco ficaria da seguinte forma: \n");

            for (int contador = 0; contador < fraseSeparada.Length; contador++) {
                if (fraseSeparada[contador].Equals(' ')) {
                    espacos++;
                } else {
                    Console.Write(fraseSeparada[contador]);
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"\nA frase continha {espacos} espaços em branco.");
            Console.ReadKey();
        }
    }
}