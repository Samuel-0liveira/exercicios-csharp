/*Faça um programa que leia 1O valores inteiros e positivos e:
- Encontre o maior valor
- Encontre o menor valor
- Calcule a média dos números lidos
*/

namespace Exercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            PedirValores();
            Console.ReadKey();
        }

        static void PedirValores()
        {
            Console.Clear();

            int[] valores = new int[10];

            for (int contador = 0; contador < 10; contador++) {
                Console.Write("Digite um valor: ");
                valores[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Analisando valores lidos....");
            Console.WriteLine("");

            AnaliseDeValores(valores);
        }

        static void AnaliseDeValores(int[] numeros)
        {
            int maior, menor, totalValores;
            maior = totalValores = 0;
            menor = 100;
            
            for (int contador = 0; contador < 10; contador++) {
                if (numeros[contador] >= maior) {
                    maior = numeros[contador];
                }

                if (numeros[contador] <= menor) {
                    menor = numeros[contador];
                }

                totalValores += numeros[contador];
            }

            int media = totalValores / 10;

            Console.WriteLine($"Maior valor digitado: {maior}\nMenor valor digitado: {menor}\nA média dos valores inseridos é: {media}");
        }
    }
}