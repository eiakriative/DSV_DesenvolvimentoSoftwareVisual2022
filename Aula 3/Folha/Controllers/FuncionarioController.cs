using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Folha.Models;


namespace Folha.Controllers
{
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        // GET: /api/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(funcionarios);

        // POST: /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Funcionario funcionario)
        {
            // DataContext ctx = new DataContext();
            // ctx.Funcionarios.Add(funcionario);

            funcionarios.Add(funcionario);
            return Created("", funcionario);
        }

        // GET: /api/funcionario/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if(funcionarios[i].Cpf.Equals(cpf))
                {
                    return Ok(funcionarios[i]);
                }
            }
            return NotFound();
        }

        // DELETE: /api/funcionario/deletar/{cpf}
        [HttpDelete]
        [Route("deletar/{cpf}")]
        public IActionResult Deletar([FromRoute] string cpf)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(cpf)
            );
            if(funcionario != null)
            {
                funcionarios.Remove(funcionario);
                return Ok(funcionario);
            }
            return NotFound();
        }

        // PATCH: /api/funcionario/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(funcionario.Cpf)
            );
            if(funcionarioEncontrado != null)
            {
                funcionarioEncontrado.Nome = funcionario.Nome;
                return Ok(funcionarioEncontrado);
            }
            return NotFound();
        }
    }
}
