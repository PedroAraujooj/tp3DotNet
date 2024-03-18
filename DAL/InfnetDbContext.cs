using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions opt) : base(opt) {
           
        }

        public DbSet<Computador> Computadores { get; set; }
    }
}
