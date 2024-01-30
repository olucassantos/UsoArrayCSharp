using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que solicite o nome de 10 alunos,
                e também sua idade. Ao final mostre uma lista de
                alunos.

                Use um vetor para o nome e outro para idade.
            */

            string[] alunos = new string[5];
            int[] idades = new int[5];

            Console.WriteLine("Bem vindo ao sistema");
            Console.WriteLine("Informe o nome e idade dos alunos para processmento");

            // alunos.Length é o comprimento do vetor de alunos

            // Executa uma vez para cada item no vetor
            for (int index = 0; index < alunos.Length; index++)
            {
                // Solicita o nome do aluno
                Console.WriteLine($"Qual o nome do aluno {index + 1}?");
                string nome = Console.ReadLine();

                // Solicita a idade do aluno
                Console.WriteLine($"Qual a idade do aluno {index + 1}?");
                int idade;
                int.TryParse(Console.ReadLine(), out idade);

                alunos[index] = nome;
                idades[index] = idade;

                // Limpar a tela
                Console.Clear();
            }

            // Laço de repetição que percorre todos os alunos
            Console.WriteLine($"LISTA DE ALUNOS");
            for (int index = 0; index < alunos.Length; index++)
            {
                Console.WriteLine($"{index + 1} - {alunos[index]} - Idade {idades[index]}");
            }
        }
    }
}
