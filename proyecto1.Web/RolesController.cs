using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto.Web.Controllers
{
    public class RolesController : Controller
    {
        private readonly RolService _rolService;

        public RolesController(RolService rolService)
        {
            _rolService = rolService;
        }

        public IActionResult Index()
        {
            var roles = _rolService.ObtenerRoles();
            return View(roles);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Rol rol)
        {
            _rolService.AgregarRol(rol);
            return RedirectToAction("Index");
        }
    }
}
