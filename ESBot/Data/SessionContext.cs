using ESBot.Models;
using Microsoft.EntityFrameworkCore;

namespace ESBot.Data;

public class SessionContext(DbContextOptions<SessionContext> options) : DbContext(options)
{
    public DbSet<Session> Sessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Session>().HasData(
            new Session { Id = 1, Name = "Molly", Text = "test" },
            new Session { Id = 3, Name = "Missy", Text = "text2" },
            new Session { Id = 2, Name = "Cleo", Text = "text3" });
    }
}