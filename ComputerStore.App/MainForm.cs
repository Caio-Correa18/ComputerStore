using ComputerStore.App.Infra;
using ComputerStore.App.Others;
using ComputerStore.App.Register;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using Microsoft.EntityFrameworkCore;
using ComputerStore.Service.Service;
using ComputerStore.App.ViewModel;

namespace ComputerStore.App
{
    public partial class MainForm : LostForm
    {
        private readonly IBaseService<Ticket> _ticketService;
        private readonly IBaseService<Supplier> _supplierService;
        private readonly IBaseService<Client> _clientService;
        private readonly IBaseService<ProductOrService> _productOrServiceService;
        public MainForm()
        {
            _ticketService = ConfigureDI.serviceProvider!.GetService<IBaseService<Ticket>>();
            _supplierService = ConfigureDI.serviceProvider!.GetService<IBaseService<Supplier>>();
            _clientService = ConfigureDI.serviceProvider!.GetService<IBaseService<Client>>();
            _productOrServiceService = ConfigureDI.serviceProvider!.GetService<IBaseService<ProductOrService>>();
            InitializeComponent();
            LoadLogin();

            ConfigListView();
            ConfigListViewTickedFinished();
            CarregarTicketsIniciados();
            CarregarTicketsFinalizados();
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }


        #region Create

        private void ConfigListView()
        {
            lvTickets.View = View.Details;
            lvTickets.FullRowSelect = true;
            lvTickets.GridLines = true;

            lvTickets.Columns.Clear();


            lvTickets.Columns.Add("ID", 50);
            lvTickets.Columns.Add("Date", 100);
            lvTickets.Columns.Add("Client", 200);
            lvTickets.Columns.Add("Description", 300);
            lvTickets.Columns.Add("Budget (R$)", 100);
        }

        private void ConfigListViewTickedFinished()
        {
            lvTicketsFinished.View = View.Details;
            lvTicketsFinished.FullRowSelect = true;
            lvTicketsFinished.GridLines = true;

            lvTicketsFinished.Columns.Clear();


            lvTicketsFinished.Columns.Add("ID", 50);
            lvTicketsFinished.Columns.Add("Date", 100);
            lvTicketsFinished.Columns.Add("Client", 200);
            lvTicketsFinished.Columns.Add("Description", 300);
            lvTicketsFinished.Columns.Add("Budget (R$)", 100);
        }

        private void CarregarTicketsIniciados()
        {
            try
            {
                lvTickets.Items.Clear();


                var includes = new List<string> { "Client" };
                var result = _ticketService.Get<Ticket>(includes);
                var allTickets = result?.ToList() ?? new List<Ticket>();
                var ticketsIniciados = allTickets
                                        .Where(t => t.Status == "Started")
                                        .ToList();

                foreach (var ticket in ticketsIniciados)
                {
                    var item = new ListViewItem(ticket.Id.ToString());

                    item.SubItems.Add(ticket.IssueDate.ToShortDateString());

                    
                    string clientName = ticket.Client != null ? ticket.Client.Name : "Unknown";
                    item.SubItems.Add(clientName);

                    item.SubItems.Add(ticket.Description);
                    item.SubItems.Add(ticket.Budget.ToString("F2"));

                    item.Tag = ticket;

                    lvTickets.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to load tickets: {ex.Message}");
            }
        }

        private void CarregarTicketsFinalizados()
        {
            try
            {
                lvTicketsFinished.Items.Clear();


                var includes = new List<string> { "Client" };
                var result = _ticketService.Get<Ticket>(includes);
                var allTickets = result?.ToList() ?? new List<Ticket>();
                var ticketsFinished = allTickets
                                        .Where(t => t.Status == "Finished")
                                        .ToList();

                foreach (var ticket in ticketsFinished)
                {
                    var item = new ListViewItem(ticket.Id.ToString());

                    item.SubItems.Add(ticket.IssueDate.ToShortDateString());


                    string clientName = ticket.Client != null ? ticket.Client.Name : "Unknown";
                    item.SubItems.Add(clientName);

                    item.SubItems.Add(ticket.Description);
                    item.SubItems.Add(ticket.Budget.ToString("F2"));

                    item.Tag = ticket;

                    lvTicketsFinished.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to load tickets: {ex.Message}");
            }
        }

        #endregion




        private Ticket GetSelectedTicket()
        {
            if (lvTickets.SelectedItems.Count > 0)
            {
                return (Ticket)lvTickets.SelectedItems[0].Tag;
            }
            return null;
        }

        private Ticket GetSelectedTicketFinished()
        {
            if (lvTicketsFinished.SelectedItems.Count > 0)
            {

                return (Ticket)lvTicketsFinished.SelectedItems[0].Tag;
            }
            return null;
        }




       

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            var ticketForm = ConfigureDI.serviceProvider!.GetService<TicketRegister>();
            ticketForm.ShowDialog();
            if (ticketForm.DialogResult == DialogResult.OK)
            {
                CarregarTicketsFinalizados();
                CarregarTicketsIniciados();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedTicket = GetSelectedTicket();

            if (selectedTicket == null)
            {
                MessageBox.Show("Please select a ticket from the list to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (var form = new TicketRegister(selectedTicket))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    CarregarTicketsIniciados();
                    CarregarTicketsFinalizados();
                }
            }
        }

        private void btnEditFinished_Click(object sender, EventArgs e)
        {
            var selectedTicket = GetSelectedTicketFinished();

            
            if (selectedTicket == null)
            {
                MessageBox.Show("Please select a ticket from the list to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            using (var form = new TicketRegister(selectedTicket))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                    CarregarTicketsFinalizados();
                    CarregarTicketsIniciados();
                }
            }
        }


        public void Refresh()
        {
            lvTicketsFinished.Items.Clear();
            lvTickets.Items.Clear();
            CarregarTicketsIniciados();
            CarregarTicketsFinalizados();
        }


        private void tabPageMain_Click(object sender, EventArgs e)
        {
            if (airTabPage1.SelectedTab == tabPage1)
            {
                CarregarTicketsIniciados();
                CarregarTicketsFinalizados();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ticket selectedTicket = GetSelectedTicket();

            if (selectedTicket == null)
            {
                selectedTicket = GetSelectedTicketFinished();
            }

            if (selectedTicket == null)
            {
                MessageBox.Show("Please select a ticket to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string descriptionPreview = selectedTicket.Description?.Length > 30
                                        ? selectedTicket.Description.Substring(0, 30) + "..."
                                        : selectedTicket.Description;

            var result = MessageBox.Show(
                $"Are you sure you want to remove Ticket #{selectedTicket.Id} ('{descriptionPreview}')?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                try
                {
                    _ticketService.Delete(selectedTicket.Id);
                    MessageBox.Show("Ticket removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    CarregarTicketsFinalizados();
                    CarregarTicketsIniciados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
