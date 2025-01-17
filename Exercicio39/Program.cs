/*Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar, 
e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte
pergunta,"Deseja encerrar o programa?"
*/

namespace Exercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 'n';

            do {
                Console.Clear();

                Console.Write("Olá, digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numero >= 0) {
                    Console.Write("O número é positivo e ");
                } else {
                    Console.Write("O número é negativo e ");
                }

                if (numero % 2 == 0) {
                    Console.Write("par!");
                } else {
                    Console.Write("ímpar!");
                }

                Console.WriteLine("");

                Console.Write("\nDeseja encerrar o programa?: ");
                opcao = char.Parse(Console.ReadLine()!);

            } while (opcao != 's');

            Console.ReadKey();
        }
    }
}