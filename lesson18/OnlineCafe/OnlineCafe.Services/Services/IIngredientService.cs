using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface IIngredientService
{
    public Task<List<IngredientDto>> Get();

    public Task<IngredientDto> GetById(long id);

    public Task<long> Create(IngredientDto dto);

    public Task Update(IngredientDto dto);

    public Task Delete(long id);
}
