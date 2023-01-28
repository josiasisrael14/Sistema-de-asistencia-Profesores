using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using REGISTROASISTENCIA.services;
using System.Drawing.Imaging;
using System.Drawing;
namespace REGISTROASISTENCIA.Controllers
{
    public class registrogeneralController : Controller
    {
       
        public static byte[] imagen2 = new byte[0];
        private readonly db _login;

       
        public registrogeneralController(db contexts)
        {

            _login = contexts;

        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult login(string logeo, string password)

        {


            DataTable dt = new DataTable();
          
           
            string nombre;
            byte[] imagen1 = new byte[0];
            //byte[] imagen2 = new byte[0];
          
            var datos = new entidad
            {
                logeo = logeo,
                password = password
              
            };


           dt = _login.login(datos);

            if (dt.Rows.Count>0)
            {
    
              nombre=dt.Rows[0][0].ToString();
               imagen1 = (byte[])dt.Rows[0][3];

                imagen2 = imagen1;
                
                HttpContext.Session.SetString("sess_1", nombre);
               
                return RedirectToAction("index","Panel");
               

            }
            else
            {

                TempData["msg"] = "USUARIO INCORRECTO";

                return RedirectToAction("index","RegistrarAsistencia");
            }




          

        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
       


    }
}