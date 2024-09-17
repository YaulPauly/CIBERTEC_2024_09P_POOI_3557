using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00I_Tarea1
{
    internal class Coordinador
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int celular { get; set; }

        public const int COORDINADOR_ALTO = 8500;
        public const int COORDINADOR_MEDIO = 6850;
        public const int COORDINADOR_BAJO = 5500;

        public int calculateSalaryByCategory()
        {
            switch (categoria)
            {
                case 0: return COORDINADOR_ALTO;
                case 1: return COORDINADOR_MEDIO;
                case 2: return COORDINADOR_BAJO;
                default: return 0;
            }
        }
    }
}

