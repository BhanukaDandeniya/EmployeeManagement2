using Microsoft.EntityFrameworkCore;
using EmployeeAPI.Models.Entities;

namespace EmployeeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.EmpNo).IsUnique();
                entity.Property(e => e.EmpNo).IsRequired().HasMaxLength(10);
                entity.Property(e => e.EmpName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EmpAddressLine1).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EmpAddressLine2).HasMaxLength(100);
                entity.Property(e => e.EmpAddressLine3).HasMaxLength(100);
                entity.Property(e => e.EmpDateOfJoin).IsRequired();
                entity.Property(e => e.EmpStatus).IsRequired();
                entity.Property(e => e.EmpImage).IsRequired();
            });
        }
    }
}