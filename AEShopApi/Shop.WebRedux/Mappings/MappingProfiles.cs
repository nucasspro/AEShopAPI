using AutoMapper;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using Shop.Domain.Enumerations;
using Shop.ViewModel.ViewModels;
using Shop.WebApi.FormModels;
using System;

namespace Shop.WebRedux.Mappings
{
    public class MappingProfiles : Profile
    {
        /// <summary>
        /// CreateMap<Product, ProductViewModel>();
        /// Source: Product Model
        /// Destination: ProductViewModel viewmodel
        /// </summary>
        public MappingProfiles()
        {
            #region Mapping Admin Model

            //CreateMap<AdminViewModel, Admin>();
            //CreateMap<Admin, AdminViewModel>()
            //    .ForMember(destination => destination.IsActive,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(ActivateType), source.IsActive)))
            //    .ForMember(destination => destination.Gender,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(GenderType), source.Gender)))
            //    .ForMember(destination => destination.InsertedAt,
            //    opt => opt.MapFrom(source => ConvertDatetime.UnixTimestampToDateTime(source.InsertedAt)));

            #endregion Mapping Admin Model

            //CreateMap<ProductCategory, ProductCategoryViewModel>();
            ////CreateMap<Category, CategoryViewModel>()
            ////    .ForMember(destination => destination.ParentName,
            ////    opt => opt.MapFrom(source => Enum.GetName(typeof(CategoryType), source.ParentId)));

            #region Mapping Customer

            //CreateMap<CustomerViewModel, Customer>();
            //CreateMap<Customer, CustomerViewModel>()
            //    .ForMember(destination => destination.IsActive,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(ActivateType), source.IsActive)))
            //    .ForMember(destination => destination.Gender,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(GenderType), source.Gender)));

            #endregion Mapping Customer

            #region Mapping Discount Model

            //CreateMap<DiscountViewModel, Discount>();
            //CreateMap<Discount, DiscountViewModel>()
            //    .ForMember(destination => destination.IsActive,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(ActivateType), source.IsActive)))
            //     .ForMember(destination => destination.IsRedeem,
            //    opt => opt.MapFrom(source => Enum.GetName(typeof(RedeemType), source.IsRedeem)));

            CreateMap<DiscountViewModel, Discount>();
            CreateMap<Discount, DiscountViewModel>();

            #endregion Mapping Discount Model

            #region Mapping OrderDetail Model

            CreateMap<OrderDetail, OrderDetailViewModel>();
            CreateMap<OrderDetailViewModel, OrderDetail>();

            #endregion Mapping OrderDetail Model

            #region Mapping Order Model

            //CreateMap<Order, OrderViewModel>();
            //CreateMap<OrderViewModel, Order>();

            #endregion Mapping Order Model

            #region Mapping Payment Model

            //CreateMap<Payment, PaymentViewModel>();
            //CreateMap<PaymentViewModel, Payment>();

            #endregion Mapping Payment Model

            #region Mapping Product Model

            CreateMap<ProductViewModel, Product>()
                .ForMember(model => model.ProductStatusTypeId,
                opt=> opt.MapFrom(viewmodel => ProductStatusTypeEnum.FromName(viewmodel.ProductStatusName).Id));
            CreateMap<Product, ProductViewModel>()
                //.ForMember(viewmodel => viewmodel.ProductStatusName,
                //opt => opt.MapFrom(model => Enumeration.FromValue<ProductStatusTypeEnum>(model.ProductStatusId).ToString()))
                //opt => opt.MapFrom(model => ProductStatusTypeEnum.From(model.ProductStatusId).Name))
                .ForMember(viewmodel => viewmodel.InsertedAt,
                opt => opt.MapFrom(source => ConvertDatetime.UnixTimestampToDateTime(source.InsertedAt)))
                .ForMember(viewmodel => viewmodel.UpdatedAt,
                opt => opt.MapFrom(model => ConvertDatetime.UnixTimestampToDateTime(model.UpdatedAt)));

            #endregion Mapping Product Model

            #region Mapping ShippingProvider Model

            //CreateMap<ShippingProvider, ShippingProviderViewModel>();
            //CreateMap<ShippingProviderViewModel, ShippingProvider>();

            #endregion Mapping ShippingProvider Model

            #region Mapping Shipping Model

            //CreateMap<Shipping, ShippingViewModel>();
            //CreateMap<ShippingViewModel, Shipping>();

            #endregion Mapping Shipping Model

            //CreateMap<Product, ProductViewModel>()
            //.ForMember(viewmodel => viewmodel.ProductStatusName,
            //opt => opt.MapFrom(model => Enumeration.FromValue<ProductStatusTypeEnum>(model.ProductStatusId).ToString()));
            //.ForMember(viewmodel => viewmodel.ProductStatusName, opt => opt.MapFrom("1"));
            //.ForMember(viewmodel => viewmodel.ProductStatusName,
            //opt => opt.MapFrom(model => Enumeration.FromValue<ProductStatusTypeEnum>(model.ProductStatusId).displayName));

            #region Mapping EditProductViewModel

            CreateMap<EditProductViewModel, Product>()
                .ForMember(model => model.UpdatedAt,
                opt => opt.MapFrom(viewmodel => ConvertDatetime.ConvertToTimeSpan(DateTime.Now)));

            #endregion Mapping EditProductViewModel

            #region Mapping ProductStatusType

            CreateMap<ProductStatusType, ProductStatusTypeViewModel>();
            CreateMap<ProductStatusTypeViewModel, ProductStatusType>();

            #endregion Mapping ProductStatusType

            #region Mapping Category

            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();

            #endregion Mapping Category
        }
    }
}