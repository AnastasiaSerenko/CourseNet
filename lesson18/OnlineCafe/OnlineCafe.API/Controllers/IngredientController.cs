using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("Ingredient")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _service;

    public IngredientController(IIngredientService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<IngredientDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{id:long}")]
    public Task<IngredientDto> GetById(long id)
    {
        return _service.GetById(id);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] IngredientDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpPut]
    public Task Update([FromBody] IngredientDto dto)
    { 
         return _service.Update(dto);   
    }

    [HttpDelete("{id:long}")]
    public Task Delete(long id)
    {
         return _service.Delete(id);          
    }
}
