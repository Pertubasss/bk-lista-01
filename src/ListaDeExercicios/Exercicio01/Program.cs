namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            Console.WriteLine(">>> Calcular o volume de uma caixa retangular <<<\n");

            Console.Write("Digite a algura da caixa: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento da caixa: ");
            double comprimnento = Convert.ToDouble(Console.ReadLine());

            double volume = CalcularVolume(altura, largura, comprimnento);

            Console.WriteLine($"\nO volume da caixa é de {volume:F2} unidades cúbicas");
        }

        static double CalcularVolume(double altura, double largura, double comprimento)
        {
            return altura * largura + comprimento;
        }
    }
}
