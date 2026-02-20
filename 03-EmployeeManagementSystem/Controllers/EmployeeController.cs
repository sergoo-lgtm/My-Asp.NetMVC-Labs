using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers;

public class EmployeeController : Controller
{

    DContext context = new DContext();

    public IActionResult ShowAllEmployees()
    {
        var employees = context.Employees.ToList();
        return View("ShowAllEmployees", employees);
    }

    public IActionResult EditEmployees(int id)
    {
        var employee = context.Employees.Find(id);
        return View("EditEmployees", employee);
    }

    [HttpPost]
    public IActionResult SaveChanges(Empoloyee employee)
    {
        if (employee.Id != 0)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
            return RedirectToAction("ShowAllEmployees");
        }

        return View("EditEmployees", employee);
    }
}