using EduManageSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduManageSystem.Controllers;

public class InstructorsController : Controller
{
    Dcontext context = new Dcontext();
    public IActionResult Index()
    {
        List<Instructor> instructors = context.Instructors.ToList();
        
        
        return View("ShowAllIns", instructors);
    }
    
    public IActionResult DetailsInstructor(int id)
    {
        Instructor instructorDetails = context.Instructors.Where(i=>i.Id == id).FirstOrDefault();
        
        
        return View("instructorDetails", instructorDetails);
    }
    
}