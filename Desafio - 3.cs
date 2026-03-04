using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio__Primeiro_Projeto
{
    internal class Desafio__3
    {
        public static void Executar()
        {
            /* 1. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas
                  (adição, subtração, divisão e multiplicação), utilizando interpolação de strings. */
            int a = 12;
            int b = 16;
            void OperacoesBasicas()
            {
                float a = 12;
                float b = 16;
                Console.WriteLine($"\nA soma de {a} mais {b} é de: {a+b}");
                Console.WriteLine($"A subtração de {a} menos {b} é de: {a-b}");
                Console.WriteLine($"A divisão de {a} por {b} é de: {a/b}");
                Console.WriteLine($"A multiplicação de {a} vezes {b} é de: {a*b}");
            }
            OperacoesBasicas();

            // 2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
            List<string> bandas = new List<string>();
            bandas.Add("\nGrupo Revelação");
            bandas.Add("Soweto");

            // 3. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
            for (int i = 0; i < bandas.Count; i++)
            {
                Console.WriteLine(bandas[i]);
            }

            // 4. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
            List<int> numeros = new List<int> {1, 2, 3, 4};
            int soma = 0;

            foreach (int numero in numeros)
            {
                soma += numero;
            }

            Console.WriteLine($"\nA soma dos elementos da lista é: {soma}");

        }
    }
}
