namespace ComputerStore.App.Register
{
    partial class ClientRegister
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
            txtName = new ReaLTaiizor.Controls.TextBoxEdit();
            lblName = new Label();
            label1 = new Label();
            rdbEnterprise = new ReaLTaiizor.Controls.AirRadioButton();
            rdbPerson = new ReaLTaiizor.Controls.AirRadioButton();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new ReaLTaiizor.Controls.TextBoxEdit();
            txtDocument = new ReaLTaiizor.Controls.TextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.TextBoxEdit();
            label4 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(683, 613);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(889, 613);
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Tahoma", 11F);
            txtName.ForeColor = Color.FromArgb(176, 183, 191);
            txtName.Image = null;
            txtName.Location = new Point(136, 286);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = false;
            txtName.Size = new Size(851, 46);
            txtName.TabIndex = 9;
            txtName.TextAlignment = HorizontalAlignment.Left;
            txtName.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(62, 295);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 10;
            lblName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(76, 162);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 11;
            label1.Text = "Type:";
            // 
            // rdbEnterprise
            // 
            rdbEnterprise.Checked = false;
            rdbEnterprise.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rdbEnterprise.Field = 16;
            rdbEnterprise.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbEnterprise.Image = null;
            rdbEnterprise.Location = new Point(108, 225);
            rdbEnterprise.Name = "rdbEnterprise";
            rdbEnterprise.NoRounding = false;
            rdbEnterprise.Size = new Size(120, 16);
            rdbEnterprise.TabIndex = 14;
            rdbEnterprise.Text = "Enterprise";
            rdbEnterprise.Transparent = false;
            // 
            // rdbPerson
            // 
            rdbPerson.Checked = true;
            rdbPerson.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rdbPerson.Field = 16;
            rdbPerson.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbPerson.Image = null;
            rdbPerson.Location = new Point(335, 225);
            rdbPerson.Name = "rdbPerson";
            rdbPerson.NoRounding = false;
            rdbPerson.Size = new Size(120, 16);
            rdbPerson.TabIndex = 15;
            rdbPerson.Text = "Person";
            rdbPerson.Transparent = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 410);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 16;
            label2.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(481, 410);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 17;
            label3.Text = "Document:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.Transparent;
            txtPhone.Font = new Font("Tahoma", 11F);
            txtPhone.ForeColor = Color.FromArgb(176, 183, 191);
            txtPhone.Image = null;
            txtPhone.Location = new Point(128, 410);
            txtPhone.MaxLength = 32767;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = false;
            txtPhone.Size = new Size(327, 46);
            txtPhone.TabIndex = 18;
            txtPhone.TextAlignment = HorizontalAlignment.Left;
            txtPhone.UseSystemPasswordChar = false;
            // 
            // txtDocument
            // 
            txtDocument.BackColor = Color.Transparent;
            txtDocument.Font = new Font("Tahoma", 11F);
            txtDocument.ForeColor = Color.FromArgb(176, 183, 191);
            txtDocument.Image = null;
            txtDocument.Location = new Point(594, 410);
            txtDocument.MaxLength = 32767;
            txtDocument.Multiline = false;
            txtDocument.Name = "txtDocument";
            txtDocument.ReadOnly = false;
            txtDocument.Size = new Size(393, 46);
            txtDocument.TabIndex = 19;
            txtDocument.TextAlignment = HorizontalAlignment.Left;
            txtDocument.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Tahoma", 11F);
            txtEmail.ForeColor = Color.FromArgb(176, 183, 191);
            txtEmail.Image = null;
            txtEmail.Location = new Point(171, 511);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(816, 46);
            txtEmail.TabIndex = 20;
            txtEmail.TextAlignment = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(76, 520);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 21;
            label4.Text = "Email:";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(336, 57);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(384, 57);
            bigLabel1.TabIndex = 22;
            bigLabel1.Text = "Create a new Client";
            // 
            // ClientRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 716);
            Controls.Add(bigLabel1);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtDocument);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdbPerson);
            Controls.Add(rdbEnterprise);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtName);
            MaximizeBox = false;
            Name = "ClientRegister";
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Client Register";
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(rdbEnterprise, 0);
            Controls.SetChildIndex(rdbPerson, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(txtDocument, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(bigLabel1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.TextBoxEdit txtName;
        private Label lblName;
        private Label label1;
        private ReaLTaiizor.Controls.AirRadioButton rdbEnterprise;
        private ReaLTaiizor.Controls.AirRadioButton rdbPerson;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.TextBoxEdit txtPhone;
        private ReaLTaiizor.Controls.TextBoxEdit txtDocument;
        private ReaLTaiizor.Controls.TextBoxEdit txtEmail;
        private Label label4;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}