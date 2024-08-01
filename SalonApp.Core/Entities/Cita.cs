namespace SalonApp.Core.Entities
{
    public class Cita
    {
        public int Id { get; set; }
        public required DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
        public int EmpleadoId { get; set; }
        public required Empleado Empleado { get; set; }
        public required string Servicio { get; set; }
    }
}
