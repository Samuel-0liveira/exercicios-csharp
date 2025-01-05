/*Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCI DADE.
Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
tempo gasto,a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*/
using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoLitrosUsados();
            Console.ReadKey();
        }

        public static void CalculoLitrosUsados()
        {
            Console.Clear();

            Console.Write("Digite o tempo gasto na viagem em horas (caso sejam minutos, digite na frente um 0 seguido da , mais os minutos): ");
            float tempo = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Por favor, digite a velocidade média do veículo: ");
            float velocidade = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float distancia = tempo * velocidade;

            float litrosUsados = distancia / 12;

            Console.WriteLine($"A distância percorrida foi de: {distancia} km \nA quantidade de litros utilizada na viagem foi: {(litrosUsados):n2}L");
        }
    }
}