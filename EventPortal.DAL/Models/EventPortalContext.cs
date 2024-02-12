using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class EventPortalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
    }
}
