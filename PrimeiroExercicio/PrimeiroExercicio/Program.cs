namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a posição para localizar o numero na squencia Fibonacci: ");
            int posicao = int.Parse(Console.ReadLine());

            int resultado = CalcularFibonnaciPorPosicao(posicao);
            Console.WriteLine($"O número é {resultado}.");

        }

        private static int CalcularFibonnaciPorPosicao(int posicao)
        {
            int numeroAtual = 0;
            int proximoNumero = 1;
            int resultado = 0;

            for (int i = 2; i < posicao; i++)
            {
                resultado = numeroAtual + proximoNumero;
                numeroAtual = proximoNumero;
                proximoNumero = resultado;
            }

            return resultado;
        }
    }
}