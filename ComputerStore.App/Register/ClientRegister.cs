using ComputerStore.App.Base;
using ComputerStore.App.ViewModel;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum;
using ComputerStore.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.App.Register
{
    public partial class ClientRegister : TestBaseForm
    {
        private IBaseService<Client> _clientService;
        private List<ClientViewModel> _clients;
        public ClientRegister(IBaseService<Client> clientService)
        {
            _clientService = clientService;
            InitializeComponent();
        }

        private void FormToObject(Client client)
        {
            
            client.Name = txtName.Text;
            client.Email = txtEmail.Text;
            client.Document = txtDocument.Text;
            string aux = txtPhone.Text;
            client.Phone = (int)Convert.ToInt64(aux);
            
            if(rdbEnterprise.Checked)
            {
                client.TypeCLient = TypeClient.Enterprise;
            }
            if (rdbPerson.Checked)
            {
                client.TypeCLient = TypeClient.Person;
            }

            
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var client = new Client();
                FormToObject(client);
                _clientService.Add<Client,Client,ClientValidator>(client);
                MessageBox.Show("Client added successfully.",
                    "Computer Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, @"Computer Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }


        }


        private void ClearFields()
        {
            foreach (var control in this.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                {
                    textBox.Clear();
                }
            }
        }


    }
}
