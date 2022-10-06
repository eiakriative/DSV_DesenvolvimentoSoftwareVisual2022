using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeDB.Models
{
    public class Genero
    {
        public Genero() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
        
    }
}