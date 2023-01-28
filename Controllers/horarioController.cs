using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class horarioController : Controller
    {

        private readonly db _horarios = null;
        public static byte[] imagen11 = new byte[0];

        public horarioController(db context)
        {
            _horarios = context;


        }

        public IActionResult Index()
        {
            DataTable dt;

            List<entidad> entidad = new List<entidad>();
            dt = _horarios.LISTARHORARIOS();
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                entidad entidad1 = new entidad();

                entidad1.idhorario = dt.Rows[i][0].GetHashCode();
                entidad1.horaentrada =dt.Rows[i][1].ToString();
                entidad1.horasalida = dt.Rows[i][2].ToString();

                entidad.Add(entidad1);
                ViewBag.entidad = entidad;
                imagen11 = registrogeneralController.imagen2;
                string imagen = Convert.ToBase64String(imagen11);
                string imagenURL = string.Format("data:image/png;base64,{0}", imagen);

                ViewBag.imagenes = imagenURL;
            }
            return View();




        }

        [HttpPost]
        public IActionResult guardar(int idhorario, string time1, string time2)

        {
            if (idhorario<1)
            {
                try
                {

                    var guardarhorario = new entidad
                    {
                        horaentrada = time1,
                        horasalida = time2


                    };


                    _horarios.mantenimiento_horarios(guardarhorario);

                    return Json(new { success = true, message = "Guardado Exitoso" });


                }


                catch (Exception ex)
                {

                    return Json(String.Format("'success':'false','error': " + ex + " "));

                }


            }
            else { 
            try
            {

                var guardarhorario = new entidad
                {

                    idhorario=idhorario,
                    horaentrada=time1,
                    horasalida=time2


                };


                _horarios.EditarHorario(guardarhorario);

                return Json(new { success = true, message = "Guardado Exitoso" });


            }


            catch (Exception ex)
            {

                return Json(String.Format("'success':'false','error': " + ex + " "));

            }


            }





            return View();
        }


        public JsonResult listaridhorario(int idhorario)
        {

            DataTable dt;
            List<entidad> entidades = new List<entidad>();


            var id = new entidad
            {

               idhorario = idhorario
            };

            dt = _horarios.Listarhorariosid(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                entidad entidadess = new entidad();


                entidadess.idhorario = dt.Rows[i][0].GetHashCode();
                entidadess.horaentrada = dt.Rows[i][1].ToString();
                entidadess.horasalida = dt.Rows[i][2].ToString();

                entidades.Add(entidadess);
            }
            return Json(entidades);



        }


        [HttpGet]
        public JsonResult eliminarhorario(int idhorario)
        {
            bool respuesta;


            var eliminar = new entidad
            {

                idhorario = idhorario



            };
            respuesta = _horarios.Eliminarhorario(eliminar);
            return Json(new { respuesta = respuesta });
            //return Json(new { success = true, message = "eliminado Exitoso" });


        }


    }
}
