using System;
using System.ComponentModel.DataAnnotations;

namespace crudTimeNet.Models
{
    public class Jogo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public string Oponente { get; set; }
    }
}