namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius
             */

            int escolha;

            do
            {
                Console.WriteLine(">>> Conversão de temperatura <<<\n");

                Console.WriteLine("1 - Converter graus Fahrenheit para graus Celsius\n"
                    + "2 - Converter graus Celsius para graus Fahrenheit\n"
                    + "3 - Sair");

                escolha = Convert.ToInt16(Console.ReadLine());

                if (escolha < 0 || escolha > 3)
                {
                    Console.WriteLine("Escolha inválida. Por favor, digite uma uma opção válida\n");
                }
                else if (escolha == 3)
                {
                    Environment.Exit(0);
                }

                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite a temperatura em graus Fahrenheit que deseja converter: ");
                        double grausFahrenheit = Convert.ToDouble(Console.ReadLine());
                        double celsius = FahrenheitParaCelsius(grausFahrenheit);

                        Console.WriteLine($"{celsius:F2} graus celsius");
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em graus Celsius que deseja converter: ");
                        double grausCelsius = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = CelsiusParaFahrenheit(grausCelsius);

                        Console.WriteLine($"{fahrenheit:F2} graus fahrenheit");
                        break;
                }

                Console.WriteLine("\nDeseja realizar outra operação?\n");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");

                int stop = Convert.ToInt16(Console.ReadLine());

                if (stop == 2)
                    escolha = 3;

                Console.Clear();

            } while (escolha != 3);
        }

        static double FahrenheitParaCelsius(double grausFahrenheit)
        {
            return (grausFahrenheit - 32) * 5 / 9;
        }

        static double CelsiusParaFahrenheit(double grausCelsius)
        {
            return (grausCelsius * 9) / 5 + 32;
        }
    }
}
