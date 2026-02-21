using Microsoft.EntityFrameworkCore;

namespace EduManageSystem.Models;

public class Dcontext:DbContext
{
   
        public DbSet<Course> Courses { get; set; } 
        public DbSet<CourseResult> CourseResults { get; set; } 
        public DbSet<Instructor> Instructors { get; set; } 
        public DbSet<Trainee> Trainees { get; set; } 
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=EduManagementSystemDB;User Id=sa;Password=Yosuef@2026;TrustServerCertificate=True;"
            );
        }

        public Dcontext():base()
        {
        
        }

     
    
    
}