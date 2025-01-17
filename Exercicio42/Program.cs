//Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de
//um valor O, ou seja, o programa deve ficar executando até que a entrada seja igual a O (ZERO).

namespace Exercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, maior, menor;
            numero = maior = 0;

            menor = 100;

            do {
                Console.Clear();

                Console.Write("Por favor, digite um número (digite 0 para encerrar): ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (numero != 0) {
                    if (numero >= maior) {
                        maior = numero;
                    }

                    if (numero <= menor) {
                        menor = numero;
                    }
                } else {
                    Console.WriteLine("Encerrando...");
                }

            } while (numero != 0);

            Console.WriteLine("");
            Console.WriteLine($"O maior valor digitado foi: {maior}\nO menor valor digitado foi: {menor}");
        }
    }
}