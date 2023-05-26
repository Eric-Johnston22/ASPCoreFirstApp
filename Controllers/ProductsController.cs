using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ASPCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        /**
        public string Welcome(string name, int secretNumber = 13)
        {
            return HttpUtility.HtmlEncode("Hello " + name + " the secret number is " + secretNumber);
        }
        **/

        public IActionResult Welcome()
        {
            ViewBag.name = "Eric";
            ViewBag.secretNumber = 13;
            return View();
        }
    }
}
