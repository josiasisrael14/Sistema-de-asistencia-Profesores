using Microsoft.EntityFrameworkCore;
using REGISTROASISTENCIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTROASISTENCIA.services
{
    public class Iregistro:Sregistro
    {

        registroDBContext _dbcontext = null;



        public Iregistro(registroDBContext dbcontext)

        {



            _dbcontext = dbcontext;


        }



        //public void login(entidad entidass)
        //{

        //    var r = _dbcontext.entidad.FromSqlRaw($"sp_loguer{entidass.logeo},{entidass.password}");
            

        //}


        //public List<entidad> login(string logeo, string password)
        //{

        //    var login = _dbcontext.entidad.FromSqlRaw($"sp_loguer{logeo},{password}").ToList();

        //   return login;

        //}

        //List<entidad> Sregistro.login()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
