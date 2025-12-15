using ComputerStore.App.Base;
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
    public partial class ServiceRegister : TestBaseForm
    {
        private IBaseService<ProductOrService> _serviceService;
        private IBaseService<Supplier> _supplierService;
        public ServiceRegister(IBaseService<ProductOrService> serviceService, IBaseService<Supplier> supplierService)
        {
            _supplierService = supplierService;
            _serviceService = serviceService;
            InitializeComponent();
            LoadData();
            AtualizaSupplierAndStorage();

        }

        private void FormToObjet(ProductOrService service)
        {
            if (rbProduct.Checked)
            {
                service.Type = TypeServiceOrProduct.Product;
            }
            else
            {
                service.Type = TypeServiceOrProduct.Service;
            }


            if (txtStorage.Enabled == false)
            {
                txtStorage.Text = "0";
            }


            service.Name = txtName.Text;

            if (!decimal.TryParse(txtPrice.Text, out decimal priceValue))
            {
                MessageBox.Show(@"The price shown is invalid. Please enter only numbers.",
                    "Computer Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            service.Price = priceValue;

            if (cbSupplier.Enabled && cbSupplier.SelectedItem != null)
            {
                service.Supplier = cbSupplier.SelectedItem as Supplier;
            }
            else
            {
                service.Supplier = null;
            }

            int storageValue = 0;
            if (txtStorage.Enabled && !int.TryParse(txtStorage.Text, out storageValue))
            {
                MessageBox.Show(@"The storage shown is invalid. Please enter only numbers.",
                    "Computer Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            service.Storage = storageValue;
        }

        private void LoadData()
        {
            var clients = _supplierService.Get<Supplier>().OrderBy(c => c.Name).ToList();
            cbSupplier.DataSource = clients;
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {


            try
            {
                var service = new ProductOrService();
                FormToObjet(service);
                _serviceService.Add<ProductOrService, ProductOrService, ProductOrServiceValidator>(service);
                MessageBox.Show("Added successfully.",
                    "Computer Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var form = new SupplierRegister(_supplierService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                var supplier = (List<Supplier>)cbSupplier.DataSource;
                var newSupplier = supplier.OrderBy(x => x.Id).FirstOrDefault();
                if (newSupplier != null)
                {
                    int index = cbSupplier.Items.IndexOf(newSupplier);
                    if (index >= 0) { cbSupplier.SelectedIndex = index; }
                }
            }
        }

        private void rbProduct_CheckedChanged(object sender)
        {
            AtualizaSupplierAndStorage();
        }

        private void rbService_CheckedChanged(object sender)
        {
            AtualizaSupplierAndStorage();
        }

        private void AtualizaSupplierAndStorage()
        {
            cbSupplier.Enabled = rbProduct.Checked;
            txtStorage.Enabled = rbProduct.Checked;
        }
    }
}
