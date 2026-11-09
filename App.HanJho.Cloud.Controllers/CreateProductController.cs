using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.Presenters;
using App.HanJho.Cloud.UseCasesPorts;
using Microsoft.AspNetCore.Mvc; 

namespace App.HanJho.Cloud.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class CreateProductController( ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort) : ControllerBase
{ 
    readonly ICreateProductInputPort InputPort=inputPort;
    readonly ICreateProductOutputPort OutputPort= outputPort;

    [HttpPost]
    public async Task<ProductDTO> CreateProduct([FromBody] CreateProductDTO productDTO)
    {
        await InputPort.Handle(productDTO);
        return ((IPresenter<ProductDTO>)OutputPort).Content;

    }
}
