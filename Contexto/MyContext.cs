using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Contexto
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
