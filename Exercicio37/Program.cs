/*Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
seguintes opções:
1-Adição
2 - Subtração
3 - Multiplicação
4 - Divisão
Informea opção:
A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o
programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
menu principal. Caso a resposta seja 'S' ou 's', deverá voltar ao menu, caso contrário deverá encerrar o
programa.
*/

namespace Exercicio37
{
    class Program 
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            char sair = 's';

            do {
                Console.Clear();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("");

                Console.Write("Qual operação deseja realizar?: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch(opcao)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    default:
                        Console.WriteLine("Opção inexistente digitada.");
                        break;
                }

                Console.ReadKey();

                Console.WriteLine("");
                Console.Write("Deseja voltar ao menu principal? [1 - S / 2 - N]");
                sair = char.Parse(Console.ReadLine()!);

            } while (sair.Equals('S') || sair.Equals('s'));
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numeroA = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numeroB = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma dos valores é: {numeroA + numeroB:n1}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numeroA = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numeroB = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração dos valores é: {numeroA - numeroB:n1}");
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numeroA = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numeroB = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação dos valores é: {numeroA * numeroB:n1}");
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float numeroA = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            float numeroB = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão dos valores é: {numeroA / numeroB:n1}");
        }
    }
}