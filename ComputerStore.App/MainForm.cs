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
            CarregarTicketsIniciados();
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


        private void CarregarTicketsIniciados()
        {
            try
            {
                lvTickets.Items.Clear();


                var includes = new List<string> { "Client" };

                // Passamos essa lista para o método Get, igualzinho ao código do Book
                var result = _ticketService.Get<Ticket>(includes);

                // Tratamento de nulo igual ao exemplo (?? new List...)
                var allTickets = result?.ToList() ?? new List<Ticket>();

                // Filtramos os iniciados (mantendo sua regra de negócio original)
                var ticketsIniciados = allTickets
                                        .Where(t => t.Status == "Started")
                                        .ToList();

                foreach (var ticket in ticketsIniciados)
                {
                    var item = new ListViewItem(ticket.Id.ToString());

                    item.SubItems.Add(ticket.IssueDate.ToShortDateString());

                    // 2. RECUPERANDO O NOME COM SEGURANÇA
                    // Como passamos "Client" na lista de includes, o Entity Framework preencheu essa propriedade.
                    // Usamos a mesma lógica de verificação do exemplo Book (GetAuthorName)
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

        #endregion




        private Ticket GetSelectedTicket()
        {
            if (lvTickets.SelectedItems.Count > 0)
            {
                // Recupera o objeto Ticket que guardamos na propriedade .Tag
                return (Ticket)lvTickets.SelectedItems[0].Tag;
            }
            return null;
        }




        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            var clientForm = ConfigureDI.serviceProvider!.GetService<ClientRegister>();
            clientForm.ShowDialog();
        }

        private void btnServiceRegister_Click(object sender, EventArgs e)
        {
            var serviceForm = ConfigureDI.serviceProvider!.GetService<ServiceRegister>();
            serviceForm.ShowDialog();

        }

        private void btnSupplierRegister_Click(object sender, EventArgs e)
        {
            var supplierForm = ConfigureDI.serviceProvider!.GetService<SupplierRegister>();
            supplierForm.ShowDialog();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            var ticketForm = ConfigureDI.serviceProvider!.GetService<TicketRegister>();
            ticketForm.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                CarregarTicketsIniciados();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedTicket = GetSelectedTicket();

            // Verifica se tem algo selecionado
            if (selectedTicket == null)
            {
                MessageBox.Show("Please select a ticket from the list to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abre o formulário de Registro passando o Ticket selecionado (Modo Edição)
            using (var form = new TicketRegister(selectedTicket))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Se salvou com sucesso, recarrega a lista para mostrar as alterações
                    CarregarTicketsIniciados();
                }
            }
        }


    }
}
