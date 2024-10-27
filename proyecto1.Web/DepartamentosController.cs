using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto.Web.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly DepartamentoService _departamentoService;

        public DepartamentosController(DepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var departamentos = _departamentoService.ObtenerDepartamentos();
            return View(departamentos);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Departamento departamento)
        {
            _departamentoService.AgregarDepartamento(departamento);
            return RedirectToAction("Index");
        }
    }
}
