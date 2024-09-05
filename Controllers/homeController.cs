using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using backendtwo.Models;

namespace backendtwo.Controllers
{
    public class homeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
