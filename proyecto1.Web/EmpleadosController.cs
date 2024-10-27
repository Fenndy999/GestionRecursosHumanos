using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto.Web.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly EmpleadoService _empleadoService;

        public EmpleadosController(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        public IActionResult Index()
        {
            var empleados = _empleadoService.ObtenerEmpleados();
            return View(empleados);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Empleado empleado)
        {
            _empleadoService.AgregarEmpleado(empleado);
            return RedirectToAction("Index");
        }
    }
}
