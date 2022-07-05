using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class IngredientService : IIngredientService
{
    private readonly AppDbContext _context;
    private readonly IIngredientMapper _mapper;
    public IngredientService(AppDbContext context, IIngredientMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<IngredientDto>> Get()
    {
        return _context.Ingredients.ProjectTo<IngredientDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<IngredientDto> GetById(long id)
    {
        return _context.Ingredients.ProjectTo<IngredientDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<long> Create(IngredientDto dto)
    {
        var entity = _mapper.Map<Ingredient>(dto);
        await _context.Ingredients.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task Update(IngredientDto dto)
    {
        var entity = await _context.Ingredients.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            throw new Exception($"Объект с id: {entity.Id} не найден");
        }
        _mapper.Map(dto, entity);


        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Ingredients.FirstOrDefaultAsync(x => x.Id == id);
        _context.Ingredients.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
