using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int IdCliente { get; set; }
        [Required]
        public string? Estado { get; set; }
        [Required]
        public DateTime Fecha { get; set;}
    }
}
