namespace proyecto1.Domain
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DepartamentoId { get; set; }
        public int RolId { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public bool Activo { get; set; }

        // Navegación
        public Departamento Departamento { get; set; }
        public Rol Rol { get; set; }
    }
}
