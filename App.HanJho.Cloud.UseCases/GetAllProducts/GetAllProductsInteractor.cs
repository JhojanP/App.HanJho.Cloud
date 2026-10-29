using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.UseCasesPorts; 
namespace App.HanJho.Cloud.UseCases.GetAllProducts;

public class GetAllProductsInteractor(
    IProductRepository repository, 
    IGetAllProductsOutputPort outputPort) : IGetAllProductsInputPort
{ 
    public Task Handle()
    {
        var products = repository.GetAll().Select(p => new ProductDTO { 
            Id = p.Id, 
            Name = p.Name 
        });
        outputPort.Handle(products);
        return  Task.CompletedTask;
    }
}
