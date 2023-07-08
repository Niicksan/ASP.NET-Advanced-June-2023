using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HouseRentingSystem.Data
{
    public class HouseRentingDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Agent> Agents { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<House> Houses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(HouseRentingDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            modelBuilder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}