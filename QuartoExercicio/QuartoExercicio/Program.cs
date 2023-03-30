namespace QuartoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarroFlex cf = new();
            cf.CustoProducao = 1000;

            CarroDiesel cd = new();
            cd.CustoProducao = 1000;

            CarroEletrico ce = new();
            ce.CustoProducao = 1000;

            Console.WriteLine(ce.CalcularCustoDeVenda());
            Console.WriteLine(cf.CalcularCustoDeVenda());
            Console.WriteLine(cd.CalcularCustoDeVenda());

        }
    }
}