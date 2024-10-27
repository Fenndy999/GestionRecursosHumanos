using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly DepartamentoService _departamentoService;

        public DepartamentosController(DepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpPost]
        public IActionResult Create(Departamento departamento)
        {
            _departamentoService.AgregarDepartamento(departamento);
            return CreatedAtAction(nameof(Create), departamento);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var departamentos = _departamentoService.ObtenerDepartamentos();
            return Ok(departamentos);
        }
    }
}
