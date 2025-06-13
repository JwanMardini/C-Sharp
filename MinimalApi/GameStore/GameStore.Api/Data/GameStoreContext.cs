using System;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Entities.Game> Games => Set<Entities.Game>();
    public DbSet<Endpoints.Genre> Genres => Set<Endpoints.Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Endpoints.Genre>().HasData(
            new Endpoints.Genre { Id = 1, Name = "Action" },
            new Endpoints.Genre { Id = 2, Name = "Adventure" },
            new Endpoints.Genre { Id = 3, Name = "Role-Playing" },
            new Endpoints.Genre { Id = 4, Name = "Simulation" },
            new Endpoints.Genre { Id = 5, Name = "Strategy" }
        );
    }

}
