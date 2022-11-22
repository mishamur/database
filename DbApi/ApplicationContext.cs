using Microsoft.EntityFrameworkCore;
using DbApi.Models;
using System;
using System.IO;

namespace DbApi
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Bonus> Bonuses => Set<Bonus>();
        public DbSet<Projectile> Projectiles => Set<Projectile>();
        public DbSet<Stat> Stats => Set<Stat>();
        public string DbPath { get; }

        public ApplicationContext()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var path = Path.Combine(folder, "MoonEscape");

            Directory.CreateDirectory(path);

            this.DbPath = Path.Combine(path, "MoonEscape.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={this.DbPath}");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}