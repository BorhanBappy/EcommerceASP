using AutoMapper;
using Ecommerce.ModelViews;
using Ecommerce.Entity.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductModelViews, Product>()
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.ImageFileName, opt => opt.Ignore());

        CreateMap<Product, ProductModelViews>();
    }
}