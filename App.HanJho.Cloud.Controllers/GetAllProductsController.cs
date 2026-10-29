using App.HanJho.Cloud.DTOs;
using App.HanJho.Cloud.Presenters;
using App.HanJho.Cloud.UseCasesPorts;
using Microsoft.AspNetCore.Mvc; 

namespace App.HanJho.Cloud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort) : ControllerBase
{
    readonly IGetAllProductsInputPort InputPort = inputPort;
    readonly IGetAllProductsOutputPort OutputPort = outputPort;

    [HttpGet]
    public async Task<IEnumerable<ProductDTO>> GetAllProducts()
    {
        await InputPort.Handle();
        return ((IPresenter<IEnumerable<ProductDTO>>)OutputPort).Content;
    }
}
