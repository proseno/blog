using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Registration()
        {
            return View();
        }
    }
}