using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View("TableContent");
        }
    }
}
