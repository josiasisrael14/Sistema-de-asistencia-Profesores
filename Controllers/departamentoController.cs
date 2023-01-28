using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class departamentoController : Controller
    {
       

        public static byte[]imagen11=new byte[0];
        public System.Collections.Generic.List<entidad> entidad { get; set; }
        private readonly db _departamento = null;


        public departamentoController(db context)
        {

            _departamento=context;


        }

        public IActionResult salirr()
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


            DataTable dt;

            List<entidad> entidad = new List<entidad>();
            dt = _departamento.D_ListarDepartamentos();

            for (int i = 0; i < dt.Rows.Count; i++)
            {


                entidad entidad1 = new entidad();
               
                entidad1.nombreD = dt.Rows[i][0].ToString();
                entidad1.descripcion = dt.Rows[i][1].ToString();
                entidad1.fechacreadaD = (DateTime)dt.Rows[i][2];
                entidad1.iddepartamento = dt.Rows[i][3].GetHashCode();
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
        public IActionResult guardar(int iddepartamento, string nombreD,string descripcion)
        {
            DateTime mifecha = DateTime.Now;
            if (iddepartamento <1)
            {
                try
                {

                    var guardar = new entidad
                {
                 nombreD = nombreD,
                 descripcion = descripcion,
                 fechacreadaD=mifecha



                };


                _departamento.mantenimiento_Departamento(guardar);

                return Json(new { success = true, message = "Guardado Exitoso" });


            }


            catch (Exception ex)
            {

                    return Json(String.Format("'success':'false','error': " + ex + " "));

                }




            }
            else
            {
                try
                {

                    var editar = new entidad
                    {
                        nombreD = nombreD,
                        descripcion = descripcion,
                        fechacreadaD = mifecha,
                        iddepartamentos=iddepartamento


                    };


                    _departamento.Editar_Departamento(editar);

                    return Json(new { success = true, message = "Guardado Exitoso" });


                }


                catch (Exception ex)
                {

                    return Json(String.Format("'success':'false','error': " + ex + " "));

                }











            }

            return View();

    }



        public JsonResult listaridD(int iddepartamento)
        {
            DataTable dt;
            List<entidad> entidades = new List<entidad>();


            var id = new entidad
            {

                iddepartamentos = iddepartamento
            };

            dt = _departamento.ListarDepa(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                entidad entidadess = new entidad();

               
                entidadess.nombreD = dt.Rows[i][0].ToString();
                entidadess.descripcion = dt.Rows[i][1].ToString();
                entidadess.fechacreadaD = (DateTime)dt.Rows[i][2];
                entidadess.iddepartamentos = dt.Rows[i][3].GetHashCode();
               
                entidades.Add(entidadess);
            }
            return Json(entidades);




        }

        //[HttpDelete]
        [HttpGet]
        public JsonResult eliminar(int iddepartamento)
        {
            bool respuesta;
           
            
              var eliminar = new entidad{

                    iddepartamentos = iddepartamento



                };
               respuesta= _departamento.EliminarDepartamento(eliminar);
            return Json(new { respuesta = respuesta });
            //return Json(new { success = true, message = "eliminado Exitoso" });


        }


    }


}