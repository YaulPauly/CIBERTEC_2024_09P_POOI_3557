using POO1_T1_Yauli_Misco_Paul.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO1_T1_Yauli_Misco_Paul.Controllers
{
    public class PlanillaController : Controller
    {
        public static int contador = 0;
        public static List<Asistente> listAsistente;

        public PlanillaController()
        {
            if (listAsistente == null)
            {
                listAsistente = new List<Asistente>();
                listAsistente.Add(new Asistente()
                {
                    dniTrab = "70184952",
                    apeTrab = "Yauli",
                    nomTrab = "Paul",
                    fecContrato = new DateTime(2000, 5, 15),
                    categoriaTrab = "D",
                    numeroHijos = 1,
                    gradoEducacion = "superior",
                });
                listAsistente.Add(new Asistente()
                {
                    dniTrab = "78459517",
                    apeTrab = "Chavez",
                    nomTrab = "Brandon",
                    fecContrato = new DateTime(2005, 5, 15),
                    categoriaTrab = "B",
                    numeroHijos = 4,
                    gradoEducacion = "secundaria",
                });
                contador = listAsistente.Count;
            }

            Debug.WriteLine("Ini LaptopController");
        }

        // GET: Planilla
        public ActionResult Index()
        {
            ViewBag.dniTrab = "80485178";
            ViewBag.apeTrab = "Yauli";
            ViewBag.nomTrab = "Paul";
            ViewBag.fecContrato = "2023-10-01";
            ViewBag.categoriaTrab = "D";

            return View();
        }

        [HttpGet]
        public ActionResult CreateTrabajador()
        {
            Trabajador objTrab = new Trabajador();
            return View(objTrab);
        }

        [HttpPost]
        public ActionResult CreateTrabajador(Trabajador objTrab)
        {

            Debug.WriteLine("Dni Trabajador : " + objTrab.dniTrab);
            Debug.WriteLine("Apellido : " + objTrab.apeTrab);
            Debug.WriteLine("Nombre : " + objTrab.nomTrab);
            Debug.WriteLine("Fecha Contrato : " + objTrab.fecContrato);
            Debug.WriteLine("Categoria : " + objTrab.categoriaTrab);

            ViewBag.SueldoBasico = objTrab.calculoSueldoBasico();
            ViewBag.Bonificacion = objTrab.calculoBonificacionCategoria();
            ViewBag.Monto = objTrab.Monto();

            return View(objTrab);
        }

        [HttpGet]
        public ActionResult CreateAsistente()
        {
            return View(new Asistente());
        }

        [HttpPost]
        public ActionResult CreateAsistente(Asistente objAsist)
        {
            Debug.WriteLine("Dni Trabajador : " + objAsist.dniTrab);
            Debug.WriteLine("Apellido : " + objAsist.apeTrab);
            Debug.WriteLine("Nombre : " + objAsist.nomTrab);
            Debug.WriteLine("Fecha Contrato : " + objAsist.fecContrato);
            Debug.WriteLine("Categoria : " + objAsist.categoriaTrab);
            Debug.WriteLine("Numero de hijos : " + objAsist.numeroHijos);
            Debug.WriteLine("Grado Educación : " + objAsist.gradoEducacion);

            string mensaje;
            Asistente asistExistente = listAsistente.Find(x => x.dniTrab == objAsist.dniTrab);
            if (asistExistente == null)
            {
                listAsistente.Add(objAsist);
                contador++;
                mensaje = "El asistente fue agregado a la lista";
                Debug.WriteLine("El dni ingresado no existe");
            }
            else
            {
                mensaje = "El asistente ya existe";
                Debug.WriteLine("El dni ingresado existe");
                Debug.WriteLine("Dni : " + asistExistente.dniTrab);
            }

            ViewBag.ContadorRegistros = contador;
            ViewBag.MensajeValidacion = mensaje;
            ViewBag.SueldoBasico = objAsist.calculoSueldoBasico();
            ViewBag.Escolaridad = objAsist.calculoEscolaridad();
            ViewBag.BonificaciónEspecial = objAsist.calculoBonificacionEspecial();
            ViewBag.Monto = objAsist.Monto();
            Debug.WriteLine("Total Registros : " + listAsistente.Count);
            return View(objAsist);
        }

        public ActionResult ListadoAsistente()
        {
            ViewBag.CantidadRegistrados = listAsistente.Count;
            return View(listAsistente);
        }
    }
}