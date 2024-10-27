using proyecto1.Domain;
using proyecto1.Infrastructure;
namespace proyecto1.Application
{
    public class DepartamentoService
    {
        private readonly ApplicationDbContext _context;

        public DepartamentoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AgregarDepartamento(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            _context.SaveChanges();
        }

        public IEnumerable<Departamento> ObtenerDepartamentos()
        {
            return _context.Departamentos.ToList();
        }
    }
}
