using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// using Folha.Validations;

namespace Folha.Models
{
    //Data Annotations
    public class Funcionario
    {
        public Funcionario() => CriadoEm = DateTime.Now;
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo CPF é obrigatório!")]
        [StringLength(
            11,
            MinimumLength = 11,
            ErrorMessage = "O campo CPF deve conter 11 caracteres!"
        )]
        public string Cpf { get; set; }

        [Range(
        0,
        1000,
        ErrorMessage = "O salário deve estar entre R$ 0.00 e R$ 1.000,00"
        )]

        public double Salario { get; set; }

        [EmailAddress(
            ErrorMessage = "E-mail inválido!"
        )]
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}