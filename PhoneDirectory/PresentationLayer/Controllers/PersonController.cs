using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonCreate()
        {
            return View();
        }
    }
}
