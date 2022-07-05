using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("Order")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<OrderDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{id:long}")]
    public Task<OrderDto> GetById(long id)
    {
        return _service.GetById(id);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] OrderDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpPut]
    public Task Update([FromBody] OrderDto dto)
    { 
         return _service.Update(dto);   
    }

    [HttpDelete("{id:long}")]
    public Task Delete(long id)
    {
         return _service.Delete(id);          
    }
}
