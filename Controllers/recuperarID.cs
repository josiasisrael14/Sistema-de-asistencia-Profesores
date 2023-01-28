using Microsoft.AspNetCore.Mvc;
using REGISTROASISTENCIA.Models;
using System.Collections.Generic;
using System.Data;

namespace REGISTROASISTENCIA.Controllers
{
    public class recuperarID : Controller
    {

        private readonly  db _listar;
        public IActionResult Index()
        {
            return View();
        }

        public recuperarID(db context)
        {

            _listar= context;


        }


        //[HttpGet]
        public JsonResult listarid(string  idempleados)
        {
            //idempleados= "U0002";
            DataTable dt;
            List<entidad> entidades = new List<entidad>();


            var id = new entidad
            {

                idempleados=idempleados
            };

            dt = _listar.ListarID(id);
            for(int i= 0;  i<dt.Rows.Count; i++){

                entidad entidadess = new entidad();

                entidadess.idempleados= dt.Rows[i][0].ToString();
                entidadess.nombre = dt.Rows[i][1].ToString();
                entidadess.apellidos= dt.Rows[i][2].ToString();
                entidadess.logeo= dt.Rows[i][3].ToString();
                entidadess.nombreD= dt.Rows[i][4].ToString();
                entidadess.iddepartamento=dt.Rows[i][5].GetHashCode();
                entidadess.nombreT= dt.Rows[i][6].ToString();
                entidadess.idtipoempleado=dt.Rows[i][7].ToString();
                entidadess.email = dt.Rows[i][8].ToString();
                entidadess.estado= dt.Rows[i][9].GetHashCode();
                entidadess.usuariocreado= dt.Rows[i][11].ToString();
                entidadess.codigoempleado = dt.Rows[i][12].ToString();
                entidadess.password = dt.Rows[i][13].ToString();
                entidadess.imagen = (byte[])dt.Rows[i][14];
                entidadess.idhorario = dt.Rows[i][15].GetHashCode();
                //entidadess.horaentrada = dt.Rows[i][16].ToString();
                //entidadess.horasalida = dt.Rows[i][17].ToString();
                entidades.Add(entidadess);
            }
            return Json(entidades);

        }

       
    }





}
