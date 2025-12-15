using ComputerStore.Domain.Entity;
using FluentValidation;
using ComputerStore.Domain.Enum;
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
                .NotEmpty().WithMessage("Your document is required.")
                .MaximumLength(14).WithMessage("A CNPJ (Brazilian company tax ID) can only have 14 digits.")
                .MinimumLength(14).WithMessage("A CNPJ (Brazilian company tax ID) can only have 14 digits.")
                .When(d => d.TypeCLient == TypeClient.Enterprise);
            RuleFor(d => d.Document)
                .NotEmpty().WithMessage("Your document is required.")
                .MaximumLength(11).WithMessage("A CPF (Brazilian taxpayer ID) can only have 11 digits.")
                .MinimumLength(11).WithMessage("A CPF (Brazilian taxpayer ID) can only have 11 digits.")
                .When(d => d.TypeCLient == TypeClient.Person);
            RuleFor(d => d.TypeCLient)
                .IsInEnum().WithMessage("The type cannot be empty.");
        }

    }
}
