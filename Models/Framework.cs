﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Models
{
    [Table("Frameworks")]
    public class Framework
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string? Apelido { get; set; } = string.Empty;

        [Required]
        [StringLength(64)]
        public string? Descricao { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string? Versao { get; set; } = string.Empty;

        public HashSet<Erro>? Erros { get; set; }
    }
}
