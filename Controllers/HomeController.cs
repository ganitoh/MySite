using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello world!";
        }
    }
}
