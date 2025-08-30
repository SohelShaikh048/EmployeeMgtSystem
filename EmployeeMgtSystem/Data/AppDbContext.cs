using EmployeeMgtSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgtSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<tbl_Employee> tbl_Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed some dummy data
            modelBuilder.Entity<tbl_Employee>().HasData(
new tbl_Employee { Id = 1, Name = "Jane Smith", Email = "jane.smith@example.com", Department = Department.HR, HireDate = new DateTime(2023, 12, 10), Salary = 40000 },
new tbl_Employee { Id = 2, Name = "Michael Johnson", Email = "michael.j@example.com", Department = Department.Finance, HireDate = new DateTime(2023, 11, 05), Salary = 50000 },
new tbl_Employee { Id = 3, Name = "Emily Davis", Email = "emily.davis@example.com", Department = Department.Marketing, HireDate = new DateTime(2023, 10, 20), Salary = 38000 },
new tbl_Employee { Id = 4, Name = "David Wilson", Email = "david.wilson@example.com", Department = Department.IT, HireDate = new DateTime(2023, 09, 15), Salary = 60000 },
new tbl_Employee { Id = 5, Name = "Sophia Brown", Email = "sophia.brown@example.com", Department = Department.HR, HireDate = new DateTime(2023, 08, 25), Salary = 42000 },
new tbl_Employee { Id = 6, Name = "James Taylor", Email = "james.taylor@example.com", Department = Department.Finance, HireDate = new DateTime(2023, 07, 10), Salary = 55000 },
new tbl_Employee { Id = 7, Name = "Olivia Anderson", Email = "olivia.anderson@example.com", Department = Department.Marketing, HireDate = new DateTime(2023, 06, 18), Salary = 47000 },
new tbl_Employee { Id = 8, Name = "Daniel Thomas", Email = "daniel.thomas@example.com", Department = Department.IT, HireDate = new DateTime(2023, 05, 12), Salary = 52000 },
new tbl_Employee { Id = 9, Name = "Ava Martinez", Email = "ava.martinez@example.com", Department = Department.Finance, HireDate = new DateTime(2023, 04, 08), Salary = 48000 },
new tbl_Employee { Id = 10, Name = "Sohel Shaikh", Email = "sohel048@gmail.com", Department = Department.IT, HireDate = new DateTime(2024, 01, 15), Salary = 45000 }
            );

            modelBuilder.Entity<tbl_Employee>(entity =>
            {
                entity.Property(e => e.Salary).HasPrecision(18, 2);
            });
        }

    }
}
