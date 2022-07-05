using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("Guest")]
public class GuestController : ControllerBase
{
    private readonly IGuestService _service;

    public GuestController(IGuestService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<GuestDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{id:long}")]
    public Task<GuestDto> GetById(long id)
    {
        return _service.GetById(id);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] GuestDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpPut]
    public Task Update([FromBody] GuestDto dto)
    { 
         return _service.Update(dto);   
    }

    [HttpDelete("{id:long}")]
    public Task Delete(long id)
    {
         return _service.Delete(id);          
    }
}
