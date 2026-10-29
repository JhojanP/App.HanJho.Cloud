
using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.Entities.POCOs;
using App.HanJho.Cloud.UseCasesPorts;

namespace App.HanJho.Cloud.UseCases.CreateProduct;

public class CreateProductInteractor( IProductRepository repository,  
    IUnitOfWork unitOfWork, 
    ICreateProductOutputPort outputPort) : ICreateProductInputPort
{
    public async Task Handle(CreateProductDTO product )
    {
        Product newProduct = new Product
        {
            Name = product.ProductName
        }; 
        repository.Add(newProduct); 
        await unitOfWork.SaveChangesAsync();
        await outputPort.Handle(new ProductDTO { Id = newProduct.Id, Name = newProduct.Name });
    }
}
