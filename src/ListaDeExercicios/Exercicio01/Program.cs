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

            Console.WriteLine("Calculo do colume de uma caixa");
            Console.WriteLine("\r\n\t Entre com a altura da caixa:");
            var altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\nEntre com a largura da caixa:");
            var largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\n Entre com a comprimento da caixa:");
            var comprimento = Convert.ToDouble(Console.ReadLine());

            var volumeCaixa = altura * largura * comprimento;

            Console.WriteLine($"O volume da caixa é : {volumeCaixa}");
        }
    }
}
