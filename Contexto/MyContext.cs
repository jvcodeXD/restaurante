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
    }
}
