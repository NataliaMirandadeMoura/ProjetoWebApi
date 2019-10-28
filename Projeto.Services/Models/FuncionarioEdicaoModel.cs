using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class FuncionarioEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do funcionário.")]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "Informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o salário do funcionário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Informe a data de admissão do funcionário.")]
        public DateTime DataAdmissao { get; set; }
    }
}