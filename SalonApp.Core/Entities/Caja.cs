namespace SalonApp.Core.Entities
{
    public class Caja
    {
        public int Id { get; set; }
        public decimal Saldo { get; set; }
        public required List<Movimiento> Movimientos { get; set; }
    }
}
