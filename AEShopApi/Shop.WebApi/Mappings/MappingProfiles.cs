using AutoMapper;
using Shop.Domain.Entities;
using Shop.Domain.Enumerations;
using Shop.WebApi.ViewModels;
using System;

namespace Shop.WebApi.Mappings
{
    public class MappingProfiles : Profile
    {
        /// <summary>
        /// CreateMap<Product, ProductViewModel>();
        /// Source: Product Model
        /// Destination: ProductViewModel model
        /// </summary>
        public MappingProfiles()
        {
            CreateMap<Product, ProductViewModel>();

            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Category, CategoryViewModel>()
                .ForMember(destination => destination.ParentName,
                opt => opt.MapFrom(source => Enum.GetName(typeof(CategoryType), source.ParentId)));
        }
    }
}