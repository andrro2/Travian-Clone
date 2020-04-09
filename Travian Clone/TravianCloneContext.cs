using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Travian_Clone.Models;

namespace Travian_Clone
{
    public class TravianCloneContext : IdentityDbContext<User>
    {


        public TravianCloneContext(DbContextOptions<TravianCloneContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TravianClone;Trusted_Connection=True;");

        public virtual DbSet<Tile> Tiles { set; get; }

        public virtual DbSet<Settlement> Settlements { set; get; }

        public virtual DbSet<World> Worlds { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<WorldLayout>()
                .Property(b => b.Id)
                .IsRequired();

            modelBuilder.Entity<Tile>()
                .HasOne(b => b.tileSettlement)
                .WithOne(i => i.position)
                .HasForeignKey<Tile>(b => b.SettlementId);

            modelBuilder.Entity<Settlement>()
                .Property(b => b.Id)
                .IsRequired();

            modelBuilder.Entity<World>()
                .Property(b => b.Id)
                .IsRequired();
        }
    }
}
