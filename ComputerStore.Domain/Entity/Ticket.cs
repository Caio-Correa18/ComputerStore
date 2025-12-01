
using ComputerStore.Domain.Base;

namespace ComputerStore.Domain.Entity
{
    public class Ticket : BaseEntity<int>
    {
        public Ticket() { }


        public Ticket(int id,DateTime issueDate,decimal budget,
            string status,Client client,string description, DateTime deadLine,
                string solution) : base(id)
        {
            IssueDate = issueDate;
            Budget = budget;
            Status = status;
            Client = client;
            Description = description;
            DeadLine = deadLine;
            Solution = solution;
            SaleItens = new List<Sale>();
            TicketUsers = new List<TicketUser>();
        }

        public DateTime IssueDate { get; set; }
        public decimal Budget { get; set; }
        public string Status { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public string Solution { get; set; }
        public List<Sale> SaleItens { get; set; }
        public List<TicketUser> TicketUsers { get; set; }
    }

    public class Sale : BaseEntity<int>
    {
        public Sale() { }

        public Sale(int id, int quantity, decimal unityValue,
            decimal totalValue, ProductOrService productOrService,
            Ticket ticket) : base(id)
        {
            Quantity = quantity;
            UnityValue = unityValue;
            TotalValue = totalValue;
            ProductOrService = productOrService;
            Ticket = ticket;

        }

        public int Quantity { get; set; }
        public decimal UnityValue { get; set; }
        public decimal TotalValue { get; set; }
        public ProductOrService ProductOrService { get; set; }
        public Ticket Ticket { get; set; }

    }

    public class TicketUser : BaseEntity<int>
    {
        public TicketUser() { }

        public TicketUser(int id, DateTime assignmentDate,
            Ticket ticket, User user) : base(id)
        {
            AssignmentDate = assignmentDate;
            Ticket = ticket;
            User = user;
        }

        public DateTime AssignmentDate { get; set; }
        public Ticket Ticket { get; set; }
        public User User { get; set; }
    }
}
