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
        public ServiceRegister(IBaseService<ProductOrService> serviceService)
        {
            _serviceService = serviceService;
            InitializeComponent();
        }

        private void FormToObjet(ProductOrService service)
        {
            service.Type = TypeServiceOrProduct.Service;
            service.Name = txtName.Text;
            if(!decimal.TryParse(txtPrice.Text, out decimal priceValue))
            {
                MessageBox.Show(@"The price shown is invalid. Please enter only numbers.",
                    "Computer Store",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            service.Price = priceValue;
            service.Supplier = null;
            service.Storage = 0;
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
                MessageBox.Show("Service added successfully.",
                    "Computer Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
