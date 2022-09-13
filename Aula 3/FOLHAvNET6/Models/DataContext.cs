using Microsoft.EntityFrameworkCore;

namespace FOLHAvNET6.Models
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}