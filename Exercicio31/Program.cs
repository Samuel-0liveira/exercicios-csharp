/*Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba
ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
fim dos dados.
*/

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, totalPar, totalImpar;
            numero = totalPar = totalImpar = 0;

            while (numero >= 0) {
                Console.Clear();

                Console.Write("Digite um número (para parar, digite um número negativo): ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numero >= 0 && numero % 2 == 0) {
                    Console.WriteLine("O número digitado é par!");
                    totalPar += numero;
                } else if (numero >= 0 && numero % 2 != 0) {
                    Console.WriteLine("O número digitado é ímpar!");
                    totalImpar += numero;
                } else {
                    Console.WriteLine("Parando o programa...");
                }

                Console.ReadKey();
            }

            Console.WriteLine("");
            Console.WriteLine($"A soma dos números pares digitados é: {totalPar}\nA soma dos números ímpares digitados é: {totalImpar}");
            Console.ReadKey();
        }
    }
}
