namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Calcular o salário total de um vendedor.
                //Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão(5 % sobre as vendas)
                //Fórmula: Salário total = Salário base + (Total de vendas *Comissão)
                //Exemplo de saída: O salário total do vendedor é R$ 2750.

                Console.WriteLine(">>> Calcular salário total de um vendedor <<<\n");

                Console.Write("Digite o valor do salário base: ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor total de vendas: ");
                double totalVendas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor (%) da comissão: ");
                double comissao = Convert.ToDouble(Console.ReadLine());

                double salarioTotal = CalcularSalarioTotal(salarioBase, totalVendas, comissao);

                Console.WriteLine($"O salário total do vendedor é de R${salarioTotal:F2}");
            }

            static double CalcularSalarioTotal(double salarioBase, double totalVendas, double comissao)
            {
                return salarioBase + (totalVendas * comissao / 100);
            }
        }
    }

}