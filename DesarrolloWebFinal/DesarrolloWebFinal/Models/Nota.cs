using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesarrolloWebFinal.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Idalumno { get; set; }

        [Required]
        public int idcurso { get; set; }

        [Required]
        [Range(0, 10)]
        public int nota { get; set; }
    }
}
