using Microsoft.AspNetCore.Mvc;

namespace SuspirarDocesMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string email, string senha)
        {
            return View();
        }
    }
}
