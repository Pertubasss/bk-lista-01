namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar se a soma de A + B é menor que C.

            //Exemplo de entrada: A = 5, B = 3, C = 10
            //Exemplo de saída: A + B é menor que C.

            int continuar;

            do
            {
                Console.WriteLine(">>> Verificar se a soma de A +B é menor que C <<<");

                Console.Write("Digite o valor de A: ");
                double valorA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor de B: ");
                double valorB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor de C: ");
                double valorC = Convert.ToDouble(Console.ReadLine());

                string result = Validacao(valorA, valorB, valorC);

                Console.WriteLine(result);

                Console.WriteLine("Deseja realizar outra verificação?\n"
                    + "0 - Sair\n"
                    + "Qualquer tecla para continuar");

                continuar = Convert.ToInt32(Console.ReadLine());

            } while (continuar != 0);
        }

        static string Validacao(double valorA, double valorB, double valorC)
        {
            if (valorA + valorB > valorC)
            {
                return ($"A soma dos valores A: {valorA} + B: {valorB} é maior que C: {valorC}");
            }
            else
            {
                return ($"A soma dos valores A: {valorA} + B: {valorB} é menor que C: {valorC}");
            }
        }
    }
}