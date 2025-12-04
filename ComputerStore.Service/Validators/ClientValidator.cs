using ComputerStore.Domain.Entity;
using FluentValidation;
using System.Data;

namespace ComputerStore.Service.Validators
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(d => d.Name)
               .NotEmpty().WithMessage("Client name is required!");
            RuleFor(d => d.Email)
                .NotEmpty().WithMessage(" The client's email address cannot be empty")
                .Matches(@"[a-zA-Z0-9@._-]$").WithMessage("No special characters allowed");
            RuleFor(d => d.Phone)
                .NotEmpty().WithMessage("A phone number is required.");
            RuleFor(d => d.Document)
                .NotEmpty().WithMessage("Your document is required.");
            RuleFor(d => d.TypeCLient)
                .NotEmpty().WithMessage("The type cannot be empty.");
        }

    }
}
