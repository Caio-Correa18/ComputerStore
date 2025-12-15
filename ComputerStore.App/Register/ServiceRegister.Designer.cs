namespace ComputerStore.App.Register
{
    partial class ServiceRegister
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtName = new ReaLTaiizor.Controls.BigTextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new ReaLTaiizor.Controls.BigTextBox();
            rbService = new ReaLTaiizor.Controls.AirRadioButton();
            rbProduct = new ReaLTaiizor.Controls.AirRadioButton();
            label3 = new Label();
            cbSupplier = new ReaLTaiizor.Controls.ComboBoxEdit();
            label4 = new Label();
            btnAddSupplier = new ReaLTaiizor.Controls.Button();
            label5 = new Label();
            txtStorage = new ReaLTaiizor.Controls.BigTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(485, 467);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(677, 467);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(149, 48);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(618, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Create a new Product or Service";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Tahoma", 11F);
            txtName.ForeColor = Color.DimGray;
            txtName.Image = null;
            txtName.Location = new Point(136, 227);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = false;
            txtName.Size = new Size(599, 46);
            txtName.TabIndex = 3;
            txtName.TextAlignment = HorizontalAlignment.Left;
            txtName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 236);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 344);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 5;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Transparent;
            txtPrice.Font = new Font("Tahoma", 11F);
            txtPrice.ForeColor = Color.DimGray;
            txtPrice.Image = null;
            txtPrice.Location = new Point(136, 335);
            txtPrice.MaxLength = 32767;
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = false;
            txtPrice.Size = new Size(209, 46);
            txtPrice.TabIndex = 6;
            txtPrice.TextAlignment = HorizontalAlignment.Left;
            txtPrice.UseSystemPasswordChar = false;
            // 
            // rbService
            // 
            rbService.Checked = true;
            rbService.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbService.Field = 16;
            rbService.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbService.Image = null;
            rbService.Location = new Point(115, 156);
            rbService.Name = "rbService";
            rbService.NoRounding = false;
            rbService.Size = new Size(119, 16);
            rbService.TabIndex = 7;
            rbService.Text = "Service";
            rbService.Transparent = false;
            rbService.CheckedChanged += rbService_CheckedChanged;
            // 
            // rbProduct
            // 
            rbProduct.Checked = false;
            rbProduct.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbProduct.Field = 16;
            rbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbProduct.Image = null;
            rbProduct.Location = new Point(372, 156);
            rbProduct.Name = "rbProduct";
            rbProduct.NoRounding = false;
            rbProduct.Size = new Size(152, 16);
            rbProduct.TabIndex = 8;
            rbProduct.Text = "Product";
            rbProduct.Transparent = false;
            rbProduct.CheckedChanged += rbProduct_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 105);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 9;
            label3.Text = "Type:";
            // 
            // cbSupplier
            // 
            cbSupplier.BackColor = Color.FromArgb(246, 246, 246);
            cbSupplier.DrawMode = DrawMode.OwnerDrawFixed;
            cbSupplier.DropDownHeight = 100;
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.Font = new Font("Segoe UI", 10F);
            cbSupplier.ForeColor = Color.FromArgb(142, 142, 142);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            cbSupplier.IntegralHeight = false;
            cbSupplier.ItemHeight = 20;
            cbSupplier.Location = new Point(559, 342);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(198, 26);
            cbSupplier.StartIndex = 0;
            cbSupplier.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(485, 342);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 11;
            label4.Text = "Supplier:";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.Transparent;
            btnAddSupplier.BorderColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.EnteredBorderColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.EnteredColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddSupplier.Image = Properties.Resources.Plus2;
            btnAddSupplier.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddSupplier.InactiveColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.Location = new Point(763, 336);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.PressedBorderColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.PressedColor = Color.FromArgb(2, 103, 115);
            btnAddSupplier.Size = new Size(46, 36);
            btnAddSupplier.TabIndex = 17;
            btnAddSupplier.TextAlignment = StringAlignment.Center;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(485, 401);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 18;
            label5.Text = "Storage:";
            // 
            // txtStorage
            // 
            txtStorage.BackColor = Color.Transparent;
            txtStorage.Font = new Font("Tahoma", 11F);
            txtStorage.ForeColor = Color.DimGray;
            txtStorage.Image = null;
            txtStorage.Location = new Point(575, 392);
            txtStorage.MaxLength = 32767;
            txtStorage.Multiline = false;
            txtStorage.Name = "txtStorage";
            txtStorage.ReadOnly = false;
            txtStorage.Size = new Size(73, 46);
            txtStorage.TabIndex = 19;
            txtStorage.TextAlignment = HorizontalAlignment.Left;
            txtStorage.UseSystemPasswordChar = false;
            // 
            // ServiceRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 574);
            Controls.Add(txtStorage);
            Controls.Add(label5);
            Controls.Add(btnAddSupplier);
            Controls.Add(label4);
            Controls.Add(cbSupplier);
            Controls.Add(label3);
            Controls.Add(rbProduct);
            Controls.Add(rbService);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(bigLabel1);
            MaximizeBox = false;
            Name = "ServiceRegister";
            Sizable = false;
            Text = "Service Register";
            Controls.SetChildIndex(bigLabel1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(rbService, 0);
            Controls.SetChildIndex(rbProduct, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(cbSupplier, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(btnAddSupplier, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtStorage, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtName;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.BigTextBox txtPrice;
        private ReaLTaiizor.Controls.AirRadioButton rbService;
        private ReaLTaiizor.Controls.AirRadioButton rbProduct;
        private Label label3;
        private ReaLTaiizor.Controls.ComboBoxEdit cbSupplier;
        private Label label4;
        private ReaLTaiizor.Controls.Button btnAddSupplier;
        private Label label5;
        private ReaLTaiizor.Controls.BigTextBox txtStorage;
    }
}