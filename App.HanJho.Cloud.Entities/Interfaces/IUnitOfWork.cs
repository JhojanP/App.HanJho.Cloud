namespace App.HanJho.Cloud.Entities.Interfaces;
public interface IUnitOfWork
{ 
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);     
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}
