using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicacaoDeTeste.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        [Display(Name = "Tipo")]
        public int IdTipo { get; set; }
        
        [ForeignKey("IdTipo")]       
        public Tipo Tipo { get; set; } 

    }
}