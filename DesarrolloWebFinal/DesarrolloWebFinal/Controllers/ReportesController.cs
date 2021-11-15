using DesarrolloWebFinal.Data;
using DesarrolloWebFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesarrolloWebFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private readonly ContextoModelo _context;

        public ReportesController(ContextoModelo contexto)
        {
            _context = contexto;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Alumno>>> GetAlumnoItem(int id)
        {
            //Reporte 1 
            if (id == 1)
            {
                return await _context.AlumnoItems.Include(x => x.activo).Where(x => x.activo == true).ToListAsync();
            }
            if(id == 2)
            {
                return await _context.AlumnoItems.Include(x => x.aprobadoreprobado).Where(x => x.aprobadoreprobado == true).ToListAsync();
            }
            if(id == 3)
            {
                return await _context.AlumnoItems.Include(x => x.aprobadoreprobado).Where(x => x.aprobadoreprobado == false).ToListAsync();
            }
            else
            {
                return BadRequest();
            }
            

        }
    }
}
