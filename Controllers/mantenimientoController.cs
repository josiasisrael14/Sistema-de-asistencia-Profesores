using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace REGISTROASISTENCIA.Controllers
{
    public class mantenimientoController : Controller
    {

        //private readonly db _mantenimiento;
        //private readonly registroDBContext _context;
      private readonly db _mantenimiento;
      private readonly IWebHostEnvironment _hostEnvironment;
        //private readonly IHostingEnvironment _hostingEnvironment;

        public mantenimientoController(db mantenimiento, IWebHostEnvironment hostEnvironment)
        {

            //this._context = mantenimiento ?? throw new ArgumentNullException();

            _mantenimiento = mantenimiento;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
 public IActionResult guardar(string idempleados ,string nombre,string apellidos,string logeo,string password, int iddepartamento,string idtipoempleado,int idhorario ,string email,string codigoempleado, IFormFile archivoImagen)
        {
            string accion;
            //string mifecha = DateTime.Now.ToShortDateString();
            DateTime mifecha = DateTime.Now;
            //idempleados = "0";
            string Ruta = "";
            var file = archivoImagen;
            byte[] imagendata = null;

            if (string.IsNullOrEmpty(idempleados))
            {

                accion = "1";
                try
                {


                    if (file == null)
                    {


                        using (var ms1 = new MemoryStream())
                        {

                            imagendata = ms1.ToArray();


                        }




                    }
                    else { 

                        //string Ruta = "";
                        //var file = archivoImagen;
                        //var exist = System.IO.File.Exists(file);

                        //if (File.Exists(archivoImagen))
                        //{
                        //}

                        //var filename = Path.GetFileName(file.FileName);
                        //Stream stream = file.InputStream;
                        //Ruta = string.Format("imagenes/imagenes1", filename);

                        string imagenes = Path.Combine(_hostEnvironment.ContentRootPath, "imagenes");
                        Directory.CreateDirectory(imagenes);
                        string filepath = Path.Combine(imagenes, file.FileName);

                        using (Stream fileStream = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                        {

                            file.CopyTo(fileStream);

                        }

                        //string oPath = HttpContext.Current.Server.MapPath("~" + Ruta);

                        //byte[] imagendata = null;
                        using (var fs1 = archivoImagen.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {


                            fs1.CopyTo(ms1);
                            imagendata = ms1.ToArray();



                        }


                    }


                    var guardar = new entidad

                        {
                            idempleados = "0",
                            nombre = nombre,
                            apellidos = apellidos,
                            logeo = logeo,
                            password = password,
                            iddepartamento = iddepartamento,
                            idtipoempleado = idtipoempleado,
                            idhorario= idhorario,
                            email = email,
                            codigoempleado = codigoempleado,
                            imagen = imagendata,
                            accion = accion,
                            usuariocreado = "abi",
                            estado = 1,
                            fechacreado = mifecha
                        };



                        _mantenimiento.D_mantenimientousuarios(guardar);

                        return Json(new { success = true, message = "Guardado Exitoso" });

                    }

                catch (Exception ex)
                {




                    return Json(String.Format("'success':'false','error': " + ex + " "));


                }



           


            }
            else
            {


                accion = "2";

                try
                {

                  
                    if (file == null)
                    {
                        
                        //byte[] imagendata = null;
                        //using (var fs1 = archivoImagen.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {

                            //var nul = nulo;
                            //fs1.CopyTo(ms1);
                            imagendata = ms1.ToArray();




                        }

                    }


                    else
                    {
                        string imagenes = Path.Combine(_hostEnvironment.ContentRootPath, "imagenes");

                        //if (Directory.Exists(imagenes))
                        //{

                        string filepath = Path.Combine(imagenes, file.FileName);

                        using (Stream fileStream = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                        {

                            file.CopyTo(fileStream);

                        }






                        //byte[] imagendata = null;
                        using (var fs1 = archivoImagen.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {


                            fs1.CopyTo(ms1);
                            imagendata = ms1.ToArray();



                        }



                    }



                    //Directory.CreateDirectory(imagenes);
                    //string filepath = Path.Combine(imagenes, file.FileName);

                    //using (Stream fileStream = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                    //{

                    //    file.CopyTo(fileStream);

                    //}

                    //string oPath = HttpContext.Current.Server.MapPath("~" + Ruta);




                    var guardar = new entidad

                    {
                        idempleados = idempleados,
                        nombre = nombre,
                        apellidos = apellidos,
                        logeo = logeo,
                        password = password,
                        iddepartamento = iddepartamento,
                        idtipoempleado = idtipoempleado,
                        idhorario = idhorario,
                        email = email,
                        codigoempleado = codigoempleado,
                        imagen = imagendata,
                        accion = accion,
                        usuariocreado = "abi",
                        estado = 1,
                        fechacreado = mifecha
                    };



                    _mantenimiento.D_mantenimientousuarios(guardar);

                    return Json(new { success = true, message = "Guardado Exitoso" });

                }

                catch (Exception ex)
                {




                    return Json(String.Format("'success':'false','error': " + ex + " "));


                }




            }

            //string Ruta = "";
            //var file = archivoImagen;










        }



        [HttpGet]
        public JsonResult eliminarr(string idempleados)
        {
            bool respuesta;


            var eliminar = new entidad
            {

                idempleados = idempleados



            };
            respuesta = _mantenimiento.EliminarUsuario(eliminar);
            return Json(new { respuesta = respuesta });
            //return Json(new { success = true, message = "eliminado Exitoso" });


        }



        //return View();

    }


    }
