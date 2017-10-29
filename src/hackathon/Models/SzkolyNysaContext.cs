using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using hackathon.Models;
using JetBrains.Annotations;

namespace hackathon.Models
{
    public class SzkolyNysaContext : DbContext
    {
        public SzkolyNysaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Przedszkole> Przedszkola { get; set; }
        public DbSet<SzkolaPodstawowa> SzkolyPodstawowe { get; set; }
        public DbSet<SzkolaSrednia> SzkolySrednie { get; set; }
        public DbSet<Przedszkole> Zlobki { get; set; }
    }

}