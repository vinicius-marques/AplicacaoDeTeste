using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AplicacaoDeTeste.Models
{
    public class Tipo
    {
        public Tipo() {

            Clientes = new List<Cliente>();    
            
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}