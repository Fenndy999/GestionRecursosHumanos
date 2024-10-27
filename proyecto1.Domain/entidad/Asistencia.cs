using proyecto1.Domain;

namespace proyecto1.Domain
{
    public class Asistencia
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }

        // Navegación
        public Empleado Empleado { get; set; }
    }
}
