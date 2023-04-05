namespace Aula03_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            // Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            // Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            // E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            // total de vendas.


            // solicita o código do funcionário
            Console.WriteLine("Informe o código do funcionário:");
            int codigo = int.Parse(Console.ReadLine());

            // solicita o nome do funcionário
            Console.WriteLine("Informe o nome do funcionário:");
            string nome = Console.ReadLine();

            // solicita o salário base do funcionário
            Console.WriteLine("Informe o salário base do funcionário:");
            double salarioBase = double.Parse(Console.ReadLine());

            // solicita o total de vendas do funcionário
            Console.WriteLine("Informe o total de vendas do funcionário:");
            double totalVendas = double.Parse(Console.ReadLine());

            // verifica se o total de vendas é maior que R$ 500,00 e adiciona 5% ao salário base
            if (totalVendas > 500)
            {
                salarioBase += totalVendas * 0.05;
            }

            // verifica se o total de vendas é maior que R$ 1000,00 e adiciona 7% ao salário base
            if (totalVendas > 1000)
            {
                salarioBase += totalVendas * 0.07;
            }

            // verifica se o total de vendas é maior que R$ 5000,00 e adiciona 10% ao salário base
            if (totalVendas > 5000)
            {
                salarioBase += totalVendas * 0.1;
            }

            // exibe o salário final do funcionário com os bônus adicionados
            Console.WriteLine($"O salário final do funcionário {nome} é R$ {salarioBase.ToString("F2")}");
        }
    }
}