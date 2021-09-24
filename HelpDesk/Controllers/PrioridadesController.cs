using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk.DAL;
using HelpDesk.Models;

namespace HelpDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioridadesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PrioridadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Prioridades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prioridade>>> GetPriooridades()
        {
            return await _context.Priooridades.ToListAsync();
        }

        // GET: api/Prioridades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prioridade>> GetPrioridade(int id)
        {
            var prioridade = await _context.Priooridades.FindAsync(id);

            if (prioridade == null)
            {
                return NotFound();
            }

            return prioridade;
        }

        // PUT: api/Prioridades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrioridade(int id, Prioridade prioridade)
        {
            if (id != prioridade.Id)
            {
                return BadRequest();
            }

            _context.Entry(prioridade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrioridadeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Prioridades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prioridade>> PostPrioridade(Prioridade prioridade)
        {
            _context.Priooridades.Add(prioridade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrioridade", new { id = prioridade.Id }, prioridade);
        }

        // DELETE: api/Prioridades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrioridade(int id)
        {
            var prioridade = await _context.Priooridades.FindAsync(id);
            if (prioridade == null)
            {
                return NotFound();
            }

            _context.Priooridades.Remove(prioridade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrioridadeExists(int id)
        {
            return _context.Priooridades.Any(e => e.Id == id);
        }
    }
}
