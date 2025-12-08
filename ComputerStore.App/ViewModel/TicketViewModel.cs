using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Domain.Entity;

namespace ComputerStore.App.ViewModel
{
    public class TicketViewModel
    {
        public TicketViewModel() 
        {
            SaleItens = new List<SaleViewModel>();
            TicketUsers = new List<TicketUserViewModel>();
        }

        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Budget { get; set; }
        public string Status { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public string Solution { get; set; }
        public List<SaleViewModel> SaleItens { get; set; }
        public List<TicketUserViewModel> TicketUsers { get; set; }

    }

    public class SaleViewModel()
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnityValue { get; set; }
        public decimal TotalValue { get; set; }
        public ProductOrService ProductOrService { get; set; }
        public Ticket Ticket { get; set; }

    }

    public class TicketUserViewModel()
    {
        public int Id { get; set; }
        public DateTime AssignmentDate { get; set; }
        public Ticket Ticket { get; set; }
        public User User { get; set; }
    }
}
