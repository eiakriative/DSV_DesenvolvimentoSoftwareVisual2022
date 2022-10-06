using System;
using System.Collections.Generic;
using System.Linq;
using FilmeDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/filmes")]
    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;
        public FilmeController(DataContext context) =>
            _context = context;

        // GET: /api/filmes/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() =>
            Ok(_context.Filmes
            .Include(p => p.Genero)
            .ToList());

        // POST: /api/filmes/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Filme filme)
        {
            filme.Genero = _context.Generos
            .Find(filme.GeneroId);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return Created("Filme adicionado com sucesso!", filme);
        }


        // PUT: /api/filmes/editar
        [Route("editar")]
        [HttpPut]
        public IActionResult Editar([FromBody] Filme filme)
        {
            _context.Filmes.Update(filme);
            _context.SaveChanges();
            return Ok(filme);
        }

        // DELETE: /api/filmes/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Delete([FromRoute] int? id)
        {
            Filme filme = _context.Filmes.FirstOrDefault
            (
                filme => filme.Id == id
            );

            if (id == null)
            {
                return NotFound();
            }
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            return Ok(_context.Filmes.ToList());
        }
        // GET: /api/filmes/buscarpornome/{Nome}

        [HttpGet]
        [Route("buscarpornome/{Nome}")]
        public IActionResult BuscarPorNome(string Nome) 
        {
             Filme filme = _context.Filmes
             .Include(p => p.Genero)
             .FirstOrDefault(f => f.Nome == Nome);
            //If ternário
            return filme != null ? Ok(filme) : NotFound();
        }

                
        // GET: /api/filmes/buscar/{ano}

        [HttpGet]
        [Route("buscarporano/{Ano}")]
        public IActionResult BuscarPorAno(string Ano)
        {
        {
           Filme filme = _context.Filmes
           .Include(p => p.Genero)
           .FirstOrDefault(f => f.Ano == Ano);
            //If ternário
           return filme != null ? Ok(filme) : NotFound();
        }
        }
        
    }
}