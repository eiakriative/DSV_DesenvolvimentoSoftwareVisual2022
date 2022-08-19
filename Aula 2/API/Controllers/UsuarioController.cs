using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase 
    {
    //  GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            
            Usuario usr = new Usuario
            {
                Email = "joventinopantanal@gmail.com",
                Senha = "jumamarruatapera"
                
            };
            return NotFound(usr);
        }

         //Exercício 1: cadastrar um usuário recebendo as informações 
        //da URL
        //Exercício 2: cadastrar um usuário recebendo as informações 
        //da corpo da requisição
        
   
    }
}