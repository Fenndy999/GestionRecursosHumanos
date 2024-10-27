using proyecto1.Domain;
using proyecto1.Infrastructure;

namespace proyecto1.Application
{
    public class RolService
    {
        private readonly ApplicationDbContext _context;

        public RolService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarRol(Rol rol)
        {
            _context.Roles.Add(rol);
            _context.SaveChanges();
        }

        public IEnumerable<Rol> ObtenerRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
