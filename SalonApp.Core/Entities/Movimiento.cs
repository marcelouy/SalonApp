// SalonApp.Core/Entities/Movimiento.cs
namespace SalonApp.Core.Entities;

public class Movimiento
{
    public int Id { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    // Otras propiedades relevantes...
}