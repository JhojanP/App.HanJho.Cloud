using App.HanJho.Cloud.Entities.POCOs;

namespace App.HanJho.Cloud.Entities.Interfaces;
public interface IProductRepository
{
    void Add(Product product);
    void Update(Product product);    
    void Delete(int id);
    IEnumerable<Product> GetAll();
}
