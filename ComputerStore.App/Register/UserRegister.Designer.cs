namespace ComputerStore.App.Register
{
    partial class UserRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtName = new ReaLTaiizor.Controls.BigTextBox();
            txtLogin = new ReaLTaiizor.Controls.BigTextBox();
            txtPassword = new ReaLTaiizor.Controls.BigTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(676, 404);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(105, 146);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(108, 226);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(76, 301);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(243, 62);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(357, 57);
            bigLabel1.TabIndex = 6;
            bigLabel1.Text = "Create a new user";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Tahoma", 11F);
            txtName.ForeColor = Color.DimGray;
            txtName.Image = null;
            txtName.Location = new Point(194, 146);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = false;
            txtName.Size = new Size(625, 46);
            txtName.TabIndex = 7;
            txtName.TextAlignment = HorizontalAlignment.Left;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Transparent;
            txtLogin.Font = new Font("Tahoma", 11F);
            txtLogin.ForeColor = Color.DimGray;
            txtLogin.Image = null;
            txtLogin.Location = new Point(194, 217);
            txtLogin.MaxLength = 32767;
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = false;
            txtLogin.Size = new Size(625, 46);
            txtLogin.TabIndex = 8;
            txtLogin.TextAlignment = HorizontalAlignment.Left;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Tahoma", 11F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Image = null;
            txtPassword.Location = new Point(194, 292);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(625, 46);
            txtPassword.TabIndex = 9;
            txtPassword.TextAlignment = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 494);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtName);
            Controls.Add(bigLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "UserRegister";
            Sizable = false;
            Text = "User Register";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(bigLabel1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtLogin, 0);
            Controls.SetChildIndex(txtPassword, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtName;
        private ReaLTaiizor.Controls.BigTextBox txtLogin;
        private ReaLTaiizor.Controls.BigTextBox txtPassword;
    }
}