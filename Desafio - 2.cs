using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio__Primeiro_Projeto
{
    internal class Desafio__2
    {
        public static void Executar()
        {
            /* 1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5,
                escreva na tela "Nota suficiente para aprovação" */
            int notaMedia = 8;
            if (notaMedia >= 5)
            {
                Console.WriteLine("\nVocê foi aprovado!");
            }
            else
            {
                Console.WriteLine("Você foi reprovado!");
            }

            // 2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
            List<string> linguagensDeProgramacao = new List<string> { "C#", "Java", "JavaScript"};

            // 3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
            Console.WriteLine(linguagensDeProgramacao[0]);

            // 4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
            Console.WriteLine("Digite a posição desejada: ");
            int posicao = int.Parse(Console.ReadLine()!);

            Console.WriteLine(linguagensDeProgramacao[posicao]);
        }
    }
}
