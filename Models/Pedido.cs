using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class Pedido
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        
        public double CostoTotal { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public string? Cliente { get; set; }
       
    }
}
