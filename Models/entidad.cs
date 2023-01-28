using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTROASISTENCIA.Models
{

    [Serializable]
    public class entidad
    {
        //[Key]
        public int idhorario { get; set; }
        public int idasistencias { get; set; }
        public String horaentrada { get; set; }
        public String horasalida { get; set; }
        public String idempleados { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String password { get; set; }
        public String logeo { get; set; }

        //public String iddepartamento { get; set; }
        //public String idtipoempleado { get; set; }
        public String TardeTemprano { get; set; }
        public int iddepartamento { get; set; }
        public string nombreD { get; set; }
        public String idtipoempleado { get; set; }

        public String nombreT { get; set; }
        public String email { get; set; }
        public String codigoempleado { get; set; }
        public String accion { get; set; }

        //  public string imagen { get; set; }
        public String usuariocreado { get; set; }

        public DateTime fechacreado { get; set; }
        public DateTime fechacreada { get; set; }
        //public String fechacreado { get; set; }
        public int estado { get; set; }
        public byte[] imagen { get; set; }

        public DateTime fechahora { get; set; }
        //public TimeZoneInfo fechahora8{ get; set; }
        //public String fechahora { get; set; }
          public  DateTime fecha { get; set; }
        //public TimeZoneInfo fechahora9 { get; set; }
        //public String fecha { get; set; }
        public String fechainicio { get; set; }
        public String fechafin { get; set; }
        public DateTime fechainicio1 { get; set; }
        public DateTime fechafin1 { get; set; }
        public DateTime fechacreadaD { get; set; }
        public String tipo { get; set; }
        public String descripcion { get; set; }
        public int iddepartamentos { get;set; }

    }
}
