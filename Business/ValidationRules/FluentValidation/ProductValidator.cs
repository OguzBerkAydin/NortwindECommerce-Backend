using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product>
	{
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage(MyMessages.ProductNameCannotEmpty);
            RuleFor(p=>p.ProductName).Length(2,int.MaxValue).WithMessage(MyMessages.ProductNameLengthInvalid);
        }
    }
}
