using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P00I_Tarea1
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double estatura { get; set; }
        public double peso { get; set; }

        public string isAdult()
        {
            if (edad > 18)
            {
                return "mayor de edad";
            }
            else
            {
                return "menor de edad";
            }
        }

        public double calculateBodyMass()
        {
            double body_mass = peso / estatura;
            return Math.Round(body_mass, 2);
        }
    }
}
