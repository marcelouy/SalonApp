// SalonApp.Core/Interfaces/IProductoRepository.cs
using SalonApp.Core.Entities;

namespace SalonApp.Core.Interfaces;

public interface IProductoRepository
{
    Task<Producto> ObtenerPorIdAsync(int id);
    Task<IEnumerable<Producto>> ObtenerTodosAsync();
    Task<Producto> AgregarAsync(Producto producto);
    Task ActualizarAsync(Producto producto);
    Task<IEnumerable<Producto>> ObtenerProductosBajoStockAsync(int limiteStock);
}