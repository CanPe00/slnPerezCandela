using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class DBSistemaWebMisRecetaContext : DbContext
    {
        public DBSistemaWebMisRecetaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Receta> Recetas { get; set; }

    }
}
