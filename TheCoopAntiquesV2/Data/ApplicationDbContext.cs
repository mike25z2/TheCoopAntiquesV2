using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheCoopAntiquesV2.Models;

namespace TheCoopAntiquesV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<Booth> Booth { get; set; }
        public DbSet<DealerBooth> DealerBooth { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DealerBooth>()
                .HasKey(d => new { d.DealerId, d.BoothId });
        }
    }
}
