﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Models
{
    [Table("Frameworks")]
    public class Framework : PageModel
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
    }
}
