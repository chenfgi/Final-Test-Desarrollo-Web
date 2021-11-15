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
    public class NotasController : ControllerBase
    {
        private readonly ContextoModelo _context;

        public NotasController(ContextoModelo contexto)
        {
            _context = contexto;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Nota>> GetNotaItem(int id)
        {
            var NotaItem = await _context.NotaItems.FindAsync(id);

            if (NotaItem == null)
            {
                return NotFound();
            }

            return NotaItem;
        }

        [HttpPost]
        public async Task<ActionResult<Alumno>> PostNotasItem(Nota item)
        {
            _context.NotaItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNotaItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotasItem(int id, Nota item)
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
