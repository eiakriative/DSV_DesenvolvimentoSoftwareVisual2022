using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmeDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeDB.Controllers
{
      [ApiController]
    [Route("api/generos")]
    public class GeneroController : ControllerBase
    {
        private readonly DataContext _context;
        public GeneroController(DataContext context) =>
            _context = context;

        //POST: api/generos/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Genero genero)
        {
            _context.Generos.Add(genero);
            _context.SaveChanges();
            return Created("Genero cadastrado com sucesso!", genero);
        }

        //GET: api/generos/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Generos.ToList());

        
        // PATCH: /api/atores/editar
        
        [Route("Editar")]
        [HttpPut]
        public IActionResult Editar([FromBody] Genero genero)
        {
            _context.Generos.Update(genero);
            _context.SaveChanges();
            return Ok(genero);
        }


      // DELETE: /api/generos/deletar/{id}
 	 /* [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int? id)
        {

            Genero gen = _context.Generos.FirstOrDefault
            (
                gen => gen.Id == id
            );

            if (id == null)
            {
                return NotFound();
            }
            _context.Generos.Remove(gen);
            _context.SaveChanges();
            return Ok(_context.Generos.ToList());
        }
     */
        
    }
}