using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Correo { get;set; }
        [Required]
        public int Nit  { get; set; }
        [Required]
        public string? Nombre { get; set; }
     
    }
}
