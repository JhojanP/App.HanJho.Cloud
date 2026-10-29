using App.HanJho.Cloud.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace App.HanJho.Cloud.RepositoryEFCore.DataContext
{
    public class EFCoreContext :DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
        { 
        }

        public DbSet<Product> Product { get; set; }
    }
}
