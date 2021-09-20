using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class RegistrationController : Controller
    {
        public RedirectResult Registration()
        {
            return Redirect("~/Admin/Login");
        }
    }
}