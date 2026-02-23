using EntityFrameWorkCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data;

public class FootballLeagueDBContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Dr-YOUSEF;Database=FootballLeague_EFCore;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasData(

             new Team { TeamId = 1, Name = "Tivoli Gardens F.C.", CreationDate = new DateTime(2026, 2, 23) },
            new Team { TeamId = 2, Name = "Waterhouse F.C.", CreationDate = new DateTime(2026, 2, 23) },
            new Team { TeamId = 3, Name = "Humble Lions F.C.", CreationDate = new DateTime(2026, 2, 23) }
    

            );

    }
}
