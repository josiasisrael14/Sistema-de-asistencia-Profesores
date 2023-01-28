using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class ReporteAsistenciaController : Controller
    {
        public static byte[] imagen11 = new byte[0];
        private readonly db _reporteasistencia = null;

        public ReporteAsistenciaController(db context)
        {


            _reporteasistencia=context;

        }

        public IActionResult salir()
        {
            HttpContext.Session.Remove("sess_1");
            //HttpContext.Session.Remove("nombre");

            return RedirectToAction("index", "RegistrarAsistencia");


        }

        [HttpPost]
        public IActionResult listarReporteAsistencia(string idempleados, DateTime fechainicio, DateTime fechafin)
        {


          

            int recordsTotal = 0;
            //idempleados = "U0007";

            byte[] resultado = null;

            DataTable dt = new DataTable();

            var reporte = new entidad
            {
                idempleados = idempleados,
                fechainicio1 = fechainicio,
                fechafin1 = fechafin

            };
            List<entidad> entidad = new List<entidad>();
            dt = _reporteasistencia.D_AsistenciaReporte(reporte);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                entidad entidad1 = new entidad();
                entidad1.nombre = dt.Rows[i][0].ToString();
                entidad1.tipo = dt.Rows[i][1].ToString();
                entidad1.fechahora = (DateTime)dt.Rows[i][2];
                entidad1.codigoempleado = dt.Rows[i][3].ToString();
                entidad.Add(entidad1);


            }
           

            return Json(new { data = entidad });

            //return Json(entidad);


        }

        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("sess_1") == null)
            {


                return RedirectToAction("index", "RegistrarAsistencia");


            }


            DataTable dt1 = new DataTable();
            List<entidad> entidad2 = new List<entidad>();
            dt1 = _reporteasistencia.LISTAREMPLEADOS1();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                entidad entidad3 = new entidad();
                entidad3.idempleados = dt1.Rows[i][0].ToString();
                entidad3.nombre = dt1.Rows[i][1].ToString();
                entidad2.Add(entidad3);
               

            }


            List<SelectListItem> items = entidad2.ConvertAll(d =>
            {
                return new SelectListItem()
                {

                    Text = d.nombre.ToString(),
                    Value = d.idempleados.ToString(),
                    Selected = false



                };





            });
            imagen11 = registrogeneralController.imagen2;
            //imagen11 = ListarAsistencia.imagen11;
            string imagen = Convert.ToBase64String(imagen11);
            string imagenURL = string.Format("data:image/png;base64,{0}", imagen);
            ViewBag.imagen = imagenURL;
            ViewBag.item = items;

            return View();
           
        }



    }
}
