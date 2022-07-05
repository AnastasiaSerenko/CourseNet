using Microsoft.AspNetCore.Mvc;
using OnlineCafe.Services.Services;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.API.Controllers;

[ApiController]
[Route("MenuIngredient")]
public class MenuIngredientController : ControllerBase
{
    private readonly IMenuIngredientService _service;

    public MenuIngredientController(IMenuIngredientService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<MenuIngredientDto>> Get() 
    {
        return _service.Get();    
    }

    [HttpGet("{menuId:long}")]
    public Task<List<MenuIngredientDto>> GetByMenuId(long menuId)
    {
        return _service.GetByMenuId(menuId);  
    }

    [HttpPost]
    public Task<long> Create([FromBody] MenuIngredientDto dto)
    { 
        return _service.Create(dto);        
    }

    [HttpDelete]
    public Task Delete([FromBody] MenuIngredientDto dto)
    {
         return _service.Delete(dto);          
    }
}
