/*Fazer um programa que sorteie um número de O a 100 e que permita que o usuário (sem conhecer o número 
sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número 
sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de
tentativas feitas
*/

namespace Exercicio50
{
    class Program {
        static void Main(string[] args)
        {
            Console.Clear();

            Random aleatorio = new Random();
            Console.WriteLine("Sorteando um número...");
            int numeroAleatorio = aleatorio.Next(0, 100);

            int palpite = 200;
            int tentativas = 0;

            while (palpite != numeroAleatorio) {
                Console.Clear();

                Console.Write("Tente acertar o número sorteado: ");
                palpite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numeroAleatorio > palpite) {
                    Console.WriteLine("Ops, o número sorteado é maior que o seu palpite!");
                    tentativas++;
                    Console.ReadKey();
                } else if (numeroAleatorio < palpite) {
                    Console.WriteLine("Ops, o número sorteado é menor que o seu palpite!");
                    tentativas++;
                    Console.ReadKey();
                } else {
                    Console.WriteLine("Parabêns! Você acertou o número sorteado!");
                    tentativas++;
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine($"Essas foram as quantidades de tentativas até acertar o valor: {tentativas}");
            Console.ReadKey();
        }
    }
}