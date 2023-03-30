using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio
{
    internal abstract class CarroBase
    {
        public string NumeroChassi { get; set; }
        public int NumeroMotor { get; set; }
        public int ImpostoBase { get;  set; } = 20;
        public int VaricaoImpostoTipoVeiculo { get; set; } = 0;
        public int LucroFabrica { get;  set; } = 25;
        public double CustoProducao { get; set; }


        public double CalcularCustoDeVenda()
        {
            double ImpostoTotal = (double)(ImpostoBase + LucroFabrica + VaricaoImpostoTipoVeiculo) / 100;
            Console.WriteLine(ImpostoTotal);
            return this.CustoProducao * (1+ ImpostoTotal);
        }
        

    }
}
