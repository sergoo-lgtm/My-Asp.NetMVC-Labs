using System.Security.Cryptography.X509Certificates;

namespace asptest.Models
{
    public class StudentBL
    {
          List<Student> students;
        public StudentBL()
        {
            students = new List<Student>()
            {
                new Student(){Id=1,Name="Yousef",ImageURL="male.png"},
                new Student(){Id=2,Name="Ali",ImageURL="male.png"},
                new Student(){Id=3,Name="shahd",ImageURL="female.png"},
                new Student(){Id=4,Name="Sara",ImageURL="female.png"},
            };
        }
        
        public List<Student> GetAllStudents()
        {
            return students;
        }

           public Student GetStudentById(int id)
            {
                return students.FirstOrDefault(s => s.Id == id);
            }
    }
}
