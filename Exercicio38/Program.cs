/*Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um
operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a
50, calcule o excesso de pagamento armazenando -o na variável E, caso contrário zerar tal variável. A hora
excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O
programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
programa?"
*/

using System.Globalization;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            char encerrar = 'n';
            float salario, salarioExcedente, salarioTotal;
            int e = 0;
            salario = salarioExcedente = salarioTotal = 0;
            var formatacao = CultureInfo.CreateSpecificCulture("pt-Br");


            do
            {
                Console.Clear();

                Console.Write("Olá, digite o código do operário: ");
                string c = Console.ReadLine()!;
                Console.WriteLine("");

                Console.Write("Digite agora as horas trabalhadas (Mín 1): ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (n > 50) {
                    e = n - 50;
                    salario = 50 * 10.00f;
                } else {
                    e = 0;
                    salario = n * 10.00f;
                }

                salarioExcedente = e * 20.00f;

                salarioTotal = salario + salarioExcedente;

                Console.WriteLine($"Código do operário: {c}\nSalário excedente: {salarioExcedente.ToString("C",formatacao)}\nSalário total: {salarioTotal.ToString("C", formatacao)}");
                Console.WriteLine("");

                Console.WriteLine("Deseja encerrar o programa? [s/n]: ");
                encerrar = char.Parse(Console.ReadLine()!);

            } while (encerrar != 's');

            Console.ReadKey();
        }
    }
}