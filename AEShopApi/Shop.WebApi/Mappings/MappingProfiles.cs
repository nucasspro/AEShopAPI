using AutoMapper;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Domain.Enumerations;
using Shop.ViewModel.ViewModels;
using Shop.WebApi.Models;

namespace Shop.WebApi.Mappings
{
    public class MappingProfiles : Profile
    {
        /// <summary>
        /// CreateMap<Product, ProductViewModel>();
        ///
        /// Product -> ProductViewModel
        ///
        /// </summary>
        public MappingProfiles()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();

            CreateMap<ProductViewModel, Product>();
            CreateMap<Product, ProductViewModel>()
                .ForMember(viewmodel => viewmodel.ProductStatusTypeId,
                opt => opt.MapFrom(view => view.ProductStatusTypeId))
                .ForMember(viewmodel => viewmodel.InsertedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.InsertedAt).ToShortDateString()))
                .ForMember(viewmodel => viewmodel.UpdatedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.UpdatedAt).ToShortDateString()));

            CreateMap<CategoryViewModel, Category>()
                .ForMember(view => view.CategoryStatusTypeId,
                opt => opt.MapFrom(viewmodel => CategoryStatusTypeEnum.FromId(viewmodel.CategoryStatusType.Id).Id))
                .ForMember(view => view.CategoryStatusType, opt => opt.Ignore());

            CreateMap<Category, CategoryViewModel>()
                .MaxDepth(2)
                .ForMember(viewmodel => viewmodel.InsertedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.InsertedAt).ToShortDateString()))
                .ForMember(viewmodel => viewmodel.UpdatedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.UpdatedAt).ToShortDateString()))
                .ForMember(viewmodel => viewmodel.CategoryStatusType, 
                opt=>opt.MapFrom(view => view.CategoryStatusType));

            CreateMap<CategoryStatusTypeViewModel, CategoryStatusType>();
            CreateMap<CategoryStatusType, CategoryStatusTypeViewModel>()
                .IncludeAllDerived()
                .ForMember(viewmodel => viewmodel.InsertedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.InsertedAt).ToShortDateString()))
                .ForMember(viewmodel => viewmodel.UpdatedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.UpdatedAt).ToShortDateString()));
        }
    }
}