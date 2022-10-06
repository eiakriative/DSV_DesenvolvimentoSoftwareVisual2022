using System;
using System.Collections.Generic;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeDB.Models
{
    //Data Annotations
    public class Ator
    {
        public Ator() => CriadoEm = DateTime.Now;
        public int Id { get; set; }

        public string Nome { get; set; }

        public Filme Filme { get; set; }

        [Required(ErrorMessage = "O campo FilmeId é obrigatório")]
        public int FilmeId { get; set; }

        public Genero Genero { get; set; }
        public int GeneroId { get; set; }

        public DateTime Nascimento { get; set; }

        public DateTime CriadoEm { get; set; }

    }
}