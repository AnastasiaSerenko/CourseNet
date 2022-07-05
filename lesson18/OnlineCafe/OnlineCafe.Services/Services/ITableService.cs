using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface ITableService
{
    public Task<List<TableDto>> Get();

    public Task<TableDto> GetById(long id);

    public Task<long> Create(TableDto dto);

    public Task Update(TableDto dto);

    public Task Delete(long id);
}