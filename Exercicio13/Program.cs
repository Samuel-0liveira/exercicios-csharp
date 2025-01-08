//Escreva um programa que leia 3 números inteiros e imprima natela os valores em ordem decrescente

using System;

namespace Execicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizarEmOrdemDecrescente();
            Console.ReadKey();
        }

        static void OrganizarEmOrdemDecrescente()
        {
            Console.Clear();

            int maior, meio, menor;
            maior = meio = menor = 0; 
            int[] numeros = new int[3];

            for(int contador = 0; contador < 3; contador++) {
                Console.Write("Por favor, digite o " + (contador + 1) + "° número: ");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            if (numeros[0] >= numeros[1] && numeros[0] >= numeros[2]) {
                maior = numeros[0];

                if (numeros[1] >= numeros[2]) {
                    meio = numeros[1];
                    menor = numeros[2];
                } else {
                    meio = numeros[2];
                    menor = numeros[1];
                }
            } else if (numeros[1] >= numeros[0] && numeros[1] >= numeros[2]) {
                maior = numeros[1];

                if (numeros[0] >= numeros[2]) {
                    meio = numeros[0];
                    menor = numeros[2];
                } else {
                    meio = numeros[2];
                    menor = numeros[0];
                }
            } else if (numeros[2] >= numeros[0] && numeros[2] >= numeros[1]) {
                maior = numeros[2];

                if (numeros[0] >= numeros[1]) {
                    meio = numeros[0];
                    menor = numeros[1];
                } else {
                    meio = numeros[1];
                    menor = numeros[0];
                }
            }

            Console.WriteLine($"Esses foram os números digitados, em ordem decrescente: {maior}, {meio}, {menor}");
        }
    }
}