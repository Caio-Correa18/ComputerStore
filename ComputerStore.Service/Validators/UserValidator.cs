using ComputerStore.Domain.Entity;
using FluentValidation;
using System.Data;

namespace ComputerStore.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("Username is required.");
            RuleFor(d => d.Login)
                .NotEmpty().WithMessage("Your login cannot be empty.")
                .Matches(@"[0-9]+").WithMessage("Your login must contain at least one number.")
                .Matches(@"[a-zA-Z0-9@._-]$").WithMessage("No special characters allowed");
            RuleFor(d => d.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("The password must be at least 8 characters long.")
                .MaximumLength(20).WithMessage("The password must be a maximum of 20 characters long.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                .Matches(@"[\!\?\*\.\@]+").WithMessage("Your password must contain at least one special character (! ? * .).");


        }

    }
}
