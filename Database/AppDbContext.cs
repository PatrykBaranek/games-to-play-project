using GamesToPlayProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Database
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<GamesEntity> Games { get; set; }

        public AppDbContext(DbContextOptions options): base(options)
        {
        }

    }
}
