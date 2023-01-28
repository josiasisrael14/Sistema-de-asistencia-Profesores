using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTROASISTENCIA.Models
{
    public class registroDBContext:DbContext
    {

        public registroDBContext(DbContextOptions<registroDBContext> options) : base(options)
        {






        }


        public DbSet<entidad> entidad { get; set; }
    }
}
