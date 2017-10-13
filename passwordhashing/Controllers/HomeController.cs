using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PH.Web.Models;

namespace PH.Web.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 60*60)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
