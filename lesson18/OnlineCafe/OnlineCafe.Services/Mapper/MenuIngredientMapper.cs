using AutoMapper;
using OnlineCafe.Entities;
using OnlineCafe.Services.Dto;

namespace OnlineCafe.Services.Mapper;

public class MenuIngredientMapper : IMenuIngredientMapper
{    
    protected IMapper Mapper { get; set; }

    public MenuIngredientMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<MenuIngredient, MenuIngredientDto>().ReverseMap();
        });
        Mapper = config.CreateMapper();
    }

    public IConfigurationProvider ConfigurationProvider => Mapper.ConfigurationProvider;

    public T Map<T>(object source)
    {
        return Mapper.Map<T>(source);
    }

    public void Map<TSource, TDestination>(TSource source, TDestination destination)
    {
        Mapper.Map(source, destination);
    }
}
