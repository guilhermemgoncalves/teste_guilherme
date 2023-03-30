using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio
{
    internal class CarroEletrico: CarroBase
    {
        public  int Potencia { get; set; }
        public int DuracaoBateria { get; set; }

        public CarroEletrico()
        {
            this.VaricaoImpostoTipoVeiculo = -10;
        }
    }
}
