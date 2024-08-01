using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.OpenApi.Models;
using SalonApp.Core.Interfaces;
using SalonApp.Core.Services;
using SalonApp.Infrastructure.Data;
using SalonApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura servicios
ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configura el pipeline de solicitudes HTTP
ConfigureApp(app);

app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    // Añade AutoMapper
    services.AddAutoMapper(typeof(Program).Assembly);

    // Añade controladores
    services.AddControllers();

    // Configura Swagger
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "SalonApp API", Version = "v1" });
    });

    // Registra IClienteService y su implementación
    services.AddScoped<IClienteService, ClienteService>();

    // Registra IClienteRepository
    services.AddScoped<IClienteRepository, ClienteRepository>();

    // Registra DbContext
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

    // ... más configuraciones de servicios si las tienes
}

void ConfigureApp(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SalonApp API v1"));
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    // ... más configuraciones de middleware si las tienes
}