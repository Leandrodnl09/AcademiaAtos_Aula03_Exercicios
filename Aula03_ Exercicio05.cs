using System.Xml.Linq;

namespace Aula03_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            // se a média das duas notas for maior ou igual a 7, 0.

            // Caso a média seja inferior a 7, 0, o programa deve ler a nota do exame e calcular a média final,
            // é a média entre a nota do exame e a média das 2 notas.
            // Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            // escrever “Reprovado”.

            double nota1, nota2, exame, media, mediaFinal; // Declara as variáveis que serão utilizadas no programa

            Console.Write("Digite a primeira nota do aluno: "); // Imprime a mensagem na tela solicitando a primeira nota
            nota1 = double.Parse(Console.ReadLine()); // Lê a entrada do usuário como uma string, converte para float e armazena na variável nota1

            Console.Write("Digite a segunda nota do aluno: "); // Imprime a mensagem na tela solicitando a segunda nota
            nota2 = double.Parse(Console.ReadLine()); // Lê a entrada do usuário como uma string, converte para float e armazena na variável nota2

            media = (nota1 + nota2) / 2; // Calcula a média das notas e armazena o resultado na variável media

            if (media >= 7.0)
            { // Verifica se a média é maior ou igual a 7.0
                Console.WriteLine("Aprovado"); // Se for, imprime na tela a mensagem "Aprovado"
            }
            else
            { // Caso contrário
                Console.Write("Digite a nota do exame: "); // Imprime a mensagem na tela solicitando a nota do exame
                exame = double.Parse(Console.ReadLine()); // Lê a entrada do usuário como uma string, converte para float e armazena na variável exame

                mediaFinal = (media + exame) / 2; // Calcula a média final e armazena o resultado na variável mediaFinal

                if (mediaFinal >= 5.0)
                { // Verifica se a média final é maior ou igual a 5.0
                    Console.WriteLine("Aprovado"); // Se for, imprime na tela a mensagem "Aprovado"
                }
                else
                { // Caso contrário
                    Console.WriteLine("Reprovado"); // Imprime na tela a mensagem "Reprovado"
                }
            }
    }
}