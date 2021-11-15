using DesarrolloWebFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesarrolloWebFinal.Data
{
    public class ContextoModelo : DbContext
    {
        public ContextoModelo(DbContextOptions<ContextoModelo> options) : base(options)
        {

        }

        public DbSet<Alumno> AlumnoItems { get; set; }
        public DbSet<Nota> NotaItems { get; set; }
    }
}
