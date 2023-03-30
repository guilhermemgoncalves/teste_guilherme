using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio
{
    internal class CarroFlex : CarroBase
    {
        public int NumeroDePortas { get; set; }
        public int Cilindrada { get; set; }

        public CarroFlex()
        {
            this.VaricaoImpostoTipoVeiculo = 0;
        }
    }
}
