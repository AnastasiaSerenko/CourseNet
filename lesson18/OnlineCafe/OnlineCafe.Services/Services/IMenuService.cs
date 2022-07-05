using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface IMenuService
{
    public Task<List<MenuDto>> Get();

    public Task<MenuDto> GetById(long id);

    public Task<long> Create(MenuDto dto);

    public Task Update(MenuDto dto);

    public Task Delete(long id);
}