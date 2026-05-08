using Microsoft.EntityFrameworkCore;
using ComicoApi.Models;

namespace ComicoApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Comic> Comics => Set<Comic>();
    public DbSet<Banner> Banners => Set<Banner>();
    public DbSet<Chapter> Chapters => Set<Chapter>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chapter>()
            .Ignore(c => c.Links);

        modelBuilder.Entity<Comic>()
            .HasMany(c => c.Chapters)
            .WithOne()
            .HasForeignKey(ch => ch.ComicId);
    }
}