using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult CreatePerson()
        {
            return View();
        }
    }
}
