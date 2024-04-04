namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcular o consumo de combustível por km.

Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.
            */
            decimal quilometragemInicial, quilometragemFinal, consumoCombustivel, consumoPorKm;

            Console.WriteLine("Calcular o consumo de combustível por quilômetro.");
            Console.WriteLine("\r\n\t Entre com a Quilometragem inicial:");
            quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\r\nEntre com a Quilometragem final:");
            quilometragemFinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\r\n Entre com o consumo de combustível:");
            consumoCombustivel = Convert.ToDecimal(Console.ReadLine());

            consumoPorKm = consumoCombustivel / (quilometragemFinal - quilometragemInicial);

            Console.WriteLine($"O consumo de combustível por quilômetro é de {consumoPorKm} litros/km.");
        }
    }
}
