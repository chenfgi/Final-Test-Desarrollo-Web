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
    public class AlumnosController : ControllerBase
    {

        private readonly ContextoModelo _context;

        public AlumnosController(ContextoModelo contexto)
        {
            _context = contexto;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> GetAlumnoItem(int id)
        {
            var AlumnoItem = await _context.AlumnoItems.FindAsync(id);

            if (AlumnoItem == null)
            {
                return NotFound();
            }

            return AlumnoItem;
        }

        [HttpPost]
        public async Task<ActionResult<Alumno>> PostAlumnoItem(Alumno item)
        {
            _context.AlumnoItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlumnoItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnoItem(int id, Alumno item)
        {
            if (id != item.Id)
            {
                return BadRequest();

            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
