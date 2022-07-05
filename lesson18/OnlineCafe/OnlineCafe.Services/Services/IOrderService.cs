using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface IOrderService
{
    public Task<List<OrderDto>> Get();

    public Task<OrderDto> GetById(long id);

    public Task<long> Create(OrderDto dto);

    public Task Update(OrderDto dto);

    public Task Delete(long id);
}