using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00I_Tarea1
{
    internal class Filmacion
    {
        public int codigo { get; set; }
        public string titulo { get; set; }

        public int minutos {  get; set; }
        public double precio_soles { get; set; }

        public const double TIPO_CAMBIO_DOLAR = 3.59;

        public double calculatePriceDollars()
        {
            return precio_soles * TIPO_CAMBIO_DOLAR;
        }
    }
}
