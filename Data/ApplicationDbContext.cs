using Microsoft.EntityFrameworkCore;
using jugadores_futbol.Models;

namespace jugadores_futbol.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Assignment> Assignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assignment>()
            .HasIndex(a => new { a.PlayerId, a.TeamId })
            .IsUnique(); // Evita duplicados

        base.OnModelCreating(modelBuilder);
    }
}
