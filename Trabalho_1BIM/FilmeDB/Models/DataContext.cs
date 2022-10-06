using System;
using Microsoft.EntityFrameworkCore;

namespace FilmeDB.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ator> Atores { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Genero> Generos  { get; set; }

    }
}