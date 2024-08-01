using System.Net.Http.Json;
using SalonApp.Core.Entities;
using SalonApp.Core.Interfaces;

namespace SalonApp.Web.Services;

public class ApiClienteService : IClienteService
{
    private readonly HttpClient _httpClient;

    public ApiClienteService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<Cliente> CreateClienteAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClienteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Cliente>>("api/clientes")
            ?? Enumerable.Empty<Cliente>();
    }

    public Task<Cliente?> GetClienteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClienteAsync(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    // Implementa otros métodos...
}