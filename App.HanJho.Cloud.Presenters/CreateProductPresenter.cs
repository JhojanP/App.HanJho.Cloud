using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.UseCasesPorts; 

namespace App.HanJho.Cloud.Presenters;

public class CreateProductPresenter : ICreateProductOutputPort,IPresenter<ProductDTO>
{
    public ProductDTO Content { get; private set; }
    public Task Handle(ProductDTO product)
    {
        Content = product;
        return Task.CompletedTask;
    } 
}
