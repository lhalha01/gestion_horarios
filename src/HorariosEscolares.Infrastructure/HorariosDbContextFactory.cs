using HorariosEscolares.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HorariosEscolares.Infrastructure;

/// <summary>
/// Factory para crear el DbContext en tiempo de diseño (migraciones)
/// </summary>
public class HorariosDbContextFactory : IDesignTimeDbContextFactory<HorariosDbContext>
{
    public HorariosDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<HorariosDbContext>();
        
        // Connection string para desarrollo local (Docker)
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=HorariosDB;User Id=sa;Password=HorariosDB2024!;TrustServerCertificate=True",
            b => b.MigrationsAssembly("HorariosEscolares.Infrastructure"));

        return new HorariosDbContext(optionsBuilder.Options);
    }
}
