namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcular a área de um terreno retangular.

Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
Fórmula: Área = Comprimento * Largura
Exemplo de saída: A área do terreno é 50 metros quadrados.

             */
            Console.WriteLine("Calculo area terreno");
            Console.WriteLine("\r\n\t Entre com o comprimento:");
            var comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\r\nEntre com a largura:");
            var largura = Convert.ToDouble(Console.ReadLine());


            var areaTerreno = largura * comprimento;

            Console.WriteLine($"Area do terreno é de : {areaTerreno}");
        }
    }
}
