using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCORE.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new Dictionary<string, object> { ["Placeholder"] = "Placeholder" });
        }
    }
}