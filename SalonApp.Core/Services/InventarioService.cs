// SalonApp.Core/Services/InventarioService.cs
using SalonApp.Core.Entities;
using SalonApp.Core.Interfaces;

namespace SalonApp.Core.Services;

public class InventarioService : IInventarioService
{
    private readonly IProductoRepository _productoRepository;

    public InventarioService(IProductoRepository productoRepository)
    {
        _productoRepository = productoRepository;
    }

    public async Task<bool> ActualizarStock(int productoId, int cantidad)
    {
        var producto = await _productoRepository.ObtenerPorIdAsync(productoId);
        if (producto == null) return false;

        producto.Cantidad += cantidad;
        await _productoRepository.ActualizarAsync(producto);
        return true;
    }

    public async Task<IEnumerable<Producto>> ObtenerProductosBajoStock(int limiteStock)
    {
        return await _productoRepository.ObtenerProductosBajoStockAsync(limiteStock);
    }

    public async Task<Producto> AgregarProducto(Producto producto)
    {
        return await _productoRepository.AgregarAsync(producto);
    }

    public async Task<Producto> ObtenerProductoPorId(int id)
    {
        return await _productoRepository.ObtenerPorIdAsync(id);
    }

    public async Task<IEnumerable<Producto>> ObtenerTodosLosProductos()
    {
        return await _productoRepository.ObtenerTodosAsync();
    }
}