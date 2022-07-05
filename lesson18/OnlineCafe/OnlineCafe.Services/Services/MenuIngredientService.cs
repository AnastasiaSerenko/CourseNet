using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class MenuIngredientService : IMenuIngredientService
{
    private readonly AppDbContext _context;
    private readonly IMenuIngredientMapper _mapper;
    public MenuIngredientService(AppDbContext context, IMenuIngredientMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<MenuIngredientDto>> Get()
    {
        return _context.MenuIngredients.ProjectTo<MenuIngredientDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<List<MenuIngredientDto>> GetByMenuId(long menuId)
    {
        return _context.MenuIngredients.ProjectTo<MenuIngredientDto>(_mapper.ConfigurationProvider)
            .Where(x => x.MenuId == menuId)
            .ToListAsync();
    }

    public async Task<long> Create(MenuIngredientDto dto)
    {
        var entity = _mapper.Map<MenuIngredient>(dto);
        await _context.MenuIngredients.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.MenuId + entity.IngredientId;
    }

    public async Task Delete(MenuIngredientDto dto)
    {
        var entity = await _context.MenuIngredients
            .FirstOrDefaultAsync(x => (x.MenuId == dto.MenuId && x.IngredientId == dto.IngredientId));
        _context.MenuIngredients.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
