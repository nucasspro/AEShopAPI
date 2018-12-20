using FluentValidation;
using Shop.ViewModel.ViewModels;

namespace Shop.WebApi.ValidationModels
{
    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Sku).NotNull().NotEmpty().Length(5,20);
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 100);
            RuleFor(x => x.Quantity).GreaterThan(0).LessThan(999);
            RuleFor(x => x.Description).MaximumLength(250);
            RuleFor(x => x.Detail);
            RuleFor(x => x.ProductImage).MaximumLength(100);
            RuleFor(x => x.ProductStatusTypeId).GreaterThanOrEqualTo(1).LessThanOrEqualTo(3);
            RuleFor(x => x.Image1).MaximumLength(100);
            RuleFor(x => x.Image2).MaximumLength(100);
            RuleFor(x => x.Image3).MaximumLength(100);
            RuleFor(x => x.Image4).MaximumLength(100);
            RuleFor(x => x.PromotionPrice).GreaterThanOrEqualTo(0).LessThanOrEqualTo(y => y.RegularPrice).WithMessage("Promotion Price need less than Regular Price");
            RuleFor(x => x.RegularPrice).NotNull().NotEmpty().GreaterThanOrEqualTo(y => y.PromotionPrice).WithMessage("Regular Price need greater than Promotion Price");
            RuleFor(x => x.IncludeVAT);
            RuleFor(x => x.Weight);
            RuleFor(x => x.Width);
            RuleFor(x => x.Height);
            RuleFor(x => x.Length);
            RuleFor(x => x.Warranty);
            RuleFor(x => x.ViewCounts);
            RuleFor(x => x.InsertedAt);
            RuleFor(x => x.UpdatedAt);
        }
    }
}