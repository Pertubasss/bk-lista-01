namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Calcular o salário total de um vendedor.

Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão (5% sobre as vendas)
Fórmula: Salário total = Salário base + (Total de vendas * Comissão)
Exemplo de saída: O salário total do vendedor é R$ 2750.
             */

            decimal salarioBase, comissao, totalDeVendas, salarioTotal;

            Console.WriteLine("Entre com o salario base:");

            salarioBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o total de vendas:");
            totalDeVendas = decimal.Parse(Console.ReadLine());
            comissao = totalDeVendas * 0.05m;

            salarioTotal = salarioBase + comissao;


            Console.WriteLine("Salario total do vendedor é de :" + salarioTotal);
        }
    }
}
