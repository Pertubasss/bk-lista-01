namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius
             */
            Console.WriteLine("Informe a temperatura em fahrenheit:");

            double valorTemperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

            double temperaturaCelcius = (valorTemperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celcius é de {temperaturaCelcius} C");
        }
    }
}
