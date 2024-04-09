namespace Exercicios
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Calcular o Índice de Massa Corporal(IMC) e determinar a condição de peso de um adulto.

            //Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
            //Fórmula: IMC = Peso / (Altura^2)
            //Exemplo de saída: IMC = 22.86 (Peso normal).

            Console.WriteLine(">>> Calculadora Indice de Massa Corporal (IMC) <<<\n");

            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double result = CalcularIMC(peso, altura);

            Console.Write($"\nIMC = {result:F2}");

            if (result < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (result >= 18.5 && result < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}
