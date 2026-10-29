using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.UseCasesPorts; 

namespace App.HanJho.Cloud.Presenters;

public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
{
    //ICustomFormatter Formatter;
    public IEnumerable<ProductDTO> Content { get; private set; }
    public Task Handle(IEnumerable<ProductDTO> products)
    {
        Content = products;
        return Task.CompletedTask;
    }

}
