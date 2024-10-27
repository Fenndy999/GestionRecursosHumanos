using proyecto1.Domain;
using proyecto1.Infrastructure;

namespace proyecto1.Application
{
    public class EmpleadoService
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public IEnumerable<Empleado> ObtenerEmpleados()
        {
            return _context.Empleados.ToList();
        }
    }
}
