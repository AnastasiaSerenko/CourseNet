using AutoMapper;

namespace OnlineCafe.Services.Mapper;

public interface IMenuIngredientMapper
{
    IConfigurationProvider ConfigurationProvider { get; }
    T Map<T>(object source);
    void Map<TSource, TDestination>(TSource source, TDestination destination);
}
