using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using REGISTROASISTENCIA.Models;

namespace REGISTROASISTENCIA.Controllers
{
    public class escritorioController : Controller
    {
        public static byte[] imagen1 = new byte[0];
        public List<entidad> entidad { get; set; }
        private readonly db _login=null;

        public escritorioController(db context)
        {

            _login = context;



        }



        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("sess_1") == null)
            {


                return RedirectToAction("index", "RegistrarAsistencia");


            }



           







            DataTable dt;
            DataTable dt1;
            DataTable dt2;
            DataTable dth;

            List<entidad> entidad = new List<entidad>();


            dt = _login.LISTAREMPLEADOS();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                entidad entidad1 = new entidad();
                entidad1.idempleados=dt.Rows[i][0].ToString();
                entidad1.nombre = dt.Rows[i][1].ToString();
                entidad1.apellidos = dt.Rows[i][2].ToString();
                entidad1.logeo = dt.Rows[i][3].ToString();
                entidad1.nombreD=dt.Rows[i][4].ToString();
                entidad1.nombreT = dt.Rows[i][6].ToString();
                entidad1.email = dt.Rows[i][8].ToString();
                entidad1.estado = dt.Rows[i][9].GetHashCode();
                entidad1.fechacreado = (DateTime)dt.Rows[i][10];
                entidad1.usuariocreado = dt.Rows[i][11].ToString();
                entidad1.codigoempleado = dt.Rows[i][12].ToString();
                entidad1.password = dt.Rows[i][13].ToString();

                entidad1.imagen = (byte[])dt.Rows[i][14];
                entidad1.horaentrada = dt.Rows[i][16].ToString() + "-" + dt.Rows[i][17].ToString();

                //entidad1.horasalida= dt.Rows[i][16].ToString();

                imagen1 = registrogeneralController.imagen2;

                string imagen =Convert.ToBase64String(imagen1);
                string imagenURL = string.Format("data:image/png;base64,{0}", imagen);
                ViewBag.imagen= imagenURL;
                //imagen1 = entidad1.imagen;

                //string imagen = Convert.ToBase64String(imagen1);

                //string imagemDadosURL = string.Format("data:image/png;base64,{0}", imagen);
                //ViewBag.imagen = imagemDadosURL;
                //string imagenbyte = Convert.ToBase64String(entidad1.imagen);
                //string imagemDadosURL = string.Format("data:image/png;base64,{0}", imagenbyte);
                //entidad1.imagen=ConvertImage.ByteArrayToImage((byte[])dt.Rows[i][14]);


                //Convert.ToBase64String(entidad1.imagen);

                //MemoryStream ms = new MemoryStream(entidad1.imagen = (byte[])dt.Rows[i][14]);
                //Image image = Image.FromStream(ms);

                //ms = new MemoryStream();
                //image.Save(ms, ImageFormat.Png);

                //ms.Position = 0;

                //MemoryStream ms = new MemoryStream(imagen1);

                //ViewBag.entidadw = Image.FromStream(ms);

                entidad.Add(entidad1);

                ViewBag.entidad = entidad;

                //ViewBag.entidad1 = (entidad1.imagen, "image/png");
                //return File(entidad1.imagen,"image/png");
                //return new FileContentResult(entidad1.imagen, "image/png");

                //return new FileContentResult(entidad1.imagen, "imagenes/png");
            }


            List<entidad> entidad2 = new List<entidad>();

            dt1 = _login.D_ListarDepartamento();

            for (int i=0; i < dt1.Rows.Count; i++)
            {


                entidad entidad3 = new entidad();
                entidad3.iddepartamento = dt1.Rows[i][0].GetHashCode();
                entidad3.nombreD = dt1.Rows[i][1].ToString();

                entidad2.Add(entidad3);

               

            }


            List<SelectListItem> items = entidad2.ConvertAll(d =>
                  {

                      return new SelectListItem()
                      {


                       Text = d.nombreD.ToString(),
                      Value = d.iddepartamento.ToString(),
                      Selected=false


                      };

                  });


            ViewBag.item = items;







            List<entidad> entidadH = new List<entidad>();
            dth = _login.LISTARHORARIOS();
            for (int i = 0; i < dth.Rows.Count; i++)
            {

                entidad entidadh4 = new entidad();

                entidadh4.idhorario = dth.Rows[i][0].GetHashCode();
                entidadh4.horaentrada = dth.Rows[i][1].ToString();
                entidadh4.horasalida = dth.Rows[i][2].ToString();
                entidadH.Add(entidadh4);

            }

            List<SelectListItem> itemH = entidadH.ConvertAll(d =>
            {

                return new SelectListItem()
                {


                    //Text = d.horaentrada.ToString(),
                    Text = d.horaentrada.ToString() + "-" + d.horasalida.ToString(),
                    Value = d.idhorario.ToString(),
                    Selected = false


                };

            });


            ViewBag.itemH = itemH;














            List<entidad> entidad4 = new List<entidad>();


            dt2 = _login.D_ListarTipo();

            for (int i=0; i<dt2.Rows.Count; i++)
            {

                entidad entidad41 = new entidad();

                entidad41.idtipoempleado = dt2.Rows[i][0].ToString();
                entidad41.nombreT=dt2.Rows[i][1].ToString();

                entidad4.Add(entidad41);

            }





            List<SelectListItem>item2=entidad4.ConvertAll(d=>
                {

                    return new SelectListItem()
                    {


                        Text = d.nombreT.ToString(),
                        Value = d.idtipoempleado.ToString(),
                        Selected = false


                    };



            });

            ViewBag.item2 = item2;

            return View(ViewBag.item2);

            
        }







        public DataTable conversion()
        {
            DataTable dt;

           dt=_login.LISTAREMPLEADOS();

            return dt;
        }


        public IActionResult salirr()
        {
            HttpContext.Session.Remove("sess_1");
            //HttpContext.Session.Remove("nombre");

            return RedirectToAction("index", "RegistrarAsistencia");


        }





    }
}