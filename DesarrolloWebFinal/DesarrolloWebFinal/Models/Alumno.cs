using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesarrolloWebFinal.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public bool activo { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool aprobadoreprobado { get; set; }
    }
}
