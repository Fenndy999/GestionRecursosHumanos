using proyecto1.Domain;

namespace proyecto1.Domain
{
    public class Deduccion
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }

        // Navegación
        public Empleado Empleado { get; set; }
    }
}
