using ComputerStore.App.Base;
using ComputerStore.App.ViewModel;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Service.Validators;
using Org.BouncyCastle.Pqc.Crypto.Saber;
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
    public partial class SupplierRegister : TestBaseForm
    {
        private IBaseService<Supplier> _supplierService;
        private List<SupplierViewModel> _suppliers;
        public SupplierRegister(IBaseService<Supplier> supplierService)
        {
            _supplierService = supplierService;
            InitializeComponent();
        }

        private void FormToObject(Supplier supplier)
        {
            supplier.Name = txtName.Text;
            supplier.Email = txtEmail.Text;
            supplier.Document = txtDocument.Text;
            string aux = txtPhone.Text;
            supplier.Phone = (int)Convert.ToInt64(aux);
            supplier.Adress = txtAddress.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var supplier = new Supplier();
                FormToObject(supplier);
                _supplierService.Add<Supplier,Supplier,SupplierValidator>(supplier);
                MessageBox.Show("Supplier added successfully.",
                    "Computer Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
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
