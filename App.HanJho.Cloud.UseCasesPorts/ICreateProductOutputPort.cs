
using App.HanJho.Cloud.DTOs;

namespace App.HanJho.Cloud.UseCasesPorts;

public interface ICreateProductOutputPort
{
    Task Handle(ProductDTO product);
}
