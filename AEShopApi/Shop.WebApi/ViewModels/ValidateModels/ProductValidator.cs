using FluentValidation;

namespace Shop.WebApi.ViewModels.ValidateModels
{
    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name).NotNull().NotEmpty().MaximumLength(200).WithMessage("Please add product name!");
            RuleFor(product => product.Description).NotEmpty();
            RuleFor(product => product.RegularPrice).NotNull().NotEmpty();
            RuleFor(product => product.DiscountPrice).NotEqual(0);
        }
    }
}