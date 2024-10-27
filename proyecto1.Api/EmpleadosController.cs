using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadoService _empleadoService;

        public EmpleadosController(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            _empleadoService.AgregarEmpleado(empleado);
            return CreatedAtAction(nameof(Create), empleado);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var empleados = _empleadoService.ObtenerEmpleados();
            return Ok(empleados);
        }
    }
}
