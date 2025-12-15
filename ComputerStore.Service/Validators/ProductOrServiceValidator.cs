using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum;
using FluentValidation;
using System.Data;

namespace ComputerStore.Service.Validators
{
    public class ProductOrServiceValidator : AbstractValidator<ProductOrService>
    {
        public ProductOrServiceValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("The name of the ticket or product is required.");
            RuleFor(d => d.Price)
                .NotEmpty().WithMessage("The price of the item or product is mandatory.")
                .GreaterThan(0).WithMessage("The price cannot be negative.");
            RuleFor(d => d.Type)
                .IsInEnum().WithMessage("The type cannot be empty.");
            RuleFor(d => d.Supplier)
                .NotNull().WithMessage("The supplier is required for products.")
                .When(d => d.Type == TypeServiceOrProduct.Product);
        }
    }
}
