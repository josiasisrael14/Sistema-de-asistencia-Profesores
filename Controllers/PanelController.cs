using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;

namespace REGISTROASISTENCIA.Controllers
{
    public class PanelController : Controller
    {
        public static byte[] imagen3 = new byte[0];
        private readonly db _ContarDe = null;


        public PanelController(db context)
        {

            _ContarDe = context;


        }

        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("sess_1") == null)
            {


               return RedirectToAction("index", "RegistrarAsistencia");


            }


            imagen3 = registrogeneralController.imagen2;


            string imagenbyte = Convert.ToBase64String(imagen3);

            string imagemDadosURL = string.Format("data:image/png;base64,{0}", imagenbyte);
            ViewBag.DadosImagem = imagemDadosURL;
            //MemoryStream ms = new MemoryStream(imagen3);
            //Image image = Image.FromStream(ms);

            //Image image;
            var nombre = TempData["nombre"];
            //imagen2= (byte[])TempData["imagen1"];

            //ViewBag.imagen = ViewBag.imagen2;
            //ViewBag.imagen = ViewBag.imagen3;
            //var imagenn = TempData["imagenn"];

            //ViewBag.imagen3 = imagenn;
            HttpContext.Session.GetString("sess_1");

            var contarr = _ContarDe.ContarDepartamento();
            var contarUsuario=_ContarDe.ContarEmpleados();
            var tipoempleado = _ContarDe.ContarTipoEmpleado();
            var tarde = _ContarDe.ContarTarde();
            var temprano = _ContarDe.ContarTemprano();
            ViewBag.TipoEmpleados = tipoempleado;
            ViewBag.Contarr = contarr;
            ViewBag.ContarUsuario = contarUsuario;
            ViewBag.tarde=tarde;
            ViewBag.temprano=temprano;
            //return File(imagen3, "image/png");
            return View();



        }

        public IActionResult salir()
        {
            HttpContext.Session.Remove("sess_1");
            //HttpContext.Session.Remove("nombre");

            return RedirectToAction("index", "RegistrarAsistencia");


        }


    }
}