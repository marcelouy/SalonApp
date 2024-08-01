// SalonApp.Infrastructure/Repositories/ProductoRepository.cs
using Microsoft.EntityFrameworkCore;
using SalonApp.Core.Entities;
using SalonApp.Core.Interfaces;
using SalonApp.Infrastructure.Data;

namespace SalonApp.Infrastructure.Repositories;

public class ProductoRepository : IProductoRepository
{
    private readonly ApplicationDbContext _context;

    public ProductoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Producto> ObtenerPorIdAsync(int id)
    {
        return await _context.Productos.FindAsync(id);
    }

    public async Task<IEnumerable<Producto>> ObtenerTodosAsync()
    {
        return await _context.Productos.ToListAsync();
    }

    public async Task<Producto> AgregarAsync(Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
        return producto;
    }

    public async Task ActualizarAsync(Producto producto)
    {
        _context.Entry(producto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Producto>> ObtenerProductosBajoStockAsync(int limiteStock)
    {
        return await _context.Productos
            .Where(p => p.Cantidad < limiteStock)
            .ToListAsync();
    }
}