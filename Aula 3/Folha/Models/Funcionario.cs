using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Folha.Models
{
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}