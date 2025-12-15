using ComputerStore.App.Base;
using ComputerStore.App.Infra;
using ComputerStore.App.Others; // Certifique-se que UserSession está aqui
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum; // Para acessar os Enums TypeServiceOrProduct
using ComputerStore.Service.Validators; // Para o validador
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
        // Serviços injetados
        
        private readonly IBaseService<Ticket> _ticketService;
        private readonly IBaseService<ProductOrService> _productOrServiceService;
        private readonly IBaseService<Client> _clientService;

        // Lista em memória para facilitar o filtro (Produto vs Serviço)
        private List<ProductOrService> _allItens;
        private int _currentTicketId;
        

        // Construtor para NOVO Ticket
        public TicketRegister()
        {
            InitializeComponent();

            // Injeção de Dependência
            _ticketService = ConfigureDI.serviceProvider.GetService<IBaseService<Ticket>>();
            _productOrServiceService = ConfigureDI.serviceProvider.GetService<IBaseService<ProductOrService>>();
            _clientService = ConfigureDI.serviceProvider.GetService<IBaseService<Client>>();

            LoadData();
            ConfigureEvents();
        }

        // Construtor para EDITAR Ticket
        public TicketRegister(Ticket ticket) : this()
        {
            IsEditMode = true;
            _currentTicketId = ticket.Id;
            FillFields(ticket);
        }

        // 1. Configura Eventos (Cliques de botão, mudança de radio, etc)
        private void ConfigureEvents()
        {
            
            rbProduct.CheckedChanged += RbType_CheckedChanged;
            rbService.CheckedChanged += RbType_CheckedChanged;
            rbStarted.CheckedChanged += RbStatus_CheckedChanged;
            rbFinished.CheckedChanged += RbStatus_CheckedChanged;
        }

        private void RbStatus_CheckedChanged(object sender)
        {
            CheckStatus();
        }

        private void RbType_CheckedChanged(object sender)
        {
            FilterListByType();
        }

        private void CheckStatus()
        {
            if (rbStarted.Checked)
            {
                txtSolution.Enabled = false;
            }
            if (rbService.Checked)
            {
                txtSolution.Enabled = true;
            }
        }


        // 2. Carrega os dados iniciais do Banco
        private void LoadData()
        {
            // Carrega Clientes
            var clients = _clientService.Get<Client>().OrderBy(c => c.Name).ToList();
            cbClient.DataSource = clients;
            cbClient.DisplayMember = "Name";
            cbClient.ValueMember = "Id";

            // Carrega TODOS os Produtos/Serviços para memória
            _allItens = _productOrServiceService.Get<ProductOrService>().ToList();

            // Filtra a lista inicial com base no que está marcado (provavelmente Service)
            FilterListByType();
        }

        // 3. Lógica de Filtro (Product vs Service)
        private void FilterListByType()
        {
            cblService.DataSource = null;
            cblService.Items.Clear();

            List<ProductOrService> filteredList;

            if (rbProduct.Checked)
            {
                // Filtra onde o Enum Type é Product (ajuste o nome do Enum se for diferente)
                filteredList = _allItens.Where(x => x.Type == TypeServiceOrProduct.Product).ToList();
            }
            else
            {
                // Filtra onde o Enum Type é Service
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

        // 4. Preenche os campos (Modo Edição)
        private void FillFields(Ticket ticket)
        {
            // Campos Simples
            txtDate.Text = ticket.IssueDate.ToShortDateString();
            txtBudget.Text = ticket.Budget.ToString("F2");
            bigTextBox1.Text = ticket.Description;
            txtSolution.Text = ticket.Solution;

            // Status
            if (ticket.Status == "Started") rbStarted.Checked = true;
            else if (ticket.Status == "Finished") rbFinished.Checked = true;

            // Cliente
            if (ticket.Client != null)
            {
                cbClient.SelectedValue = ticket.Client.Id;
            }

            // Itens (SaleItens)
            // Aqui tem um truque: Como filtramos a lista visual, pode ser que alguns itens do ticket 
            // não estejam visíveis agora (ex: ticket tem produto, mas radio 'Service' tá marcado).
            // O ideal seria marcar o que der.
            if (ticket.SaleItens != null)
            {
                for (int i = 0; i < cblService.Items.Count; i++)
                {
                    var itemDaLista = (ProductOrService)cblService.Items[i];

                    // Verifica se esse item existe na lista de vendas do ticket
                    if (ticket.SaleItens.Any(sale => sale.ProductOrService.Id == itemDaLista.Id))
                    {
                        cblService.SetItemChecked(i, true);
                    }
                }
            }
        }

        // 5. Passa dados do Form para o Objeto
        private void FormToObject(Ticket ticket)
        {
            if (DateTime.TryParse(txtDate.Text, out DateTime date))
                ticket.IssueDate = date;
            else
                ticket.IssueDate = DateTime.Now;

            if (decimal.TryParse(txtBudget.Text, out decimal budget))
                ticket.Budget = budget;

            ticket.Description = bigTextBox1.Text;
            ticket.Solution = txtSolution.Text;

            // Define Prazo padrão (ex: 7 dias) se for novo
            if (ticket.Id == 0) ticket.DeadLine = DateTime.Now.AddDays(7);

            ticket.Status = rbStarted.Checked ? "Started" : "Finished";
            ticket.Client = (Client)cbClient.SelectedItem;

            // Lógica dos Itens (Sale)
            if (ticket.SaleItens == null) ticket.SaleItens = new List<Sale>();

            // Nota: Num cenário real, você provavelmente limparia a lista e refaria, 
            // ou gerenciaria adições/remoções. Aqui vamos adicionar os novos selecionados.
            // O CheckedListBox não tem "Quantidade", então assumiremos Qtd = 1.

            // IMPORTANTE: Esse loop pega apenas os itens VISÍVEIS e MARCADOS na lista atual.
            foreach (ProductOrService item in cblService.CheckedItems)
            {
                // Só adiciona se ainda não existir na lista (evita duplicação se salvar 2x)
                if (!ticket.SaleItens.Any(s => s.ProductOrService.Id == item.Id))
                {
                    var newSale = new Sale
                    {
                        ProductOrService = item,
                        Quantity = 1,
                        UnityValue = item.Price,
                        TotalValue = item.Price * 1, // Qtde 1
                        Ticket = ticket
                    };
                    ticket.SaleItens.Add(newSale);
                }
            }
        }

        // 6. Botão Salvar
        protected override void Save()
        {
            try
            {
                Ticket ticket;

                if (IsEditMode)
                {
                    // Busca com Includes para trazer a lista de itens e cliente
                    // Atenção: O seu BaseService precisa suportar Includes strings ou expression
                    ticket = _ticketService.GetById<Ticket>(_currentTicketId);
                    // Se o GetById genérico não trouxer os itens (SaleItens), pode dar erro ao salvar.
                    // Idealmente: _ticketService.GetById(_currentTicketId, new List<string> { "SaleItens", "Client" });
                }
                else
                {
                    ticket = new Ticket();
                }

                FormToObject(ticket);

                // Anexa objetos relacionados para evitar duplicação no EF Core
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
            var clientForm = ConfigureDI.serviceProvider!.GetService<ClientRegister>();
            clientForm.ShowDialog();
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            var serviceForm = ConfigureDI.serviceProvider!.GetService<ServiceRegister>();
            serviceForm.ShowDialog();
        }
    }
}