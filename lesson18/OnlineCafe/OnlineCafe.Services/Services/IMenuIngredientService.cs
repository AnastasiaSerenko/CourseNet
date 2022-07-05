using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface IMenuIngredientService
{
    public Task<List<MenuIngredientDto>> Get();

    public Task<List<MenuIngredientDto>> GetByMenuId(long menuId);

    public Task<long> Create(MenuIngredientDto dto);

    public Task Delete(MenuIngredientDto dto);
}
