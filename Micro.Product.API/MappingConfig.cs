using AutoMapper;

namespace Micro.Product.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Models.Dto.ProductDto, Models.Product>()
                    .ReverseMap();
            });
            return mappingConfig;
        }
    }
}
