using Microsoft.EntityFrameworkCore;
using SalonApp.Core.Entities;
using SalonApp.Core.Interfaces;
using SalonApp.Infrastructure.Data;

namespace SalonApp.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // Implementa los métodos de IClienteRepository

    public Task<Cliente> CreateAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        return await _context.Clientes.ToListAsync();
    }

    public Task<Cliente?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    // Implementa otros métodos...
}
