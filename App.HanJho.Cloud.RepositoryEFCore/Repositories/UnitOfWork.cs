using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.RepositoryEFCore.DataContext;

namespace App.HanJho.Cloud.RepositoryEFCore.Repositories;
public class UnitOfWork(EFCoreContext _context) : IUnitOfWork
{
    //readonly EFCoreContext _context ;
    //public UnitOfWork(EFCoreContext context) => _context = context;
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
       return _context.SaveChangesAsync(cancellationToken);
    }
}
