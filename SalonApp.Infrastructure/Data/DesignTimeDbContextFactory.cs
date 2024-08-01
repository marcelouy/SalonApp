using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SalonApp.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Obtén el directorio del proyecto Infrastructure
            string projectDir = Directory.GetCurrentDirectory();

            // Navega hacia arriba en la estructura de directorios hasta encontrar la solución
            while (!File.Exists(Path.Combine(projectDir, "SalonApp.sln")) && Directory.GetParent(projectDir) != null)
            {
                projectDir = Directory.GetParent(projectDir).FullName;
            }

            // Combina la ruta con la ubicación del proyecto Infrastructure
            string configPath = Path.Combine(projectDir, "SalonApp.Infrastructure", "appsettings.json");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(configPath))
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}