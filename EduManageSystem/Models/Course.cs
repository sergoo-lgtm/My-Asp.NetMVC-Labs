using System.ComponentModel.DataAnnotations.Schema;

namespace EduManageSystem.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MinDegree { get; set; }
    public string Degree { get; set; }
    public int Hours { get; set; }
    
    public List<CourseResult> CourseResults { get; set; }
    public List<Instructor> Instructors { get; set; }
    
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}