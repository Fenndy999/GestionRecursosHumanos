using proyecto1.Domain;

namespace proyecto1.Domain
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Navegación
        public List<Empleado> Empleados { get; set; }
    }
}
