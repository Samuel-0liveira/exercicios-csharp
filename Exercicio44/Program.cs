/*Faça um programa que exiba as opções:
1- Conversão de Graus Celsius em Graus Fahrenheit
2- Conversão de Graus Fahrenheit em Graus Celsius
3- Peso ideal do homem
4- Peso ideal da mulher
Oprograma só deve encerrar quando o usuário digitar 'S' para a pergunta "Deseja encerrar o programa?"
Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal
*/

namespace Exercicio44
{
    class Program
    {
        static void Main(string[] args)
        {
            char encerrar = 'N';

            do {
                Console.Clear();

                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("");

                Console.Write("Escolha uma das opções: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        ConversaoDeCelsiusParaFahrenheit();
                        break;
                    case 2:
                        ConversaoFahrenheitParaCelsius();
                        break;
                    case 3:
                        PesoIdealHomem();
                        break;
                    case 4:
                        PesoIdealMulher();
                        break;
                    default:
                        Console.WriteLine("Opção inexistente digitada!");
                        break;
                }

                Console.WriteLine("");
                Console.Write("Deseja encerrar o programa? [S / N]: ");
                encerrar = char.Parse(Console.ReadLine()!);

            } while (encerrar != 'S');

            Console.ReadKey();
        }

        static void ConversaoDeCelsiusParaFahrenheit()
        {
            Console.Clear();

            Console.Write("Por favor, digite a temperatura em Celsius para converter em Fahrenheit: ");
            var celsius = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"O valor {celsius}°C convertido para Fahrenheit é igual a: {fahrenheit:n1}°F");
            Console.ReadKey();
        }

        static void ConversaoFahrenheitParaCelsius()
        {
            Console.Clear();

            Console.Write("Por favor, informe a temperatura em Fahrenheit para conversão em Celsius: ");
            float fahrenheit = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"O valor {fahrenheit}°F convertido em Celsius é: {celsius:n1}°C");
            Console.ReadKey();
        }

        static void PesoIdealHomem()
        {
            Console.Clear();

            Console.Write("Olá, digite a altura da pessoa: ");
            float altura = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o peso da pessoa: ");
            float peso = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float pesoIdeal = (72.7f * altura) - 58;

            Console.WriteLine($"Este é o peso ideal baseado na altura informada: {pesoIdeal:n1}");

            if (peso < pesoIdeal) {
                Console.WriteLine("A pessoa está abaixo do peso ideal!");
            } else if (peso > pesoIdeal) {
                Console.WriteLine("A pessoa está acima do peso ideal!");
            } else {
                Console.WriteLine("A pessoa está no peso ideal!");
            }

            Console.ReadKey();
        }

        static void PesoIdealMulher()
        {
            Console.Clear();

            Console.Write("Olá, digite a altura da pessoa: ");
            float altura = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o peso da pessoa: ");
            float peso = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float pesoIdeal = (62.1f * altura) - 44.7f;

            Console.WriteLine($"Este é o peso ideal baseado na altura informada: {pesoIdeal:n1}");

            if (peso < pesoIdeal) {
                Console.WriteLine("A pessoa está abaixo do peso ideal!");
            } else if (peso > pesoIdeal) {
                Console.WriteLine("A pessoa está acima do peso ideal!");
            } else {
                Console.WriteLine("A pessoa está no peso ideal!");
            }

            Console.ReadKey();
        }
    }
}