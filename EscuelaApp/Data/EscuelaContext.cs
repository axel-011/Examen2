using Microsoft.EntityFrameworkCore;
using EscuelaApp.Models;

namespace EscuelaApp.Data
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
