namespace SegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int linhas = 3;
            int colunas = 3;
            Console.WriteLine(RetornaMaior(matriz, linhas, colunas));
        }

        private static int RetornaMaior(int[,] matriz, int linhas, int colunas)
        {
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                }
            }

            if (pares > impares)
            {
                return pares;
            }
            else if (impares > pares)
            {
                return impares;
            }
            else
            {
                return -1;
            }
        }
    }
}