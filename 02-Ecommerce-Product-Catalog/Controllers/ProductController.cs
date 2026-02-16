using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult ShowAllProducts()
    {
        ProductBL productBl = new ProductBL();
        List<Product> products = productBl.GetProducts();
        return View("ShowAll",products);
    }


    public IActionResult ProductId(int id)
    {
        
        ProductBL productBl = new ProductBL();
        Product product = productBl.GetProductById(id);
        return View("ShowDetails",product);

    }
}