using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio
{
    internal class CarroDiesel : CarroBase
    {
        public int CapacidadeCarga { get; set; }
        public int VolumeCancamba { get; set; }

        public CarroDiesel()
        {
            this.VaricaoImpostoTipoVeiculo = +10;
        }
    }
}
