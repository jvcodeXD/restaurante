using Restaurante.Dto;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public double Precio { get; set; }
    }
}
