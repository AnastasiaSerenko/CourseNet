using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Services;

public interface IGuestService
{
    public Task<List<GuestDto>> Get();

    public Task<GuestDto> GetById(long id);

    public Task<long> Create(GuestDto dto);

    public Task Update(GuestDto dto);

    public Task Delete(long id);
}