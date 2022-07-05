using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("Menu")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _service;

    public MenuController(IMenuService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<MenuDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{id:long}")]
    public Task<MenuDto> GetById(long id)
    {
        return _service.GetById(id);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] MenuDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpPut]
    public Task Update([FromBody] MenuDto dto)
    { 
         return _service.Update(dto);   
    }

    [HttpDelete("{id:long}")]
    public Task Delete(long id)
    {
         return _service.Delete(id);          
    }
}
