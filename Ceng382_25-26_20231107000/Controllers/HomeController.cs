using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ceng382_25_26_20231107000.Models;

namespace Ceng382_25_26_20231107000.Controllers;

public class HomeController : Controller
{
    // ANA SAYFA (Index) - Öğrenciler burada listelenecek
    public IActionResult Index()
    {
        var students = new List<ProductCard>
        {
            new ProductCard { Id = 1, Name = "Ayşe Kaya", Midterm = 78, Final = 85, Grade = "BA" },
            new ProductCard { Id = 2, Name = "Mehmet Demir", Midterm = 65, Final = 72, Grade = "CB" },
            new ProductCard { Id = 3, Name = "Elif Yılmaz", Midterm = 90, Final = 93, Grade = "AA" }
        };

        return View(students); // Listeyi buraya gönderdik!
    }
    public IActionResult ProductCatalog()
    {
        var products = new List<ProductCard>
        {
            new ProductCard { Name = "Laptop", Category = "Electronics", Price = 45000, Description = "Developer machine", Midterm = 0, Final = 0 },
            new ProductCard { Name = "Mouse", Category = "Accessories", Price = 1500, Description = "Wireless mouse", Midterm = 0, Final = 0 }
        };

        return View(products); 
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}