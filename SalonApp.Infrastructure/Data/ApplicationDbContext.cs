using Microsoft.EntityFrameworkCore;
using SalonApp.Core.Entities;
using System.Collections.Generic;

namespace SalonApp.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    // Otros DbSets...
}