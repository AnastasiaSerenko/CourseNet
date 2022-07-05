using AutoMapper.QueryableExtensions;
using OnlineCafe.DB;
using OnlineCafe.Entities;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace OnlineCafe.Services.Services;

public class OrderService : IOrderService
{
    private readonly AppDbContext _context;
    private readonly IOrderMapper _mapper;
    public OrderService(AppDbContext context, IOrderMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Task<List<OrderDto>> Get()
    {
        return _context.Orders.ProjectTo<OrderDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public Task<OrderDto> GetById(long id)
    {
        return _context.Orders.ProjectTo<OrderDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<long> Create(OrderDto dto)
    {
        var entity = _mapper.Map<Order>(dto);
        await _context.Orders.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task Update(OrderDto dto)
    {
        var entity = await _context.Orders.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            throw new Exception($"Объект с id: {entity.Id} не найден");
        }
        _mapper.Map(dto, entity);


        await _context.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        var entity = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        _context.Orders.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
