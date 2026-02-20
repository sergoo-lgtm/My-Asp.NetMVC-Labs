using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers;

public class DepartmentController : Controller
{
    // GET
    DContext context = new DContext();

    public IActionResult Index()
    {
        List<Department> departmentList = context.Departments
            .Include(d => d.Emps)
            .ToList();
        return View("Index", departmentList);
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View("Add");
    }

    [HttpPost]
    public IActionResult SaveAdd(Department department)
    {
        if (department.Name != null)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View("Add", department);
    }
}