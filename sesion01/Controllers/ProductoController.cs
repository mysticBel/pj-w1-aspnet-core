using Microsoft.AspNetCore.Mvc;

namespace sesion01.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
