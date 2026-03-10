using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ceng382_25_26_202311070_1.Models;

namespace Ceng382_25_26_202311070_1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var students = new List<ProductCard>
        {
            new ProductCard { Id = 1, Name = "Ayşe Kaya", Midterm = 78, Final = 85, Grade = "BA" },
            new ProductCard { Id = 2, Name = "Mehmet Demir", Midterm = 65, Final = 72, Grade = "CB" },
            new ProductCard { Id = 3, Name = "Elif Yılmaz", Midterm = 90, Final = 93, Grade = "AA" }
        };
        return View(students);
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
