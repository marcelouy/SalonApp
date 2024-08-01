using SalonApp.Core.Entities;

namespace SalonApp.Core.Interfaces;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> GetAllClientesAsync();
    Task<Cliente?> GetClienteByIdAsync(int id);
    Task<Cliente> CreateClienteAsync(Cliente cliente);
    Task UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int id);
    // Aquí podrías añadir métodos adicionales que involucren lógica de negocio
}