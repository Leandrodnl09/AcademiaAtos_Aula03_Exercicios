using System.Drawing;
using System.Net;

namespace Aula03_Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            // diária de um paciente diabético.Para cada valor recebido analisar e informar ao paciente o seguinte:
            // Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            // Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.


            // Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for
            // menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            // 150, avisá - lo que será necessário adicionar 2 unidades de insulina.


            // Declaração das variáveis que irão armazenar os valores de glicemia
            double glicemia1, glicemia2, glicemia3;

            // Solicita ao usuário que digite os valores de glicemia
            Console.WriteLine("Digite o valor da primeira medição de glicemia em jejum:");
            glicemia1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda medição de glicemia em jejum:");
            glicemia2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira medição de glicemia em jejum:");
            glicemia3 = double.Parse(Console.ReadLine());

            // Verifica se cada valor de glicemia está dentro da faixa normal
            if (glicemia1 < 65)
            {
                Console.WriteLine("Atenção: Risco de hipoglicemia na primeira medição!");
            }
            else if (glicemia1 > 250)
            {
                Console.WriteLine("Atenção: Risco de hiperglicemia na primeira medição!");
            }

            if (glicemia2 < 65)
            {
                Console.WriteLine("Atenção: Risco de hipoglicemia na segunda medição!");
            }
            else if (glicemia2 > 250)
            {
                Console.WriteLine("Atenção: Risco de hiperglicemia na segunda medição!");
            }

            if (glicemia3 < 65)
            {
                Console.WriteLine("Atenção: Risco de hipoglicemia na terceira medição!");
            }
            else if (glicemia3 > 250)
            {
                Console.WriteLine("Atenção: Risco de hiperglicemia na terceira medição!");
            }

            // Calcula a média dos 3 valores de glicemia
            double media = (glicemia1 + glicemia2 + glicemia3) / 3;

            // Verifica se é necessário diminuir ou adicionar unidades de insulina
            if (media < 80)
            {
                Console.WriteLine("Atenção: É preciso diminuir 2 unidades de insulina!");
            }
            else if (media > 150)
            {
                Console.WriteLine("Atenção: É necessário adicionar 2 unidades de insulina!");
            }
        }
    }
}