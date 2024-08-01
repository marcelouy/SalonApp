// SalonApp.Core/Interfaces/IInventarioService.cs
using SalonApp.Core.Entities;

namespace SalonApp.Core.Interfaces;

public interface IInventarioService
{
    Task<bool> ActualizarStock(int productoId, int cantidad);
    Task<IEnumerable<Producto>> ObtenerProductosBajoStock(int limiteStock);
    Task<Producto> AgregarProducto(Producto producto);
    Task<Producto> ObtenerProductoPorId(int id);
    Task<IEnumerable<Producto>> ObtenerTodosLosProductos();
}