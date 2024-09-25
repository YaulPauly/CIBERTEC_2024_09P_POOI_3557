using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO1_T1_Yauli_Misco_Paul.Models
{
    public class Asistente : Trabajador
    {
        public int numeroHijos { get; set; }
        public string gradoEducacion { get; set; }

        public Asistente(string dniTrab, string apeTrab, string nomTrab, 
            DateTime fecContrato, string categoriaTrab, int numeroHijos, string gradoEducacion)
           : base(dniTrab, apeTrab, nomTrab, fecContrato, categoriaTrab)
        {
            this.numeroHijos = numeroHijos;
            this.gradoEducacion = gradoEducacion;
        }

        public Asistente()
        {
            numeroHijos = 0;
            gradoEducacion= "superior";
        }

        public int calculoSueldoBasico()
        {
            string gradoEducminus = gradoEducacion.ToLower();
            if (gradoEducminus == "secundaria")
            {
                return 950;
            }
            else if (gradoEducminus == "superior")
            {
                return 1500;
            }
            else
            {
                return 0;
            }
        }

        public int calculoBonificacion()
        {
            return 0;
        }

        public int calculoEscolaridad()
        {
            return numeroHijos * 95;
        }

        public double calculoBonificacionEspecial() 
        {
            DateTime fecActual = DateTime.Now;
            int aniosTrabajando = fecActual.Year - this.fecContrato.Year;

            if (aniosTrabajando <= 1)
            {
                return calculoSueldoBasico()*0.05;
            }
            else
            {
                return calculoSueldoBasico()*0.1;
            }
        }

        public double Monto()
        {
            return calculoSueldoBasico() + calculoEscolaridad() + calculoBonificacionEspecial();
        }

    }
}