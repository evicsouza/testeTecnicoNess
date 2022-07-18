using System;
using System.ComponentModel.DataAnnotations;

namespace crudTimeNet.Models{
    public class Jogador {
        [Key]
        public Guid Id {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string nome {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string posicao {get; set;}
    }
}