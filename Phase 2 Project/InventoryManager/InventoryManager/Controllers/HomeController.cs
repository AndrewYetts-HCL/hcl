using InventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventoryManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
