namespace ComputerStore.App.Register
{
    partial class ProductRegister
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
            label3 = new Label();
            txtStorage = new ReaLTaiizor.Controls.BigTextBox();
            txtPrice = new ReaLTaiizor.Controls.BigTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(412, 356);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(611, 356);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(264, 48);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(266, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "New Product";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Tahoma", 11F);
            txtName.ForeColor = Color.DimGray;
            txtName.Image = null;
            txtName.Location = new Point(115, 139);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = false;
            txtName.Size = new Size(648, 46);
            txtName.TabIndex = 3;
            txtName.TextAlignment = HorizontalAlignment.Left;
            txtName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 148);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 253);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 5;
            label2.Text = "Storage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(412, 253);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            // 
            // txtStorage
            // 
            txtStorage.BackColor = Color.Transparent;
            txtStorage.Font = new Font("Tahoma", 11F);
            txtStorage.ForeColor = Color.DimGray;
            txtStorage.Image = null;
            txtStorage.Location = new Point(114, 244);
            txtStorage.MaxLength = 32767;
            txtStorage.Multiline = false;
            txtStorage.Name = "txtStorage";
            txtStorage.ReadOnly = false;
            txtStorage.Size = new Size(257, 46);
            txtStorage.TabIndex = 7;
            txtStorage.TextAlignment = HorizontalAlignment.Left;
            txtStorage.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Transparent;
            txtPrice.Font = new Font("Tahoma", 11F);
            txtPrice.ForeColor = Color.DimGray;
            txtPrice.Image = null;
            txtPrice.Location = new Point(486, 244);
            txtPrice.MaxLength = 32767;
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = false;
            txtPrice.Size = new Size(257, 46);
            txtPrice.TabIndex = 8;
            txtPrice.TextAlignment = HorizontalAlignment.Left;
            txtPrice.UseSystemPasswordChar = false;
            // 
            // ProductRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(txtStorage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(bigLabel1);
            MaximizeBox = false;
            Name = "ProductRegister";
            Sizable = false;
            Text = "Form1";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(bigLabel1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtStorage, 0);
            Controls.SetChildIndex(txtPrice, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.BigTextBox txtStorage;
        private ReaLTaiizor.Controls.BigTextBox txtPrice;
    }
}