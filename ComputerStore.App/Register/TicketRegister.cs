using ComputerStore.App.Base;
using ComputerStore.App.Infra;
using ComputerStore.App.Others; 
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum; 
using ComputerStore.Service.Validators; 
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComputerStore.App.Base;

namespace ComputerStore.App.Register
{
    public partial class TicketRegister : TestBaseForm
    {


        private readonly IBaseService<Ticket> _ticketService;
        private readonly IBaseService<ProductOrService> _productOrServiceService;
        private readonly IBaseService<Client> _clientService;
        private readonly IBaseService<Supplier> _supplierService;


        private List<ProductOrService> _allItens;
        private int _currentTicketId;



        public TicketRegister()
        {


            // Injeção de Dependência
            _ticketService = ConfigureDI.serviceProvider.GetService<IBaseService<Ticket>>();
            _productOrServiceService = ConfigureDI.serviceProvider.GetService<IBaseService<ProductOrService>>();
            _clientService = ConfigureDI.serviceProvider.GetService<IBaseService<Client>>();
            _supplierService = ConfigureDI.serviceProvider.GetService<IBaseService<Supplier>>();
            InitializeComponent();
            LoadData();

        }


        public TicketRegister(Ticket ticket) : this()
        {
            IsEditMode = true;
            _currentTicketId = ticket.Id;
            FillFields(ticket);
        }






        private void LoadData()
        {

            var clients = _clientService.Get<Client>().OrderBy(c => c.Name).ToList();
            cbClient.DataSource = clients;
            cbClient.DisplayMember = "Name";
            cbClient.ValueMember = "Id";


            _allItens = _productOrServiceService.Get<ProductOrService>().ToList();


            cblService.DataSource = _allItens.Where(x => x.Type == TypeServiceOrProduct.Service).ToList();
            cblService.DisplayMember = "Name";
            cblService.ValueMember = "Id";


            cblProduct.DataSource = _allItens.Where(x => x.Type == TypeServiceOrProduct.Product).ToList();
            cblProduct.DisplayMember = "Name";
            cblProduct.ValueMember = "Id";

            // FilterListByType();
        }


        private void FilterListByType()
        {
            cblService.DataSource = null;
            cblService.Items.Clear();

            List<ProductOrService> filteredList;

            if (rbProduct.Checked)
            {

                filteredList = _allItens.Where(x => x.Type == TypeServiceOrProduct.Product).ToList();
            }
            else
            {

                filteredList = _allItens.Where(x => x.Type == TypeServiceOrProduct.Service).ToList();
            }

            cblService.DataSource = filteredList;
            cblService.DisplayMember = "Name";
            cblService.ValueMember = "Id";
        }

        private void RbType_CheckedChanged(object sender, EventArgs e)
        {
            FilterListByType();
        }


        private void FillFields(Ticket ticket)
        {

            txtDate.Text = ticket.IssueDate.ToShortDateString();
            txtBudget.Text = ticket.Budget.ToString("F2");
            txtDescription.Text = ticket.Description;
            txtSolution.Text = ticket.Solution;

            rbFinished.Checked = false;
            rbStarted.Checked = false;

            if (ticket.Status == "Started") rbStarted.Checked = true;
            else if (ticket.Status == "Finished") rbFinished.Checked = true;


            if (ticket.Client != null)
            {
                cbClient.SelectedValue = ticket.Client.Id;
            }


            if (ticket.SaleItens != null)
            {
                for (int i = 0; i < cblProduct.Items.Count; i++)
                {
                    var itemDaLista = (ProductOrService)cblProduct.Items[i];


                    if (ticket.SaleItens.Any(sale => sale.ProductOrService.Id == itemDaLista.Id))
                    {
                        cblProduct.SetItemChecked(i, true);
                    }
                }

                for (int i = 0; i < cblService.Items.Count; i++)
                {
                    var itemDaLista = (ProductOrService)cblService.Items[i];


                    if (ticket.SaleItens.Any(sale => sale.ProductOrService.Id == itemDaLista.Id))
                    {
                        cblService.SetItemChecked(i, true);
                    }
                }
            }
        }


        private void FormToObject(Ticket ticket)
        {
            if (DateTime.TryParse(txtDate.Text, out DateTime date))
                ticket.IssueDate = date;
            else
                ticket.IssueDate = DateTime.Now;



            ticket.Description = txtDescription.Text;
            ticket.Solution = txtSolution.Text;
            ticket.Status = rbStarted.Checked ? "Started" : "Finished";
            ticket.Client = (Client)cbClient.SelectedItem;


            if (ticket.SaleItens == null) ticket.SaleItens = new List<Sale>();


            void AddItemsFromList(CheckedListBox listbox)
            {
                foreach (ProductOrService item in listbox.CheckedItems)
                {

                    if (!ticket.SaleItens.Any(s => s.ProductOrService.Id == item.Id))
                    {
                        var newSale = new Sale
                        {
                            ProductOrService = item,
                            Quantity = 1,
                            UnityValue = item.Price,
                            TotalValue = item.Price * 1,
                            Ticket = ticket
                        };
                        ticket.SaleItens.Add(newSale);
                    }

                    ticket.Budget += item.Price;
                }
            }

            AddItemsFromList(cblService);
            AddItemsFromList(cblProduct);


        }


        protected override void Save()
        {
            try
            {
                Ticket ticket;

                if (IsEditMode)
                {

                    ticket = _ticketService.GetById<Ticket>(_currentTicketId);

                }
                else
                {
                    ticket = new Ticket();
                }

                FormToObject(ticket);


                if (ticket.Client != null) _ticketService.AttachObject(ticket.Client);

                foreach (var sale in ticket.SaleItens)
                {
                    if (sale.ProductOrService != null)
                        _ticketService.AttachObject(sale.ProductOrService);
                }

                if (IsEditMode)
                    _ticketService.Update<Ticket, Ticket, TicketValidator>(ticket);
                else
                    _ticketService.Add<Ticket, Ticket, TicketValidator>(ticket);

                MessageBox.Show("Ticket saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Computer Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var form = new ClientRegister(_clientService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                var client = (List<Client>)cbClient.DataSource;
                var newClient = client.OrderBy(x => x.Id).FirstOrDefault();
                if (newClient != null)
                {
                    int index = cbClient.Items.IndexOf(newClient);
                    if (index >= 0) { cbClient.SelectedIndex = index; }
                }
            }
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            var form = new ServiceRegister(_productOrServiceService, _supplierService);



            if (form.ShowDialog() == DialogResult.OK)
            {
                rbService.Checked = true;
                LoadData();


                var listaAtual = (List<ProductOrService>)cblService.DataSource;
                var newService = listaAtual.OrderBy(x => x.Id).FirstOrDefault();


                if (newService != null)
                {
                    int index = cblService.Items.IndexOf(newService);
                    if (index >= 0)
                    {
                        cblService.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new ServiceRegister(_productOrServiceService, _supplierService);



            if (form.ShowDialog() == DialogResult.OK)
            {
                rbService.Checked = true;
                LoadData();

                var listaAtual = (List<ProductOrService>)cblProduct.DataSource;
                var newService = listaAtual.OrderBy(x => x.Id).FirstOrDefault();

                if (newService != null)
                {
                    int index = cblProduct.Items.IndexOf(newService);
                    if (index >= 0)
                    {
                        cblProduct.SetItemChecked(index, true);
                    }
                }
            }


        }

        private void rbService_CheckedChanged(object sender)
        {
            VerificaProductService();
        }

        private void rbProduct_CheckedChanged(object sender)
        {
            VerificaProductService();
        }

        private void rbStarted_CheckedChanged(object sender)
        {
            VerificaStatus();
        }

        private void rbFinished_CheckedChanged(object sender)
        {
            VerificaStatus();
        }

        private void VerificaStatus()
        {
            txtSolution.Enabled = rbFinished.Checked;
            if (!txtSolution.Enabled)
            {
                txtSolution.Text = string.Empty;
            }
           
        }

        private void VerificaProductService()
        {
            cblProduct.Enabled = rbProduct.Checked;
            cblService.Enabled = rbService.Checked;

            for (int i = 0; i < cblService.Items.Count; i++)
            {
                cblService.SetItemChecked(i, false);
            }

           
            for (int i = 0; i < cblProduct.Items.Count; i++)
            {
                cblProduct.SetItemChecked(i, false);
            }

        }
    }
}