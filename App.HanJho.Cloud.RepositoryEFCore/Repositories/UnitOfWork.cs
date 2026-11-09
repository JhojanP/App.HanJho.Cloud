using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore.Storage;

namespace App.HanJho.Cloud.RepositoryEFCore.Repositories;
public class UnitOfWork(EFCoreContext _context) : IUnitOfWork
{
    private IDbContextTransaction? _currentTransaction;
    //readonly EFCoreContext _context ;
    //public UnitOfWork(EFCoreContext context) => _context = context;
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task BeginTransactionAsync()
    {
        if (_currentTransaction != null) return;
        _currentTransaction = await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            if (_currentTransaction != null)
            {
                await _currentTransaction.CommitAsync();
            }
        }
        catch
        {
            await RollbackAsync();
            throw;
        }
        finally
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }
        }
    }

    public async Task RollbackAsync()
    {
        try
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.RollbackAsync();
            }
        }
        finally
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }


}
