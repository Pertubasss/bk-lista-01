namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a área de um terreno retangular.
            //Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
            //Fórmula: Área = Comprimento * Largura
            //Exemplo de saída: A área do terreno é 50 metros quadrados.

            Console.WriteLine(">>> Calcular a área de um terreno retangular <<<");

            Console.WriteLine("Digite o comprimento do terreno: ");
            double comprimentoTerreno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura do terreno: ");
            double larguraTerreno = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaTerreno(comprimentoTerreno, larguraTerreno);

            Console.WriteLine($"A área do terreno é de {area}m²");
        }

        static double CalcularAreaTerreno(double comprimentoTerreno, double larguraTerreno)
        {
            return comprimentoTerreno * larguraTerreno;
        }
    }
}