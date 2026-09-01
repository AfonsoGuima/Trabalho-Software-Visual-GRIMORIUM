using Microsoft.EntityFrameworkCore;

namespace GrimoriumRPG.Api.Data
{
    public class GrimoriumDbContext : DbContext{
        public GrimoriumDbContext(DbContextOptions<GrimoriumDbContext> options) : base(options){}

        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Campanha> Campanhas {get; set;}
        public DbSet<Ficha> Fichas {get;set;}
        public DbSet<Npc> Npcs {get;set;}
        public DbSet<Cidade> Cidades {get;set;}
        public DbSet<Item> Itens {get;set;}

        protected override void OnModelCreating(ModelBuilder model){
            model.Entity<Campanha>()
                .HasOne(c => c.Mestre)
                .WithMany()
                .HasForeignKey(c => c.Mestre);
        }
    }

    public class Item
    {
    }

    public class Cidade
    {
    }

    public class Npc
    {
    }

    public class Ficha
    {
    }

    public class Campanha
    {
        public object Mestre { get; internal set; }
    }

    public class Usuario
    {
    }
}