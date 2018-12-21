using FluentValidation;
using Shop.ViewModel.ViewModels;

namespace Shop.WebApi.ValidationModels
{
    public class CategoryValidator : AbstractValidator<CategoryViewModel>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 50);
            RuleFor(x => x.Description).MaximumLength(200);
            RuleFor(x => x.Image).MaximumLength(100);
            //RuleFor(x => x.CategoryStatusTypeId).GreaterThanOrEqualTo(1).LessThanOrEqualTo(2);
            RuleFor(x => x.InsertedAt);
            RuleFor(x => x.UpdatedAt);
        }
    }
}