using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.DbContexts
{
    public class VotingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<ElectionResult> ElectionResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0CD3M7N;Database=SmartVoteDatabase;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Election>()
                .HasMany(e => e.Candidates)
            .WithOne(c => c.Election)
                .HasForeignKey(c => c.ElectionID);

            modelBuilder.Entity<Election>()
                .HasMany(e => e.Votes)
                .WithOne(v => v.Election)
                .HasForeignKey(v => v.ElectionID);
        }
    }
}
