using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class FuncionarioCadastroModel
    {
        [Required(ErrorMessage ="Informe o nome do funcionário")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o salário do funcionário")]
        public decimal Salaario { get; set; }

        [Required(ErrorMessage ="Informe  a data de admissão do funcionário")]
        public DateTime DataAdmissao { get; set; }
    }
}