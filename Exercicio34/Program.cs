/*Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
fim dos dados.
*/

namespace Exercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor, numero;
            menor = 100;
            maior = numero = 0;

            while (numero >= 0) {
                Console.Clear();

                Console.Write("Por favor, digite um número (caso queira parar, digite um valor negativo): ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numero < 0) {
                    Console.WriteLine("Encerrando...");
                } else {
                    if (numero >= maior) {
                        maior = numero;
                    }
                    
                    if (numero <= menor) {
                        menor = numero;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"O maior número digitado foi: {maior}\nO menor digitado foi: {menor}");
            Console.ReadKey();
        }
    }
}