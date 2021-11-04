using Microsoft.AspNetCore.Mvc;

namespace ManutencaoVeiculoApi.Controllers
{
    public class PrincipalController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgendarManutencao()
        {
            return View();
        }
    }
}
