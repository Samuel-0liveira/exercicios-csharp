/*Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os
tempos registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
i. melhor tempo;
ii. a volta em que o melhor tempo ocorreu;
iii. tempo médio das N voltas
*/

using System.Net.Mail;

namespace Exercicio53
{
    class Program
    {
        static void Main(string[] args)
        {
            float melhorTempo, tempoMedio;
            int voltaDoMelhorTempo = 0;
            melhorTempo = 100;
            tempoMedio = 0;

            Console.Clear();

            Console.Write("Olá, informe o número de voltas do piloto: ");
            int quantidadeVoltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            float[] tempo = new float[quantidadeVoltas];

            for (int contador = 0; contador < quantidadeVoltas; contador++) {
                Console.Write("Informe o tempo da " + (contador + 1) + "º volta (minutos e segundos devem ser separados por vírgula): ");
                tempo[contador] = float.Parse(Console.ReadLine()!);
                Console.Clear();
            }
            
            for (int volta = 0; volta < quantidadeVoltas; volta++) {
                if (tempo[volta] < melhorTempo) {
                    melhorTempo = tempo[volta];
                    voltaDoMelhorTempo = volta;
                }
                tempoMedio += tempo[volta];
            }

            tempoMedio = tempoMedio / quantidadeVoltas;

            Console.WriteLine($"Esse foi o melhor tempo do piloto: {melhorTempo:n2}\nA volta do melhor tempo: {voltaDoMelhorTempo + 1}º volta\nTempo médio das voltas: {tempoMedio:n2}");
            Console.ReadKey();
        }
    }
}