using FluentValidation;
using Shop.WebRedux.ViewModels;

namespace Shop.WebApi.ViewModels.ValidateModels
{
    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(200).WithMessage("Please add product name!");
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.RegularPrice).NotNull().NotEmpty();
            //RuleFor(product => product.DiscountPrice).NotEqual(0);
        }
    }
}