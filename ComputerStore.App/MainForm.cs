using ComputerStore.App.Infra;
using ComputerStore.App.Others;
using ComputerStore.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ComputerStore.App
{
    public partial class MainForm : LostForm
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
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
        }
    }
}
