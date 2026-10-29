using App.HanJho.Cloud.DTOs; 
namespace App.HanJho.Cloud.UseCasesPorts;

public interface ICreateProductInputPort
{
    Task Handle(CreateProductDTO input);
}
