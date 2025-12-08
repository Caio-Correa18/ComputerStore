using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.App.Base
{
    public partial class BaseForm : LostForm
    {

        #region Variables
        protected bool IsEditMode = false;
        #endregion

        #region Method
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


        private void TabPageBaseForm(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        #endregion

        #region Methods
        private void ClearFields()
        {
            IsEditMode = false;
            foreach (var control in tabPageRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                {
                    textBox.Clear();
                }

                if (control is MaterialMaskedTextBox masketTextBox)
                {
                    masketTextBox.Clear();
                }
            }
        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }

        protected virtual void Save()
        {

        }

        protected virtual void Delete(int id)
        {

        }

        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }

            else
            {
                MessageBox.Show(@"Please, select any row!", @"ComputerStore",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }

        protected virtual void PopulateGrid()
        {

        }

        #endregion


       
    }
}
