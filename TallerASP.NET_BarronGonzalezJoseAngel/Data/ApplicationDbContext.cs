using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TallerASP.NET_BarronGonzalezJoseAngel.Models; // Agregado para usar TaskItem directamente

namespace TallerASP.NET_BarronGonzalezJoseAngel.Data
{
    // Sintaxis de constructor primario (C# 12) correcta
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        // Se crea el DbSet para la entidad TaskItem
        // RECOMENDACIÓN: Usar PascalCase (TaskItems) para nombres de tablas/propiedades
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}