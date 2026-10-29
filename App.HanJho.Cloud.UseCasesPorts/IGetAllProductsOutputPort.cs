using App.HanJho.Cloud.DTOs; 

namespace App.HanJho.Cloud.UseCasesPorts;

public interface IGetAllProductsOutputPort
{
     Task Handle(IEnumerable<ProductDTO> products);
}
