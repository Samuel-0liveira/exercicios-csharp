/*A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe
para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades,se o índice atingir 0,5 todos os grupos
devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e
emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o
usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".
*/

namespace Exercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            char encerrar = 'n';

            do {
                Console.Clear();

                Console.Write("Olá, digite o índice de poluição(0,05 - 0,5): ");
                decimal indicePoluicao = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine("");

                if (indicePoluicao >= 0.05m && indicePoluicao <= 0.25m) {
                    Console.WriteLine("O índice de poluição se encontra aceitável!");
                } else if (indicePoluicao >= 0.3m && indicePoluicao < 0.4m) {
                    Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades!");
                } else if (indicePoluicao >= 0.4m && indicePoluicao < 0.5m) {
                    Console.WriteLine("Indústrias do 1º e 2º grupo devem suspender suas atividades!");
                } else if (indicePoluicao >= 0.5m) {
                    Console.WriteLine("Indústrias de todos os grupos devem suspender suas atividades!");
                } else {
                    Console.WriteLine("O valor digitado está fora dos índices para validação!");
                }

                Console.WriteLine("");

                Console.Write("Deseja encerrar o programa? [S / N]");
                encerrar = char.Parse(Console.ReadLine()!);

            } while (encerrar != 'S');

            Console.WriteLine("Encerrando programa...");
            Console.ReadKey();
        }
    }
}