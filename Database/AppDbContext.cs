using GamesToPlayProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<GamesEntity> Games { get; set; }

        public AppDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.TimeSpent)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.ImgUrl)
                .IsRequired();
        }
    }
}
