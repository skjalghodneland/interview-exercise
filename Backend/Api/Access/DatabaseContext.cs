using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Access;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<Timeline> Timelines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Timeline>();
    }
}