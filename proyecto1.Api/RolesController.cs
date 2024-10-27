using Microsoft.AspNetCore.Mvc;
using proyecto1.Application;
using proyecto1.Domain;

namespace proyecto1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RolService _rolService;

        public RolesController(RolService rolService)
        {
            _rolService = rolService;
        }

        [HttpPost]
        public IActionResult Create(Rol rol)
        {
            _rolService.AgregarRol(rol);
            return CreatedAtAction(nameof(Create), rol);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var roles = _rolService.ObtenerRoles();
            return Ok(roles);
        }
    }
}
