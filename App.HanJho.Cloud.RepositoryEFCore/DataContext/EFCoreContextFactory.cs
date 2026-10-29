using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design; 
namespace App.HanJho.Cloud.RepositoryEFCore.DataContext; 
public class EFCoreContextFactory : IDesignTimeDbContextFactory<EFCoreContext>
{
    public EFCoreContext CreateDbContext(string[] args)
    {
       var optionsBuilder = new DbContextOptionsBuilder<EFCoreContext>();
        optionsBuilder.UseSqlServer("Server=DESKTOP-3PTAJHR;Database=DbCAPrueba;User Id=sa;Password=sql;TrustServerCertificate=True;");
        return new EFCoreContext(optionsBuilder.Options);
    }
}
