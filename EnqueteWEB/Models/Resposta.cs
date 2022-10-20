using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnqueteWEB.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "O Campo Nome deve ser preenchido")]    
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo E-mail deve ser preenchido")]
        [EmailAddress(ErrorMessage ="O campo E-mail nao corresponde a um endereco valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo Sim deve ser preenchido")]
        public bool? Sim { get; set; }
    }
}
