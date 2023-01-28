using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class ESRegistro : Controller
    {
        private db _registrar = null;

        public ESRegistro(db context)
        {

            _registrar = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult registrar(string codigoempleado)
        {
            string ver;
            DataTable mostrar = new DataTable();
            DateTime mifechaHora = DateTime.Now;
            DateTime fechasola = DateTime.Now;
            //var fechaS = fechasola.Date.ToString();
            string tipo = "entrada";
            var asistencia = new entidad
            {
                codigoempleado = codigoempleado,
                fechahora = mifechaHora,
                tipo = tipo,

                fecha = mifechaHora
            };


            ver = _registrar.EntradaSalida(asistencia);
            if (ver == "entradaI")
            {


                var codigoempleados = new entidad
                {


                    codigoempleado = codigoempleado

                };
                List<entidad> entidad = new List<entidad>();
                mostrar = _registrar.MostrarDatosAsistencia(codigoempleados);
                string nombr;
                for (int i = 0; i < mostrar.Rows.Count; i++)
                {
                    entidad entidad1 = new entidad();
                    entidad1.nombre = mostrar.Rows[i][0].ToString();
                    entidad1.apellidos = mostrar.Rows[i][1].ToString();
                    entidad.Add(entidad1);
                    ViewBag.n = entidad1.nombre;
                    ViewBag.ns = entidad1.apellidos;
                }
                ViewBag.e = tipo;
                ViewBag.fecha = mifechaHora;
                TempData["entrada"] = ViewBag.n;
                TempData["entradas"] = ViewBag.ns;
                TempData["fecha"] = ViewBag.fecha;
                TempData["tipoentrada"] = ViewBag.e;
                return RedirectToAction("Index", "ESRegistro");
                //prosigo a recuperar los datos en formato dataTable y luego lo convierto en una lista y luego lo 
                //envio a la vista con el tempdata

            }
          

            if (ver == "usuarioN")
            {
                TempData["msg"] = "USUARIO NO EXISTE";
                return RedirectToAction("Index", "ESRegistro");
            }
            //mostrar = _registrar.MostrarDatosAsistencia();

            return View();
        }

        public IActionResult registrarS(string codigoempleado)
        {
            string ver;
            DataTable mostrar = new DataTable();
            DateTime mifechaHora = DateTime.Now;
            DateTime fechasola = DateTime.Now;
            //var fechaS = fechasola.Date.ToString();
            string tipo = "salida";
            var asistencia = new entidad
            {
                codigoempleado = codigoempleado,
                fechahora = mifechaHora,
                tipo = tipo,

                fecha = mifechaHora
            };

            ver = _registrar.EntradaSalida(asistencia);
            if (ver == "salidaI")
            {


                var codigoempleados = new entidad
                {


                    codigoempleado = codigoempleado

                };
                List<entidad> entidad = new List<entidad>();
                mostrar = _registrar.MostrarDatosAsistencia(codigoempleados);
                for (int i = 0; i < mostrar.Rows.Count; i++)
                {
                    entidad entidad1 = new entidad();
                    entidad1.nombre = mostrar.Rows[i][0].ToString();
                    entidad1.apellidos = mostrar.Rows[i][1].ToString();
                    entidad.Add(entidad1);
                    ViewBag.n = entidad1.nombre;
                    ViewBag.ns = entidad1.apellidos;

                }

                ViewBag.e = tipo;
                ViewBag.fecha = mifechaHora;
                TempData["entrada"] = ViewBag.n;
                TempData["entradas"] = ViewBag.ns;
                TempData["fecha"] = ViewBag.fecha;
                TempData["tipoentrada"] = ViewBag.e;
                return RedirectToAction("Index", "ESRegistro");

            }
            if (ver == "usuarioN")
            {
                TempData["msg"] = "USUARIO NO EXISTE";
                return RedirectToAction("Index", "ESRegistro");
            }


            return View();

        }






    }
}
