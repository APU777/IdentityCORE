using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IdentityCORE.Models;

namespace IdentityCORE.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        public AdminController(UserManager<AppUser> usrMgr)
        {
            userManager = usrMgr;
        }
        public ViewResult Index() => View(userManager.Users);
    }
}