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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(481, 422);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(669, 422);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(242, 52);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(408, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Create a new Service";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Tahoma", 11F);
            txtName.ForeColor = Color.DimGray;
            txtName.Image = null;
            txtName.Location = new Point(135, 189);
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
            label1.Location = new Point(61, 198);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 306);
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
            txtPrice.Location = new Point(135, 297);
            txtPrice.MaxLength = 32767;
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = false;
            txtPrice.Size = new Size(209, 46);
            txtPrice.TabIndex = 6;
            txtPrice.TextAlignment = HorizontalAlignment.Left;
            txtPrice.UseSystemPasswordChar = false;
            // 
            // ServiceRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 516);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(bigLabel1);
            MaximizeBox = false;
            Name = "ServiceRegister";
            Sizable = false;
            Text = "Service Register";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(bigLabel1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtPrice, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtName;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.BigTextBox txtPrice;
    }
}