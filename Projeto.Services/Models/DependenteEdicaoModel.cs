using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class DependenteEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do dependente")]
        public int IdDependente { get; set; }

        [Required(ErrorMessage = "Informe o nome do dependente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do dependente")]
        public DateTime DataNascimento { get; set; }



    }
}