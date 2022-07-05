using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("Table")]
public class TableController : ControllerBase
{
    private readonly ITableService _service;

    public TableController(ITableService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<TableDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{id:long}")]
    public Task<TableDto> GetById(long id)
    {
        return _service.GetById(id);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] TableDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpPut]
    public Task Update([FromBody] TableDto dto)
    { 
         return _service.Update(dto);   
    }

    [HttpDelete("{id:long}")]
    public Task Delete(long id)
    {
         return _service.Delete(id);          
    }
}
