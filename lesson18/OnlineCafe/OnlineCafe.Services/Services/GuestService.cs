using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class GuestService : IGuestService
{
    private readonly AppDbContext _context;
    private readonly IGuestMapper _mapper;
    public GuestService(AppDbContext context, IGuestMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<GuestDto>> Get()
    {
        return _context.Guests.ProjectTo<GuestDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<GuestDto> GetById(long id)
    {
        return _context.Guests.ProjectTo<GuestDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<long> Create(GuestDto dto)
    {
        var entity = _mapper.Map<Guest>(dto);
        await _context.Guests.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task Update(GuestDto dto)
    {
        var entity = await _context.Guests.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            throw new Exception($"Объект с id: {entity.Id} не найден");
        }
        _mapper.Map(dto, entity);


        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Guests.FirstOrDefaultAsync(x => x.Id == id);
        _context.Guests.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
