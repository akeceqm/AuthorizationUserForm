using AuthorizationUserForm.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AuthorizationUserForm.DAL;

public class AppDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Укажите вашу строку подключения к SQL Server
        optionsBuilder.UseSqlServer(
            "Server=DESKTOP-BGJ1FOE\\SQLEXPRESS01;Database=UserDataBase;Trusted_Connection=True;TrustServerCertificate=true");
    }
}