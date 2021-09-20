using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class LoginController : Controller
    {
        public RedirectResult Login()
        {
            return Redirect("~/Admin/Login");
        }
    }
}