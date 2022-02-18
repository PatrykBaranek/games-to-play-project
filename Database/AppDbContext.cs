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
        DbSet<GamesEntity> Games { get; set; }

        public AppDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Title)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.ImgUrl)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .HasData(new GamesEntity() { Id =1, Title = "Dying Light 2", IsFinished = false, ImgUrl = "https://image.ceneostatic.pl/data/article_picture/87/ba/8615-3732-4335-82df-e6522b68f716_large.png", TimeSpent = 0 });
        }
    }
}
