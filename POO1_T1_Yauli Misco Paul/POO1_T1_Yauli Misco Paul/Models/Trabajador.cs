using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO1_T1_Yauli_Misco_Paul.Models
{
    public class Trabajador
    {
        public string dniTrab { get; set; }

        public string apeTrab { get; set; }
        public string nomTrab { get; set; }
        public DateTime fecContrato { get; set; }
        public string categoriaTrab { get; set; }

        public Trabajador(string dniTrab, string apeTrab, string nomTrab, DateTime fecContrato, string categoriaTrab)
        {
            this.dniTrab = dniTrab;
            this.apeTrab = apeTrab;
            this.nomTrab = nomTrab;
            this.fecContrato = fecContrato;
            this.categoriaTrab = categoriaTrab;
        }

        public Trabajador()
        {
            dniTrab = "";
            apeTrab = "";
            nomTrab = "";
            fecContrato = DateTime.Now;
            categoriaTrab = "A";
        }

        public int calculoSueldoBasico()
        {
            DateTime fecActual = DateTime.Now;
            int aniosTrabajando = fecActual.Year - fecContrato.Year;

            if( aniosTrabajando <= 3 )
            {
                return 1000;
            } else if (aniosTrabajando > 3 && aniosTrabajando <=5)
            {
                return 1500;
            } else if (aniosTrabajando > 5 && aniosTrabajando <=10)
            {
                return 2500;
            } else
            {
                return 3500;
            }
        }

        public double calculoBonificacionCategoria()
        {
            string[] categorias = { "A", "B", "C" };
            if (Array.Exists(categorias, el => el == categoriaTrab))
            {
                return calculoSueldoBasico()*0.1;
            } else
            {
                return calculoSueldoBasico() * 0.15;
            }
        }

        public double Monto()
        {
            return calculoSueldoBasico() + calculoBonificacionCategoria();
        }
    }
}