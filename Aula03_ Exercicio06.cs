using System.Reflection.Emit;

namespace Aula03_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            // O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
            // O cálculo do imc = peso / (altura * altura)

            // IMC
            // menor que 18->baixo peso
            // maior que 18 e menor que 25->peso normal
            // maior que 25 e menor que 30->sobrepeso
            // maior que 30 e menor que 35->obesidade
            // maior que 35->obesidade grau sério

            Console.Write("Digite o nome da pessoa: ");  // Exibe uma mensagem solicitando o nome da pessoa
            string nome = Console.ReadLine();  // Lê o nome digitado pelo usuário e armazena na variável 'nome'

            Console.Write("Digite a altura da pessoa em metros: ");  // Exibe uma mensagem solicitando a altura da pessoa
            double altura = double.Parse(Console.ReadLine());  // Lê a altura digitada pelo usuário e converte para o tipo double, armazenando na variável 'altura'

            Console.Write("Digite o peso da pessoa em kg: ");  // Exibe uma mensagem solicitando o peso da pessoa
            double peso = double.Parse(Console.ReadLine());  // Lê o peso digitado pelo usuário e converte para o tipo double, armazenando na variável 'peso'

            double imc = peso / (altura * altura);  // Calcula o IMC da pessoa através da fórmula peso / (altura * altura) e armazena na variável 'imc'

            Console.WriteLine("O IMC de " + nome + " é " + imc.ToString("F2"));  // Exibe o valor do IMC da pessoa com duas casas decimais utilizando a variável 'nome' e 'imc'

            if (imc < 18)  // Se o IMC for menor que 18, a pessoa está com baixo peso
            {
                Console.WriteLine("Situação: Baixo Peso");
            }
            else if (imc >= 18 && imc < 25)  // Se o IMC for maior ou igual a 18 e menor que 25, a pessoa está com peso normal
            {
                Console.WriteLine("Situação: Peso Normal");
            }
            else if (imc >= 25 && imc < 30)  // Se o IMC for maior ou igual a 25 e menor que 30, a pessoa está com sobrepeso
            {
                Console.WriteLine("Situação: Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)  // Se o IMC for maior ou igual a 30 e menor que 35, a pessoa está com obesidade
            {
                Console.WriteLine("Situação: Obesidade");
            }
            else  // Se o IMC for maior ou igual a 35, a pessoa está com obesidade grau sério
            {
                Console.WriteLine("Situação: Obesidade Grau Sério");
            }
        }
    }
}