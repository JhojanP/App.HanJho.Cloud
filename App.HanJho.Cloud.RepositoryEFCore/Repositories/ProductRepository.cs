using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.Entities.POCOs;
using App.HanJho.Cloud.RepositoryEFCore.DataContext;

namespace App.HanJho.Cloud.RepositoryEFCore.Repositories
{
    public class ProductRepository(EFCoreContext _context) : IProductRepository
    {
        //readonly EFCoreContext _context ;
        //public ProductRepository(EFCoreContext context) => _context = context;
        public IEnumerable<Product> GetAll()
        {
            return _context.Product;
        }

        public void Add(Product product)
        {
            _context.Add(product); 
        }
        public void Update(Product product)
        {
            _context.Update(product);
        }
        public void Delete(int id)
        {
            var result = _context.Product.Find(id);
            if (result != null)
            {
                _context.Remove(result);
            } 
        }

       
        
    }
}
