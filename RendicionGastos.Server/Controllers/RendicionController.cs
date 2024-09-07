using Microsoft.AspNetCore.Mvc;

namespace RendicionGastos.Server.Controllers
{
    public class RendicionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
