using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class MenuService : IMenuService
{
    private readonly AppDbContext _context;
    private readonly IMenuMapper _mapper;
    public MenuService(AppDbContext context, IMenuMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<MenuDto>> Get()
    {
        return _context.Menu.ProjectTo<MenuDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<MenuDto> GetById(long id)
    {
        return _context.Menu.ProjectTo<MenuDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<long> Create(MenuDto dto)
    {
        var entity = _mapper.Map<Menu>(dto);
        await _context.Menu.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task Update(MenuDto dto)
    {
        var entity = await _context.Menu.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            throw new Exception($"Объект с id: {entity.Id} не найден");
        }
        _mapper.Map(dto, entity);


        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Menu.FirstOrDefaultAsync(x => x.Id == id);
        _context.Menu.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
