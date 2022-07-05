using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class TableService : ITableService
{
    private readonly AppDbContext _context;
    private readonly ITableMapper _mapper;
    public TableService(AppDbContext context, ITableMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<TableDto>> Get()
    {
        return _context.Tables.ProjectTo<TableDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<TableDto> GetById(long id)
    {
        return _context.Tables.ProjectTo<TableDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<long> Create(TableDto dto)
    {
        var entity = _mapper.Map<Table>(dto);
        await _context.Tables.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task Update(TableDto dto)
    {
        var entity = await _context.Tables.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            throw new Exception($"Объект с id: {entity.Id} не найден");
        }
        _mapper.Map(dto, entity);


        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Tables.FirstOrDefaultAsync(x => x.Id == id);
        _context.Tables.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
