using System;
using System.ComponentModel.DataAnnotations;

namespace crudTimeNet.Models {
    public class Jogador {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Posicao { get; set; }
    }
}