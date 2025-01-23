//Fazer um programa que leia uma frase e imprima somente as vogais

namespace Exercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine()!;
            Console.WriteLine("");

            char[] fraseSeparada = frase.ToCharArray();

            Console.WriteLine("A frase somente com as vogais ficaria da seguinte forma: \n");


            for (int contador = 0; contador < fraseSeparada.Length; contador++) {
                switch (fraseSeparada[contador]) {
                    case 'a':
                    case 'A':
                        Console.Write(fraseSeparada[contador]);
                        break;
                    case 'e':
                    case 'E':
                        Console.Write(fraseSeparada[contador]);
                        break;
                    case 'i':
                    case 'I':
                        Console.Write(fraseSeparada[contador]);
                        break;
                    case 'o':
                    case 'O':
                        Console.Write(fraseSeparada[contador]);
                        break;
                    case 'u':
                    case 'U':
                        Console.Write(fraseSeparada[contador]);
                        break;
                }
            }
            
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}