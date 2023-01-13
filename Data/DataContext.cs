using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using pokemon_api_net6.Models;

namespace pokemon_api_net6.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Country> Country { get; set; }   
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }

        public DbSet<PokemonCategory> PokemonCategory { get; set; }
        public DbSet<PokemonOwenrs> PokemonOwenrs { get;set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Reviewer> Reviewer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                  .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Category)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemonOwenrs>()
                    .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwenrs>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonOwenrs)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwenrs>()
                    .HasOne(p => p.Owner)
                    .WithMany(pc => pc.PokemonOwenrs)
                    .HasForeignKey(c => c.OwnerId);
        }


    }
}
