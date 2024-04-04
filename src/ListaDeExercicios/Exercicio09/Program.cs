namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.
            Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
            Fórmula: IMC = Peso / (Altura^2)
            Exemplo de saída: IMC = 22.86 (Peso normal).
             */

            double peso, altura, imc;

            Console.WriteLine("Entre com seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }

        }
    }
}
