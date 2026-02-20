using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Models;

public class DContext:DbContext
{
    public DbSet<Empoloyee> Employees { get; set; } 
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=EmployeeManagementSystemDB;User Id=sa;Password=Yosuef@2026;TrustServerCertificate=True;"
        );
    }

    public DContext():base()
    {
        
    }

     
    
}