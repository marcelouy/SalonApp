using AutoMapper;
using SalonApp.Core.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Cliente, ClienteDto>();
        CreateMap<ClienteDto, Cliente>();

        // No necesitamos mapear explícitamente NombreCompleto ya que es una propiedad calculada
    }
}