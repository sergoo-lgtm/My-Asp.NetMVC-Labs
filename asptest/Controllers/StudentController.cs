using asptest.Models;
using Microsoft.AspNetCore.Mvc;

namespace asptest.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> studentListModel = studentBL.GetAllStudents();
            return View("ShowAll",studentListModel);
        }


        public IActionResult StudentDetils(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student studentDetailsModel = studentBL.GetStudentById(id);
            if (studentDetailsModel == null)
            {
                return NotFound(); 
            }

            return View("ShowDetails", studentDetailsModel);
        }

    }
}
