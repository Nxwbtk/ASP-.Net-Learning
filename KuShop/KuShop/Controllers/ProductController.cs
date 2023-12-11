using Microsoft.AspNetCore.Mvc;

namespace KuShop.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}