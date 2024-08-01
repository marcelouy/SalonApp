using SalonApp.Core.Entities;

public class ClienteDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string? Telefono { get; set; }

    // Propiedad calculada para NombreCompleto
    public string NombreCompleto => $"{Nombre} {Apellido}";

    // Constructor sin parámetros
    public ClienteDto() { }

    // Constructor con parámetros
    public ClienteDto(int id, string nombre, string apellido, string email, string? telefono)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
    }

    // Constructor que acepta un objeto Cliente
    public ClienteDto(Cliente cliente)
    {
        Id = cliente.Id;
        Nombre = cliente.Nombre;
        Apellido = cliente.Apellido;
        Email = cliente.Email;
        Telefono = cliente.Telefono;
    }
}