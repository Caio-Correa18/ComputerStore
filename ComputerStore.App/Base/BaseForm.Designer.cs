namespace ComputerStore.App.Base
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRegister = new TabPage();
            panel1 = new Panel();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnAdd = new ReaLTaiizor.Controls.Button();
            tabPage2 = new TabPage();
            dataGridViewList = new DataGridView();
            panel2 = new Panel();
            btnEdit = new ReaLTaiizor.Controls.Button();
            btnNew = new ReaLTaiizor.Controls.Button();
            btnDelete = new ReaLTaiizor.Controls.Button();
            imageList1 = new ImageList(components);
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPage2);
            tabControlRegister.Depth = 0;
            tabControlRegister.ImageList = imageList1;
            tabControlRegister.Location = new Point(5, 39);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(790, 413);
            tabControlRegister.TabIndex = 0;
            tabControlRegister.Enter += TabPageBaseForm;
            // 
            // tabPageRegister
            // 
            tabPageRegister.BackColor = Color.FromArgb(2, 103, 115);
            tabPageRegister.Controls.Add(panel1);
            tabPageRegister.ImageKey = "form.png";
            tabPageRegister.Location = new Point(4, 37);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(782, 372);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Create";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(255, 239, 214);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(3, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 74);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancel.EnteredBorderColor = Color.FromArgb(60, 166, 166);
            btnCancel.EnteredColor = Color.FromArgb(60, 166, 166);
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(60, 166, 166);
            btnCancel.Location = new Point(650, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(60, 166, 166);
            btnCancel.PressedColor = Color.FromArgb(60, 166, 166);
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(32, 34, 37);
            btnAdd.EnteredBorderColor = Color.FromArgb(60, 166, 166);
            btnAdd.EnteredColor = Color.FromArgb(255, 128, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Image = null;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.InactiveColor = Color.FromArgb(60, 166, 166);
            btnAdd.Location = new Point(539, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedBorderColor = Color.FromArgb(60, 166, 166);
            btnAdd.PressedColor = Color.FromArgb(60, 166, 166);
            btnAdd.Size = new Size(91, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(2, 103, 115);
            tabPage2.Controls.Add(dataGridViewList);
            tabPage2.Controls.Add(panel2);
            tabPage2.ImageIndex = 6;
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(782, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(3, 0);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.Size = new Size(773, 289);
            dataGridViewList.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(255, 239, 214);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Location = new Point(0, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 74);
            panel2.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(32, 34, 37);
            btnEdit.EnteredBorderColor = Color.FromArgb(60, 166, 166);
            btnEdit.EnteredColor = Color.FromArgb(255, 128, 0);
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Image = null;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.InactiveColor = Color.FromArgb(60, 166, 166);
            btnEdit.Location = new Point(567, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedBorderColor = Color.FromArgb(60, 166, 166);
            btnEdit.PressedColor = Color.FromArgb(60, 166, 166);
            btnEdit.Size = new Size(91, 44);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.Transparent;
            btnNew.BorderColor = Color.FromArgb(32, 34, 37);
            btnNew.EnteredBorderColor = Color.FromArgb(60, 166, 166);
            btnNew.EnteredColor = Color.FromArgb(60, 166, 166);
            btnNew.Font = new Font("Microsoft Sans Serif", 12F);
            btnNew.Image = null;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.InactiveColor = Color.FromArgb(60, 166, 166);
            btnNew.Location = new Point(664, 17);
            btnNew.Name = "btnNew";
            btnNew.PressedBorderColor = Color.FromArgb(60, 166, 166);
            btnNew.PressedColor = Color.FromArgb(60, 166, 166);
            btnNew.Size = new Size(92, 44);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.TextAlignment = StringAlignment.Center;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderColor = Color.FromArgb(32, 34, 37);
            btnDelete.EnteredBorderColor = Color.FromArgb(60, 166, 166);
            btnDelete.EnteredColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Image = null;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.InactiveColor = Color.FromArgb(60, 166, 166);
            btnDelete.Location = new Point(457, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBorderColor = Color.FromArgb(60, 166, 166);
            btnDelete.PressedColor = Color.FromArgb(60, 166, 166);
            btnDelete.Size = new Size(104, 44);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Aba.png");
            imageList1.Images.SetKeyName(1, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(2, "ComputerStoreIcon.png");
            imageList1.Images.SetKeyName(3, "form.png");
            imageList1.Images.SetKeyName(4, "imac.png");
            imageList1.Images.SetKeyName(5, "plus.png");
            imageList1.Images.SetKeyName(6, "Search.png");
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(tabControlRegister);
            HeaderColor = Color.FromArgb(1, 46, 64);
            Image = Properties.Resources.ComputerStoreIcon;
            Name = "BaseForm";
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        protected TabPage tabPageRegister;
        protected TabPage tabPage2;
        protected Panel panel1;
        protected ReaLTaiizor.Controls.Button btnAdd;
        protected ReaLTaiizor.Controls.Button btnCancel;
        protected Panel panel2;
        protected ReaLTaiizor.Controls.Button btnNew;
        protected ReaLTaiizor.Controls.Button btnDelete;
        protected ReaLTaiizor.Controls.Button btnEdit;
        protected ImageList imageList1;
        protected DataGridView dataGridViewList;
    }
}