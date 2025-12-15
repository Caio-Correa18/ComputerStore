using ComputerStore.Domain.Entity;
using FluentValidation;

namespace ComputerStore.Service.Validators
{
    public class TicketValidator : AbstractValidator<Ticket>
    {
        public TicketValidator() 
        {
            RuleFor(d => d.Client)
                .NotEmpty().WithMessage("Customer is required");
            RuleFor(d => d.Status)
                .NotEmpty().WithMessage("Status is required");
            RuleFor(d => d.IssueDate)
                .NotEmpty().WithMessage("The issue date must be provided.");
            RuleFor(d => d.Description)
                .NotEmpty().WithMessage("Description is required");
            RuleFor(d => d.Solution)
                .NotEmpty().WithMessage("The solution is required.")
                .When(d => d.Status == "Finished");

     

        }
    }

    public class TicketUserValidator : AbstractValidator<TicketUser> 
    {
        
        public TicketUserValidator()
        {
            RuleFor(d => d.Ticket)
                .NotEmpty().WithMessage("A ticket is required.");
            RuleFor(d => d.User)
                .NotEmpty().WithMessage("The user is required.");
            

        }
    }

    public class SaleValidator : AbstractValidator<Sale>
    {

        public SaleValidator()
        {
            RuleFor(d => d.ProductOrService)
                .NotEmpty().WithMessage("A product or a service are required");
            RuleFor(d => d.Ticket)
                .NotEmpty().WithMessage("A ticket is required");
            RuleFor(d => d.TotalValue)
                .NotEmpty().WithMessage("Total item price is required!");
            RuleFor(d => d.UnityValue)
                .NotEmpty().WithMessage("The unit price of the item is required.");
            RuleFor(d => d.Quantity)
                .NotEmpty().WithMessage("Quantity of the item sold is required!");
        }

    } 



}
