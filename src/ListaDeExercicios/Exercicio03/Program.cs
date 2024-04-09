namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
              Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
              Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.
            */

            Console.WriteLine(">>> Calculo para consumo de combustível por km rodado <<<\n");

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustivel utilizado (l): ");
            double fuelConsum = Convert.ToDouble(Console.ReadLine());

            double consumo = (kmFinal - kmInicial) / fuelConsum;

            Console.WriteLine($"\nO consumo de combustível por km rodado é de {consumo:F2}km/l");
        }
    }
}
