using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class ListarAsistencia : Controller
    {

        public static byte[] imagen11 = new byte[0];

        private readonly db _ListarAsistencia = null;

        public ListarAsistencia(db context)
        {


           _ListarAsistencia=context;


        }
        public IActionResult salir()
        {
            HttpContext.Session.Remove("sess_1");
            //HttpContext.Session.Remove("nombre");

            return RedirectToAction("index", "RegistrarAsistencia");


        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("sess_1") == null)
            {


                return RedirectToAction("index", "RegistrarAsistencia");


            }



            listarA();

            return View();
        }


        public IActionResult listarA()
        {


            




            DataTable dt;
            List<entidad> entidad = new List<entidad>();

            dt=_ListarAsistencia.ListarAsistencias();

            for (int i=0; i<dt.Rows.Count; i++)
            {

                entidad entidad1 = new entidad();
                entidad1.nombre= dt.Rows[i][0].ToString();
                entidad1.apellidos= dt.Rows[i][1].ToString();
                entidad1.nombreD= dt.Rows[i][2].ToString();
                entidad1.tipo= dt.Rows[i][4].ToString();
                entidad1.fechahora = (DateTime)dt.Rows[i][5];
                entidad1.codigoempleado=dt.Rows[i][6].ToString();
                entidad1.TardeTemprano = dt.Rows[i][7].ToString();
                entidad1.idasistencias = dt.Rows[i][8].GetHashCode();
                entidad.Add(entidad1);

                ViewBag.entidad = entidad;
                imagen11 = registrogeneralController.imagen2;
                string imagen = Convert.ToBase64String(imagen11);
                string imagenURL = string.Format("data:image/png;base64,{0}", imagen);
                ViewBag.imagen = imagenURL;

            }


            return View();

        }





    }
}
