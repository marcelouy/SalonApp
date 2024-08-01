// SalonApp.Core/Services/ClienteService.cs
using SalonApp.Core.Interfaces;
using SalonApp.Core.Entities;

namespace SalonApp.Core.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public Task<Cliente> CreateClienteAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClienteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cliente>> GetAllClientesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Cliente?> GetClienteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClienteAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    // Implementa los métodos de IClienteService
}