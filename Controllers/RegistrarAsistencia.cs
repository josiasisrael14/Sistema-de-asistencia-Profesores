using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Data;
//using System.Globalization;

namespace REGISTROASISTENCIA.Controllers
{
    public class RegistrarAsistencia : Controller
    {

        private db _registrar = null;

        public RegistrarAsistencia(db context)
        {

            _registrar = context;


        }
        public IActionResult Index( string codigoempleado)
        {

          


            return View();
        }


        public IActionResult registrar(string codigoempleado)
        {
            //DateTime fechaU = DateTime.Now.AddHours(+3);
            DateTime fechaU = DateTime.Today;
            //DateTime fechaU = DateTime.Today;
            DataTable mostrarU = new DataTable();
            DataTable HoraRegistradaUsuario =new DataTable();
            var codigoultimo = new entidad
            {

                codigoempleado = codigoempleado

            };
            List<entidad> entidadU = new List<entidad>();
            mostrarU = _registrar.ultimoregistro(codigoultimo);

            for (int i = 0; i < mostrarU.Rows.Count; i++)
            {
                entidad entidad13 = new entidad();
                entidad13.codigoempleado = mostrarU.Rows[i][0].ToString();
                entidad13.fechahora = (DateTime)mostrarU.Rows[i][1];
                entidad13.tipo = mostrarU.Rows[i][2].ToString();
                entidad13.fecha = (DateTime)mostrarU.Rows[i][3];
                entidadU.Add(entidad13);
                ViewBag.nn = entidad13.fecha;
                ViewBag.entradas = entidad13.tipo;

            }


            if (ViewBag.nn == fechaU && ViewBag.entradas=="entrada")
            {


                TempData["mensajes"] = "USUARIO REGISTRO ASISTENCIA";
                return RedirectToAction("Index", "ESRegistro");


            }








            string ver;
            DataTable mostrar = new DataTable();
            //DateTime mifechaHora = DateTime.Now.AddHours(+3);
            DateTime mifechaHora=DateTime.Now;  
            DateTime fechahorario = DateTime.Now;
            string conversion1= DateTime.Now.ToString("t");
            string conversion2;
            
            string tipo = "entrada";
           

            var HorarioUsuario = new entidad
            {

                codigoempleado=codigoempleado
            };



              List<entidad> entidadhorario = new List<entidad>();
              HoraRegistradaUsuario = _registrar.HorarioUsuarioRegistrada(HorarioUsuario);

            if ((HoraRegistradaUsuario?.Rows?.Count ?? 0) == 0)
            {

                TempData["msg"] = "USUARIO NO EXISTE";
                return RedirectToAction("Index", "ESRegistro");

            }

            for (int i = 0; i < HoraRegistradaUsuario.Rows.Count; i++)
            {
                entidad entidadHOR = new entidad();
                entidadHOR.idhorario = HoraRegistradaUsuario.Rows[i][0].GetHashCode();
                entidadHOR.codigoempleado =HoraRegistradaUsuario.Rows[i][1].ToString();
                entidadHOR.horaentrada = HoraRegistradaUsuario.Rows[i][2].ToString();
              
                entidadU.Add(entidadHOR);
               ViewBag.Tiempollegada = entidadHOR.horaentrada;
                //ViewBag.entradas = entidad13.tipo;

            }
            conversion2 = ViewBag.Tiempollegada;
            //var c1 = DateTime.Parse(conversion1).AddHours(+3);
            var c1 = DateTime.Parse(conversion1);
            var c2 = DateTime.Parse(conversion2);
          

            if (c1 > c2)
            {
                var asistencia = new entidad
                {
                    codigoempleado = codigoempleado,
                    fechahora = mifechaHora,
                    //fechahora8=mifechaHora8,
                    tipo = tipo,
                    TardeTemprano ="Tarde",
                    fecha = mifechaHora
                    //fechahora9 = mifechaHora8

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










            }
            else
            {

            }if(c1 <= c2)
            {

                var asistencia = new entidad
                {
                    codigoempleado = codigoempleado,
                    fechahora = mifechaHora,
                    tipo = tipo,
                    TardeTemprano = "Temprano",
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







            }


            return View();

        }


        public IActionResult registrarS(string codigoempleado)
        {
            //int contadorS;
            //DateTime fechaU=DateTime.Now;
            DateTime fechaU = DateTime.Today;
            DataTable mostrarU = new DataTable();
            var codigoultimo = new entidad
            {

                codigoempleado= codigoempleado

            };
            List<entidad> entidadU = new List<entidad>();
            mostrarU = _registrar.ultimoregistroS(codigoultimo);

            for (int i = 0; i < mostrarU.Rows.Count; i++)
            {
                entidad entidad13 = new entidad();
                entidad13.codigoempleado= mostrarU.Rows[i][0].ToString();
                entidad13.fechahora = (DateTime)mostrarU.Rows[i][1];
                entidad13.tipo= mostrarU.Rows[i][2].ToString();
                entidad13.fecha =(DateTime)mostrarU.Rows[i][3];
                entidadU.Add(entidad13);
                ViewBag.nn = entidad13.fecha;
                ViewBag.salidas=entidad13.tipo;

            }


            if (ViewBag.nn==fechaU && ViewBag.salidas== "salida")
            {


                TempData["mensajes"] = "USUARIO REGISTRO ASISTENCIA";
              return RedirectToAction("Index", "ESRegistro");


            }




            string ver;
            DataTable mostrar = new DataTable();
            DateTime mifechaHora = DateTime.Now;

            //DateTime mifechaHora = DateTime.Now.AddHours(+3);

            DateTime fechasola = DateTime.Now;
            //var fechaS = fechasola.Date.ToString();
            string tipo = "salida";
            var asistencia = new entidad
            {
                codigoempleado = codigoempleado,
                fechahora = mifechaHora,
                tipo = tipo,

                fecha = mifechaHora,
                TardeTemprano=""
            };

           ver=_registrar.EntradaSalida(asistencia);
           
            if (ver == "salidaI")
            {
               

                //if (contadorS == 1) { 

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


                //}

                //else
                //{


                //    ViewBag.mensajes = "usuario registro asistencia";
                //    return RedirectToAction("Index", "ESRegistro");

                //}


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
